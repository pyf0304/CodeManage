using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicExs;
using ExamLib.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class SysCommentExApiController : ControllerBase
    {

        //添加评论扩展 20200603
        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/SysCommentApi/AddNewRecordWithMaxId
        /// 在Body区传输objSysCommentEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
        /// </summary>
        /// <param name = "objSysCommentEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public ActionResult AddNewRecordEx([FromBody]clsSysCommentEN objSysCommentEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSysCommentJSONObj = clsJSON.GetJsonFromObj(objSysCommentEN);
            dictParam.Add("strSysCommentJSONObj", strSysCommentJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strResult = objSysCommentEN.AddNewRecordWithMaxId();
            

                #region 参数声明赋值；
                //执行之后，需要进行数据核算
                string strUserId = string.Empty;
                string strTableKeyId = string.Empty;
                string strCommentTypeId = string.Empty;
                string strParentId = string.Empty;
                string stridCurrEduCls = string.Empty;

                strUserId = objSysCommentEN.UserId;
                strTableKeyId = objSysCommentEN.TableKey;
                strCommentTypeId = objSysCommentEN.CommentTypeId;
                strParentId = objSysCommentEN.ParentId;
                stridCurrEduCls = objSysCommentEN.IdCurrEduCls;
                #endregion

                bool bolResult;
               // bool i = clsSysCommentBLEx.PersonalScoreStatistics(strUserId,strTableKeyId,strCommentTypeId,strParentId,stridCurrEduCls);
                bool i = clsSysCommentNewBLEx.AddNewRecordEx(objSysCommentEN);
                if (i == true)
                {
                    bolResult = true;
                }
                else
                {
                    bolResult = false;
                    dictParam.Add("PersonalScoreStatistics", strUserId+strTableKeyId+strCommentTypeId+strParentId+stridCurrEduCls);
                    clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
                }
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        //删除评论扩展20200604
        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// 调用方法: DELETE /api/SysCommentApi/DelRecord/Id
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
        /// </summary>
        /// <param name = "Id">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        [HttpDelete("DelRecordEx")]
        public ActionResult DelRecordEx(string Id)
        {
            string strCommentId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCommentId"] = strCommentId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strCommentId) == true)
            {
                string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                //int intRecNum = clsSysCommentBLEx.DelRecord(strCommentId);
                int intRecNum = clsSysCommentNewBLEx.DelRecord(strCommentId);
              
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        #region  学生总分核算 UpdUserId用于记录当前是谁在核算操作； 
        [HttpGet("GetStuTotalRevalidation")]
        public ActionResult GetStuTotalRevalidation(string UpdUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUpdUserId", UpdUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 获取教学班数据
                //1.获取评分教学班数据
                //bool i = clsSysCommentBLEx.GetTotalRevalidation(UpdUserId);
               
                bool i = clsSysCommentNewBLEx.GetStuTotalRevalidation(UpdUserId);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("核算返回成功");
                    dictParam.Add("GetTotalRevalidation", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetTotalRevalidation", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("核算返回失败");
                    dictParam.Add("GetTotalRevalidation", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetTotalRevalidation", dictParam);
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                
            }
            
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
        }





        //修改评论内的教学班周 ；（参数，教学班，编辑人；）
        [HttpGet("UpdateCommentWeek")]
        public ActionResult UpdateCommentWeek(string strIdCurrEduCls, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUpdUserId", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;

            try
            {
                #region 获取教学班数据
                //1、获取当前教学班评论

                bool i = clsSysCommentBLEx.UpdateCommentWeek(strIdCurrEduCls, strUpdUser);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("评论表修改教学班周成功！");
                    dictParam.Add("UpdateCommentWeek", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "UpdateCommentWeek", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("评论表修改教学班周失败！");
                    dictParam.Add("UpdateCommentWeek", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "UpdateCommentWeek", dictParam);
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);


            }
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

        }



        #endregion


        //教师针对评价、讨论 、总的打分；
        //3个参数，页面参数、判断是添加还是修改；类型参数：是讨论还是评价；操作人；
        [HttpPost("AddOrUpdateSysScoreSummary")]
        public ActionResult AddOrUpdateSysScoreSummary([FromBody]clsSysScoreSummaryEN objSysScoreSummaryEN) {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSysScoreSummaryJSONObj = clsJSON.GetJsonFromObj(objSysScoreSummaryEN);
            dictParam.Add("strSysCommentJSONObj", strSysScoreSummaryJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {

                bool varResult = false;

                bool i = clsSysCommentNewBLEx.AddOrUpdateSysScoreSummary(objSysScoreSummaryEN);
                if (i == true)
                {
                    varResult = true;
                }
                else
                {
                    varResult = false;
                    //dictParam.Add("PersonalScoreStatistics", strUserId + strTableKeyId + strCommentTypeId + strParentId + stridCurrEduCls);
                    clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
                }

                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}