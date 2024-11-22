
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFriendLinkWApi
 表名:vFriendLink(01120438)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:链接管理
 模块英文名:LinkManage
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
public static class clsvFriendLinkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetFriendLinkId(this clsvFriendLinkEN objvFriendLinkEN, long lngFriendLinkId, string strComparisonOp="")
	{
objvFriendLinkEN.FriendLinkId = lngFriendLinkId; //友情链接Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.FriendLinkId) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.FriendLinkId, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.FriendLinkId] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetLinkCategoriesId(this clsvFriendLinkEN objvFriendLinkEN, string strLinkCategoriesId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkCategoriesId, 2, convFriendLink.LinkCategoriesId);
clsCheckSql.CheckFieldForeignKey(strLinkCategoriesId, 2, convFriendLink.LinkCategoriesId);
objvFriendLinkEN.LinkCategoriesId = strLinkCategoriesId; //链接分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.LinkCategoriesId) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.LinkCategoriesId, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.LinkCategoriesId] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetLinkCategoriesName(this clsvFriendLinkEN objvFriendLinkEN, string strLinkCategoriesName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkCategoriesName, 50, convFriendLink.LinkCategoriesName);
objvFriendLinkEN.LinkCategoriesName = strLinkCategoriesName; //链接分类名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.LinkCategoriesName) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.LinkCategoriesName, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.LinkCategoriesName] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetFriendLinkName(this clsvFriendLinkEN objvFriendLinkEN, string strFriendLinkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFriendLinkName, convFriendLink.FriendLinkName);
clsCheckSql.CheckFieldLen(strFriendLinkName, 100, convFriendLink.FriendLinkName);
objvFriendLinkEN.FriendLinkName = strFriendLinkName; //友情链接名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.FriendLinkName) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.FriendLinkName, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.FriendLinkName] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetFriendLinkUrl(this clsvFriendLinkEN objvFriendLinkEN, string strFriendLinkUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFriendLinkUrl, 500, convFriendLink.FriendLinkUrl);
objvFriendLinkEN.FriendLinkUrl = strFriendLinkUrl; //友情链接地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.FriendLinkUrl) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.FriendLinkUrl, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.FriendLinkUrl] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetIsMark(this clsvFriendLinkEN objvFriendLinkEN, bool bolIsMark, string strComparisonOp="")
	{
objvFriendLinkEN.IsMark = bolIsMark; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.IsMark) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.IsMark, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.IsMark] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFriendLinkEN SetMemo(this clsvFriendLinkEN objvFriendLinkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFriendLink.Memo);
objvFriendLinkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFriendLinkEN.dicFldComparisonOp.ContainsKey(convFriendLink.Memo) == false)
{
objvFriendLinkEN.dicFldComparisonOp.Add(convFriendLink.Memo, strComparisonOp);
}
else
{
objvFriendLinkEN.dicFldComparisonOp[convFriendLink.Memo] = strComparisonOp;
}
}
return objvFriendLinkEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFriendLinkEN objvFriendLink_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFriendLink_Cond.IsUpdated(convFriendLink.FriendLinkId) == true)
{
string strComparisonOp_FriendLinkId = objvFriendLink_Cond.dicFldComparisonOp[convFriendLink.FriendLinkId];
strWhereCond += string.Format(" And {0} {2} {1}", convFriendLink.FriendLinkId, objvFriendLink_Cond.FriendLinkId, strComparisonOp_FriendLinkId);
}
if (objvFriendLink_Cond.IsUpdated(convFriendLink.LinkCategoriesId) == true)
{
string strComparisonOp_LinkCategoriesId = objvFriendLink_Cond.dicFldComparisonOp[convFriendLink.LinkCategoriesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFriendLink.LinkCategoriesId, objvFriendLink_Cond.LinkCategoriesId, strComparisonOp_LinkCategoriesId);
}
if (objvFriendLink_Cond.IsUpdated(convFriendLink.LinkCategoriesName) == true)
{
string strComparisonOp_LinkCategoriesName = objvFriendLink_Cond.dicFldComparisonOp[convFriendLink.LinkCategoriesName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFriendLink.LinkCategoriesName, objvFriendLink_Cond.LinkCategoriesName, strComparisonOp_LinkCategoriesName);
}
if (objvFriendLink_Cond.IsUpdated(convFriendLink.FriendLinkName) == true)
{
string strComparisonOp_FriendLinkName = objvFriendLink_Cond.dicFldComparisonOp[convFriendLink.FriendLinkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFriendLink.FriendLinkName, objvFriendLink_Cond.FriendLinkName, strComparisonOp_FriendLinkName);
}
if (objvFriendLink_Cond.IsUpdated(convFriendLink.FriendLinkUrl) == true)
{
string strComparisonOp_FriendLinkUrl = objvFriendLink_Cond.dicFldComparisonOp[convFriendLink.FriendLinkUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFriendLink.FriendLinkUrl, objvFriendLink_Cond.FriendLinkUrl, strComparisonOp_FriendLinkUrl);
}
if (objvFriendLink_Cond.IsUpdated(convFriendLink.IsMark) == true)
{
if (objvFriendLink_Cond.IsMark == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFriendLink.IsMark);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFriendLink.IsMark);
}
}
if (objvFriendLink_Cond.IsUpdated(convFriendLink.Memo) == true)
{
string strComparisonOp_Memo = objvFriendLink_Cond.dicFldComparisonOp[convFriendLink.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFriendLink.Memo, objvFriendLink_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v友情链接(vFriendLink)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFriendLinkWApi
{
private static readonly string mstrApiControllerName = "vFriendLinkApi";

 public clsvFriendLinkWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFriendLinkId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFriendLinkEN GetObjByFriendLinkId(long lngFriendLinkId)
{
string strAction = "GetObjByFriendLinkId";
string strErrMsg = string.Empty;
string strResult = "";
clsvFriendLinkEN objvFriendLinkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FriendLinkId"] = lngFriendLinkId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvFriendLinkEN = JsonConvert.DeserializeObject<clsvFriendLinkEN>((string)jobjReturn["ReturnObj"]);
return objvFriendLinkEN;
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
 /// <param name = "lngFriendLinkId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFriendLinkEN GetObjByFriendLinkId_WA_Cache(long lngFriendLinkId)
{
string strAction = "GetObjByFriendLinkId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvFriendLinkEN objvFriendLinkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FriendLinkId"] = lngFriendLinkId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvFriendLinkEN = JsonConvert.DeserializeObject<clsvFriendLinkEN>((string)jobjReturn["ReturnObj"]);
return objvFriendLinkEN;
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
public static clsvFriendLinkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvFriendLinkEN objvFriendLinkEN = null;
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
objvFriendLinkEN = JsonConvert.DeserializeObject<clsvFriendLinkEN>((string)jobjReturn["ReturnObj"]);
return objvFriendLinkEN;
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
 /// <param name = "lngFriendLinkId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFriendLinkEN GetObjByFriendLinkId_Cache(long lngFriendLinkId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFriendLinkEN._CurrTabName_S);
List<clsvFriendLinkEN> arrvFriendLinkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFriendLinkEN> arrvFriendLinkObjLst_Sel =
from objvFriendLinkEN in arrvFriendLinkObjLst_Cache
where objvFriendLinkEN.FriendLinkId == lngFriendLinkId
select objvFriendLinkEN;
if (arrvFriendLinkObjLst_Sel.Count() == 0)
{
   clsvFriendLinkEN obj = clsvFriendLinkWApi.GetObjByFriendLinkId(lngFriendLinkId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFriendLinkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFriendLinkEN> GetObjLst(string strWhereCond)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFriendLinkEN> GetObjLstByFriendLinkIdLst(List<long> arrFriendLinkId)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
string strAction = "GetObjLstByFriendLinkIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFriendLinkId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngFriendLinkId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvFriendLinkEN> GetObjLstByFriendLinkIdLst_Cache(List<long> arrFriendLinkId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFriendLinkEN._CurrTabName_S);
List<clsvFriendLinkEN> arrvFriendLinkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFriendLinkEN> arrvFriendLinkObjLst_Sel =
from objvFriendLinkEN in arrvFriendLinkObjLst_Cache
where arrFriendLinkId.Contains(objvFriendLinkEN.FriendLinkId)
select objvFriendLinkEN;
return arrvFriendLinkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFriendLinkEN> GetObjLstByFriendLinkIdLst_WA_Cache(List<long> arrFriendLinkId)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
string strAction = "GetObjLstByFriendLinkIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFriendLinkId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFriendLinkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFriendLinkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFriendLinkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFriendLinkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngFriendLinkId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FriendLinkId"] = lngFriendLinkId.ToString()
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
 /// <param name = "objvFriendLinkENS">源对象</param>
 /// <param name = "objvFriendLinkENT">目标对象</param>
 public static void CopyTo(clsvFriendLinkEN objvFriendLinkENS, clsvFriendLinkEN objvFriendLinkENT)
{
try
{
objvFriendLinkENT.FriendLinkId = objvFriendLinkENS.FriendLinkId; //友情链接Id
objvFriendLinkENT.LinkCategoriesId = objvFriendLinkENS.LinkCategoriesId; //链接分类Id
objvFriendLinkENT.LinkCategoriesName = objvFriendLinkENS.LinkCategoriesName; //链接分类名称
objvFriendLinkENT.FriendLinkName = objvFriendLinkENS.FriendLinkName; //友情链接名
objvFriendLinkENT.FriendLinkUrl = objvFriendLinkENS.FriendLinkUrl; //友情链接地址
objvFriendLinkENT.IsMark = objvFriendLinkENS.IsMark; //是否启用
objvFriendLinkENT.Memo = objvFriendLinkENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvFriendLinkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFriendLinkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFriendLinkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFriendLinkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFriendLinkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFriendLinkEN.AttributeName)
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
if (clsFriendLinkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFriendLinkWApi没有刷新缓存机制(clsFriendLinkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FriendLinkId");
//if (arrvFriendLinkObjLst_Cache == null)
//{
//arrvFriendLinkObjLst_Cache = await clsvFriendLinkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvFriendLinkEN._CurrTabName_S);
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
public static List<clsvFriendLinkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvFriendLinkEN._CurrTabName_S);
List<clsvFriendLinkEN> arrvFriendLinkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFriendLinkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFriendLinkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFriendLink.FriendLinkId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFriendLink.LinkCategoriesId, Type.GetType("System.String"));
objDT.Columns.Add(convFriendLink.LinkCategoriesName, Type.GetType("System.String"));
objDT.Columns.Add(convFriendLink.FriendLinkName, Type.GetType("System.String"));
objDT.Columns.Add(convFriendLink.FriendLinkUrl, Type.GetType("System.String"));
objDT.Columns.Add(convFriendLink.IsMark, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFriendLink.Memo, Type.GetType("System.String"));
foreach (clsvFriendLinkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFriendLink.FriendLinkId] = objInFor[convFriendLink.FriendLinkId];
objDR[convFriendLink.LinkCategoriesId] = objInFor[convFriendLink.LinkCategoriesId];
objDR[convFriendLink.LinkCategoriesName] = objInFor[convFriendLink.LinkCategoriesName];
objDR[convFriendLink.FriendLinkName] = objInFor[convFriendLink.FriendLinkName];
objDR[convFriendLink.FriendLinkUrl] = objInFor[convFriendLink.FriendLinkUrl];
objDR[convFriendLink.IsMark] = objInFor[convFriendLink.IsMark];
objDR[convFriendLink.Memo] = objInFor[convFriendLink.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}