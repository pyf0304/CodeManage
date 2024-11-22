﻿using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogicEx;
using ExamLib.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class ge_StructureGraphExApiController : ControllerBase
    {


        //提交结构图谱；（图谱Id，提交用户，耗时）
        [HttpGet("SubmitStructureGraph")]
        public ActionResult SubmitStructureGraph(string strStructureGraphId, string strUserId, string strTakeUpTime)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("StructureGraphId", strStructureGraphId);
            dictParam.Add("UserId", strUserId);
            dictParam.Add("TakeUpTime", strTakeUpTime);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
               
                //1.提交结构图谱
                bool i = clsge_StructureGraphBLEx.SubmitStructureGraph(strStructureGraphId, strUserId, strTakeUpTime);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("提交结构图成功");
                    dictParam.Add("GetTotalStatisticsByTable", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetTotalStatisticsByTable", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("提交结构图失败");
                    dictParam.Add("GetTotalStatisticsByTable", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetTotalStatisticsByTable", dictParam);
                }

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