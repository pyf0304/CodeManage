
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClientVersionWApi
 表名:vClientVersion(01120278)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:24
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsvClientVersionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetClientVersionId(this clsvClientVersionEN objvClientVersionEN, string strClientVersionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClientVersionId, 8, convClientVersion.ClientVersionId);
clsCheckSql.CheckFieldForeignKey(strClientVersionId, 8, convClientVersion.ClientVersionId);
objvClientVersionEN.ClientVersionId = strClientVersionId; //客户端版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.ClientVersionId) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.ClientVersionId, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.ClientVersionId] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetClientVersionTypeId(this clsvClientVersionEN objvClientVersionEN, string strClientVersionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClientVersionTypeId, convClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, convClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, convClientVersion.ClientVersionTypeId);
objvClientVersionEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.ClientVersionTypeId) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.ClientVersionTypeId, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.ClientVersionTypeId] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetClientVersionTypeName(this clsvClientVersionEN objvClientVersionEN, string strClientVersionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClientVersionTypeName, 50, convClientVersion.ClientVersionTypeName);
objvClientVersionEN.ClientVersionTypeName = strClientVersionTypeName; //客户端版本类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.ClientVersionTypeName) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.ClientVersionTypeName, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.ClientVersionTypeName] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetVersionDescription(this clsvClientVersionEN objvClientVersionEN, string strVersionDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVersionDescription, 1000, convClientVersion.VersionDescription);
objvClientVersionEN.VersionDescription = strVersionDescription; //版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionDescription) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionDescription, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionDescription] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetVersionNumber(this clsvClientVersionEN objvClientVersionEN, string strVersionNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionNumber, convClientVersion.VersionNumber);
clsCheckSql.CheckFieldLen(strVersionNumber, 50, convClientVersion.VersionNumber);
objvClientVersionEN.VersionNumber = strVersionNumber; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionNumber) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionNumber, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionNumber] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetVersionState(this clsvClientVersionEN objvClientVersionEN, bool bolVersionState, string strComparisonOp="")
	{
objvClientVersionEN.VersionState = bolVersionState; //版本状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionState) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionState, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionState] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetVersionUrl(this clsvClientVersionEN objvClientVersionEN, string strVersionUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionUrl, convClientVersion.VersionUrl);
clsCheckSql.CheckFieldLen(strVersionUrl, 500, convClientVersion.VersionUrl);
objvClientVersionEN.VersionUrl = strVersionUrl; //版本文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionUrl) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionUrl, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionUrl] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetUpdDate(this clsvClientVersionEN objvClientVersionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClientVersion.UpdDate);
objvClientVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.UpdDate) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.UpdDate, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.UpdDate] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetUpdUser(this clsvClientVersionEN objvClientVersionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClientVersion.UpdUser);
objvClientVersionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.UpdUser) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.UpdUser, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.UpdUser] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClientVersionEN SetMemo(this clsvClientVersionEN objvClientVersionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClientVersion.Memo);
objvClientVersionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.Memo) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.Memo, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.Memo] = strComparisonOp;
}
}
return objvClientVersionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClientVersionEN objvClientVersion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClientVersion_Cond.IsUpdated(convClientVersion.ClientVersionId) == true)
{
string strComparisonOp_ClientVersionId = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.ClientVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.ClientVersionId, objvClientVersion_Cond.ClientVersionId, strComparisonOp_ClientVersionId);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.ClientVersionTypeId) == true)
{
string strComparisonOp_ClientVersionTypeId = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.ClientVersionTypeId, objvClientVersion_Cond.ClientVersionTypeId, strComparisonOp_ClientVersionTypeId);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.ClientVersionTypeName) == true)
{
string strComparisonOp_ClientVersionTypeName = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.ClientVersionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.ClientVersionTypeName, objvClientVersion_Cond.ClientVersionTypeName, strComparisonOp_ClientVersionTypeName);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.VersionDescription) == true)
{
string strComparisonOp_VersionDescription = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.VersionDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.VersionDescription, objvClientVersion_Cond.VersionDescription, strComparisonOp_VersionDescription);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.VersionNumber) == true)
{
string strComparisonOp_VersionNumber = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.VersionNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.VersionNumber, objvClientVersion_Cond.VersionNumber, strComparisonOp_VersionNumber);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.VersionState) == true)
{
if (objvClientVersion_Cond.VersionState == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClientVersion.VersionState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClientVersion.VersionState);
}
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.VersionUrl) == true)
{
string strComparisonOp_VersionUrl = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.VersionUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.VersionUrl, objvClientVersion_Cond.VersionUrl, strComparisonOp_VersionUrl);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.UpdDate, objvClientVersion_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.UpdUser, objvClientVersion_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvClientVersion_Cond.IsUpdated(convClientVersion.Memo) == true)
{
string strComparisonOp_Memo = objvClientVersion_Cond.dicFldComparisonOp[convClientVersion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.Memo, objvClientVersion_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v客户端版本(vClientVersion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClientVersionWApi
{
private static readonly string mstrApiControllerName = "vClientVersionApi";

 public clsvClientVersionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClientVersionEN GetObjByClientVersionId(string strClientVersionId)
{
string strAction = "GetObjByClientVersionId";
string strErrMsg = string.Empty;
string strResult = "";
clsvClientVersionEN objvClientVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClientVersionId"] = strClientVersionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvClientVersionEN = JsonConvert.DeserializeObject<clsvClientVersionEN>((string)jobjReturn["ReturnObj"]);
return objvClientVersionEN;
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
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClientVersionEN GetObjByClientVersionId_WA_Cache(string strClientVersionId)
{
string strAction = "GetObjByClientVersionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClientVersionEN objvClientVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClientVersionId"] = strClientVersionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvClientVersionEN = JsonConvert.DeserializeObject<clsvClientVersionEN>((string)jobjReturn["ReturnObj"]);
return objvClientVersionEN;
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
public static clsvClientVersionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClientVersionEN objvClientVersionEN = null;
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
objvClientVersionEN = JsonConvert.DeserializeObject<clsvClientVersionEN>((string)jobjReturn["ReturnObj"]);
return objvClientVersionEN;
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
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClientVersionEN GetObjByClientVersionId_Cache(string strClientVersionId)
{
if (string.IsNullOrEmpty(strClientVersionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName_S);
List<clsvClientVersionEN> arrvClientVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClientVersionEN> arrvClientVersionObjLst_Sel =
from objvClientVersionEN in arrvClientVersionObjLst_Cache
where objvClientVersionEN.ClientVersionId == strClientVersionId
select objvClientVersionEN;
if (arrvClientVersionObjLst_Sel.Count() == 0)
{
   clsvClientVersionEN obj = clsvClientVersionWApi.GetObjByClientVersionId(strClientVersionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClientVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClientVersionEN> GetObjLst(string strWhereCond)
{
 List<clsvClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClientVersionEN> GetObjLstByClientVersionIdLst(List<string> arrClientVersionId)
{
 List<clsvClientVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByClientVersionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClientVersionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvClientVersionEN> GetObjLstByClientVersionIdLst_Cache(List<string> arrClientVersionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName_S);
List<clsvClientVersionEN> arrvClientVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClientVersionEN> arrvClientVersionObjLst_Sel =
from objvClientVersionEN in arrvClientVersionObjLst_Cache
where arrClientVersionId.Contains(objvClientVersionEN.ClientVersionId)
select objvClientVersionEN;
return arrvClientVersionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClientVersionEN> GetObjLstByClientVersionIdLst_WA_Cache(List<string> arrClientVersionId)
{
 List<clsvClientVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByClientVersionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClientVersionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClientVersionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClientVersionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClientVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClientVersionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strClientVersionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClientVersionId"] = strClientVersionId
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
 /// <param name = "objvClientVersionENS">源对象</param>
 /// <param name = "objvClientVersionENT">目标对象</param>
 public static void CopyTo(clsvClientVersionEN objvClientVersionENS, clsvClientVersionEN objvClientVersionENT)
{
try
{
objvClientVersionENT.ClientVersionId = objvClientVersionENS.ClientVersionId; //客户端版本Id
objvClientVersionENT.ClientVersionTypeId = objvClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objvClientVersionENT.ClientVersionTypeName = objvClientVersionENS.ClientVersionTypeName; //客户端版本类型名称
objvClientVersionENT.VersionDescription = objvClientVersionENS.VersionDescription; //版本说明
objvClientVersionENT.VersionNumber = objvClientVersionENS.VersionNumber; //版本号
objvClientVersionENT.VersionState = objvClientVersionENS.VersionState; //版本状态
objvClientVersionENT.VersionUrl = objvClientVersionENS.VersionUrl; //版本文件
objvClientVersionENT.UpdDate = objvClientVersionENS.UpdDate; //修改日期
objvClientVersionENT.UpdUser = objvClientVersionENS.UpdUser; //修改人
objvClientVersionENT.Memo = objvClientVersionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvClientVersionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClientVersionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClientVersionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClientVersionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClientVersionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClientVersionEN.AttributeName)
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
if (clsClientVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClientVersionWApi没有刷新缓存机制(clsClientVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClientVersionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClientVersionTypeWApi没有刷新缓存机制(clsClientVersionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClientVersionId");
//if (arrvClientVersionObjLst_Cache == null)
//{
//arrvClientVersionObjLst_Cache = await clsvClientVersionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName_S);
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
public static List<clsvClientVersionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName_S);
List<clsvClientVersionEN> arrvClientVersionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClientVersionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClientVersionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClientVersion.ClientVersionId, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.ClientVersionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.ClientVersionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.VersionDescription, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.VersionNumber, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.VersionState, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClientVersion.VersionUrl, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convClientVersion.Memo, Type.GetType("System.String"));
foreach (clsvClientVersionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClientVersion.ClientVersionId] = objInFor[convClientVersion.ClientVersionId];
objDR[convClientVersion.ClientVersionTypeId] = objInFor[convClientVersion.ClientVersionTypeId];
objDR[convClientVersion.ClientVersionTypeName] = objInFor[convClientVersion.ClientVersionTypeName];
objDR[convClientVersion.VersionDescription] = objInFor[convClientVersion.VersionDescription];
objDR[convClientVersion.VersionNumber] = objInFor[convClientVersion.VersionNumber];
objDR[convClientVersion.VersionState] = objInFor[convClientVersion.VersionState];
objDR[convClientVersion.VersionUrl] = objInFor[convClientVersion.VersionUrl];
objDR[convClientVersion.UpdDate] = objInFor[convClientVersion.UpdDate];
objDR[convClientVersion.UpdUser] = objInFor[convClientVersion.UpdUser];
objDR[convClientVersion.Memo] = objInFor[convClientVersion.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}