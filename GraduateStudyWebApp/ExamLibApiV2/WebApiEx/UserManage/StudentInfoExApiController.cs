
/*-- -- -- -- -- -- -- -- -- -- --
类名:StudentInfoExApiController
表名:StudentInfo(01120131)
* 版本:2023.12.07.1(服务器:WIN-SRV103-116)
日期:2023/12/11 11:33:55
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:用户管理(UserManage)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using ExamLib.Entity;
using ExamLib.BusinessLogicEx;

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;
using ExamLib.BusinessLogic;

namespace ExamLib.WebApi
{
    /// <summary>
    /// StudentInfoExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class StudentInfoExApiController : ControllerBase
    {

        /// <summary>
        /// 同步用户信息到学生
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "objUsersEN">用户对象</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("SynchUsersToStudent")]
        public ActionResult SynchUsersToStudent([FromBody] clsUsersEN objUsersEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = clsJSON.GetJsonFromObj(objUsersEN);
            dictParam.Add("objUsersEN", strJSONString);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsStudentInfoBLEx.SynchUsersToStudent(objUsersEN);
                return Ok(new { errorId = 0, errorMsg = "", returnObj = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 扩展删除学生
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "arrIdStu">学生流水号殂</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("DelStudentInfoEx")]
        public ActionResult DelStudentInfoEx([FromBody] List<string> arrIdStu)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = string.Join(",", arrIdStu);
            dictParam.Add("arrIdStu", strJSONString);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsStudentInfoBLEx.DelStudentInfoEx(arrIdStu);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 同步学生到平台
        /// 调用方法: Get /api/clsStudentInfoBLExApi/SynchStudentToPlatform?strIdStudentInfo=value&strSchoolId=value&strOpUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdStudentInfo">学生流水号</param>
        /// <param name = "strSchoolId">学校Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        //[HttpGet("SynchStudentToPlatform")]
        //public ActionResult SynchStudentToPlatform(string strIdStudentInfo, string strSchoolId, string strOpUser)
        //{
        //    string strFunctionName = clsStackTrace.GetCurrFunction();
        //    Dictionary<string, string> dictParam = new Dictionary<string, string>();
        //    dictParam.Add("strIdStudentInfo", strIdStudentInfo);
        //    dictParam.Add("strSchoolId", strSchoolId);
        //    dictParam.Add("strOpUser", strOpUser);
        //    clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
        //    try
        //    {
        //        var objStudentInfo = clsStudentInfoBL.GetObjByIdStudentInfo(strIdStudentInfo);
        //        var strIdentityDesc = objStudentInfo.UserType == "university" ? "学生" : "中小学学生";
        //        var varResult = clsStudentInfoBLEx.SynchStudentToPlatform(strIdStudentInfo, strSchoolId, strIdentityDesc, strOpUser);
        //        return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
        //        return Ok(new { errorId = 1, errorMsg = strMsg });
        //    }
        //}
    }
}