using com.taishsoft.common;
using ExamLib.BusinessLogicEx;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class gs_UserRelaExApiController : ControllerBase
    {

        //获取各个表的数据统计同步到总表 ；（参数，教学班，编辑人；）
        [HttpGet("SynUserRelaNum")]
        public ActionResult SynUserRelaNum(string stridCurrEduCls, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("UpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 获取教学班数据
                //1.获取评分教学班数据
                bool i = clsgs_UserRelaBLEx.SynUserRelaNum(stridCurrEduCls, strUpdUser);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("同步返回成功");
                    dictParam.Add("SynUserRelaNum", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "SynUserRelaNum", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("同步返回失败");
                    dictParam.Add("SynUserRelaNum", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "SynUserRelaNum", dictParam);
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