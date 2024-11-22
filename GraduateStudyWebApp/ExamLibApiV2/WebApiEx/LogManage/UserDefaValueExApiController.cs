
/*-- -- -- -- -- -- -- -- -- -- --
类名:UserDefaValueExApiController
表名:UserDefaValue(01120203)
生成代码版本:2022.05.07.1
生成日期:2022/11/17 03:25:10
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:日志管理(LogManage)
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

namespace ExamLib.WebApi
{
    /// <summary>
    /// UserDefaValueExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserDefaValueExApiController : ControllerBase
    {

        /// <summary>
        /// 设置用户缺省值
        /// 调用方法: Get /api/clsUserDefaValueBLExApi/setUserDefaValue?strCurrPrjId=value&strCurrSelPrjId=value&strUserId=value&strDefaValName=value&strUserDefaValue=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCurrPrjId">当前工程Id</param>
        /// <param name = "strCurrSelPrjId">当前用户选择的工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strDefaValName">缺省值名</param>
        /// <param name = "strUserDefaValue">用户缺省值</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("setUserDefaValue")]
        public ActionResult setUserDefaValue(string strUserId, string strDefaValName, string strUserDefaValue)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strDefaValName", strDefaValName);
            dictParam.Add("strUserDefaValue", strUserDefaValue);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserDefaValueBLEx.setUserDefaValue(strUserId, strDefaValName, strUserDefaValue);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }


        /// <summary>
        /// 获取用户缺省值
        /// 调用方法: Get /api/clsUserDefaValueBLExApi/getUserDefaValue?strCurrPrjId=value&strCurrSelPrjId=value&strUserId=value&strDefaValName=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCurrPrjId">当前选择的工程Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strDefaValName">缺省值名</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("getUserDefaValue")]
        public ActionResult getUserDefaValue(string strUserId, string strDefaValName)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strDefaValName", strDefaValName);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsUserDefaValueBLEx.getUserDefaValue(strUserId, strDefaValName);

                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }
    }
}