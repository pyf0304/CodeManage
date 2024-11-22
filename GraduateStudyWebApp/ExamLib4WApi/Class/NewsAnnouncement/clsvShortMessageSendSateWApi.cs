
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvShortMessageSendSateWApi
 表名:vShortMessageSendSate(01120289)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:06
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告
 模块英文名:NewsAnnouncement
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
public static class clsvShortMessageSendSateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageSendSateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageSendSateEN SetShortMessageSendSateID(this clsvShortMessageSendSateEN objvShortMessageSendSateEN, string strShortMessageSendSateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strShortMessageSendSateID, 8, convShortMessageSendSate.ShortMessageSendSateID);
clsCheckSql.CheckFieldForeignKey(strShortMessageSendSateID, 8, convShortMessageSendSate.ShortMessageSendSateID);
objvShortMessageSendSateEN.ShortMessageSendSateID = strShortMessageSendSateID; //消息发送状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageSendSateEN.dicFldComparisonOp.ContainsKey(convShortMessageSendSate.ShortMessageSendSateID) == false)
{
objvShortMessageSendSateEN.dicFldComparisonOp.Add(convShortMessageSendSate.ShortMessageSendSateID, strComparisonOp);
}
else
{
objvShortMessageSendSateEN.dicFldComparisonOp[convShortMessageSendSate.ShortMessageSendSateID] = strComparisonOp;
}
}
return objvShortMessageSendSateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageSendSateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageSendSateEN SetShortMessageSendSateName(this clsvShortMessageSendSateEN objvShortMessageSendSateEN, string strShortMessageSendSateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strShortMessageSendSateName, 200, convShortMessageSendSate.ShortMessageSendSateName);
objvShortMessageSendSateEN.ShortMessageSendSateName = strShortMessageSendSateName; //短消息发送状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageSendSateEN.dicFldComparisonOp.ContainsKey(convShortMessageSendSate.ShortMessageSendSateName) == false)
{
objvShortMessageSendSateEN.dicFldComparisonOp.Add(convShortMessageSendSate.ShortMessageSendSateName, strComparisonOp);
}
else
{
objvShortMessageSendSateEN.dicFldComparisonOp[convShortMessageSendSate.ShortMessageSendSateName] = strComparisonOp;
}
}
return objvShortMessageSendSateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageSendSateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageSendSateEN SetUpdDate(this clsvShortMessageSendSateEN objvShortMessageSendSateEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convShortMessageSendSate.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convShortMessageSendSate.UpdDate);
objvShortMessageSendSateEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageSendSateEN.dicFldComparisonOp.ContainsKey(convShortMessageSendSate.UpdDate) == false)
{
objvShortMessageSendSateEN.dicFldComparisonOp.Add(convShortMessageSendSate.UpdDate, strComparisonOp);
}
else
{
objvShortMessageSendSateEN.dicFldComparisonOp[convShortMessageSendSate.UpdDate] = strComparisonOp;
}
}
return objvShortMessageSendSateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageSendSateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageSendSateEN SetUpdUser(this clsvShortMessageSendSateEN objvShortMessageSendSateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convShortMessageSendSate.UpdUser);
objvShortMessageSendSateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageSendSateEN.dicFldComparisonOp.ContainsKey(convShortMessageSendSate.UpdUser) == false)
{
objvShortMessageSendSateEN.dicFldComparisonOp.Add(convShortMessageSendSate.UpdUser, strComparisonOp);
}
else
{
objvShortMessageSendSateEN.dicFldComparisonOp[convShortMessageSendSate.UpdUser] = strComparisonOp;
}
}
return objvShortMessageSendSateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageSendSateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageSendSateEN SetMemo(this clsvShortMessageSendSateEN objvShortMessageSendSateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convShortMessageSendSate.Memo);
objvShortMessageSendSateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageSendSateEN.dicFldComparisonOp.ContainsKey(convShortMessageSendSate.Memo) == false)
{
objvShortMessageSendSateEN.dicFldComparisonOp.Add(convShortMessageSendSate.Memo, strComparisonOp);
}
else
{
objvShortMessageSendSateEN.dicFldComparisonOp[convShortMessageSendSate.Memo] = strComparisonOp;
}
}
return objvShortMessageSendSateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvShortMessageSendSateEN objvShortMessageSendSate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvShortMessageSendSate_Cond.IsUpdated(convShortMessageSendSate.ShortMessageSendSateID) == true)
{
string strComparisonOp_ShortMessageSendSateID = objvShortMessageSendSate_Cond.dicFldComparisonOp[convShortMessageSendSate.ShortMessageSendSateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessageSendSate.ShortMessageSendSateID, objvShortMessageSendSate_Cond.ShortMessageSendSateID, strComparisonOp_ShortMessageSendSateID);
}
if (objvShortMessageSendSate_Cond.IsUpdated(convShortMessageSendSate.ShortMessageSendSateName) == true)
{
string strComparisonOp_ShortMessageSendSateName = objvShortMessageSendSate_Cond.dicFldComparisonOp[convShortMessageSendSate.ShortMessageSendSateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessageSendSate.ShortMessageSendSateName, objvShortMessageSendSate_Cond.ShortMessageSendSateName, strComparisonOp_ShortMessageSendSateName);
}
if (objvShortMessageSendSate_Cond.IsUpdated(convShortMessageSendSate.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvShortMessageSendSate_Cond.dicFldComparisonOp[convShortMessageSendSate.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessageSendSate.UpdDate, objvShortMessageSendSate_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvShortMessageSendSate_Cond.IsUpdated(convShortMessageSendSate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvShortMessageSendSate_Cond.dicFldComparisonOp[convShortMessageSendSate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessageSendSate.UpdUser, objvShortMessageSendSate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvShortMessageSendSate_Cond.IsUpdated(convShortMessageSendSate.Memo) == true)
{
string strComparisonOp_Memo = objvShortMessageSendSate_Cond.dicFldComparisonOp[convShortMessageSendSate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessageSendSate.Memo, objvShortMessageSendSate_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 消息发送状态视图(vShortMessageSendSate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvShortMessageSendSateWApi
{
private static readonly string mstrApiControllerName = "vShortMessageSendSateApi";

 public clsvShortMessageSendSateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strShortMessageSendSateID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvShortMessageSendSateEN GetObjByShortMessageSendSateID(string strShortMessageSendSateID)
{
string strAction = "GetObjByShortMessageSendSateID";
string strErrMsg = string.Empty;
string strResult = "";
clsvShortMessageSendSateEN objvShortMessageSendSateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ShortMessageSendSateID"] = strShortMessageSendSateID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvShortMessageSendSateEN = JsonConvert.DeserializeObject<clsvShortMessageSendSateEN>((string)jobjReturn["ReturnObj"]);
return objvShortMessageSendSateEN;
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
 /// <param name = "strShortMessageSendSateID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvShortMessageSendSateEN GetObjByShortMessageSendSateID_WA_Cache(string strShortMessageSendSateID)
{
string strAction = "GetObjByShortMessageSendSateID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvShortMessageSendSateEN objvShortMessageSendSateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ShortMessageSendSateID"] = strShortMessageSendSateID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvShortMessageSendSateEN = JsonConvert.DeserializeObject<clsvShortMessageSendSateEN>((string)jobjReturn["ReturnObj"]);
return objvShortMessageSendSateEN;
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
public static clsvShortMessageSendSateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvShortMessageSendSateEN objvShortMessageSendSateEN = null;
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
objvShortMessageSendSateEN = JsonConvert.DeserializeObject<clsvShortMessageSendSateEN>((string)jobjReturn["ReturnObj"]);
return objvShortMessageSendSateEN;
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
 /// <param name = "strShortMessageSendSateID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvShortMessageSendSateEN GetObjByShortMessageSendSateID_Cache(string strShortMessageSendSateID)
{
if (string.IsNullOrEmpty(strShortMessageSendSateID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvShortMessageSendSateEN._CurrTabName_S);
List<clsvShortMessageSendSateEN> arrvShortMessageSendSateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvShortMessageSendSateEN> arrvShortMessageSendSateObjLst_Sel =
from objvShortMessageSendSateEN in arrvShortMessageSendSateObjLst_Cache
where objvShortMessageSendSateEN.ShortMessageSendSateID == strShortMessageSendSateID
select objvShortMessageSendSateEN;
if (arrvShortMessageSendSateObjLst_Sel.Count() == 0)
{
   clsvShortMessageSendSateEN obj = clsvShortMessageSendSateWApi.GetObjByShortMessageSendSateID(strShortMessageSendSateID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvShortMessageSendSateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageSendSateEN> GetObjLst(string strWhereCond)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageSendSateEN> GetObjLstByShortMessageSendSateIDLst(List<string> arrShortMessageSendSateID)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
string strAction = "GetObjLstByShortMessageSendSateIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrShortMessageSendSateID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strShortMessageSendSateID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvShortMessageSendSateEN> GetObjLstByShortMessageSendSateIDLst_Cache(List<string> arrShortMessageSendSateID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvShortMessageSendSateEN._CurrTabName_S);
List<clsvShortMessageSendSateEN> arrvShortMessageSendSateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvShortMessageSendSateEN> arrvShortMessageSendSateObjLst_Sel =
from objvShortMessageSendSateEN in arrvShortMessageSendSateObjLst_Cache
where arrShortMessageSendSateID.Contains(objvShortMessageSendSateEN.ShortMessageSendSateID)
select objvShortMessageSendSateEN;
return arrvShortMessageSendSateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageSendSateEN> GetObjLstByShortMessageSendSateIDLst_WA_Cache(List<string> arrShortMessageSendSateID)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
string strAction = "GetObjLstByShortMessageSendSateIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrShortMessageSendSateID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageSendSateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageSendSateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageSendSateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageSendSateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvShortMessageSendSateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageSendSateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strShortMessageSendSateID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ShortMessageSendSateID"] = strShortMessageSendSateID
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
 /// <param name = "objvShortMessageSendSateENS">源对象</param>
 /// <param name = "objvShortMessageSendSateENT">目标对象</param>
 public static void CopyTo(clsvShortMessageSendSateEN objvShortMessageSendSateENS, clsvShortMessageSendSateEN objvShortMessageSendSateENT)
{
try
{
objvShortMessageSendSateENT.ShortMessageSendSateID = objvShortMessageSendSateENS.ShortMessageSendSateID; //消息发送状态Id
objvShortMessageSendSateENT.ShortMessageSendSateName = objvShortMessageSendSateENS.ShortMessageSendSateName; //短消息发送状态名称
objvShortMessageSendSateENT.UpdDate = objvShortMessageSendSateENS.UpdDate; //修改日期
objvShortMessageSendSateENT.UpdUser = objvShortMessageSendSateENS.UpdUser; //修改人
objvShortMessageSendSateENT.Memo = objvShortMessageSendSateENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvShortMessageSendSateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvShortMessageSendSateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvShortMessageSendSateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvShortMessageSendSateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvShortMessageSendSateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvShortMessageSendSateEN.AttributeName)
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
if (clsShortMessageSendSateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsShortMessageSendSateWApi没有刷新缓存机制(clsShortMessageSendSateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ShortMessageSendSateID");
//if (arrvShortMessageSendSateObjLst_Cache == null)
//{
//arrvShortMessageSendSateObjLst_Cache = await clsvShortMessageSendSateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvShortMessageSendSateEN._CurrTabName_S);
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
public static List<clsvShortMessageSendSateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvShortMessageSendSateEN._CurrTabName_S);
List<clsvShortMessageSendSateEN> arrvShortMessageSendSateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvShortMessageSendSateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvShortMessageSendSateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convShortMessageSendSate.ShortMessageSendSateID, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessageSendSate.ShortMessageSendSateName, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessageSendSate.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessageSendSate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessageSendSate.Memo, Type.GetType("System.String"));
foreach (clsvShortMessageSendSateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convShortMessageSendSate.ShortMessageSendSateID] = objInFor[convShortMessageSendSate.ShortMessageSendSateID];
objDR[convShortMessageSendSate.ShortMessageSendSateName] = objInFor[convShortMessageSendSate.ShortMessageSendSateName];
objDR[convShortMessageSendSate.UpdDate] = objInFor[convShortMessageSendSate.UpdDate];
objDR[convShortMessageSendSate.UpdUser] = objInFor[convShortMessageSendSate.UpdUser];
objDR[convShortMessageSendSate.Memo] = objInFor[convShortMessageSendSate.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}