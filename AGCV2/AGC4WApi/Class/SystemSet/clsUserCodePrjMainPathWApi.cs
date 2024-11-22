﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPathWApi
 表名:UserCodePrjMainPath(00050338)
 * 版本:2024.09.08.1(服务器:WIN-SRV103-116)
 日期:2024/09/08 10:33:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
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
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsUserCodePrjMainPathWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUserCodePrjMainPathId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUserCodePrjMainPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckFieldForeignKey(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
objUserCodePrjMainPathEN.UserCodePrjMainPathId = strUserCodePrjMainPathId; //生成主目录Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UserCodePrjMainPathId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UserCodePrjMainPathId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UserCodePrjMainPathId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetCMProjectAppRelaId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCMProjectAppRelaId, conUserCodePrjMainPath.CMProjectAppRelaId);
objUserCodePrjMainPathEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.CMProjectAppRelaId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.CMProjectAppRelaId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.CMProjectAppRelaId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetPrjId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserCodePrjMainPath.PrjId);
objUserCodePrjMainPathEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.PrjId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.PrjId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.PrjId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetProgLangTypeId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
objUserCodePrjMainPathEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.ProgLangTypeId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.ProgLangTypeId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.ProgLangTypeId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUserId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conUserCodePrjMainPath.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conUserCodePrjMainPath.UserId);
objUserCodePrjMainPathEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UserId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UserId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UserId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUsePrjMainPath">是否使用主路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetIsUsePrjMainPath(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsUsePrjMainPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUsePrjMainPath, conUserCodePrjMainPath.IsUsePrjMainPath);
objUserCodePrjMainPathEN.IsUsePrjMainPath = bolIsUsePrjMainPath; //是否使用主路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.IsUsePrjMainPath) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.IsUsePrjMainPath, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.IsUsePrjMainPath] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strIncludeXmlPath">包含表Xml路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetIncludeXmlPath(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strIncludeXmlPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIncludeXmlPath, 150, conUserCodePrjMainPath.IncludeXmlPath);
objUserCodePrjMainPathEN.IncludeXmlPath = strIncludeXmlPath; //包含表Xml路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.IncludeXmlPath) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.IncludeXmlPath, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.IncludeXmlPath] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetIsTemplate(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conUserCodePrjMainPath.IsTemplate);
objUserCodePrjMainPathEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.IsTemplate) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.IsTemplate, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.IsTemplate] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetInUse(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, conUserCodePrjMainPath.InUse);
objUserCodePrjMainPathEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.InUse) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.InUse, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.InUse] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUpdDate(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserCodePrjMainPath.UpdDate);
objUserCodePrjMainPathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UpdDate) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UpdDate, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UpdDate] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUpdUserId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserCodePrjMainPath.UpdUserId);
objUserCodePrjMainPathEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UpdUserId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UpdUserId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UpdUserId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetMemo(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserCodePrjMainPath.Memo);
objUserCodePrjMainPathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.Memo) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.Memo, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.Memo] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserCodePrjMainPathEN objUserCodePrjMainPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UserCodePrjMainPathId) == true)
{
string strComparisonOpUserCodePrjMainPathId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UserCodePrjMainPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UserCodePrjMainPathId, objUserCodePrjMainPathCond.UserCodePrjMainPathId, strComparisonOpUserCodePrjMainPathId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserCodePrjMainPath.CMProjectAppRelaId, objUserCodePrjMainPathCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.PrjId) == true)
{
string strComparisonOpPrjId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.PrjId, objUserCodePrjMainPathCond.PrjId, strComparisonOpPrjId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.ProgLangTypeId, objUserCodePrjMainPathCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UserId) == true)
{
string strComparisonOpUserId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UserId, objUserCodePrjMainPathCond.UserId, strComparisonOpUserId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath) == true)
{
if (objUserCodePrjMainPathCond.IsUsePrjMainPath == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePrjMainPath.IsUsePrjMainPath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePrjMainPath.IsUsePrjMainPath);
}
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath) == true)
{
string strComparisonOpIncludeXmlPath = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.IncludeXmlPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.IncludeXmlPath, objUserCodePrjMainPathCond.IncludeXmlPath, strComparisonOpIncludeXmlPath);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.IsTemplate) == true)
{
if (objUserCodePrjMainPathCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePrjMainPath.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePrjMainPath.IsTemplate);
}
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.InUse) == true)
{
if (objUserCodePrjMainPathCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePrjMainPath.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePrjMainPath.InUse);
}
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UpdDate, objUserCodePrjMainPathCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UpdUserId, objUserCodePrjMainPathCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.Memo) == true)
{
string strComparisonOpMemo = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.Memo, objUserCodePrjMainPathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUserCodePrjMainPathEN.sfUpdFldSetStr = objUserCodePrjMainPathEN.getsfUpdFldSetStr();
clsUserCodePrjMainPathWApi.CheckPropertyNew(objUserCodePrjMainPathEN); 
bool bolResult = clsUserCodePrjMainPathWApi.UpdateRecord(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
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
 /// 获取唯一性条件串--UserCodePrjMainPath(用户生成项目主路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMProjectAppRelaId_PrjId_UserId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePrjMainPathEN == null) return "";
if (objUserCodePrjMainPathEN.UserCodePrjMainPathId == null || objUserCodePrjMainPathEN.UserCodePrjMainPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("UserCodePrjMainPathId !=  '{0}'", objUserCodePrjMainPathEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
try
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathWApi.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathWApi.GetMaxStrId();
 }
clsUserCodePrjMainPathWApi.CheckPropertyNew(objUserCodePrjMainPathEN); 
bool bolResult = clsUserCodePrjMainPathWApi.AddNewRecord(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
try
{
clsUserCodePrjMainPathWApi.CheckPropertyNew(objUserCodePrjMainPathEN); 
string strUserCodePrjMainPathId = clsUserCodePrjMainPathWApi.AddNewRecordWithMaxId(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
return strUserCodePrjMainPathId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strWhereCond)
{
try
{
clsUserCodePrjMainPathWApi.CheckPropertyNew(objUserCodePrjMainPathEN); 
bool bolResult = clsUserCodePrjMainPathWApi.UpdateWithCondition(objUserCodePrjMainPathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
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
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUserCodePrjMainPathWApi
{
private static readonly string mstrApiControllerName = "UserCodePrjMainPathApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsUserCodePrjMainPathWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
if (!Object.Equals(null, objUserCodePrjMainPathEN.UserCodePrjMainPathId) && GetStrLen(objUserCodePrjMainPathEN.UserCodePrjMainPathId) > 8)
{
 throw new Exception("字段[生成主目录Id]的长度不能超过8!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.PrjId) && GetStrLen(objUserCodePrjMainPathEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.ProgLangTypeId) && GetStrLen(objUserCodePrjMainPathEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.UserId) && GetStrLen(objUserCodePrjMainPathEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.IncludeXmlPath) && GetStrLen(objUserCodePrjMainPathEN.IncludeXmlPath) > 150)
{
 throw new Exception("字段[包含表Xml路径]的长度不能超过150!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.UpdDate) && GetStrLen(objUserCodePrjMainPathEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.UpdUserId) && GetStrLen(objUserCodePrjMainPathEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objUserCodePrjMainPathEN.Memo) && GetStrLen(objUserCodePrjMainPathEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objUserCodePrjMainPathEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePrjMainPathEN GetObjByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
{
string strAction = "GetObjByUserCodePrjMainPathId";
clsUserCodePrjMainPathEN objUserCodePrjMainPathEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objUserCodePrjMainPathEN = JsonConvert.DeserializeObject<clsUserCodePrjMainPathEN>(strJson);
return objUserCodePrjMainPathEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static clsUserCodePrjMainPathEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsUserCodePrjMainPathEN objUserCodePrjMainPathEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objUserCodePrjMainPathEN = JsonConvert.DeserializeObject<clsUserCodePrjMainPathEN>(strJson);
return objUserCodePrjMainPathEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePrjMainPathEN GetObjByUserCodePrjMainPathIdCache(string strUserCodePrjMainPathId,string strPrjId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Sel =
from objUserCodePrjMainPathEN in arrUserCodePrjMainPathObjLstCache
where objUserCodePrjMainPathEN.UserCodePrjMainPathId == strUserCodePrjMainPathId 
select objUserCodePrjMainPathEN;
if (arrUserCodePrjMainPathObjLst_Sel.Count() == 0)
{
   clsUserCodePrjMainPathEN obj = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUserCodePrjMainPathObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLst(string strWhereCond)
{
 List<clsUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPathEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "arrUserCodePrjMainPathId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLst(List<string> arrUserCodePrjMainPathId)
{
 List<clsUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetObjLstByUserCodePrjMainPathIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserCodePrjMainPathId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPathEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserCodePrjMainPathId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLstCache(List<string> arrUserCodePrjMainPathId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Sel =
from objUserCodePrjMainPathEN in arrUserCodePrjMainPathObjLstCache
where arrUserCodePrjMainPathId.Contains(objUserCodePrjMainPathEN.UserCodePrjMainPathId)
select objUserCodePrjMainPathEN;
return arrUserCodePrjMainPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPathEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsUserCodePrjMainPathEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPathEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsUserCodePrjMainPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPathEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPathEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelRecord(string strUserCodePrjMainPathId)
{
string strAction = "DelRecord";
try
{
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserCodePrjMainPathId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelUserCodePrjMainPaths(List<string> arrUserCodePrjMainPathId)
{
string strAction = "DelUserCodePrjMainPaths";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserCodePrjMainPathId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(arrUserCodePrjMainPathId[0]);
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelUserCodePrjMainPathsByCond(string strWhereCond)
{
string strAction = "DelUserCodePrjMainPathsByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool AddNewRecord(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPathEN>(objUserCodePrjMainPathEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPathEN>(objUserCodePrjMainPathEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathWApi.ReFreshCache(objUserCodePrjMainPathEN.PrjId);
var strUserCodePrjMainPathId = (string)jobjReturn0["returnStr"];
return strUserCodePrjMainPathId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool UpdateRecord(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPathEN>(objUserCodePrjMainPathEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPathEN>(objUserCodePrjMainPathEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool IsExist(string strUserCodePrjMainPathId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objUserCodePrjMainPathENT">目标对象</param>
 public static void CopyTo(clsUserCodePrjMainPathEN objUserCodePrjMainPathENS, clsUserCodePrjMainPathEN objUserCodePrjMainPathENT)
{
try
{
objUserCodePrjMainPathENT.UserCodePrjMainPathId = objUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPathENT.CMProjectAppRelaId = objUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePrjMainPathENT.PrjId = objUserCodePrjMainPathENS.PrjId; //工程ID
objUserCodePrjMainPathENT.ProgLangTypeId = objUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objUserCodePrjMainPathENT.UserId = objUserCodePrjMainPathENS.UserId; //用户Id
objUserCodePrjMainPathENT.IsUsePrjMainPath = objUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objUserCodePrjMainPathENT.IncludeXmlPath = objUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPathENT.IsTemplate = objUserCodePrjMainPathENS.IsTemplate; //是否模板
objUserCodePrjMainPathENT.InUse = objUserCodePrjMainPathENS.InUse; //是否在用
objUserCodePrjMainPathENT.UpdDate = objUserCodePrjMainPathENS.UpdDate; //修改日期
objUserCodePrjMainPathENT.UpdUserId = objUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objUserCodePrjMainPathENT.Memo = objUserCodePrjMainPathENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsUserCodePrjMainPathEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUserCodePrjMainPathEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUserCodePrjMainPathEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUserCodePrjMainPathEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUserCodePrjMainPathEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUserCodePrjMainPathEN.AttributeName)
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
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsUserCodePrjMainPathWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePrjMainPathWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstCache(string strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsUserCodePrjMainPathEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsUserCodePrjMainPathEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conUserCodePrjMainPath.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrUserCodePrjMainPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsUserCodePrjMainPathEN> arrObjLst_P)
{
var strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrUserCodePrjMainPathObjLstCache = CacheHelper.Get<List<clsUserCodePrjMainPathEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrUserCodePrjMainPathObjLstCache = CacheHelper.Get<List<clsUserCodePrjMainPathEN>>(strKey);
}
return arrUserCodePrjMainPathObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUserCodePrjMainPathEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUserCodePrjMainPath.UserCodePrjMainPathId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.CMProjectAppRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(conUserCodePrjMainPath.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.IsUsePrjMainPath, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserCodePrjMainPath.IncludeXmlPath, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserCodePrjMainPath.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserCodePrjMainPath.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath.Memo, Type.GetType("System.String"));
foreach (clsUserCodePrjMainPathEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUserCodePrjMainPath.UserCodePrjMainPathId] = objInFor[conUserCodePrjMainPath.UserCodePrjMainPathId];
objDR[conUserCodePrjMainPath.CMProjectAppRelaId] = objInFor[conUserCodePrjMainPath.CMProjectAppRelaId];
objDR[conUserCodePrjMainPath.PrjId] = objInFor[conUserCodePrjMainPath.PrjId];
objDR[conUserCodePrjMainPath.ProgLangTypeId] = objInFor[conUserCodePrjMainPath.ProgLangTypeId];
objDR[conUserCodePrjMainPath.UserId] = objInFor[conUserCodePrjMainPath.UserId];
objDR[conUserCodePrjMainPath.IsUsePrjMainPath] = objInFor[conUserCodePrjMainPath.IsUsePrjMainPath];
objDR[conUserCodePrjMainPath.IncludeXmlPath] = objInFor[conUserCodePrjMainPath.IncludeXmlPath];
objDR[conUserCodePrjMainPath.IsTemplate] = objInFor[conUserCodePrjMainPath.IsTemplate];
objDR[conUserCodePrjMainPath.InUse] = objInFor[conUserCodePrjMainPath.InUse];
objDR[conUserCodePrjMainPath.UpdDate] = objInFor[conUserCodePrjMainPath.UpdDate];
objDR[conUserCodePrjMainPath.UpdUserId] = objInFor[conUserCodePrjMainPath.UpdUserId];
objDR[conUserCodePrjMainPath.Memo] = objInFor[conUserCodePrjMainPath.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4UserCodePrjMainPath : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
{
string strMsg;
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
clsUserCodePrjMainPathWApi.ReFreshThisCache(strPrjId);
}
}

}