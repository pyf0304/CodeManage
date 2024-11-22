
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachSkillWApi
 表名:vTeachSkill(01120314)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:00
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsvTeachSkillWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN Setid_TeachSkill(this clsvTeachSkillEN objvTeachSkillEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convTeachSkill.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convTeachSkill.id_TeachSkill);
objvTeachSkillEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.id_TeachSkill) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.id_TeachSkill, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.id_TeachSkill] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillID(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convTeachSkill.TeachSkillID);
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachSkill.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachSkill.TeachSkillID);
objvTeachSkillEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillID) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillID, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillID] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetSkillTypeName(this clsvTeachSkillEN objvTeachSkillEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convTeachSkill.SkillTypeName);
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachSkill.SkillTypeName);
objvTeachSkillEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.SkillTypeName) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.SkillTypeName, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.SkillTypeName] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillName(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convTeachSkill.TeachSkillName);
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachSkill.TeachSkillName);
objvTeachSkillEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillName) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillName, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillName] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillTheory(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachSkill.TeachSkillTheory);
objvTeachSkillEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillTheory) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillOperMethod(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachSkill.TeachSkillOperMethod);
objvTeachSkillEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillOperMethod) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN Setid_SkillType(this clsvTeachSkillEN objvTeachSkillEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SkillType, convTeachSkill.id_SkillType);
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convTeachSkill.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convTeachSkill.id_SkillType);
objvTeachSkillEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.id_SkillType) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.id_SkillType, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.id_SkillType] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetMemo(this clsvTeachSkillEN objvTeachSkillEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachSkill.Memo);
objvTeachSkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.Memo) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.Memo, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.Memo] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachSkillEN SetSkillTypeID(this clsvTeachSkillEN objvTeachSkillEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeID, convTeachSkill.SkillTypeID);
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachSkill.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachSkill.SkillTypeID);
objvTeachSkillEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.SkillTypeID) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.SkillTypeID, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.SkillTypeID] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachSkillEN objvTeachSkill_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.id_TeachSkill, objvTeachSkill_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillID, objvTeachSkill_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.SkillTypeName, objvTeachSkill_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillName, objvTeachSkill_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillTheory, objvTeachSkill_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillOperMethod, objvTeachSkill_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.id_SkillType, objvTeachSkill_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.Memo) == true)
{
string strComparisonOp_Memo = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.Memo, objvTeachSkill_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachSkill_Cond.IsUpdated(convTeachSkill.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvTeachSkill_Cond.dicFldComparisonOp[convTeachSkill.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.SkillTypeID, objvTeachSkill_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 教学技能视图(vTeachSkill)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachSkillWApi
{
private static readonly string mstrApiControllerName = "vTeachSkillApi";

 public clsvTeachSkillWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_TeachSkill">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachSkillEN GetObjByid_TeachSkill(string strid_TeachSkill)
{
string strAction = "GetObjByid_TeachSkill";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachSkillEN objvTeachSkillEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachSkill"] = strid_TeachSkill
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachSkillEN = JsonConvert.DeserializeObject<clsvTeachSkillEN>((string)jobjReturn["ReturnObj"]);
return objvTeachSkillEN;
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
 /// <param name = "strid_TeachSkill">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachSkillEN GetObjByid_TeachSkill_WA_Cache(string strid_TeachSkill)
{
string strAction = "GetObjByid_TeachSkill_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachSkillEN objvTeachSkillEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachSkill"] = strid_TeachSkill
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachSkillEN = JsonConvert.DeserializeObject<clsvTeachSkillEN>((string)jobjReturn["ReturnObj"]);
return objvTeachSkillEN;
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
public static clsvTeachSkillEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachSkillEN objvTeachSkillEN = null;
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
objvTeachSkillEN = JsonConvert.DeserializeObject<clsvTeachSkillEN>((string)jobjReturn["ReturnObj"]);
return objvTeachSkillEN;
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
 /// <param name = "strid_TeachSkill">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachSkillEN GetObjByid_TeachSkill_Cache(string strid_TeachSkill)
{
if (string.IsNullOrEmpty(strid_TeachSkill) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName_S);
List<clsvTeachSkillEN> arrvTeachSkillObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachSkillEN> arrvTeachSkillObjLst_Sel =
from objvTeachSkillEN in arrvTeachSkillObjLst_Cache
where objvTeachSkillEN.id_TeachSkill == strid_TeachSkill
select objvTeachSkillEN;
if (arrvTeachSkillObjLst_Sel.Count() == 0)
{
   clsvTeachSkillEN obj = clsvTeachSkillWApi.GetObjByid_TeachSkill(strid_TeachSkill);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachSkillObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachSkillEN> GetObjLstById_TeachSkillLst(List<string> arrId_TeachSkill)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachSkillLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachSkill);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_TeachSkill">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachSkillEN> GetObjLstById_TeachSkillLst_Cache(List<string> arrId_TeachSkill)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName_S);
List<clsvTeachSkillEN> arrvTeachSkillObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachSkillEN> arrvTeachSkillObjLst_Sel =
from objvTeachSkillEN in arrvTeachSkillObjLst_Cache
where arrId_TeachSkill.Contains(objvTeachSkillEN.id_TeachSkill)
select objvTeachSkillEN;
return arrvTeachSkillObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLstById_TeachSkillLst_WA_Cache(List<string> arrId_TeachSkill)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachSkillLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachSkill);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachSkillEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachSkillEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachSkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachSkillEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachSkillEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachSkillEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_TeachSkill)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachSkill"] = strid_TeachSkill
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
 /// <param name = "objvTeachSkillENS">源对象</param>
 /// <param name = "objvTeachSkillENT">目标对象</param>
 public static void CopyTo(clsvTeachSkillEN objvTeachSkillENS, clsvTeachSkillEN objvTeachSkillENT)
{
try
{
objvTeachSkillENT.id_TeachSkill = objvTeachSkillENS.id_TeachSkill; //教学技能流水号
objvTeachSkillENT.TeachSkillID = objvTeachSkillENS.TeachSkillID; //教学技能ID
objvTeachSkillENT.SkillTypeName = objvTeachSkillENS.SkillTypeName; //技能类型名称
objvTeachSkillENT.TeachSkillName = objvTeachSkillENS.TeachSkillName; //教学技能名称
objvTeachSkillENT.TeachSkillTheory = objvTeachSkillENS.TeachSkillTheory; //教学技能理论阐述
objvTeachSkillENT.TeachSkillOperMethod = objvTeachSkillENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachSkillENT.id_SkillType = objvTeachSkillENS.id_SkillType; //技能类型流水号
objvTeachSkillENT.Memo = objvTeachSkillENS.Memo; //备注
objvTeachSkillENT.SkillTypeID = objvTeachSkillENS.SkillTypeID; //技能类型ID
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
public static DataTable ToDataTable(List<clsvTeachSkillEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachSkillEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachSkillEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachSkillEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachSkillEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachSkillEN.AttributeName)
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
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_TeachSkill");
//if (arrvTeachSkillObjLst_Cache == null)
//{
//arrvTeachSkillObjLst_Cache = await clsvTeachSkillWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName_S);
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
public static List<clsvTeachSkillEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName_S);
List<clsvTeachSkillEN> arrvTeachSkillObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachSkillObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachSkillEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachSkill.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachSkill.SkillTypeID, Type.GetType("System.String"));
foreach (clsvTeachSkillEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachSkill.id_TeachSkill] = objInFor[convTeachSkill.id_TeachSkill];
objDR[convTeachSkill.TeachSkillID] = objInFor[convTeachSkill.TeachSkillID];
objDR[convTeachSkill.SkillTypeName] = objInFor[convTeachSkill.SkillTypeName];
objDR[convTeachSkill.TeachSkillName] = objInFor[convTeachSkill.TeachSkillName];
objDR[convTeachSkill.TeachSkillTheory] = objInFor[convTeachSkill.TeachSkillTheory];
objDR[convTeachSkill.TeachSkillOperMethod] = objInFor[convTeachSkill.TeachSkillOperMethod];
objDR[convTeachSkill.id_SkillType] = objInFor[convTeachSkill.id_SkillType];
objDR[convTeachSkill.Memo] = objInFor[convTeachSkill.Memo];
objDR[convTeachSkill.SkillTypeID] = objInFor[convTeachSkill.SkillTypeID];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}