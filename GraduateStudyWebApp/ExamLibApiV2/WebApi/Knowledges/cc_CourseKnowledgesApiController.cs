
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:cc_CourseKnowledgesApiController
 表名:cc_CourseKnowledges(01120082)
 * 版本:2024.11.13.2(服务器:WIN-SRV103-116)
 日期:2024/11/13 08:11:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:WA_服务层(CS)(WA_Srv,0044)
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
using ExamLib.BusinessLogic;
using com.taishsoft.common;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; using Comm.WebApi;

namespace ExamLib.WebApi
{
 /// <summary>
 /// cc_CourseKnowledgesController 的摘要说明
 /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
 /// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class  cc_CourseKnowledgesApiController : ControllerBase
{ 

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetObjByCourseKnowledgeId?CourseKnowledgeId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
[HttpGet("GetObjByCourseKnowledgeId")]
public ActionResult GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strCourseKnowledgeId"] = strCourseKnowledgeId,
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
 {
string strMsg = string.Format("根据关键字获取对象时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objcc_CourseKnowledgesEN });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件获取对象列表
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetObjLst?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLst")]
public ActionResult GetObjLst(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件获取对象列表,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst = clscc_CourseKnowledgesBL.GetObjLst(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcc_CourseKnowledgesObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件获取对象列表
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetObjLst_Cache?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstCache)
 /// </summary>
 /// <returns>返回对象列表</returns>
[HttpGet("GetObjLstCache")]
public ActionResult GetObjLstCache(string strCourseId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst = clscc_CourseKnowledgesBL.GetObjLstCache(strCourseId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcc_CourseKnowledgesObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// 调用方法: POST /api/cc_CourseKnowledgesapi/GetObjLstByCourseKnowledgeIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByCourseKnowledgeIdLst")]
public ActionResult GetObjLstByCourseKnowledgeIdLst([FromBody]string[] arrCourseKnowledgeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrCourseKnowledgeId);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrCourseKnowledgeId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstCourseKnowledgeId = new(arrCourseKnowledgeId);
 try
 {
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst = clscc_CourseKnowledgesBL.GetObjLstByCourseKnowledgeIdLst(lstCourseKnowledgeId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcc_CourseKnowledgesObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// 调用方法: POST /api/cc_CourseKnowledgesapi/GetObjLstByCourseKnowledgeIdLst
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
[HttpPost("GetObjLstByCourseKnowledgeIdLstCache")]
public ActionResult GetObjLstByCourseKnowledgeIdLstCache([FromBody]string[] arrCourseKnowledgeId, string CourseId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrCourseKnowledgeId);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (arrCourseKnowledgeId.Length == 0)
{
string strMsg = string.Format("根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstCourseKnowledgeId = new(arrCourseKnowledgeId);
 try
 {
IEnumerable<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst = clscc_CourseKnowledgesBL.GetObjLstByCourseKnowledgeIdLstCache(lstCourseKnowledgeId, CourseId);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcc_CourseKnowledgesObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
[HttpPost("GetTopObjLst")]
public ActionResult GetTopObjLst([FromBody]stuTopPara objTopPara)
{
objTopPara.whereCond = objTopPara.whereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objTopPara.whereCond) == true)
 {
string strMsg = string.Format("根据条件获取顶部对象列表,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objTopPara.topSize <= 0)
 {
string strMsg = string.Format("根据条件获取顶部对象列表,顶部记录数:[{0}]不能小于等于0!({1})", objTopPara.topSize, clsStackTrace.GetCurrClassFunction());
clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
 }
 try
 {
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst = clscc_CourseKnowledgesBL.GetTopObjLst(objTopPara);
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcc_CourseKnowledgesObjLst });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetFirstID?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[HttpGet("GetFirstID")]
public ActionResult GetFirstID(string strWhereCond) 
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件获取第一条记录的关键字值时,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 string strCourseKnowledgeId;
 try
 {
 strCourseKnowledgeId = clscc_CourseKnowledgesBL.GetFirstID_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStr = strCourseKnowledgeId });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetFirstObj?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
[HttpGet("GetFirstObj")]
public ActionResult GetFirstObj(string strWhereCond) 
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件获取第一条对象时,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesBL.GetFirstObj_S(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnObj = objcc_CourseKnowledgesEN });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
 [HttpPost("GetObjLstByPager")]
 public ActionResult GetObjLstByPager([FromBody]stuPagerPara objPagerPara)
 {
objPagerPara.whereCond = objPagerPara.whereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objPagerPara.pageSize <=0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表,每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 if (objPagerPara.pageIndex <=0)
 {
string strMsg = string.Format("根据条件分页获取JSON对象列表,页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst;
 try
 {
 arrcc_CourseKnowledgesObjLst = clscc_CourseKnowledgesBL.GetObjLstByPager(objPagerPara);
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrcc_CourseKnowledgesObjLst });
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetRecCountByCond?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>某一条件的记录数</returns>
[HttpGet("GetRecCountByCond")]
public ActionResult GetRecCountByCond(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("获取某一条件的记录数,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intCount = clscc_CourseKnowledgesBL.GetRecCountByCond(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
[HttpGet("GetFldValue")]
public ActionResult GetFldValue(string strFldName, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("获取某一条件的字段值,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
List<string> arrList = clscc_CourseKnowledgesBL.GetFldValue(strFldName, strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnStrLst = string.Join(",", arrList) });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
[HttpGet("SetFldValue")]
public ActionResult SetFldValue(string strFldName, string strValue, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("获取某一条件的字段值,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
 try
 {
int intRecCount = clscc_CourseKnowledgesBL.SetFldValue(clscc_CourseKnowledgesEN._CurrTabName, strFldName, strValue, strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecCount });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/IsExistRecord?strWhereCond=v1&
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>包含结果的Jobject, 如果存在就返回TRUE,否则返回FALSE</returns>
[HttpGet("IsExistRecord")]
public ActionResult IsExistRecord(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("判断是否存在某一条件的记录,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clscc_CourseKnowledgesBL.IsExistRecord(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/IsExist?CourseKnowledgeId=value
 /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[HttpGet("IsExist")]
public ActionResult IsExist(string strCourseKnowledgeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strCourseKnowledgeId"] = strCourseKnowledgeId
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
 {
string strMsg = string.Format("判断表中是否存在给定关键字的记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
bool bolIsExist = clscc_CourseKnowledgesBL.IsExist(strCourseKnowledgeId);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// 调用方法: GET /api/cc_CourseKnowledgesApi/GetMaxStrId?
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[HttpGet("GetMaxStrId")]
public ActionResult GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
string strMaxstrCourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strMaxstrCourseKnowledgeId });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/AddNewRecord
 /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecord")]
public ActionResult AddNewRecord([FromBody]clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcc_CourseKnowledgesJSONObj = clsJSON.GetJsonFromObj(objcc_CourseKnowledgesEN);
dictParam.Add("strcc_CourseKnowledgesJSONObj", strcc_CourseKnowledgesJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clscc_CourseKnowledgesEN objcc_CourseKnowledgesCond = new();
string strCondition = objcc_CourseKnowledgesCond
.SetCourseId(objcc_CourseKnowledgesEN.CourseId, "=")
.SetKnowledgeName(objcc_CourseKnowledgesEN.KnowledgeName, "=")
.GetCombineCondition();
bool bolIsExist = clscc_CourseKnowledgesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
string strMsg = string.Format("满足条件:{0}的记录表中已经存在,违反了唯一性.(from {1})", strCondition,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
    clscc_CourseKnowledgesBL.AccessFldValueNull(objcc_CourseKnowledgesEN);
bool bolResult = objcc_CourseKnowledgesEN.AddNewRecord();
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/AddNewRecordWithMaxId
 /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("AddNewRecordWithMaxId")]
public ActionResult AddNewRecordWithMaxId([FromBody]clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcc_CourseKnowledgesJSONObj = clsJSON.GetJsonFromObj(objcc_CourseKnowledgesEN);
dictParam.Add("strcc_CourseKnowledgesJSONObj", strcc_CourseKnowledgesJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
    clscc_CourseKnowledgesBL.AccessFldValueNull(objcc_CourseKnowledgesEN);
string strCourseKnowledgeId = objcc_CourseKnowledgesEN.AddNewRecordWithMaxId();
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strCourseKnowledgeId });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/AddNewRecordWithReturnKey
 /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[HttpPost("AddNewRecordWithReturnKey")]
public ActionResult AddNewRecordWithReturnKey(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("objcc_CourseKnowledgesEN", JsonConvert.SerializeObject(objcc_CourseKnowledgesEN));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
    clscc_CourseKnowledgesBL.AccessFldValueNull(objcc_CourseKnowledgesEN);
string strKey = clscc_CourseKnowledgesBL.AddNewRecordBySql2WithReturnKey(objcc_CourseKnowledgesEN);
return Ok(new { errorId = 0, errorMsg = "", returnStr =  strKey });
}
catch (Exception objException)
{
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// 调用方法: Post /api/cc_CourseKnowledgesApi/UpdateRecord
 /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
 /// </summary>
 /// <param name = "strcc_CourseKnowledgesJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateRecord")]
public ActionResult UpdateRecord([FromBody]clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcc_CourseKnowledgesJSONObj = clsJSON.GetJsonFromObj(objcc_CourseKnowledgesEN);
dictParam.Add("strcc_CourseKnowledgesJSONObj", strcc_CourseKnowledgesJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("修改记录时,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
    clscc_CourseKnowledgesBL.SetUpdFlag(objcc_CourseKnowledgesEN);
    clscc_CourseKnowledgesBL.AccessFldValueNull(objcc_CourseKnowledgesEN);
bool bolResult = objcc_CourseKnowledgesEN.Update();
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 通过JSON对象来编辑记录对象，存在就修改，不存在就添加
 /// 调用方法: Post /api/cc_CourseKnowledgesApi/EditRecordEx
 /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_EditRecordEx)
 /// </summary>
 /// <param name = "strcc_CourseKnowledgesJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[HttpPost("EditRecordEx")]
public ActionResult EditRecordEx([FromBody]clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
string strcc_CourseKnowledgesJSONObj = clsJSON.GetJsonFromObj(objcc_CourseKnowledgesEN);
dictParam.Add("strcc_CourseKnowledgesJSONObj", strcc_CourseKnowledgesJSONObj);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
    clscc_CourseKnowledgesBL.SetUpdFlag(objcc_CourseKnowledgesEN);
    clscc_CourseKnowledgesBL.AccessFldValueNull(objcc_CourseKnowledgesEN);
bool bolResult = objcc_CourseKnowledgesEN.EditRecordEx();
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录移顶
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/GoTop
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoTop)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoTop")]
public ActionResult GoTop([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置顶时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstCourseKnowledgeId = new(objOrderByData.KeyIdLst);
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCourseChapterId = "";
if (jobjOrderByData.ContainsKey("courseChapterId"))
{
strCourseChapterId = jobjOrderByData["courseChapterId"].ToString();
}
else if (jobjOrderByData.ContainsKey("coursechapterid"))
{
strCourseChapterId = jobjOrderByData["coursechapterid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[courseChapterId]的数据,请检查!", "courseChapterId|coursechapterid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clscc_CourseKnowledgesBL.GoTop(lstCourseKnowledgeId ,strCourseChapterId);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录上移
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/UpMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpMove)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("UpMove")]
public ActionResult UpMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表上移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstCourseKnowledgeId = new(objOrderByData.KeyIdLst);
try
{
foreach(var x in lstCourseKnowledgeId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCourseChapterId = "";
if (jobjOrderByData.ContainsKey("courseChapterId"))
{
strCourseChapterId = jobjOrderByData["courseChapterId"].ToString();
}
else if (jobjOrderByData.ContainsKey("coursechapterid"))
{
strCourseChapterId = jobjOrderByData["coursechapterid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[courseChapterId]的数据,请检查!", "courseChapterId|coursechapterid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clscc_CourseKnowledgesBL.AdjustOrderNum("UP", x ,strCourseChapterId);
}
return Ok(new { errorId = 0, errorMsg = "", returnBool = true });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录下移
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/DownMove
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DownMove)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("DownMove")]
public ActionResult DownMove([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表下移时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstCourseKnowledgeId = new(objOrderByData.KeyIdLst);
lstCourseKnowledgeId.Reverse();
try
{
foreach(var x in lstCourseKnowledgeId)
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCourseChapterId = "";
if (jobjOrderByData.ContainsKey("courseChapterId"))
{
strCourseChapterId = jobjOrderByData["courseChapterId"].ToString();
}
else if (jobjOrderByData.ContainsKey("coursechapterid"))
{
strCourseChapterId = jobjOrderByData["coursechapterid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[courseChapterId]的数据,请检查!", "courseChapterId|coursechapterid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
clscc_CourseKnowledgesBL.AdjustOrderNum("DOWN", x ,strCourseChapterId);
}
return Ok(new { errorId = 0, errorMsg = "", returnBool = true });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录移底
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/GoBottom
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_GoBottom)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("GoBottom")]
public ActionResult GoBottom([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(objOrderByData.KeyIdLst);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
if (objOrderByData.KeyIdLst.Length == 0)
{
string strMsg = string.Format("根据关键字列表置底时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
}
List<string> lstCourseKnowledgeId = new(objOrderByData.KeyIdLst);
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCourseChapterId = "";
if (jobjOrderByData.ContainsKey("courseChapterId"))
{
strCourseChapterId = jobjOrderByData["courseChapterId"].ToString();
}
else if (jobjOrderByData.ContainsKey("coursechapterid"))
{
strCourseChapterId = jobjOrderByData["coursechapterid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[courseChapterId]的数据,请检查!", "courseChapterId|coursechapterid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clscc_CourseKnowledgesBL.GoBottom(lstCourseKnowledgeId ,strCourseChapterId);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 把所给的关键字列表相关的记录移底
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/ReOrder
 /// 在Body区传输clsOrderByData的JSON对象
 /// (AutoGCLib.WA_Srv4CSharp:Gen_ReOrder)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">对象</param>
 /// <returns>是否成功</returns>
[HttpPost("ReOrder")]
public ActionResult ReOrder([FromBody]clsOrderByData objOrderByData)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
dictParam.Add("ClassificationFieldValueLst", objOrderByData.ClassificationFieldValueLst);
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
try
{
JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);

string strCourseChapterId = "";
if (jobjOrderByData.ContainsKey("courseChapterId"))
{
strCourseChapterId = jobjOrderByData["courseChapterId"].ToString();
}
else if (jobjOrderByData.ContainsKey("coursechapterid"))
{
strCourseChapterId = jobjOrderByData["coursechapterid"].ToString();
}
else
{
string strMsg = string.Format("在从前台传来的OrderByData的数据中不存在关键字:[courseChapterId]的数据,请检查!", "courseChapterId|coursechapterid");
return Ok(new { errorId = 1, errorMsg = strMsg });
}
bool bolResult = clscc_CourseKnowledgesBL.ReOrder(strCourseChapterId);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
}
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 根据条件来修改记录对象
 /// 调用方法: Post /api/cc_CourseKnowledgesApi/UpdateWithCondition
 /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象和strWhereCond条件串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
 /// </summary>
 /// <param name = "strcc_CourseKnowledgesJSONObj">JSON对象字符串</param>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否成功</returns>
[HttpPost("UpdateWithCondition")]
public ActionResult UpdateWithCondition(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空,请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 }
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("根据条件修改记录时,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
try
{
    clscc_CourseKnowledgesBL.AccessFldValueNull(objcc_CourseKnowledgesEN);
bool bolResult = objcc_CourseKnowledgesEN.UpdateWithCondition(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
}
catch (Exception objException)
{
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// 调用方法: DELETE /api/cc_CourseKnowledgesApi/DelRecord/Id
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "Id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[HttpDelete("DelRecord")]
public ActionResult DelRecord(string Id)
{
string strCourseKnowledgeId = Id;
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["Id"] = strCourseKnowledgeId
 };
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
 {
string strMsg = string.Format("删除关键字所指定的记录,关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clscc_CourseKnowledgesBL.DelRecord(strCourseKnowledgeId);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/Delcc_CourseKnowledgess
 /// 在Body区传输arrCourseKnowledgeId(关键字值列表)的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrCourseKnowledgeId">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("Delcc_CourseKnowledgess")]
public ActionResult Delcc_CourseKnowledgess([FromBody]string[] arrCourseKnowledgeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrLst = new(arrCourseKnowledgeId);
dictParam.Add("arrCourseKnowledgeId", clsArray.GetSqlInStrByArray(arrLst, true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 try
 {
int intRecNum = clscc_CourseKnowledgesBL.Delcc_CourseKnowledgess(arrLst);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/DelRecords
 /// 在Body区传输strKeyIdLst字符串列表的JSON串
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
 /// </summary>
 /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
 /// <returns>返回删除的记录数</returns>
[HttpPost("DelRecords")]
public ActionResult DelRecords([FromBody]string[] strKeyIdLst)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new();
List<string> arrKey = new(strKeyIdLst);
dictParam.Add("strKeyIdLst", clsArray.GetSqlInStrByArray(arrKey,true));
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
  if (strKeyIdLst.Length == 0)
 {
string strMsg = string.Format("根据关键字列表串删除记录时,给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clscc_CourseKnowledgesBL.Delcc_CourseKnowledgess(arrKey);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
 }
 catch (Exception objException)
 {
string strMsg = string.Format("{0}.(from {1})", objException.Message,  clsStackTrace.GetCurrClassFunction());
clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// 调用方法: POST /api/cc_CourseKnowledgesApi/Delcc_CourseKnowledgessByCond
 /// 在Body区传输{"strWhereCond":"1=1"}
 /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[HttpGet("Delcc_CourseKnowledgessByCond")]
public ActionResult Delcc_CourseKnowledgessByCond(string strWhereCond)
{
strWhereCond = strWhereCond.Replace("'% ", "'%");
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
 if (string.IsNullOrEmpty(strWhereCond) == true)
 {
string strMsg = string.Format("删除满足条件的多条记录,条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
return Ok(new { errorId = 1, errorMsg = strMsg });
 }
 try
 {
int intRecNum = clscc_CourseKnowledgesBL.Delcc_CourseKnowledgessByCond(strWhereCond);
return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
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