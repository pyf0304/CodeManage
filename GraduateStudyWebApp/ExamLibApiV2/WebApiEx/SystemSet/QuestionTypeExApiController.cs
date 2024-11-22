
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:QuestionTypeExApiController
 表名:QuestionType(01120008)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/08 21:51:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:游戏化教育平台(000041, 变量首字母小写)-全部函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
 框架-层名:WA_服务扩展层(CS)(WA_SrvEx,0185)
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
 /// QuestionTypeExApiController 的摘要说明
 /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
public class  QuestionTypeExApiController : ControllerBase
{ 

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
/// </summary>
 public QuestionTypeExApiController()
 {
 }

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
 /// </summary>
 /// <param name = "objQuestionType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
[HttpPost("EditRecordEx")]
public ActionResult EditRecordEx([FromBody]clsQuestionTypeEN objQuestionType)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strQuestionTypeJSONObj = clsJSON.GetJsonFromObj(objQuestionType);
dictParam.Add("strQuestionTypeJSONObj", strQuestionTypeJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
objQuestionType._IsCheckProperty = true;
 try
 {
bool bolResult =true;//如果要使用,解除注释---- objQuestionType.EditRecordEx();
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 }

}
}