
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectPrjTabWApi
 表名:vCMProjectPrjTab(00050531)
 * 版本:2024.09.08.1(服务器:WIN-SRV103-116)
 日期:2024/09/08 10:36:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMProjectPrjTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetmId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, long lngmId, string strComparisonOp="")
	{
objvCMProjectPrjTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.mId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.mId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.mId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">CM工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetCmPrjId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMProjectPrjTab.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProjectPrjTab.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProjectPrjTab.CmPrjId);
objvCMProjectPrjTabEN.CmPrjId = strCmPrjId; //CM工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.CmPrjId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.CmPrjId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.CmPrjId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetCmPrjName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProjectPrjTab.CmPrjName);
objvCMProjectPrjTabEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.CmPrjName) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.CmPrjName, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.CmPrjName] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetPrjId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProjectPrjTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProjectPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProjectPrjTab.PrjId);
objvCMProjectPrjTabEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.PrjId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.PrjId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.PrjId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convCMProjectPrjTab.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convCMProjectPrjTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convCMProjectPrjTab.TabId);
objvCMProjectPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.TabId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.TabId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.TabId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convCMProjectPrjTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convCMProjectPrjTab.TabName);
objvCMProjectPrjTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.TabName) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.TabName, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.TabName] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetFuncModuleAgcId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMProjectPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMProjectPrjTab.FuncModuleAgcId);
objvCMProjectPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.FuncModuleAgcId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetFuncModuleName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMProjectPrjTab.FuncModuleName);
objvCMProjectPrjTabEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.FuncModuleName) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.FuncModuleName, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.FuncModuleName] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetOrderNum(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMProjectPrjTab.OrderNum);
objvCMProjectPrjTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.OrderNum) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.OrderNum, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.OrderNum] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetUpdDate(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProjectPrjTab.UpdDate);
objvCMProjectPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.UpdDate) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.UpdDate, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.UpdDate] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetUpdUser(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMProjectPrjTab.UpdUser);
objvCMProjectPrjTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.UpdUser) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.UpdUser, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.UpdUser] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetMemo(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProjectPrjTab.Memo);
objvCMProjectPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.Memo) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.Memo, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.Memo] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetSqlDsTypeId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCMProjectPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCMProjectPrjTab.SqlDsTypeId);
objvCMProjectPrjTabEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.SqlDsTypeId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.SqlDsTypeId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.SqlDsTypeId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetSqlDsTypeName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convCMProjectPrjTab.SqlDsTypeName);
objvCMProjectPrjTabEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.SqlDsTypeName) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.SqlDsTypeName, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.SqlDsTypeName] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabRecNum">记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabRecNum(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, int intTabRecNum, string strComparisonOp="")
	{
objvCMProjectPrjTabEN.TabRecNum = intTabRecNum; //记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.TabRecNum) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.TabRecNum, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.TabRecNum] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabTypeId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convCMProjectPrjTab.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convCMProjectPrjTab.TabTypeId);
objvCMProjectPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.TabTypeId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.TabTypeId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.TabTypeId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabStateId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convCMProjectPrjTab.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convCMProjectPrjTab.TabStateId);
objvCMProjectPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCMProjectPrjTab.TabStateId) == false)
{
objvCMProjectPrjTabEN.dicFldComparisonOp.Add(convCMProjectPrjTab.TabStateId, strComparisonOp);
}
else
{
objvCMProjectPrjTabEN.dicFldComparisonOp[convCMProjectPrjTab.TabStateId] = strComparisonOp;
}
}
return objvCMProjectPrjTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMProjectPrjTabEN objvCMProjectPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.mId) == true)
{
string strComparisonOpmId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectPrjTab.mId, objvCMProjectPrjTabCond.mId, strComparisonOpmId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.CmPrjId, objvCMProjectPrjTabCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.CmPrjName, objvCMProjectPrjTabCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.PrjId) == true)
{
string strComparisonOpPrjId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.PrjId, objvCMProjectPrjTabCond.PrjId, strComparisonOpPrjId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.TabId) == true)
{
string strComparisonOpTabId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.TabId, objvCMProjectPrjTabCond.TabId, strComparisonOpTabId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.TabName) == true)
{
string strComparisonOpTabName = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.TabName, objvCMProjectPrjTabCond.TabName, strComparisonOpTabName);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.FuncModuleAgcId, objvCMProjectPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.FuncModuleName, objvCMProjectPrjTabCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectPrjTab.OrderNum, objvCMProjectPrjTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.UpdDate, objvCMProjectPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.UpdUser, objvCMProjectPrjTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.Memo) == true)
{
string strComparisonOpMemo = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.Memo, objvCMProjectPrjTabCond.Memo, strComparisonOpMemo);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.SqlDsTypeId, objvCMProjectPrjTabCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.SqlDsTypeName, objvCMProjectPrjTabCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.TabRecNum) == true)
{
string strComparisonOpTabRecNum = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.TabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectPrjTab.TabRecNum, objvCMProjectPrjTabCond.TabRecNum, strComparisonOpTabRecNum);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.TabTypeId, objvCMProjectPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvCMProjectPrjTabCond.IsUpdated(convCMProjectPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objvCMProjectPrjTabCond.dicFldComparisonOp[convCMProjectPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectPrjTab.TabStateId, objvCMProjectPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCMProjectPrjTab(vCMProjectPrjTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectPrjTabWApi
{
private static readonly string mstrApiControllerName = "vCMProjectPrjTabApi";

 public clsvCMProjectPrjTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectPrjTabEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvCMProjectPrjTabEN objvCMProjectPrjTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMProjectPrjTabEN = JsonConvert.DeserializeObject<clsvCMProjectPrjTabEN>(strJson);
return objvCMProjectPrjTabEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvCMProjectPrjTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMProjectPrjTabEN objvCMProjectPrjTabEN;
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
objvCMProjectPrjTabEN = JsonConvert.DeserializeObject<clsvCMProjectPrjTabEN>(strJson);
return objvCMProjectPrjTabEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectPrjTabEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLst_Sel =
from objvCMProjectPrjTabEN in arrvCMProjectPrjTabObjLstCache
where objvCMProjectPrjTabEN.mId == lngmId 
select objvCMProjectPrjTabEN;
if (arrvCMProjectPrjTabObjLst_Sel.Count() == 0)
{
   clsvCMProjectPrjTabEN obj = clsvCMProjectPrjTabWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMProjectPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLst(string strWhereCond)
{
 List<clsvCMProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectPrjTabEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCMProjectPrjTabEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectPrjTabEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCMProjectPrjTabEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLst_Sel =
from objvCMProjectPrjTabEN in arrvCMProjectPrjTabObjLstCache
where arrMId.Contains(objvCMProjectPrjTabEN.mId)
select objvCMProjectPrjTabEN;
return arrvCMProjectPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectPrjTabEN>>(strJson);
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
public static List<clsvCMProjectPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectPrjTabEN>>(strJson);
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
public static List<clsvCMProjectPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectPrjTabEN>>(strJson);
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
public static List<clsvCMProjectPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectPrjTabEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabENS">源对象</param>
 /// <param name = "objvCMProjectPrjTabENT">目标对象</param>
 public static void CopyTo(clsvCMProjectPrjTabEN objvCMProjectPrjTabENS, clsvCMProjectPrjTabEN objvCMProjectPrjTabENT)
{
try
{
objvCMProjectPrjTabENT.mId = objvCMProjectPrjTabENS.mId; //mId
objvCMProjectPrjTabENT.CmPrjId = objvCMProjectPrjTabENS.CmPrjId; //CM工程Id
objvCMProjectPrjTabENT.CmPrjName = objvCMProjectPrjTabENS.CmPrjName; //CM工程名
objvCMProjectPrjTabENT.PrjId = objvCMProjectPrjTabENS.PrjId; //工程ID
objvCMProjectPrjTabENT.TabId = objvCMProjectPrjTabENS.TabId; //表ID
objvCMProjectPrjTabENT.TabName = objvCMProjectPrjTabENS.TabName; //表名
objvCMProjectPrjTabENT.FuncModuleAgcId = objvCMProjectPrjTabENS.FuncModuleAgcId; //功能模块Id
objvCMProjectPrjTabENT.FuncModuleName = objvCMProjectPrjTabENS.FuncModuleName; //功能模块名称
objvCMProjectPrjTabENT.OrderNum = objvCMProjectPrjTabENS.OrderNum; //序号
objvCMProjectPrjTabENT.UpdDate = objvCMProjectPrjTabENS.UpdDate; //修改日期
objvCMProjectPrjTabENT.UpdUser = objvCMProjectPrjTabENS.UpdUser; //修改者
objvCMProjectPrjTabENT.Memo = objvCMProjectPrjTabENS.Memo; //说明
objvCMProjectPrjTabENT.SqlDsTypeId = objvCMProjectPrjTabENS.SqlDsTypeId; //数据源类型Id
objvCMProjectPrjTabENT.SqlDsTypeName = objvCMProjectPrjTabENS.SqlDsTypeName; //Sql数据源名
objvCMProjectPrjTabENT.TabRecNum = objvCMProjectPrjTabENS.TabRecNum; //记录数
objvCMProjectPrjTabENT.TabTypeId = objvCMProjectPrjTabENS.TabTypeId; //表类型Id
objvCMProjectPrjTabENT.TabStateId = objvCMProjectPrjTabENS.TabStateId; //表状态ID
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
public static DataTable ToDataTable(List<clsvCMProjectPrjTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMProjectPrjTabEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMProjectPrjTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMProjectPrjTabEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMProjectPrjTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMProjectPrjTabEN.AttributeName)
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
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstCache(string strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCMProjectPrjTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCMProjectPrjTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCMProjectPrjTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCMProjectPrjTabEN> arrObjLst_P)
{
var strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCMProjectPrjTabObjLstCache = CacheHelper.Get<List<clsvCMProjectPrjTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCMProjectPrjTabObjLstCache = CacheHelper.Get<List<clsvCMProjectPrjTabEN>>(strKey);
}
return arrvCMProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMProjectPrjTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMProjectPrjTab.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMProjectPrjTab.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectPrjTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.TabRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectPrjTab.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectPrjTab.TabStateId, Type.GetType("System.String"));
foreach (clsvCMProjectPrjTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMProjectPrjTab.mId] = objInFor[convCMProjectPrjTab.mId];
objDR[convCMProjectPrjTab.CmPrjId] = objInFor[convCMProjectPrjTab.CmPrjId];
objDR[convCMProjectPrjTab.CmPrjName] = objInFor[convCMProjectPrjTab.CmPrjName];
objDR[convCMProjectPrjTab.PrjId] = objInFor[convCMProjectPrjTab.PrjId];
objDR[convCMProjectPrjTab.TabId] = objInFor[convCMProjectPrjTab.TabId];
objDR[convCMProjectPrjTab.TabName] = objInFor[convCMProjectPrjTab.TabName];
objDR[convCMProjectPrjTab.FuncModuleAgcId] = objInFor[convCMProjectPrjTab.FuncModuleAgcId];
objDR[convCMProjectPrjTab.FuncModuleName] = objInFor[convCMProjectPrjTab.FuncModuleName];
objDR[convCMProjectPrjTab.OrderNum] = objInFor[convCMProjectPrjTab.OrderNum];
objDR[convCMProjectPrjTab.UpdDate] = objInFor[convCMProjectPrjTab.UpdDate];
objDR[convCMProjectPrjTab.UpdUser] = objInFor[convCMProjectPrjTab.UpdUser];
objDR[convCMProjectPrjTab.Memo] = objInFor[convCMProjectPrjTab.Memo];
objDR[convCMProjectPrjTab.SqlDsTypeId] = objInFor[convCMProjectPrjTab.SqlDsTypeId];
objDR[convCMProjectPrjTab.SqlDsTypeName] = objInFor[convCMProjectPrjTab.SqlDsTypeName];
objDR[convCMProjectPrjTab.TabRecNum] = objInFor[convCMProjectPrjTab.TabRecNum];
objDR[convCMProjectPrjTab.TabTypeId] = objInFor[convCMProjectPrjTab.TabTypeId];
objDR[convCMProjectPrjTab.TabStateId] = objInFor[convCMProjectPrjTab.TabStateId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}