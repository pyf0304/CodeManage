
using com.taishsoft.common;
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

namespace ExamLibApi.Controllers.ExamManage
{
    [ApiController]
    [Route("[controller]")]
    public class gs_UserConfigExApiController : ControllerBase
    {

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/PaperApi/AddNewRecord
        /// 在Body区传输objPaperEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objPaperEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpGet("GetNewReturnShareId")]
        public ActionResult GetNewReturnShareId(string strConfigTypeId,string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strConfigTypeId", strConfigTypeId);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strShareId = clsgs_UserConfigBLEx.GetShareIdByConfigTypeId(strConfigTypeId, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strShareId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/gs_UserConfigApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetAddConfigEx")]
        public ActionResult GetAddConfigEx(string strUpdUser)
        {
            
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
                 dictParam.Add("strUpdUser", strUpdUser);

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
           
            try
            {
                bool bolResult = clsgs_UserConfigBLEx.GetObjLstEx(strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
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