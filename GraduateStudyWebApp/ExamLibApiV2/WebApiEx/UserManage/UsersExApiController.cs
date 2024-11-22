
using com.taishsoft.common;
using com.taishsoft.json;
using System.Text.Json;
using System.Text.Json.Serialization;

using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicEx;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;
using System.Runtime.Intrinsics.X86;
using System.Data.Common;

namespace ExamLibApiV2
{
    [ApiController]
    [Route("[controller]")]
    public class UsersExApiController : ControllerBase
    {



        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/UsersApi/AddNewRecord
        /// 在Body区传输objUsersEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objUsersEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecord")]
        public bool AddNewRecord([FromBody] clsUsersEN objUsersEN)
        {
            string strMsg = "";
            //string strId_StudentInfo = "";
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strUsersJSONObj = clsJSON.GetJsonFromObj(objUsersEN);
            dictParam.Add("strUsersJSONObj", strUsersJSONObj);
            //clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
            //{
            //    strMsg = string.Format("添加记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
            //    clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            //}
            //if (clsUsersBL.IsExist(objUsersEN.UserId) == true)
            //{
            //    strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!({1})", objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
            //    clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            //}
            try
            {
                //string strDepartmentIdInGP = clsXzClgBLEx.GetDepartmentIdInGPById_College(objUsersEN.IdXzCollege);
                //if (string.IsNullOrEmpty(strDepartmentIdInGP) == true)
                //{
                //    clsXzClgEN objXzClg = clsXzClgBL.GetObjByIdXzCollegeCache(objUsersEN.IdXzCollege);
                //    strMsg = string.Format("学院:{0}在统一平台中没有对应的部门，请联系管理员！", objXzClg.CollegeName);
                //    clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                //    return false;
                //}

                bool bolResult = objUsersEN.AddNewRecord();
                if (bolResult == true)
                {
                    clsStudentInfoEN objStudentInfoEN = clsStudentInfoBLEx.SynchUsersToStudent(objUsersEN);

                    //clsCurrEduClsEN objCurrEduClsEN = InsertToDefaCurrEduCls(objUsersEN, ref strId_StudentInfo);
                    //if (objCurrEduClsEN != null)
                    //{
                    //    if (objCurrEduClsEN._StrTag == "IsAudit")
                    //    {
                    //        strMsg = string.Format("注册成功！并且已经插入到学习班:[{0}],现在就可以参加网上学习并完成作业！", objCurrEduClsEN.EduClsName);
                    //    }
                    //    else
                    //    {
                    //        strMsg = string.Format("注册成功！并且已经插入到学习班:[{0}],明天就可以参加网上学习并完成作业！", objCurrEduClsEN.EduClsName);
                    //    }
                    //}
                    //else
                    //{
                    //    strMsg = string.Format("注册成功！明天就可以参加网上安全竞赛！", objCurrEduClsEN.EduClsName);

                    //}
                    //clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);


                    //Response.Redirect("Index.aspx");
                    // 不会弹出询问
                }
                else
                {

                    clsPubFun_WebApi.AccessException("注册失败", HttpStatusCode.NotFound);
                }
                return bolResult;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
        }



        /// <summary>
        /// 注册用户
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "objUsersEN">用户对象</param>
        /// <param name = "strDefaIdCurrEduCls">默认教学班Id</param>
        /// <param name = "spIsAutoAudit4Register">是否自动审核注册</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("RegisterUser")]
        public ActionResult RegisterUser([FromBody] clsUsersEN objUsersEN, string strDefaIdCurrEduCls, bool spIsAutoAudit4Register, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = clsJSON.GetJsonFromObj(objUsersEN);
            dictParam.Add("objUsersEN", strJSONString);
            dictParam.Add("strDefaIdCurrEduCls", strDefaIdCurrEduCls);
            dictParam.Add("spIsAutoAudit4Register", spIsAutoAudit4Register.ToString());
            dictParam.Add("strOpUser", strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strReturnInfo = "";
                var varResult = clsUsersBLEx.RegisterUser(objUsersEN, strDefaIdCurrEduCls, spIsAutoAudit4Register, strOpUser, ref strReturnInfo);
                return Ok(new { errorId = 0, errorMsg = "", returnInfo = strReturnInfo, returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 同步用户到学生和平台
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "arrUserId">用户列表</param>
        /// <param name = "strSchoolId">学校Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("SynchUsersToStudentAndPlatform")]

        public ActionResult SynchUsersToStudentAndPlatform([FromBody] Dictionary<string, object> requestData)
        {
            // 获取传递过来的数据
            List<string> arrUserId1 = new List<string>();
            string strIdSchool1 = "";
            string strOpUser1 = "";
            if (requestData.TryGetValue("arrUserId", out var arrUserId) && requestData.TryGetValue("strIdSchool", out var strIdSchool) && requestData.TryGetValue("strOpUser", out var strOpUser))
            {
                arrUserId1 = JsonSerializer.Deserialize<List<string>>(arrUserId.ToString());
                strIdSchool1 = strIdSchool.ToString();
                strOpUser1 = strOpUser.ToString();
            }
            else
            {
                string strMsg = string.Format("参数传递不正确。(in {0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }

            //public ActionResult SynchUsersToStudentAndPlatform([FromBody] List<string> arrUserId, string strSchoolId, string strOpUser)
            //{
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = string.Join(",", arrUserId1);
            dictParam.Add("arrUserId", strJSONString);
            dictParam.Add("strIdSchool", strIdSchool1);
            dictParam.Add("strOpUser", strOpUser1);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUsersBLEx.SynchUsersToStudentAndPlatform(arrUserId1, strIdSchool1, strOpUser1);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}