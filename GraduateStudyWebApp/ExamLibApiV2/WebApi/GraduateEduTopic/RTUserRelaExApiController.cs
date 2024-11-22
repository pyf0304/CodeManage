using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicEx;
using ExamLib.BusinessLogicExs;
using ExamLib.Entity;
using ExamLib.WebApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.GraduateEduTopic
{
    [ApiController]
    [Route("[controller]")]
    public class RTUserRelaExApiController : ControllerBase
    {
        [HttpGet("UpdateTypeTableHtml")]
        public ActionResult UpdateTypeTableHtml(string OldCodeColor, string NewCodeColor, string UserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("OldCodeColor", OldCodeColor);
            dictParam.Add("NewCodeColor", NewCodeColor);
            dictParam.Add("UserId", UserId);
           
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 获取教学班数据
                //1.获取评分教学班数据
                //bool i = clsSysCommentBLEx.GetTotalRevalidation(UpdUserId);
                bool i = clsRTUserRelaBLEx.UpdateTypeTableHtml(OldCodeColor,NewCodeColor, UserId);
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
    }
}