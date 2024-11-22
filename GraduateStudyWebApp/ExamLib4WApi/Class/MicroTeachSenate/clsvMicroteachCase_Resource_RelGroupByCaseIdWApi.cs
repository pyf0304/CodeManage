
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_RelGroupByCaseIdWApi
 表名:vMicroteachCase_Resource_RelGroupByCaseId(01120427)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvMicroteachCase_Resource_RelGroupByCaseIdWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN Setid_MicroteachCase(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase);
objvMicroteachCase_Resource_RelGroupByCaseIdEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase) == false)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN SetFuncModuleId(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId) == false)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN SetResourceNum(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN, int intResourceNum, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = intResourceNum; //资源数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum) == false)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseId_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_RelGroupByCaseId_Cond.IsUpdated(convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseId_Cond.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase, objvMicroteachCase_Resource_RelGroupByCaseId_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase_Resource_RelGroupByCaseId_Cond.IsUpdated(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseId_Cond.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId, objvMicroteachCase_Resource_RelGroupByCaseId_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachCase_Resource_RelGroupByCaseId_Cond.IsUpdated(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum) == true)
{
string strComparisonOp_ResourceNum = objvMicroteachCase_Resource_RelGroupByCaseId_Cond.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum, objvMicroteachCase_Resource_RelGroupByCaseId_Cond.ResourceNum, strComparisonOp_ResourceNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例资源关系_GroupByCaseId(vMicroteachCase_Resource_RelGroupByCaseId)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_RelGroupByCaseIdWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase_Resource_RelGroupByCaseIdApi";

 public clsvMicroteachCase_Resource_RelGroupByCaseIdWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByid_MicroteachCase(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByid_MicroteachCase_WA_Cache(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel =
from objvMicroteachCase_Resource_RelGroupByCaseIdEN in arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache
where objvMicroteachCase_Resource_RelGroupByCaseIdEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase_Resource_RelGroupByCaseIdEN;
if (arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_RelGroupByCaseIdEN obj = clsvMicroteachCase_Resource_RelGroupByCaseIdWApi.GetObjByid_MicroteachCase(strid_MicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstById_MicroteachCaseLst(List<string> arrId_MicroteachCase)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstById_MicroteachCaseLst_Cache(List<string> arrId_MicroteachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel =
from objvMicroteachCase_Resource_RelGroupByCaseIdEN in arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache
where arrId_MicroteachCase.Contains(objvMicroteachCase_Resource_RelGroupByCaseIdEN.id_MicroteachCase)
select objvMicroteachCase_Resource_RelGroupByCaseIdEN;
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstById_MicroteachCaseLst_WA_Cache(List<string> arrId_MicroteachCase)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strid_MicroteachCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENS, clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENT)
{
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdENT.id_MicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseIdENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdENT.FuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseIdENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdENT.ResourceNum = objvMicroteachCase_Resource_RelGroupByCaseIdENS.ResourceNum; //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase_Resource_RelGroupByCaseIdEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase_Resource_RelGroupByCaseIdEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase_Resource_RelGroupByCaseIdEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase_Resource_RelGroupByCaseIdEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase_Resource_RelGroupByCaseIdEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelWApi没有刷新缓存机制(clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase");
//if (arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache == null)
//{
//arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache = await clsvMicroteachCase_Resource_RelGroupByCaseIdWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName_S);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum, Type.GetType("System.Int32"));
foreach (clsvMicroteachCase_Resource_RelGroupByCaseIdEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase] = objInFor[convMicroteachCase_Resource_RelGroupByCaseId.id_MicroteachCase];
objDR[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId] = objInFor[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId];
objDR[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] = objInFor[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}