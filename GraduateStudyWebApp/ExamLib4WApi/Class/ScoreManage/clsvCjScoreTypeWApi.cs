
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCjScoreTypeWApi
 表名:vCjScoreType(01120346)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:41
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理
 模块英文名:ScoreManage
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
public static class clsvCjScoreTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCjScoreTypeEN Setid_ScoreType(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, convCjScoreType.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, convCjScoreType.id_ScoreType);
objvCjScoreTypeEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.id_ScoreType) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.id_ScoreType, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.id_ScoreType] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCjScoreTypeEN SetScoreTypeId(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strScoreTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strScoreTypeId, convCjScoreType.ScoreTypeId);
clsCheckSql.CheckFieldLen(strScoreTypeId, 4, convCjScoreType.ScoreTypeId);
clsCheckSql.CheckFieldForeignKey(strScoreTypeId, 4, convCjScoreType.ScoreTypeId);
objvCjScoreTypeEN.ScoreTypeId = strScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ScoreTypeId) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ScoreTypeId, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ScoreTypeId] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCjScoreTypeEN SetScoreTypeName(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strScoreTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strScoreTypeName, convCjScoreType.ScoreTypeName);
clsCheckSql.CheckFieldLen(strScoreTypeName, 10, convCjScoreType.ScoreTypeName);
objvCjScoreTypeEN.ScoreTypeName = strScoreTypeName; //分数类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ScoreTypeName) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ScoreTypeName, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ScoreTypeName] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCjScoreTypeEN Setid_MainScoreType(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strid_MainScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MainScoreType, convCjScoreType.id_MainScoreType);
clsCheckSql.CheckFieldLen(strid_MainScoreType, 2, convCjScoreType.id_MainScoreType);
clsCheckSql.CheckFieldForeignKey(strid_MainScoreType, 2, convCjScoreType.id_MainScoreType);
objvCjScoreTypeEN.id_MainScoreType = strid_MainScoreType; //成绩主类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.id_MainScoreType) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.id_MainScoreType, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.id_MainScoreType] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCjScoreTypeEN SetModifyDate(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCjScoreType.ModifyDate);
objvCjScoreTypeEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ModifyDate) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ModifyDate, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ModifyDate] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCjScoreTypeEN SetModifyUserID(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCjScoreType.ModifyUserID);
objvCjScoreTypeEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ModifyUserID) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ModifyUserID, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ModifyUserID] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCjScoreTypeEN objvCjScoreType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCjScoreType_Cond.IsUpdated(convCjScoreType.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objvCjScoreType_Cond.dicFldComparisonOp[convCjScoreType.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.id_ScoreType, objvCjScoreType_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objvCjScoreType_Cond.IsUpdated(convCjScoreType.ScoreTypeId) == true)
{
string strComparisonOp_ScoreTypeId = objvCjScoreType_Cond.dicFldComparisonOp[convCjScoreType.ScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ScoreTypeId, objvCjScoreType_Cond.ScoreTypeId, strComparisonOp_ScoreTypeId);
}
if (objvCjScoreType_Cond.IsUpdated(convCjScoreType.ScoreTypeName) == true)
{
string strComparisonOp_ScoreTypeName = objvCjScoreType_Cond.dicFldComparisonOp[convCjScoreType.ScoreTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ScoreTypeName, objvCjScoreType_Cond.ScoreTypeName, strComparisonOp_ScoreTypeName);
}
if (objvCjScoreType_Cond.IsUpdated(convCjScoreType.id_MainScoreType) == true)
{
string strComparisonOp_id_MainScoreType = objvCjScoreType_Cond.dicFldComparisonOp[convCjScoreType.id_MainScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.id_MainScoreType, objvCjScoreType_Cond.id_MainScoreType, strComparisonOp_id_MainScoreType);
}
if (objvCjScoreType_Cond.IsUpdated(convCjScoreType.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCjScoreType_Cond.dicFldComparisonOp[convCjScoreType.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ModifyDate, objvCjScoreType_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCjScoreType_Cond.IsUpdated(convCjScoreType.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCjScoreType_Cond.dicFldComparisonOp[convCjScoreType.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ModifyUserID, objvCjScoreType_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v成绩类型(vCjScoreType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCjScoreTypeWApi
{
private static readonly string mstrApiControllerName = "vCjScoreTypeApi";

 public clsvCjScoreTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_ScoreType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCjScoreTypeEN GetObjByid_ScoreType(string strid_ScoreType)
{
string strAction = "GetObjByid_ScoreType";
string strErrMsg = string.Empty;
string strResult = "";
clsvCjScoreTypeEN objvCjScoreTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ScoreType"] = strid_ScoreType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCjScoreTypeEN = JsonConvert.DeserializeObject<clsvCjScoreTypeEN>((string)jobjReturn["ReturnObj"]);
return objvCjScoreTypeEN;
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
 /// <param name = "strid_ScoreType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCjScoreTypeEN GetObjByid_ScoreType_WA_Cache(string strid_ScoreType)
{
string strAction = "GetObjByid_ScoreType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCjScoreTypeEN objvCjScoreTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ScoreType"] = strid_ScoreType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCjScoreTypeEN = JsonConvert.DeserializeObject<clsvCjScoreTypeEN>((string)jobjReturn["ReturnObj"]);
return objvCjScoreTypeEN;
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
public static clsvCjScoreTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCjScoreTypeEN objvCjScoreTypeEN = null;
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
objvCjScoreTypeEN = JsonConvert.DeserializeObject<clsvCjScoreTypeEN>((string)jobjReturn["ReturnObj"]);
return objvCjScoreTypeEN;
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
 /// <param name = "strid_ScoreType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCjScoreTypeEN GetObjByid_ScoreType_Cache(string strid_ScoreType)
{
if (string.IsNullOrEmpty(strid_ScoreType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName_S);
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Sel =
from objvCjScoreTypeEN in arrvCjScoreTypeObjLst_Cache
where objvCjScoreTypeEN.id_ScoreType == strid_ScoreType
select objvCjScoreTypeEN;
if (arrvCjScoreTypeObjLst_Sel.Count() == 0)
{
   clsvCjScoreTypeEN obj = clsvCjScoreTypeWApi.GetObjByid_ScoreType(strid_ScoreType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCjScoreTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCjScoreTypeEN> GetObjLstById_ScoreTypeLst(List<string> arrId_ScoreType)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_ScoreTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ScoreType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_ScoreType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCjScoreTypeEN> GetObjLstById_ScoreTypeLst_Cache(List<string> arrId_ScoreType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName_S);
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Sel =
from objvCjScoreTypeEN in arrvCjScoreTypeObjLst_Cache
where arrId_ScoreType.Contains(objvCjScoreTypeEN.id_ScoreType)
select objvCjScoreTypeEN;
return arrvCjScoreTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLstById_ScoreTypeLst_WA_Cache(List<string> arrId_ScoreType)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_ScoreTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ScoreType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCjScoreTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCjScoreTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCjScoreTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCjScoreTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCjScoreTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCjScoreTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_ScoreType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ScoreType"] = strid_ScoreType
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
 /// <param name = "objvCjScoreTypeENS">源对象</param>
 /// <param name = "objvCjScoreTypeENT">目标对象</param>
 public static void CopyTo(clsvCjScoreTypeEN objvCjScoreTypeENS, clsvCjScoreTypeEN objvCjScoreTypeENT)
{
try
{
objvCjScoreTypeENT.id_ScoreType = objvCjScoreTypeENS.id_ScoreType; //成绩类型流水号
objvCjScoreTypeENT.ScoreTypeId = objvCjScoreTypeENS.ScoreTypeId; //分数类型Id
objvCjScoreTypeENT.ScoreTypeName = objvCjScoreTypeENS.ScoreTypeName; //分数类型名称
objvCjScoreTypeENT.id_MainScoreType = objvCjScoreTypeENS.id_MainScoreType; //成绩主类型流水号
objvCjScoreTypeENT.ModifyDate = objvCjScoreTypeENS.ModifyDate; //修改日期
objvCjScoreTypeENT.ModifyUserID = objvCjScoreTypeENS.ModifyUserID; //修改人
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
public static DataTable ToDataTable(List<clsvCjScoreTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCjScoreTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCjScoreTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCjScoreTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCjScoreTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCjScoreTypeEN.AttributeName)
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
if (clsCjScoreTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCjScoreTypeWApi没有刷新缓存机制(clsCjScoreTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_ScoreType");
//if (arrvCjScoreTypeObjLst_Cache == null)
//{
//arrvCjScoreTypeObjLst_Cache = await clsvCjScoreTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName_S);
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
public static List<clsvCjScoreTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName_S);
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCjScoreTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCjScoreTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCjScoreType.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCjScoreType.ScoreTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCjScoreType.ScoreTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCjScoreType.id_MainScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCjScoreType.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCjScoreType.ModifyUserID, Type.GetType("System.String"));
foreach (clsvCjScoreTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCjScoreType.id_ScoreType] = objInFor[convCjScoreType.id_ScoreType];
objDR[convCjScoreType.ScoreTypeId] = objInFor[convCjScoreType.ScoreTypeId];
objDR[convCjScoreType.ScoreTypeName] = objInFor[convCjScoreType.ScoreTypeName];
objDR[convCjScoreType.id_MainScoreType] = objInFor[convCjScoreType.id_MainScoreType];
objDR[convCjScoreType.ModifyDate] = objInFor[convCjScoreType.ModifyDate];
objDR[convCjScoreType.ModifyUserID] = objInFor[convCjScoreType.ModifyUserID];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}