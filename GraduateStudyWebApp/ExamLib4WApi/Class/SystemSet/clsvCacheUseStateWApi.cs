
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCacheUseStateWApi
 表名:vCacheUseState(01120690)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:41
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsvCacheUseStateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetmId(this clsvCacheUseStateEN objvCacheUseStateEN, long lngmId, string strComparisonOp="")
	{
objvCacheUseStateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.mId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.mId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.mId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetUserId(this clsvCacheUseStateEN objvCacheUseStateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCacheUseState.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convCacheUseState.UserId);
objvCacheUseStateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.UserId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.UserId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.UserId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeId(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convCacheUseState.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convCacheUseState.CacheModeId);
objvCacheUseStateEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeName(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeName, 50, convCacheUseState.CacheModeName);
objvCacheUseStateEN.CacheModeName = strCacheModeName; //缓存方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeName) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeName, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeName] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeENName(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeENName, 50, convCacheUseState.CacheModeENName);
objvCacheUseStateEN.CacheModeENName = strCacheModeENName; //缓存方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeENName) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeENName, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeENName] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheKey(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheKey, 50, convCacheUseState.CacheKey);
objvCacheUseStateEN.CacheKey = strCacheKey; //缓存关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheKey) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheKey, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheKey] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheSize(this clsvCacheUseStateEN objvCacheUseStateEN, int intCacheSize, string strComparisonOp="")
	{
objvCacheUseStateEN.CacheSize = intCacheSize; //缓存大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheSize) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheSize, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheSize] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCacheUseStateEN SetMemo(this clsvCacheUseStateEN objvCacheUseStateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCacheUseState.Memo);
objvCacheUseStateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.Memo) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.Memo, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.Memo] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCacheUseStateEN objvCacheUseState_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.mId) == true)
{
string strComparisonOp_mId = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCacheUseState.mId, objvCacheUseState_Cond.mId, strComparisonOp_mId);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.UserId) == true)
{
string strComparisonOp_UserId = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.UserId, objvCacheUseState_Cond.UserId, strComparisonOp_UserId);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.CacheModeId) == true)
{
string strComparisonOp_CacheModeId = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeId, objvCacheUseState_Cond.CacheModeId, strComparisonOp_CacheModeId);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.CacheModeName) == true)
{
string strComparisonOp_CacheModeName = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.CacheModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeName, objvCacheUseState_Cond.CacheModeName, strComparisonOp_CacheModeName);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.CacheModeENName) == true)
{
string strComparisonOp_CacheModeENName = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.CacheModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeENName, objvCacheUseState_Cond.CacheModeENName, strComparisonOp_CacheModeENName);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.CacheKey) == true)
{
string strComparisonOp_CacheKey = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.CacheKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheKey, objvCacheUseState_Cond.CacheKey, strComparisonOp_CacheKey);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.CacheSize) == true)
{
string strComparisonOp_CacheSize = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.CacheSize];
strWhereCond += string.Format(" And {0} {2} {1}", convCacheUseState.CacheSize, objvCacheUseState_Cond.CacheSize, strComparisonOp_CacheSize);
}
if (objvCacheUseState_Cond.IsUpdated(convCacheUseState.Memo) == true)
{
string strComparisonOp_Memo = objvCacheUseState_Cond.dicFldComparisonOp[convCacheUseState.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.Memo, objvCacheUseState_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vCacheUseState(vCacheUseState), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_mId(this clsvCacheUseStateEN objvCacheUseStateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvCacheUseStateEN == null) return "";
if (objvCacheUseStateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvCacheUseStateEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvCacheUseStateEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvCacheUseStateEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vCacheUseState(vCacheUseState)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCacheUseStateWApi
{
private static readonly string mstrApiControllerName = "vCacheUseStateApi";

 public clsvCacheUseStateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCacheUseStateEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvCacheUseStateEN objvCacheUseStateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCacheUseStateEN = JsonConvert.DeserializeObject<clsvCacheUseStateEN>((string)jobjReturn["ReturnObj"]);
return objvCacheUseStateEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCacheUseStateEN GetObjBymId_WA_Cache(long lngmId, string strUserId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCacheUseStateEN objvCacheUseStateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCacheUseStateEN = JsonConvert.DeserializeObject<clsvCacheUseStateEN>((string)jobjReturn["ReturnObj"]);
return objvCacheUseStateEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
public static clsvCacheUseStateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCacheUseStateEN objvCacheUseStateEN = null;
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
objvCacheUseStateEN = JsonConvert.DeserializeObject<clsvCacheUseStateEN>((string)jobjReturn["ReturnObj"]);
return objvCacheUseStateEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCacheUseStateEN GetObjBymId_Cache(long lngmId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName_S, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLst_Cache = GetObjLst_Cache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrvCacheUseStateObjLst_Sel =
from objvCacheUseStateEN in arrvCacheUseStateObjLst_Cache
where objvCacheUseStateEN.mId == lngmId
select objvCacheUseStateEN;
if (arrvCacheUseStateObjLst_Sel.Count() == 0)
{
   clsvCacheUseStateEN obj = clsvCacheUseStateWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCacheUseStateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLst(string strWhereCond)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCacheUseStateEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCacheUseStateEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName_S, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLst_Cache = GetObjLst_Cache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrvCacheUseStateObjLst_Sel =
from objvCacheUseStateEN in arrvCacheUseStateObjLst_Cache
where arrMId.Contains(objvCacheUseStateEN.mId)
select objvCacheUseStateEN;
return arrvCacheUseStateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strUserId)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCacheUseStateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCacheUseStateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCacheUseStateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCacheUseStateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCacheUseStateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCacheUseStateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvCacheUseStateENS">源对象</param>
 /// <param name = "objvCacheUseStateENT">目标对象</param>
 public static void CopyTo(clsvCacheUseStateEN objvCacheUseStateENS, clsvCacheUseStateEN objvCacheUseStateENT)
{
try
{
objvCacheUseStateENT.mId = objvCacheUseStateENS.mId; //mId
objvCacheUseStateENT.UserId = objvCacheUseStateENS.UserId; //用户ID
objvCacheUseStateENT.CacheModeId = objvCacheUseStateENS.CacheModeId; //缓存方式Id
objvCacheUseStateENT.CacheModeName = objvCacheUseStateENS.CacheModeName; //缓存方式名
objvCacheUseStateENT.CacheModeENName = objvCacheUseStateENS.CacheModeENName; //缓存方式英文名
objvCacheUseStateENT.CacheKey = objvCacheUseStateENS.CacheKey; //缓存关键字
objvCacheUseStateENT.CacheSize = objvCacheUseStateENS.CacheSize; //缓存大小
objvCacheUseStateENT.Memo = objvCacheUseStateENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCacheUseStateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCacheUseStateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCacheUseStateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCacheUseStateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCacheUseStateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCacheUseStateEN.AttributeName)
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
if (clsCacheModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCacheModeWApi没有刷新缓存机制(clsCacheModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCacheUseStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCacheUseStateWApi没有刷新缓存机制(clsCacheUseStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCacheUseStateObjLst_Cache == null)
//{
//arrvCacheUseStateObjLst_Cache = await clsvCacheUseStateWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName_S, strUserId);
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
public static List<clsvCacheUseStateEN> GetObjLst_Cache(string strUserId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName_S, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("UserId='{0}'", strUserId)); });
return arrvCacheUseStateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCacheUseStateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCacheUseState.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCacheUseState.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheModeName, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheModeENName, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheKey, Type.GetType("System.String"));
objDT.Columns.Add(convCacheUseState.CacheSize, Type.GetType("System.Int32"));
objDT.Columns.Add(convCacheUseState.Memo, Type.GetType("System.String"));
foreach (clsvCacheUseStateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCacheUseState.mId] = objInFor[convCacheUseState.mId];
objDR[convCacheUseState.UserId] = objInFor[convCacheUseState.UserId];
objDR[convCacheUseState.CacheModeId] = objInFor[convCacheUseState.CacheModeId];
objDR[convCacheUseState.CacheModeName] = objInFor[convCacheUseState.CacheModeName];
objDR[convCacheUseState.CacheModeENName] = objInFor[convCacheUseState.CacheModeENName];
objDR[convCacheUseState.CacheKey] = objInFor[convCacheUseState.CacheKey];
objDR[convCacheUseState.CacheSize] = objInFor[convCacheUseState.CacheSize];
objDR[convCacheUseState.Memo] = objInFor[convCacheUseState.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}