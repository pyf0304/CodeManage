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

namespace ExamLibApi.Controllers.GraduateEduPaper
{
    [ApiController]
    [Route("[controller]")]
    public class gs_PaperParagraphVExApiController : ControllerBase
    {

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/gs_PaperParagraphVApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetObjLst")]
        public ActionResult GetObjLst(string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                List<clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVObjLst = clsgs_PaperParagraphVerBLEx.GetObjLstEx(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrgs_PaperParagraphVObjLst });
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