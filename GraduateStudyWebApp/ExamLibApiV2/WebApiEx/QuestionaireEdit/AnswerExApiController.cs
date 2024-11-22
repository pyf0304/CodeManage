
/*-- -- -- -- -- -- -- -- -- -- --
类名:AnswerExApiController
表名:Answer(01120002)
* 版本:2024.02.19.1(服务器:WIN-SRV103-116)
日期:2024/03/03 02:29:42
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:问卷维护(QuestionaireEdit)
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
    /// AnswerExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AnswerExApiController : ControllerBase
    {
        /// <summary>
        /// 设置题目的标准答案
        /// 调用方法: Get /api/clsAnswerBLExApi/SetQuestionAnswer?strQuestionId=value&strAnswer=value&strCourseId=value&strOpUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strQuestionId">题目Id</param>
        /// <param name = "strAnswer">标准答案</param>
        /// <param name = "strCourseId">课程Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetQuestionAnswer")]
        public ActionResult SetQuestionAnswer(long strQuestionId, string strAnswer, string strCourseId, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strQuestionId", strQuestionId.ToString());
            dictParam.Add("strAnswer", strAnswer);
            dictParam.Add("strCourseId", strCourseId);
            dictParam.Add("strOpUser", strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsAnswerBLEx.SetQuestionAnswer(strQuestionId, strAnswer, strCourseId, strOpUser);
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