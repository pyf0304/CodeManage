using com.taishsoft.common;
using ExamLib.Entity;
using ExamLib.WebApi;
using ExamLibBll.BLLEX.GraduateEdu;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.GraduateEdu
{
    public class vTopicObjectiveExApiController:vTopicObjectiveApiController
    {
        public vTopicObjectiveExApiController() { }

        /// <summary>
        /// 获取客观 、、中的用户数量
        /// 调用方法: GET /api/vPaperExApi/GetUserNumObjLst?strWhereCond=1=1
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetTopicObjectiveUserObjLst")]
        public ActionResult GetTopicObjectiveUserObjLst(string strWhereCond)
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
                List<clsvTopicObjectiveEN> arrvTopicObjectiveObjLst = clsvTopicObjectiveBLEx.GetTopicObjectiveUserObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvTopicObjectiveObjLst });
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