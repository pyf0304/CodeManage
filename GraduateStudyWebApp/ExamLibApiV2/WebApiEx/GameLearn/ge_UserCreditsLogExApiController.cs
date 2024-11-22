using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicEx;
using ExamLib.Entity;
using ExamLib.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.GameLearn
{
    [ApiController]
    [Route("[controller]")]
    public class ge_UserCreditsLogExApiController : ControllerBase
    {

        
        //获取用户每关的最大分数；通过用户ID  UserId IdCurrEduCls教学班流水号得到；
        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/ge_UserCreditsLogApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("Getge_UserCreditsObjLstEx")]
        public ActionResult Getge_UserCreditsObjLstEx(string UserId, string IdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["UserId"] = UserId,
                ["IdCurrEduCls"] = IdCurrEduCls

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
           
            try
            {
                List<clsge_UserCreditsLogEN> arrge_UserCreditsLogObjLst = clsge_UserCreditsLogBLEx.Getge_UserCreditsObjLstEx(UserId,IdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrge_UserCreditsLogObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        // 获取用户每关总分排名的方法
        //获取用户每关的最大分数；通过用户ID  UserId IdCurrEduCls教学班流水号得到；
        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/ge_UserCreditsLogApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("Getge_UserCreditsRankLstEx")]
        public ActionResult Getge_UserCreditsRankLstEx(string strWhere)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhere"] = strWhere

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                List<clsge_UserCreditsLogEN> arrge_UserCreditsLogObjLst = clsge_UserCreditsLogBLEx.Getge_UserCreditsRankLstEx(strWhere);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrge_UserCreditsLogObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


     
     

        /// <summary>
        /// 计算一个教学班的用户积分日志
        /// 调用方法: Get /api/clsge_UserCreditsLogBLExApi/CalcCreditLog?strIdCurrEduCls=value&strOpUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CalcCreditLog")]
        public ActionResult CalcCreditLog(string strIdCurrEduCls, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            dictParam.Add("strOpUser", strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_UserCreditsLogBLEx.CalcCreditLog(strIdCurrEduCls, strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 计算一个用户的积分日志
        /// 调用方法: Get /api/clsge_UserCreditsLogBLExApi/CalcCreditLogByUserId?strIdCurrEduCls=value&strUserId=value&strOpUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CalcCreditLogByUserId")]
        public ActionResult CalcCreditLogByUserId(string strIdCurrEduCls, string strGameLevelId,
string strExamBatchNo, string strUserId, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strOpUser", strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_UserCreditsLogBLEx.CalcCreditLogByUserId(strIdCurrEduCls, strGameLevelId,
strExamBatchNo, strUserId, strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 添加用户闯关日志
        /// 调用方法: Get /api/clsge_UserCreditsLogBLExApi/Addge_UserCreditsLog?strExamBatchNo=value&bolSubmit=value&strUserId=value&strIdCurrEduCls=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strExamBatchNo">测试批次号</param>
        /// <param name = "bolSubmit">是否提交</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("Addge_UserCreditsLog")]
        public ActionResult Addge_UserCreditsLog(string strGameLevelId, string strExamBatchNo, bool bolSubmit, string strUserId, string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strExamBatchNo", strExamBatchNo);
            dictParam.Add("bolSubmit", bolSubmit.ToString());
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_UserCreditsLogBLEx.Addge_UserCreditsLog(strGameLevelId, strExamBatchNo, bolSubmit, strUserId, strIdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        [HttpGet("Addge_UserCreditsLog_Marker")]
        public ActionResult Addge_UserCreditsLog_Marker(string strGameLevelId, string strExamBatchNo, bool bolSubmit, string strUserId, string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strExamBatchNo", strExamBatchNo);
            dictParam.Add("bolSubmit", bolSubmit.ToString());
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_UserCreditsLogBLEx.Addge_UserCreditsLog_Marker(strGameLevelId, strExamBatchNo, bolSubmit, strUserId, strIdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}