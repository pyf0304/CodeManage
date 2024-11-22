﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimBL
 表名:vPrjTab_Sim(00050597)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:47:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvPrjTab_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab_SimEN GetObj(this K_TabId_vPrjTab_Sim myKey)
{
clsvPrjTab_SimEN objvPrjTab_SimEN = clsvPrjTab_SimBL.vPrjTab_SimDA.GetObjByTabId(myKey.Value);
return objvPrjTab_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab_Sim.TabId);
}
objvPrjTab_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabName(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab_Sim.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab_Sim.TabName);
}
objvPrjTab_SimEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabName) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabName, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabName] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetSqlDsTypeId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convPrjTab_Sim.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab_Sim.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab_Sim.SqlDsTypeId);
}
objvPrjTab_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.SqlDsTypeId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetFuncModuleAgcId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convPrjTab_Sim.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab_Sim.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab_Sim.FuncModuleAgcId);
}
objvPrjTab_SimEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.FuncModuleAgcId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabTypeId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab_Sim.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab_Sim.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab_Sim.TabTypeId);
}
objvPrjTab_SimEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabTypeId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetCacheModeId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strCacheModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convPrjTab_Sim.CacheModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convPrjTab_Sim.CacheModeId);
}
objvPrjTab_SimEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.CacheModeId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.CacheModeId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.CacheModeId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabStateId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab_Sim.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab_Sim.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab_Sim.TabStateId);
}
objvPrjTab_SimEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabStateId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabStateId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabStateId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetPrjId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab_Sim.PrjId);
}
objvPrjTab_SimEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.PrjId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.PrjId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.PrjId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetDataBaseName(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convPrjTab_Sim.DataBaseName);
}
objvPrjTab_SimEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.DataBaseName) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.DataBaseName, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.DataBaseName] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetUpdDate(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab_Sim.UpdDate);
}
objvPrjTab_SimEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.UpdDate) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.UpdDate, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.UpdDate] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetFldNum(this clsvPrjTab_SimEN objvPrjTab_SimEN, int? intFldNum, string strComparisonOp="")
	{
objvPrjTab_SimEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.FldNum) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.FldNum, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.FldNum] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetIsShare(this clsvPrjTab_SimEN objvPrjTab_SimEN, bool bolIsShare, string strComparisonOp="")
	{
objvPrjTab_SimEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.IsShare) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.IsShare, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.IsShare] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTab_SimENS">源对象</param>
 /// <param name = "objvPrjTab_SimENT">目标对象</param>
 public static void CopyTo(this clsvPrjTab_SimEN objvPrjTab_SimENS, clsvPrjTab_SimEN objvPrjTab_SimENT)
{
try
{
objvPrjTab_SimENT.TabId = objvPrjTab_SimENS.TabId; //表ID
objvPrjTab_SimENT.TabName = objvPrjTab_SimENS.TabName; //表名
objvPrjTab_SimENT.SqlDsTypeId = objvPrjTab_SimENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimENT.FuncModuleAgcId = objvPrjTab_SimENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimENT.TabTypeId = objvPrjTab_SimENS.TabTypeId; //表类型Id
objvPrjTab_SimENT.CacheModeId = objvPrjTab_SimENS.CacheModeId; //缓存方式Id
objvPrjTab_SimENT.TabStateId = objvPrjTab_SimENS.TabStateId; //表状态ID
objvPrjTab_SimENT.PrjId = objvPrjTab_SimENS.PrjId; //工程ID
objvPrjTab_SimENT.DataBaseName = objvPrjTab_SimENS.DataBaseName; //数据库名
objvPrjTab_SimENT.UpdDate = objvPrjTab_SimENS.UpdDate; //修改日期
objvPrjTab_SimENT.FldNum = objvPrjTab_SimENS.FldNum; //字段数
objvPrjTab_SimENT.IsShare = objvPrjTab_SimENS.IsShare; //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvPrjTab_SimENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTab_SimEN:objvPrjTab_SimENT</returns>
 public static clsvPrjTab_SimEN CopyTo(this clsvPrjTab_SimEN objvPrjTab_SimENS)
{
try
{
 clsvPrjTab_SimEN objvPrjTab_SimENT = new clsvPrjTab_SimEN()
{
TabId = objvPrjTab_SimENS.TabId, //表ID
TabName = objvPrjTab_SimENS.TabName, //表名
SqlDsTypeId = objvPrjTab_SimENS.SqlDsTypeId, //数据源类型Id
FuncModuleAgcId = objvPrjTab_SimENS.FuncModuleAgcId, //功能模块Id
TabTypeId = objvPrjTab_SimENS.TabTypeId, //表类型Id
CacheModeId = objvPrjTab_SimENS.CacheModeId, //缓存方式Id
TabStateId = objvPrjTab_SimENS.TabStateId, //表状态ID
PrjId = objvPrjTab_SimENS.PrjId, //工程ID
DataBaseName = objvPrjTab_SimENS.DataBaseName, //数据库名
UpdDate = objvPrjTab_SimENS.UpdDate, //修改日期
FldNum = objvPrjTab_SimENS.FldNum, //字段数
IsShare = objvPrjTab_SimENS.IsShare, //是否共享
};
 return objvPrjTab_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvPrjTab_SimEN objvPrjTab_SimEN)
{
 clsvPrjTab_SimBL.vPrjTab_SimDA.CheckProperty4Condition(objvPrjTab_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab_SimEN objvPrjTab_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabId, objvPrjTab_SimCond.TabId, strComparisonOpTabId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabName, objvPrjTab_SimCond.TabName, strComparisonOpTabName);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.SqlDsTypeId, objvPrjTab_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.FuncModuleAgcId, objvPrjTab_SimCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabTypeId, objvPrjTab_SimCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.CacheModeId, objvPrjTab_SimCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabStateId, objvPrjTab_SimCond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.PrjId, objvPrjTab_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.DataBaseName, objvPrjTab_SimCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.UpdDate, objvPrjTab_SimCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.FldNum) == true)
{
string strComparisonOpFldNum = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab_Sim.FldNum, objvPrjTab_SimCond.FldNum, strComparisonOpFldNum);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.IsShare) == true)
{
if (objvPrjTab_SimCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab_Sim.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab_Sim.IsShare);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTab_Sim
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程表_Sim(vPrjTab_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab_SimBL
{
public static RelatedActions_vPrjTab_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTab_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTab_SimDA vPrjTab_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTab_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTab_SimBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvPrjTab_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab_SimEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vPrjTab_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable_vPrjTab_Sim(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTab_SimEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strCmPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel =
arrvPrjTab_SimObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTab_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}
//该表检查条件格式串出错, 不能生成[GetSubObjLstCache]。当前表:[vPrjTab_Sim]有后台缓存分类字段：[CmPrjId],属于扩展类字段,但后台条件格式为空,不正确!

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvPrjTab_SimEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程ID
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTab_Sim(ref clsvPrjTab_SimEN objvPrjTab_SimEN)
{
bool bolResult = vPrjTab_SimDA.GetvPrjTab_Sim(ref objvPrjTab_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab_SimEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjTab_SimEN objvPrjTab_SimEN = vPrjTab_SimDA.GetObjByTabId(strTabId);
return objvPrjTab_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTab_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTab_SimEN objvPrjTab_SimEN = vPrjTab_SimDA.GetFirstObj(strWhereCond);
 return objvPrjTab_SimEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvPrjTab_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTab_SimEN objvPrjTab_SimEN = vPrjTab_SimDA.GetObjByDataRow(objRow);
 return objvPrjTab_SimEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvPrjTab_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTab_SimEN objvPrjTab_SimEN = vPrjTab_SimDA.GetObjByDataRow(objRow);
 return objvPrjTab_SimEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstvPrjTab_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab_SimEN GetObjByTabIdFromList(string strTabId, List<clsvPrjTab_SimEN> lstvPrjTab_SimObjLst)
{
foreach (clsvPrjTab_SimEN objvPrjTab_SimEN in lstvPrjTab_SimObjLst)
{
if (objvPrjTab_SimEN.TabId == strTabId)
{
return objvPrjTab_SimEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabId;
 try
 {
 strTabId = new clsvPrjTab_SimDA().GetFirstID(strWhereCond);
 return strTabId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vPrjTab_SimDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vPrjTab_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjTab_SimDA.IsExist(strTabId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvPrjTab_SimDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vPrjTab_SimDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTab_SimENS">源对象</param>
 /// <param name = "objvPrjTab_SimENT">目标对象</param>
 public static void CopyTo(clsvPrjTab_SimEN objvPrjTab_SimENS, clsvPrjTab_SimEN objvPrjTab_SimENT)
{
try
{
objvPrjTab_SimENT.TabId = objvPrjTab_SimENS.TabId; //表ID
objvPrjTab_SimENT.TabName = objvPrjTab_SimENS.TabName; //表名
objvPrjTab_SimENT.SqlDsTypeId = objvPrjTab_SimENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimENT.FuncModuleAgcId = objvPrjTab_SimENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimENT.TabTypeId = objvPrjTab_SimENS.TabTypeId; //表类型Id
objvPrjTab_SimENT.CacheModeId = objvPrjTab_SimENS.CacheModeId; //缓存方式Id
objvPrjTab_SimENT.TabStateId = objvPrjTab_SimENS.TabStateId; //表状态ID
objvPrjTab_SimENT.PrjId = objvPrjTab_SimENS.PrjId; //工程ID
objvPrjTab_SimENT.DataBaseName = objvPrjTab_SimENS.DataBaseName; //数据库名
objvPrjTab_SimENT.UpdDate = objvPrjTab_SimENS.UpdDate; //修改日期
objvPrjTab_SimENT.FldNum = objvPrjTab_SimENS.FldNum; //字段数
objvPrjTab_SimENT.IsShare = objvPrjTab_SimENS.IsShare; //是否共享
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTab_SimEN objvPrjTab_SimEN)
{
try
{
objvPrjTab_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTab_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTab_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.TabId = objvPrjTab_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTab_Sim.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.TabName = objvPrjTab_SimEN.TabName; //表名
}
if (arrFldSet.Contains(convPrjTab_Sim.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.SqlDsTypeId = objvPrjTab_SimEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convPrjTab_Sim.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.FuncModuleAgcId = objvPrjTab_SimEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convPrjTab_Sim.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.TabTypeId = objvPrjTab_SimEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convPrjTab_Sim.CacheModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.CacheModeId = objvPrjTab_SimEN.CacheModeId == "[null]" ? null :  objvPrjTab_SimEN.CacheModeId; //缓存方式Id
}
if (arrFldSet.Contains(convPrjTab_Sim.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.TabStateId = objvPrjTab_SimEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convPrjTab_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.PrjId = objvPrjTab_SimEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convPrjTab_Sim.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.DataBaseName = objvPrjTab_SimEN.DataBaseName == "[null]" ? null :  objvPrjTab_SimEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convPrjTab_Sim.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.UpdDate = objvPrjTab_SimEN.UpdDate == "[null]" ? null :  objvPrjTab_SimEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjTab_Sim.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.FldNum = objvPrjTab_SimEN.FldNum; //字段数
}
if (arrFldSet.Contains(convPrjTab_Sim.IsShare, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimEN.IsShare = objvPrjTab_SimEN.IsShare; //是否共享
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTab_SimEN objvPrjTab_SimEN)
{
try
{
if (objvPrjTab_SimEN.CacheModeId == "[null]") objvPrjTab_SimEN.CacheModeId = null; //缓存方式Id
if (objvPrjTab_SimEN.DataBaseName == "[null]") objvPrjTab_SimEN.DataBaseName = null; //数据库名
if (objvPrjTab_SimEN.UpdDate == "[null]") objvPrjTab_SimEN.UpdDate = null; //修改日期
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvPrjTab_SimEN objvPrjTab_SimEN)
{
 vPrjTab_SimDA.CheckProperty4Condition(objvPrjTab_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab_Sim.TabId); 
List<clsvPrjTab_SimEN> arrObjLst = clsvPrjTab_SimBL.GetObjLst(strCondition).OrderBy(x=>x.TabName).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN()
{
TabId = "0",
TabName = "选[v工程表_Sim]..."
};
arrObjLst.Insert(0, objvPrjTab_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjTab_Sim.TabId;
objComboBox.DisplayMember = convPrjTab_Sim.TabName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL , string strCmPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程表_Sim]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab_Sim.TabId); 
IEnumerable<clsvPrjTab_SimEN> arrObjLst = clsvPrjTab_SimBL.GetObjLst(strCondition).OrderBy(x=>x.TabName);
objDDL.DataValueField = convPrjTab_Sim.TabId;
objDDL.DataTextField = convPrjTab_Sim.TabName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCmPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程表_Sim]...","0");
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLst = GetAllvPrjTab_SimObjLstCache(strCmPrjId); 
objDDL.DataValueField = convPrjTab_Sim.TabId;
objDDL.DataTextField = convPrjTab_Sim.TabName;
objDDL.DataSource = arrvPrjTab_SimObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTab_SimObjLstCache == null)
//{
//arrvPrjTab_SimObjLstCache = vPrjTab_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab_SimEN GetObjByTabIdCache(string strTabId, string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel =
arrvPrjTab_SimObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTab_SimObjLst_Sel.Count() == 0)
{
   clsvPrjTab_SimEN obj = clsvPrjTab_SimBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
 }
return null;
}
return arrvPrjTab_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId, string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab_SimEN objvPrjTab_Sim = GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTab_Sim == null) return "";
return objvPrjTab_Sim.TabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId, string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab_SimEN objvPrjTab_Sim = GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTab_Sim == null) return "";
return objvPrjTab_Sim.TabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab_SimEN> GetAllvPrjTab_SimObjLstCache(string strCmPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strCmPrjId); 
return arrvPrjTab_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstCache(string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strCmPrjId);
string strCondition = string.Format("CmPrjId='{0}'", strCmPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTab_SimObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsvPrjTab_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvPrjTab_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTab_SimEN._RefreshTimeLst[clsvPrjTab_SimEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strCmPrjId)
{
if (strInFldName != convPrjTab_Sim.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTab_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTab_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvPrjTab_Sim = clsvPrjTab_SimBL.GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTab_Sim == null) return "";
return objvPrjTab_Sim[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvPrjTab_SimDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvPrjTab_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTab_SimDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvPrjTab_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}

//该表检查条件格式串出错, 不能生成[GetRecCountByCondCache]。当前表:[vPrjTab_Sim]有后台缓存分类字段：[CmPrjId],属于扩展类字段,但后台条件格式为空,不正确!

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvPrjTab_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vPrjTab_SimDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vPrjTab_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}