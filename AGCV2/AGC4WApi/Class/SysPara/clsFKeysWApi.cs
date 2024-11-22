﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFKeysWApi
 表名:FKeys(00050237)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:31:09
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using AGC.Entity;

namespace AGC4WApi
{
public static class clsFKeysWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetId(this clsFKeysEN objFKeysEN, long lngId, string strComparisonOp="")
	{
objFKeysEN.Id = lngId; //对象Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.Id) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.Id, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.Id] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyName(this clsFKeysEN objFKeysEN, string strFKeyName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyName, conFKeys.FKeyName);
clsCheckSql.CheckFieldLen(strFKeyName, 128, conFKeys.FKeyName);
objFKeysEN.FKeyName = strFKeyName; //外键名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyColumnID(this clsFKeysEN objFKeysEN, string strFKeyColumnID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyColumnID, conFKeys.FKeyColumnID);
clsCheckSql.CheckFieldLen(strFKeyColumnID, 128, conFKeys.FKeyColumnID);
objFKeysEN.FKeyColumnID = strFKeyColumnID; //外键列Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyColumnID) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyColumnID, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyColumnID] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyColumnName(this clsFKeysEN objFKeysEN, string strFKeyColumnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyColumnName, conFKeys.FKeyColumnName);
clsCheckSql.CheckFieldLen(strFKeyColumnName, 128, conFKeys.FKeyColumnName);
objFKeysEN.FKeyColumnName = strFKeyColumnName; //外键列名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyColumnName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyColumnName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyColumnName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyTabID(this clsFKeysEN objFKeysEN, string strFKeyTabID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFKeyTabID, 128, conFKeys.FKeyTabID);
objFKeysEN.FKeyTabID = strFKeyTabID; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyTabID) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyTabID, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyTabID] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyTabName(this clsFKeysEN objFKeysEN, string strFKeyTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyTabName, conFKeys.FKeyTabName);
clsCheckSql.CheckFieldLen(strFKeyTabName, 128, conFKeys.FKeyTabName);
objFKeysEN.FKeyTabName = strFKeyTabName; //外键表名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyTabName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyTabName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyTabName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyColumnID(this clsFKeysEN objFKeysEN, string strPKeyColumnID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyColumnID, conFKeys.PKeyColumnID);
clsCheckSql.CheckFieldLen(strPKeyColumnID, 128, conFKeys.PKeyColumnID);
objFKeysEN.PKeyColumnID = strPKeyColumnID; //主键列ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyColumnID) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyColumnID, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyColumnID] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyColumnName(this clsFKeysEN objFKeysEN, string strPKeyColumnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyColumnName, conFKeys.PKeyColumnName);
clsCheckSql.CheckFieldLen(strPKeyColumnName, 128, conFKeys.PKeyColumnName);
objFKeysEN.PKeyColumnName = strPKeyColumnName; //主键列名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyColumnName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyColumnName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyColumnName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyTabId(this clsFKeysEN objFKeysEN, string strPKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyTabId, conFKeys.PKeyTabId);
clsCheckSql.CheckFieldLen(strPKeyTabId, 128, conFKeys.PKeyTabId);
objFKeysEN.PKeyTabId = strPKeyTabId; //主键表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyTabId) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyTabId, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyTabId] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyTabName(this clsFKeysEN objFKeysEN, string strPKeyTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyTabName, conFKeys.PKeyTabName);
clsCheckSql.CheckFieldLen(strPKeyTabName, 128, conFKeys.PKeyTabName);
objFKeysEN.PKeyTabName = strPKeyTabName; //主键表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyTabName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyTabName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyTabName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetUpdate_Action(this clsFKeysEN objFKeysEN, string strUpdate_Action, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdate_Action, conFKeys.Update_Action);
clsCheckSql.CheckFieldLen(strUpdate_Action, 128, conFKeys.Update_Action);
objFKeysEN.Update_Action = strUpdate_Action; //级联更新
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.Update_Action) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.Update_Action, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.Update_Action] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetDelete_Action(this clsFKeysEN objFKeysEN, int intDelete_Action, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intDelete_Action, conFKeys.Delete_Action);
objFKeysEN.Delete_Action = intDelete_Action; //级联删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.Delete_Action) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.Delete_Action, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.Delete_Action] = strComparisonOp;
}
}
return objFKeysEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFKeysEN objFKeys_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFKeys_Cond.IsUpdated(conFKeys.Id) == true)
{
string strComparisonOp_Id = objFKeys_Cond.dicFldComparisonOp[conFKeys.Id];
strWhereCond += string.Format(" And {0} {2} {1}", conFKeys.Id, objFKeys_Cond.Id, strComparisonOp_Id);
}
if (objFKeys_Cond.IsUpdated(conFKeys.FKeyName) == true)
{
string strComparisonOp_FKeyName = objFKeys_Cond.dicFldComparisonOp[conFKeys.FKeyName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyName, objFKeys_Cond.FKeyName, strComparisonOp_FKeyName);
}
if (objFKeys_Cond.IsUpdated(conFKeys.FKeyColumnID) == true)
{
string strComparisonOp_FKeyColumnID = objFKeys_Cond.dicFldComparisonOp[conFKeys.FKeyColumnID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyColumnID, objFKeys_Cond.FKeyColumnID, strComparisonOp_FKeyColumnID);
}
if (objFKeys_Cond.IsUpdated(conFKeys.FKeyColumnName) == true)
{
string strComparisonOp_FKeyColumnName = objFKeys_Cond.dicFldComparisonOp[conFKeys.FKeyColumnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyColumnName, objFKeys_Cond.FKeyColumnName, strComparisonOp_FKeyColumnName);
}
if (objFKeys_Cond.IsUpdated(conFKeys.FKeyTabID) == true)
{
string strComparisonOp_FKeyTabID = objFKeys_Cond.dicFldComparisonOp[conFKeys.FKeyTabID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyTabID, objFKeys_Cond.FKeyTabID, strComparisonOp_FKeyTabID);
}
if (objFKeys_Cond.IsUpdated(conFKeys.FKeyTabName) == true)
{
string strComparisonOp_FKeyTabName = objFKeys_Cond.dicFldComparisonOp[conFKeys.FKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyTabName, objFKeys_Cond.FKeyTabName, strComparisonOp_FKeyTabName);
}
if (objFKeys_Cond.IsUpdated(conFKeys.PKeyColumnID) == true)
{
string strComparisonOp_PKeyColumnID = objFKeys_Cond.dicFldComparisonOp[conFKeys.PKeyColumnID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyColumnID, objFKeys_Cond.PKeyColumnID, strComparisonOp_PKeyColumnID);
}
if (objFKeys_Cond.IsUpdated(conFKeys.PKeyColumnName) == true)
{
string strComparisonOp_PKeyColumnName = objFKeys_Cond.dicFldComparisonOp[conFKeys.PKeyColumnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyColumnName, objFKeys_Cond.PKeyColumnName, strComparisonOp_PKeyColumnName);
}
if (objFKeys_Cond.IsUpdated(conFKeys.PKeyTabId) == true)
{
string strComparisonOp_PKeyTabId = objFKeys_Cond.dicFldComparisonOp[conFKeys.PKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyTabId, objFKeys_Cond.PKeyTabId, strComparisonOp_PKeyTabId);
}
if (objFKeys_Cond.IsUpdated(conFKeys.PKeyTabName) == true)
{
string strComparisonOp_PKeyTabName = objFKeys_Cond.dicFldComparisonOp[conFKeys.PKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyTabName, objFKeys_Cond.PKeyTabName, strComparisonOp_PKeyTabName);
}
if (objFKeys_Cond.IsUpdated(conFKeys.Update_Action) == true)
{
string strComparisonOp_Update_Action = objFKeys_Cond.dicFldComparisonOp[conFKeys.Update_Action];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.Update_Action, objFKeys_Cond.Update_Action, strComparisonOp_Update_Action);
}
if (objFKeys_Cond.IsUpdated(conFKeys.Delete_Action) == true)
{
string strComparisonOp_Delete_Action = objFKeys_Cond.dicFldComparisonOp[conFKeys.Delete_Action];
strWhereCond += string.Format(" And {0} {2} {1}", conFKeys.Delete_Action, objFKeys_Cond.Delete_Action, strComparisonOp_Delete_Action);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFKeysEN objFKeysEN)
{
 if (objFKeysEN.Id == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFKeysEN.sfUpdFldSetStr = objFKeysEN.getsfUpdFldSetStr();
clsFKeysWApi.CheckPropertyNew(objFKeysEN); 
bool bolResult = clsFKeysWApi.UpdateRecord(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FKeys(表外键), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFKeysEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PKeyTabId_PKeyColumnID(this clsFKeysEN objFKeysEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFKeysEN == null) return "";
if (objFKeysEN.Id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id !=  {0}", objFKeysEN.Id);
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFKeysEN objFKeysEN)
{
try
{
clsFKeysWApi.CheckPropertyNew(objFKeysEN); 
bool bolResult = clsFKeysWApi.AddNewRecord(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFKeysEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFKeysEN objFKeysEN, string strWhereCond)
{
try
{
clsFKeysWApi.CheckPropertyNew(objFKeysEN); 
bool bolResult = clsFKeysWApi.UpdateWithCondition(objFKeysEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 表外键(FKeys)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFKeysWApi
{
private static readonly string mstrApiControllerName = "FKeysApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFKeysWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFKeysEN objFKeysEN)
{
if (!Object.Equals(null, objFKeysEN.FKeyName) && GetStrLen(objFKeysEN.FKeyName) > 128)
{
 throw new Exception("字段[外键名称]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.FKeyColumnID) && GetStrLen(objFKeysEN.FKeyColumnID) > 128)
{
 throw new Exception("字段[外键列Id]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.FKeyColumnName) && GetStrLen(objFKeysEN.FKeyColumnName) > 128)
{
 throw new Exception("字段[外键列名]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.FKeyTabID) && GetStrLen(objFKeysEN.FKeyTabID) > 128)
{
 throw new Exception("字段[外键表ID]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.FKeyTabName) && GetStrLen(objFKeysEN.FKeyTabName) > 128)
{
 throw new Exception("字段[外键表名称]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.PKeyColumnID) && GetStrLen(objFKeysEN.PKeyColumnID) > 128)
{
 throw new Exception("字段[主键列ID]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.PKeyColumnName) && GetStrLen(objFKeysEN.PKeyColumnName) > 128)
{
 throw new Exception("字段[主键列名]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.PKeyTabId) && GetStrLen(objFKeysEN.PKeyTabId) > 128)
{
 throw new Exception("字段[主键表Id]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.PKeyTabName) && GetStrLen(objFKeysEN.PKeyTabName) > 128)
{
 throw new Exception("字段[主键表名]的长度不能超过128!");
}
if (!Object.Equals(null, objFKeysEN.Update_Action) && GetStrLen(objFKeysEN.Update_Action) > 128)
{
 throw new Exception("字段[级联更新]的长度不能超过128!");
}
 objFKeysEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFKeysEN GetObjById(long lngId)
{
string strAction = "GetObjById";
string strErrMsg = string.Empty;
string strResult = "";
clsFKeysEN objFKeysEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id"] = lngId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFKeysEN = JsonConvert.DeserializeObject<clsFKeysEN>((string)jobjReturn["returnObj"]);
return objFKeysEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "lngId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFKeysEN GetObjById_WA_Cache(long lngId)
{
string strAction = "GetObjById_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFKeysEN objFKeysEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id"] = lngId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFKeysEN = JsonConvert.DeserializeObject<clsFKeysEN>((string)jobjReturn["returnObj"]);
return objFKeysEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsFKeysEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFKeysEN objFKeysEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFKeysEN = JsonConvert.DeserializeObject<clsFKeysEN>((string)jobjReturn["returnObj"]);
return objFKeysEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "lngId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFKeysEN GetObjById_Cache(long lngId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
List<clsFKeysEN> arrFKeysObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFKeysEN> arrFKeysObjLst_Sel =
from objFKeysEN in arrFKeysObjLst_Cache
where objFKeysEN.Id == lngId
select objFKeysEN;
if (arrFKeysObjLst_Sel.Count() == 0)
{
   clsFKeysEN obj = clsFKeysWApi.GetObjById(lngId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFKeysObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLst(string strWhereCond)
{
 List<clsFKeysEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFKeysEN> GetObjLstByIdLst(List<long> arrId)
{
 List<clsFKeysEN> arrObjLst = null; 
string strAction = "GetObjLstByIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "lngId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFKeysEN> GetObjLstByIdLst_Cache(List<long> arrId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
List<clsFKeysEN> arrFKeysObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFKeysEN> arrFKeysObjLst_Sel =
from objFKeysEN in arrFKeysObjLst_Cache
where arrId.Contains(objFKeysEN.Id)
select objFKeysEN;
return arrFKeysObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLstByIdLst_WA_Cache(List<long> arrId)
{
 List<clsFKeysEN> arrObjLst = null; 
string strAction = "GetObjLstByIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFKeysEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFKeysEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFKeysEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFKeysEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFKeysEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFKeysEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFKeysEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFKeysEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFKeysEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFKeysEN objFKeysEN = clsFKeysWApi.GetObjById(lngId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsFKeysWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFKeyss(List<string> arrId)
{
string strAction = "DelFKeyss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsFKeysWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFKeyssByCond(string strWhereCond)
{
string strAction = "DelFKeyssByCond";
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
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsFKeysEN objFKeysEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFKeysEN>(objFKeysEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFKeysEN objFKeysEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFKeysEN>(objFKeysEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsFKeysEN objFKeysEN)
{
if (string.IsNullOrEmpty(objFKeysEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFKeysEN.Id, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFKeysEN>(objFKeysEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFKeysEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFKeysEN objFKeysEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFKeysEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFKeysEN.Id, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFKeysEN.Id, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFKeysEN>(objFKeysEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool IsExist(long lngId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id"] = lngId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objFKeysENS">源对象</param>
 /// <param name = "objFKeysENT">目标对象</param>
 public static void CopyTo(clsFKeysEN objFKeysENS, clsFKeysEN objFKeysENT)
{
try
{
objFKeysENT.Id = objFKeysENS.Id; //对象Id
objFKeysENT.FKeyName = objFKeysENS.FKeyName; //外键名称
objFKeysENT.FKeyColumnID = objFKeysENS.FKeyColumnID; //外键列Id
objFKeysENT.FKeyColumnName = objFKeysENS.FKeyColumnName; //外键列名
objFKeysENT.FKeyTabID = objFKeysENS.FKeyTabID; //外键表ID
objFKeysENT.FKeyTabName = objFKeysENS.FKeyTabName; //外键表名称
objFKeysENT.PKeyColumnID = objFKeysENS.PKeyColumnID; //主键列ID
objFKeysENT.PKeyColumnName = objFKeysENS.PKeyColumnName; //主键列名
objFKeysENT.PKeyTabId = objFKeysENS.PKeyTabId; //主键表Id
objFKeysENT.PKeyTabName = objFKeysENS.PKeyTabName; //主键表名
objFKeysENT.Update_Action = objFKeysENS.Update_Action; //级联更新
objFKeysENT.Delete_Action = objFKeysENS.Delete_Action; //级联删除
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
public static DataTable ToDataTable(List<clsFKeysEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFKeysEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFKeysEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFKeysEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFKeysEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFKeysEN.AttributeName)
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
if (clsFKeysWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsFKeysWApi没有刷新缓存机制(clsFKeysWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id");
//if (arrFKeysObjLst_Cache == null)
//{
//arrFKeysObjLst_Cache = await clsFKeysWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFKeysWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFKeysWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFKeysEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
List<clsFKeysEN> arrFKeysObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFKeysObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFKeysEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFKeys.Id, Type.GetType("System.Int64"));
objDT.Columns.Add(conFKeys.FKeyName, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.FKeyColumnID, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.FKeyColumnName, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.FKeyTabID, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.FKeyTabName, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.PKeyColumnID, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.PKeyColumnName, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.PKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.PKeyTabName, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.Update_Action, Type.GetType("System.String"));
objDT.Columns.Add(conFKeys.Delete_Action, Type.GetType("System.Int32"));
foreach (clsFKeysEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFKeys.Id] = objInFor[conFKeys.Id];
objDR[conFKeys.FKeyName] = objInFor[conFKeys.FKeyName];
objDR[conFKeys.FKeyColumnID] = objInFor[conFKeys.FKeyColumnID];
objDR[conFKeys.FKeyColumnName] = objInFor[conFKeys.FKeyColumnName];
objDR[conFKeys.FKeyTabID] = objInFor[conFKeys.FKeyTabID];
objDR[conFKeys.FKeyTabName] = objInFor[conFKeys.FKeyTabName];
objDR[conFKeys.PKeyColumnID] = objInFor[conFKeys.PKeyColumnID];
objDR[conFKeys.PKeyColumnName] = objInFor[conFKeys.PKeyColumnName];
objDR[conFKeys.PKeyTabId] = objInFor[conFKeys.PKeyTabId];
objDR[conFKeys.PKeyTabName] = objInFor[conFKeys.PKeyTabName];
objDR[conFKeys.Update_Action] = objInFor[conFKeys.Update_Action];
objDR[conFKeys.Delete_Action] = objInFor[conFKeys.Delete_Action];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 表外键(FKeys)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FKeys : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysWApi.ReFreshThisCache();
}
}

}