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

namespace ExamLibApi.Controllers.ZXCourseware
{
    public class zx_ViewpointExApiController: zx_ViewpointApiController
    {
        /// <summary>
        /// 获取论文中的用户数量
        /// 调用方法: GET /api/zx_ViewpointExApi/GetUserNumObjLst?strWhereCond=1=1
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetAllVNumObjLst")]
        public ActionResult GetAllVNumObjLst(string strTextId)
        {
            strTextId = strTextId.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTextId"] = strTextId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strTextId) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                List<clszx_ViewpointEN> arrzx_ViewpointObjLst = clszx_ViewpointBLEx.GetAllVNumObjLst(strTextId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrzx_ViewpointObjLst });

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