
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubCaseTypeWApi
 表名:vPubCaseType(01120507)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:20
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvPubCaseTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN Setid_PubCaseType(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strid_PubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubCaseType, 4, convPubCaseType.id_PubCaseType);
clsCheckSql.CheckFieldForeignKey(strid_PubCaseType, 4, convPubCaseType.id_PubCaseType);
objvPubCaseTypeEN.id_PubCaseType = strid_PubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.id_PubCaseType) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.id_PubCaseType, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.id_PubCaseType] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN SetPubCaseTypeID(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubCaseType.PubCaseTypeID);
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubCaseType.PubCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubCaseType.PubCaseTypeID);
objvPubCaseTypeEN.PubCaseTypeID = strPubCaseTypeID; //公开课案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.PubCaseTypeID) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.PubCaseTypeID, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.PubCaseTypeID] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN SetPubCaseTypeName(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubCaseType.PubCaseTypeName);
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubCaseType.PubCaseTypeName);
objvPubCaseTypeEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.PubCaseTypeName) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.PubCaseTypeName, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.PubCaseTypeName] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN Setid_School(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convPubCaseType.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convPubCaseType.id_School);
objvPubCaseTypeEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.id_School) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.id_School, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.id_School] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN SetMemo(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubCaseType.Memo);
objvPubCaseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.Memo) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.Memo, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.Memo] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN SetSchoolId(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convPubCaseType.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convPubCaseType.SchoolId);
objvPubCaseTypeEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.SchoolId) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.SchoolId, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.SchoolId] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubCaseTypeEN SetSchoolName(this clsvPubCaseTypeEN objvPubCaseTypeEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convPubCaseType.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convPubCaseType.SchoolName);
objvPubCaseTypeEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubCaseTypeEN.dicFldComparisonOp.ContainsKey(convPubCaseType.SchoolName) == false)
{
objvPubCaseTypeEN.dicFldComparisonOp.Add(convPubCaseType.SchoolName, strComparisonOp);
}
else
{
objvPubCaseTypeEN.dicFldComparisonOp[convPubCaseType.SchoolName] = strComparisonOp;
}
}
return objvPubCaseTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubCaseTypeEN objvPubCaseType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.id_PubCaseType) == true)
{
string strComparisonOp_id_PubCaseType = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.id_PubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.id_PubCaseType, objvPubCaseType_Cond.id_PubCaseType, strComparisonOp_id_PubCaseType);
}
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.PubCaseTypeID) == true)
{
string strComparisonOp_PubCaseTypeID = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.PubCaseTypeID, objvPubCaseType_Cond.PubCaseTypeID, strComparisonOp_PubCaseTypeID);
}
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.PubCaseTypeName, objvPubCaseType_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.id_School) == true)
{
string strComparisonOp_id_School = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.id_School, objvPubCaseType_Cond.id_School, strComparisonOp_id_School);
}
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.Memo) == true)
{
string strComparisonOp_Memo = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.Memo, objvPubCaseType_Cond.Memo, strComparisonOp_Memo);
}
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.SchoolId, objvPubCaseType_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvPubCaseType_Cond.IsUpdated(convPubCaseType.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvPubCaseType_Cond.dicFldComparisonOp[convPubCaseType.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubCaseType.SchoolName, objvPubCaseType_Cond.SchoolName, strComparisonOp_SchoolName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课案例类型(vPubCaseType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubCaseTypeWApi
{
private static readonly string mstrApiControllerName = "vPubCaseTypeApi";

 public clsvPubCaseTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_PubCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubCaseTypeEN GetObjByid_PubCaseType(string strid_PubCaseType)
{
string strAction = "GetObjByid_PubCaseType";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubCaseTypeEN objvPubCaseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubCaseType"] = strid_PubCaseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubCaseTypeEN = JsonConvert.DeserializeObject<clsvPubCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvPubCaseTypeEN;
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
 /// <param name = "strid_PubCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubCaseTypeEN GetObjByid_PubCaseType_WA_Cache(string strid_PubCaseType)
{
string strAction = "GetObjByid_PubCaseType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubCaseTypeEN objvPubCaseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubCaseType"] = strid_PubCaseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubCaseTypeEN = JsonConvert.DeserializeObject<clsvPubCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvPubCaseTypeEN;
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
public static clsvPubCaseTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubCaseTypeEN objvPubCaseTypeEN = null;
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
objvPubCaseTypeEN = JsonConvert.DeserializeObject<clsvPubCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvPubCaseTypeEN;
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
 /// <param name = "strid_PubCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubCaseTypeEN GetObjByid_PubCaseType_Cache(string strid_PubCaseType)
{
if (string.IsNullOrEmpty(strid_PubCaseType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubCaseTypeEN._CurrTabName_S);
List<clsvPubCaseTypeEN> arrvPubCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubCaseTypeEN> arrvPubCaseTypeObjLst_Sel =
from objvPubCaseTypeEN in arrvPubCaseTypeObjLst_Cache
where objvPubCaseTypeEN.id_PubCaseType == strid_PubCaseType
select objvPubCaseTypeEN;
if (arrvPubCaseTypeObjLst_Sel.Count() == 0)
{
   clsvPubCaseTypeEN obj = clsvPubCaseTypeWApi.GetObjByid_PubCaseType(strid_PubCaseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubCaseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubCaseTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubCaseTypeEN> GetObjLstById_PubCaseTypeLst(List<string> arrId_PubCaseType)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubCaseTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubCaseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_PubCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubCaseTypeEN> GetObjLstById_PubCaseTypeLst_Cache(List<string> arrId_PubCaseType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubCaseTypeEN._CurrTabName_S);
List<clsvPubCaseTypeEN> arrvPubCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubCaseTypeEN> arrvPubCaseTypeObjLst_Sel =
from objvPubCaseTypeEN in arrvPubCaseTypeObjLst_Cache
where arrId_PubCaseType.Contains(objvPubCaseTypeEN.id_PubCaseType)
select objvPubCaseTypeEN;
return arrvPubCaseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubCaseTypeEN> GetObjLstById_PubCaseTypeLst_WA_Cache(List<string> arrId_PubCaseType)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubCaseTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubCaseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubCaseTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubCaseTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubCaseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubCaseTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_PubCaseType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubCaseType"] = strid_PubCaseType
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
 /// <param name = "objvPubCaseTypeENS">源对象</param>
 /// <param name = "objvPubCaseTypeENT">目标对象</param>
 public static void CopyTo(clsvPubCaseTypeEN objvPubCaseTypeENS, clsvPubCaseTypeEN objvPubCaseTypeENT)
{
try
{
objvPubCaseTypeENT.id_PubCaseType = objvPubCaseTypeENS.id_PubCaseType; //公开课案例类型流水号
objvPubCaseTypeENT.PubCaseTypeID = objvPubCaseTypeENS.PubCaseTypeID; //公开课案例类型ID
objvPubCaseTypeENT.PubCaseTypeName = objvPubCaseTypeENS.PubCaseTypeName; //公开课案例类型名称
objvPubCaseTypeENT.id_School = objvPubCaseTypeENS.id_School; //学校流水号
objvPubCaseTypeENT.Memo = objvPubCaseTypeENS.Memo; //备注
objvPubCaseTypeENT.SchoolId = objvPubCaseTypeENS.SchoolId; //学校编号
objvPubCaseTypeENT.SchoolName = objvPubCaseTypeENS.SchoolName; //学校名称
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
public static DataTable ToDataTable(List<clsvPubCaseTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubCaseTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubCaseTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubCaseTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubCaseTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubCaseTypeEN.AttributeName)
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
if (clsXzSchoolWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolWApi没有刷新缓存机制(clsXzSchoolWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeWApi没有刷新缓存机制(clsPubCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubCaseType");
//if (arrvPubCaseTypeObjLst_Cache == null)
//{
//arrvPubCaseTypeObjLst_Cache = await clsvPubCaseTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubCaseTypeEN._CurrTabName_S);
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
public static List<clsvPubCaseTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubCaseTypeEN._CurrTabName_S);
List<clsvPubCaseTypeEN> arrvPubCaseTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubCaseTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubCaseTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubCaseType.id_PubCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convPubCaseType.PubCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubCaseType.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubCaseType.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convPubCaseType.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPubCaseType.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convPubCaseType.SchoolName, Type.GetType("System.String"));
foreach (clsvPubCaseTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubCaseType.id_PubCaseType] = objInFor[convPubCaseType.id_PubCaseType];
objDR[convPubCaseType.PubCaseTypeID] = objInFor[convPubCaseType.PubCaseTypeID];
objDR[convPubCaseType.PubCaseTypeName] = objInFor[convPubCaseType.PubCaseTypeName];
objDR[convPubCaseType.id_School] = objInFor[convPubCaseType.id_School];
objDR[convPubCaseType.Memo] = objInFor[convPubCaseType.Memo];
objDR[convPubCaseType.SchoolId] = objInFor[convPubCaseType.SchoolId];
objDR[convPubCaseType.SchoolName] = objInFor[convPubCaseType.SchoolName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}