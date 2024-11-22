
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ge_KnowledgesClsMasterExApiController
 表名:ge_KnowledgesClsMaster(01120962)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/12 16:51:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace ExamLib.WebApi
{
 /// <summary>
 /// ge_KnowledgesClsMasterExApiController 的摘要说明
 /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
public class  ge_KnowledgesClsMasterExApiController : ControllerBase
{
        /// <summary>
        /// 计算教学班每个知识点的掌握度
        /// 调用方法: Get /api/clsge_KnowledgesClsMasterBLExApi/CalcKnowledgesClsMaster?strIdCurrEduCls=value&strCourseId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <param name = "strCourseId">课程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("CalcKnowledgesClsMaster")]
        public ActionResult CalcKnowledgesClsMaster(string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_KnowledgesClsMasterBLEx.CalcKnowledgesClsMaster(strIdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}