
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectPrjTabBL
 表名:vCMProjectPrjTab(00050531)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:53:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMProjectPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectPrjTabEN GetObj(this K_mId_vCMProjectPrjTab myKey)
{
clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = clsvCMProjectPrjTabBL.vCMProjectPrjTabDA.GetObjBymId(myKey.Value);
return objvCMProjectPrjTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetCmPrjId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMProjectPrjTab.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProjectPrjTab.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProjectPrjTab.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetCmPrjName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProjectPrjTab.CmPrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetPrjId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProjectPrjTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProjectPrjTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProjectPrjTab.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convCMProjectPrjTab.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convCMProjectPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convCMProjectPrjTab.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convCMProjectPrjTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convCMProjectPrjTab.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetFuncModuleAgcId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMProjectPrjTab.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMProjectPrjTab.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetFuncModuleName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMProjectPrjTab.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetUpdDate(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProjectPrjTab.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetUpdUser(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMProjectPrjTab.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetMemo(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProjectPrjTab.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetSqlDsTypeId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCMProjectPrjTab.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCMProjectPrjTab.SqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetSqlDsTypeName(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convCMProjectPrjTab.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabRecNum(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, int? intTabRecNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabTypeId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convCMProjectPrjTab.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convCMProjectPrjTab.TabTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectPrjTabEN SetTabStateId(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convCMProjectPrjTab.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convCMProjectPrjTab.TabStateId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabENS">源对象</param>
 /// <param name = "objvCMProjectPrjTabENT">目标对象</param>
 public static void CopyTo(this clsvCMProjectPrjTabEN objvCMProjectPrjTabENS, clsvCMProjectPrjTabEN objvCMProjectPrjTabENT)
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
 /// <param name = "objvCMProjectPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsvCMProjectPrjTabEN:objvCMProjectPrjTabENT</returns>
 public static clsvCMProjectPrjTabEN CopyTo(this clsvCMProjectPrjTabEN objvCMProjectPrjTabENS)
{
try
{
 clsvCMProjectPrjTabEN objvCMProjectPrjTabENT = new clsvCMProjectPrjTabEN()
{
mId = objvCMProjectPrjTabENS.mId, //mId
CmPrjId = objvCMProjectPrjTabENS.CmPrjId, //CM工程Id
CmPrjName = objvCMProjectPrjTabENS.CmPrjName, //CM工程名
PrjId = objvCMProjectPrjTabENS.PrjId, //工程ID
TabId = objvCMProjectPrjTabENS.TabId, //表ID
TabName = objvCMProjectPrjTabENS.TabName, //表名
FuncModuleAgcId = objvCMProjectPrjTabENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvCMProjectPrjTabENS.FuncModuleName, //功能模块名称
OrderNum = objvCMProjectPrjTabENS.OrderNum, //序号
UpdDate = objvCMProjectPrjTabENS.UpdDate, //修改日期
UpdUser = objvCMProjectPrjTabENS.UpdUser, //修改者
Memo = objvCMProjectPrjTabENS.Memo, //说明
SqlDsTypeId = objvCMProjectPrjTabENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvCMProjectPrjTabENS.SqlDsTypeName, //Sql数据源名
TabRecNum = objvCMProjectPrjTabENS.TabRecNum, //记录数
TabTypeId = objvCMProjectPrjTabENS.TabTypeId, //表类型Id
TabStateId = objvCMProjectPrjTabENS.TabStateId, //表状态ID
};
 return objvCMProjectPrjTabENT;
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
public static void CheckProperty4Condition(this clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
 clsvCMProjectPrjTabBL.vCMProjectPrjTabDA.CheckProperty4Condition(objvCMProjectPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMProjectPrjTab
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCMProjectPrjTab(vCMProjectPrjTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectPrjTabBL
{
public static RelatedActions_vCMProjectPrjTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMProjectPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMProjectPrjTabDA vCMProjectPrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMProjectPrjTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMProjectPrjTabBL()
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
if (string.IsNullOrEmpty(clsvCMProjectPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectPrjTabEN._ConnectString);
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
public static DataTable GetDataTable_vCMProjectPrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMProjectPrjTabDA.GetDataTable_vCMProjectPrjTab(strWhereCond);
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
objDT = vCMProjectPrjTabDA.GetDataTable(strWhereCond);
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
objDT = vCMProjectPrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMProjectPrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMProjectPrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMProjectPrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = vCMProjectPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMProjectPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMProjectPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMProjectPrjTabEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLst_Sel =
arrvCMProjectPrjTabObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMProjectPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
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
public static List<clsvCMProjectPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMProjectPrjTabEN> GetSubObjLstCache(clsvCMProjectPrjTabEN objvCMProjectPrjTabCond)
{
 string strPrjId = objvCMProjectPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMProjectPrjTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProjectPrjTab.AttributeName)
{
if (objvCMProjectPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectPrjTabCond[strFldName].ToString());
}
else
{
if (objvCMProjectPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectPrjTabCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
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
public static List<clsvCMProjectPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
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
List<clsvCMProjectPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMProjectPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMProjectPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
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
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
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
public static List<clsvCMProjectPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMProjectPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
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
public static List<clsvCMProjectPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMProjectPrjTab(ref clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
bool bolResult = vCMProjectPrjTabDA.GetvCMProjectPrjTab(ref objvCMProjectPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectPrjTabEN GetObjBymId(long lngmId)
{
clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = vCMProjectPrjTabDA.GetObjBymId(lngmId);
return objvCMProjectPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMProjectPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = vCMProjectPrjTabDA.GetFirstObj(strWhereCond);
 return objvCMProjectPrjTabEN;
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
public static clsvCMProjectPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = vCMProjectPrjTabDA.GetObjByDataRow(objRow);
 return objvCMProjectPrjTabEN;
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
public static clsvCMProjectPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = vCMProjectPrjTabDA.GetObjByDataRow(objRow);
 return objvCMProjectPrjTabEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvCMProjectPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectPrjTabEN GetObjBymIdFromList(long lngmId, List<clsvCMProjectPrjTabEN> lstvCMProjectPrjTabObjLst)
{
foreach (clsvCMProjectPrjTabEN objvCMProjectPrjTabEN in lstvCMProjectPrjTabObjLst)
{
if (objvCMProjectPrjTabEN.mId == lngmId)
{
return objvCMProjectPrjTabEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvCMProjectPrjTabDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vCMProjectPrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = vCMProjectPrjTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vCMProjectPrjTabDA.IsExist(lngmId);
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
 bolIsExist = clsvCMProjectPrjTabDA.IsExistTable();
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
 bolIsExist = vCMProjectPrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMProjectPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
try
{
objvCMProjectPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMProjectPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMProjectPrjTab.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.mId = objvCMProjectPrjTabEN.mId; //mId
}
if (arrFldSet.Contains(convCMProjectPrjTab.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.CmPrjId = objvCMProjectPrjTabEN.CmPrjId; //CM工程Id
}
if (arrFldSet.Contains(convCMProjectPrjTab.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.CmPrjName = objvCMProjectPrjTabEN.CmPrjName == "[null]" ? null :  objvCMProjectPrjTabEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMProjectPrjTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.PrjId = objvCMProjectPrjTabEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convCMProjectPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.TabId = objvCMProjectPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(convCMProjectPrjTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.TabName = objvCMProjectPrjTabEN.TabName; //表名
}
if (arrFldSet.Contains(convCMProjectPrjTab.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.FuncModuleAgcId = objvCMProjectPrjTabEN.FuncModuleAgcId == "[null]" ? null :  objvCMProjectPrjTabEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCMProjectPrjTab.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.FuncModuleName = objvCMProjectPrjTabEN.FuncModuleName == "[null]" ? null :  objvCMProjectPrjTabEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCMProjectPrjTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.OrderNum = objvCMProjectPrjTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMProjectPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.UpdDate = objvCMProjectPrjTabEN.UpdDate == "[null]" ? null :  objvCMProjectPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMProjectPrjTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.UpdUser = objvCMProjectPrjTabEN.UpdUser == "[null]" ? null :  objvCMProjectPrjTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMProjectPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.Memo = objvCMProjectPrjTabEN.Memo == "[null]" ? null :  objvCMProjectPrjTabEN.Memo; //说明
}
if (arrFldSet.Contains(convCMProjectPrjTab.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.SqlDsTypeId = objvCMProjectPrjTabEN.SqlDsTypeId == "[null]" ? null :  objvCMProjectPrjTabEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convCMProjectPrjTab.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.SqlDsTypeName = objvCMProjectPrjTabEN.SqlDsTypeName == "[null]" ? null :  objvCMProjectPrjTabEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convCMProjectPrjTab.TabRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.TabRecNum = objvCMProjectPrjTabEN.TabRecNum; //记录数
}
if (arrFldSet.Contains(convCMProjectPrjTab.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.TabTypeId = objvCMProjectPrjTabEN.TabTypeId == "[null]" ? null :  objvCMProjectPrjTabEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convCMProjectPrjTab.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectPrjTabEN.TabStateId = objvCMProjectPrjTabEN.TabStateId == "[null]" ? null :  objvCMProjectPrjTabEN.TabStateId; //表状态ID
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
 /// <param name = "objvCMProjectPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
try
{
if (objvCMProjectPrjTabEN.CmPrjName == "[null]") objvCMProjectPrjTabEN.CmPrjName = null; //CM工程名
if (objvCMProjectPrjTabEN.FuncModuleAgcId == "[null]") objvCMProjectPrjTabEN.FuncModuleAgcId = null; //功能模块Id
if (objvCMProjectPrjTabEN.FuncModuleName == "[null]") objvCMProjectPrjTabEN.FuncModuleName = null; //功能模块名称
if (objvCMProjectPrjTabEN.UpdDate == "[null]") objvCMProjectPrjTabEN.UpdDate = null; //修改日期
if (objvCMProjectPrjTabEN.UpdUser == "[null]") objvCMProjectPrjTabEN.UpdUser = null; //修改者
if (objvCMProjectPrjTabEN.Memo == "[null]") objvCMProjectPrjTabEN.Memo = null; //说明
if (objvCMProjectPrjTabEN.SqlDsTypeId == "[null]") objvCMProjectPrjTabEN.SqlDsTypeId = null; //数据源类型Id
if (objvCMProjectPrjTabEN.SqlDsTypeName == "[null]") objvCMProjectPrjTabEN.SqlDsTypeName = null; //Sql数据源名
if (objvCMProjectPrjTabEN.TabTypeId == "[null]") objvCMProjectPrjTabEN.TabTypeId = null; //表类型Id
if (objvCMProjectPrjTabEN.TabStateId == "[null]") objvCMProjectPrjTabEN.TabStateId = null; //表状态ID
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
public static void CheckProperty4Condition(clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
 vCMProjectPrjTabDA.CheckProperty4Condition(objvCMProjectPrjTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectPrjTabBL没有刷新缓存机制(clsCMProjectPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMProjectPrjTabObjLstCache == null)
//{
//arrvCMProjectPrjTabObjLstCache = vCMProjectPrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectPrjTabEN GetObjBymIdCache(long lngmId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLst_Sel =
arrvCMProjectPrjTabObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMProjectPrjTabObjLst_Sel.Count() == 0)
{
   clsvCMProjectPrjTabEN obj = clsvCMProjectPrjTabBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCMProjectPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetAllvCMProjectPrjTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectPrjTabEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMProjectPrjTabEN> arrvCMProjectPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMProjectPrjTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMProjectPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMProjectPrjTabEN._RefreshTimeLst.Count == 0) return "";
return clsvCMProjectPrjTabEN._RefreshTimeLst[clsvCMProjectPrjTabEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convCMProjectPrjTab.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMProjectPrjTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMProjectPrjTab.AttributeName));
throw new Exception(strMsg);
}
var objvCMProjectPrjTab = clsvCMProjectPrjTabBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvCMProjectPrjTab == null) return "";
return objvCMProjectPrjTab[strOutFldName].ToString();
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
int intRecCount = clsvCMProjectPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMProjectPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMProjectPrjTabDA.GetRecCount();
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
int intRecCount = clsvCMProjectPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMProjectPrjTabEN objvCMProjectPrjTabCond)
{
 string strPrjId = objvCMProjectPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMProjectPrjTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProjectPrjTab.AttributeName)
{
if (objvCMProjectPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectPrjTabCond[strFldName].ToString());
}
else
{
if (objvCMProjectPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectPrjTabCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

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
 List<string> arrList = clsvCMProjectPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectPrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectPrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}