
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPlatDefaRoleWApi
 表名:vPlatDefaRole(01120232)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:52
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
public static class clsvPlatDefaRoleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetmId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, long lngmId, string strComparisonOp="")
	{
objvPlatDefaRoleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.mId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.mId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.mId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN Setid_School(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convPlatDefaRole.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convPlatDefaRole.id_School);
objvPlatDefaRoleEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.id_School) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.id_School, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.id_School] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetSchoolId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convPlatDefaRole.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convPlatDefaRole.SchoolId);
objvPlatDefaRoleEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.SchoolId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.SchoolId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.SchoolId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetIsCurrentUse(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
objvPlatDefaRoleEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.IsCurrentUse) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.IsCurrentUse, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.IsCurrentUse] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetSchoolName(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convPlatDefaRole.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convPlatDefaRole.SchoolName);
objvPlatDefaRoleEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.SchoolName) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.SchoolName, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.SchoolName] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetPersonType(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strPersonType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPersonType, convPlatDefaRole.PersonType);
clsCheckSql.CheckFieldLen(strPersonType, 30, convPlatDefaRole.PersonType);
objvPlatDefaRoleEN.PersonType = strPersonType; //人员类别
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.PersonType) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.PersonType, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.PersonType] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetPrjId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPlatDefaRole.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPlatDefaRole.PrjId);
objvPlatDefaRoleEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.PrjId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.PrjId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.PrjId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetRoleId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convPlatDefaRole.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, convPlatDefaRole.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convPlatDefaRole.RoleId);
objvPlatDefaRoleEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.RoleId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.RoleId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.RoleId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPlatDefaRoleEN SetMemo(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPlatDefaRole.Memo);
objvPlatDefaRoleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.Memo) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.Memo, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.Memo] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPlatDefaRoleEN objvPlatDefaRole_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.mId) == true)
{
string strComparisonOp_mId = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPlatDefaRole.mId, objvPlatDefaRole_Cond.mId, strComparisonOp_mId);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.id_School) == true)
{
string strComparisonOp_id_School = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.id_School, objvPlatDefaRole_Cond.id_School, strComparisonOp_id_School);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.SchoolId, objvPlatDefaRole_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.IsCurrentUse) == true)
{
if (objvPlatDefaRole_Cond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPlatDefaRole.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPlatDefaRole.IsCurrentUse);
}
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.SchoolName, objvPlatDefaRole_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.PersonType) == true)
{
string strComparisonOp_PersonType = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.PersonType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.PersonType, objvPlatDefaRole_Cond.PersonType, strComparisonOp_PersonType);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.PrjId) == true)
{
string strComparisonOp_PrjId = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.PrjId, objvPlatDefaRole_Cond.PrjId, strComparisonOp_PrjId);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.RoleId) == true)
{
string strComparisonOp_RoleId = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.RoleId, objvPlatDefaRole_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvPlatDefaRole_Cond.IsUpdated(convPlatDefaRole.Memo) == true)
{
string strComparisonOp_Memo = objvPlatDefaRole_Cond.dicFldComparisonOp[convPlatDefaRole.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.Memo, objvPlatDefaRole_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v平台默认角色(vPlatDefaRole)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPlatDefaRoleWApi
{
private static readonly string mstrApiControllerName = "vPlatDefaRoleApi";

 public clsvPlatDefaRoleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPlatDefaRoleEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPlatDefaRoleEN objvPlatDefaRoleEN = null;
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
objvPlatDefaRoleEN = JsonConvert.DeserializeObject<clsvPlatDefaRoleEN>((string)jobjReturn["ReturnObj"]);
return objvPlatDefaRoleEN;
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
public static clsvPlatDefaRoleEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPlatDefaRoleEN objvPlatDefaRoleEN = null;
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
objvPlatDefaRoleEN = JsonConvert.DeserializeObject<clsvPlatDefaRoleEN>((string)jobjReturn["ReturnObj"]);
return objvPlatDefaRoleEN;
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
public static clsvPlatDefaRoleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPlatDefaRoleEN objvPlatDefaRoleEN = null;
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
objvPlatDefaRoleEN = JsonConvert.DeserializeObject<clsvPlatDefaRoleEN>((string)jobjReturn["ReturnObj"]);
return objvPlatDefaRoleEN;
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
public static clsvPlatDefaRoleEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName_S);
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Sel =
from objvPlatDefaRoleEN in arrvPlatDefaRoleObjLst_Cache
where objvPlatDefaRoleEN.mId == lngmId
select objvPlatDefaRoleEN;
if (arrvPlatDefaRoleObjLst_Sel.Count() == 0)
{
   clsvPlatDefaRoleEN obj = clsvPlatDefaRoleWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPlatDefaRoleObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetObjLst(string strWhereCond)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvPlatDefaRoleEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName_S);
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Sel =
from objvPlatDefaRoleEN in arrvPlatDefaRoleObjLst_Cache
where arrMId.Contains(objvPlatDefaRoleEN.mId)
select objvPlatDefaRoleEN;
return arrvPlatDefaRoleObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPlatDefaRoleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPlatDefaRoleEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPlatDefaRoleEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvPlatDefaRoleENS">源对象</param>
 /// <param name = "objvPlatDefaRoleENT">目标对象</param>
 public static void CopyTo(clsvPlatDefaRoleEN objvPlatDefaRoleENS, clsvPlatDefaRoleEN objvPlatDefaRoleENT)
{
try
{
objvPlatDefaRoleENT.mId = objvPlatDefaRoleENS.mId; //mId
objvPlatDefaRoleENT.id_School = objvPlatDefaRoleENS.id_School; //学校流水号
objvPlatDefaRoleENT.SchoolId = objvPlatDefaRoleENS.SchoolId; //学校编号
objvPlatDefaRoleENT.IsCurrentUse = objvPlatDefaRoleENS.IsCurrentUse; //是否当前使用
objvPlatDefaRoleENT.SchoolName = objvPlatDefaRoleENS.SchoolName; //学校名称
objvPlatDefaRoleENT.PersonType = objvPlatDefaRoleENS.PersonType; //人员类别
objvPlatDefaRoleENT.PrjId = objvPlatDefaRoleENS.PrjId; //PrjId
objvPlatDefaRoleENT.RoleId = objvPlatDefaRoleENS.RoleId; //角色Id
objvPlatDefaRoleENT.Memo = objvPlatDefaRoleENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvPlatDefaRoleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPlatDefaRoleEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPlatDefaRoleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPlatDefaRoleEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPlatDefaRoleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPlatDefaRoleEN.AttributeName)
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
if (clsPlatDefaRoleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPlatDefaRoleWApi没有刷新缓存机制(clsPlatDefaRoleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPlatDefaRoleObjLst_Cache == null)
//{
//arrvPlatDefaRoleObjLst_Cache = await clsvPlatDefaRoleWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName_S);
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
public static List<clsvPlatDefaRoleEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName_S);
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPlatDefaRoleObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPlatDefaRoleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPlatDefaRole.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPlatDefaRole.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convPlatDefaRole.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convPlatDefaRole.IsCurrentUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPlatDefaRole.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convPlatDefaRole.PersonType, Type.GetType("System.String"));
objDT.Columns.Add(convPlatDefaRole.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPlatDefaRole.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convPlatDefaRole.Memo, Type.GetType("System.String"));
foreach (clsvPlatDefaRoleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPlatDefaRole.mId] = objInFor[convPlatDefaRole.mId];
objDR[convPlatDefaRole.id_School] = objInFor[convPlatDefaRole.id_School];
objDR[convPlatDefaRole.SchoolId] = objInFor[convPlatDefaRole.SchoolId];
objDR[convPlatDefaRole.IsCurrentUse] = objInFor[convPlatDefaRole.IsCurrentUse];
objDR[convPlatDefaRole.SchoolName] = objInFor[convPlatDefaRole.SchoolName];
objDR[convPlatDefaRole.PersonType] = objInFor[convPlatDefaRole.PersonType];
objDR[convPlatDefaRole.PrjId] = objInFor[convPlatDefaRole.PrjId];
objDR[convPlatDefaRole.RoleId] = objInFor[convPlatDefaRole.RoleId];
objDR[convPlatDefaRole.Memo] = objInFor[convPlatDefaRole.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}