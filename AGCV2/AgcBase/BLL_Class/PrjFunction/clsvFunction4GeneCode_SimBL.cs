﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCode_SimBL
 表名:vFunction4GeneCode_Sim(00050605)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 16:37:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunction4GeneCode_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4GeneCode_SimEN GetObj(this K_FuncId4GC_vFunction4GeneCode_Sim myKey)
{
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = clsvFunction4GeneCode_SimBL.vFunction4GeneCode_SimDA.GetObjByFuncId4GC(myKey.Value);
return objvFunction4GeneCode_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncId4GC(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncId4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunction4GeneCode_Sim.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunction4GeneCode_Sim.FuncId4GC);
}
objvFunction4GeneCode_SimEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncId4GC) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncId4GC, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4GC] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncName(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunction4GeneCode_Sim.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunction4GeneCode_Sim.FuncName);
}
objvFunction4GeneCode_SimEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncName) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncName, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncName] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncId4Code(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4GeneCode_Sim.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4GeneCode_Sim.FuncId4Code);
}
objvFunction4GeneCode_SimEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncId4Code) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncId4Code, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4Code] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetSqlDsTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convFunction4GeneCode_Sim.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunction4GeneCode_Sim.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunction4GeneCode_Sim.SqlDsTypeId);
}
objvFunction4GeneCode_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.SqlDsTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFeatureId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFunction4GeneCode_Sim.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFunction4GeneCode_Sim.FeatureId);
}
objvFunction4GeneCode_SimEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FeatureId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FeatureId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FeatureId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetInUse(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, bool bolInUse, string strComparisonOp="")
	{
objvFunction4GeneCode_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.InUse) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.InUse, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.InUse] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncGCTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, convFunction4GeneCode_Sim.FuncGCTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4GeneCode_Sim.FuncGCTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4GeneCode_Sim.FuncGCTypeId);
}
objvFunction4GeneCode_SimEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncGCTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncGCTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncGCTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetTemplateNum(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, int? intTemplateNum, string strComparisonOp="")
	{
objvFunction4GeneCode_SimEN.TemplateNum = intTemplateNum; //TemplateNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.TemplateNum) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.TemplateNum, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.TemplateNum] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetProgLangTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunction4GeneCode_Sim.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunction4GeneCode_Sim.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunction4GeneCode_Sim.ProgLangTypeId);
}
objvFunction4GeneCode_SimEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.ProgLangTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncCodeTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, convFunction4GeneCode_Sim.FuncCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, convFunction4GeneCode_Sim.FuncCodeTypeId);
}
objvFunction4GeneCode_SimEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncCodeTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncCodeTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncCodeTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetUsedTimes(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, int? intUsedTimes, string strComparisonOp="")
	{
objvFunction4GeneCode_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.UsedTimes) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.UsedTimes, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.UsedTimes] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
 /// <param name = "objvFunction4GeneCode_SimENT">目标对象</param>
 public static void CopyTo(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS, clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENT)
{
try
{
objvFunction4GeneCode_SimENT.FuncId4GC = objvFunction4GeneCode_SimENS.FuncId4GC; //函数ID
objvFunction4GeneCode_SimENT.FuncName = objvFunction4GeneCode_SimENS.FuncName; //函数名
objvFunction4GeneCode_SimENT.FuncId4Code = objvFunction4GeneCode_SimENS.FuncId4Code; //函数Id4Code
objvFunction4GeneCode_SimENT.SqlDsTypeId = objvFunction4GeneCode_SimENS.SqlDsTypeId; //数据源类型Id
objvFunction4GeneCode_SimENT.FeatureId = objvFunction4GeneCode_SimENS.FeatureId; //功能Id
objvFunction4GeneCode_SimENT.InUse = objvFunction4GeneCode_SimENS.InUse; //是否在用
objvFunction4GeneCode_SimENT.FuncGCTypeId = objvFunction4GeneCode_SimENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4GeneCode_SimENT.TemplateNum = objvFunction4GeneCode_SimENS.TemplateNum; //TemplateNum
objvFunction4GeneCode_SimENT.ProgLangTypeId = objvFunction4GeneCode_SimENS.ProgLangTypeId; //编程语言类型Id
objvFunction4GeneCode_SimENT.FuncCodeTypeId = objvFunction4GeneCode_SimENS.FuncCodeTypeId; //函数代码类型Id
objvFunction4GeneCode_SimENT.UsedTimes = objvFunction4GeneCode_SimENS.UsedTimes; //使用次数
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
 /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
 /// <returns>目标对象=>clsvFunction4GeneCode_SimEN:objvFunction4GeneCode_SimENT</returns>
 public static clsvFunction4GeneCode_SimEN CopyTo(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS)
{
try
{
 clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENT = new clsvFunction4GeneCode_SimEN()
{
FuncId4GC = objvFunction4GeneCode_SimENS.FuncId4GC, //函数ID
FuncName = objvFunction4GeneCode_SimENS.FuncName, //函数名
FuncId4Code = objvFunction4GeneCode_SimENS.FuncId4Code, //函数Id4Code
SqlDsTypeId = objvFunction4GeneCode_SimENS.SqlDsTypeId, //数据源类型Id
FeatureId = objvFunction4GeneCode_SimENS.FeatureId, //功能Id
InUse = objvFunction4GeneCode_SimENS.InUse, //是否在用
FuncGCTypeId = objvFunction4GeneCode_SimENS.FuncGCTypeId, //函数生成代码类型Id
TemplateNum = objvFunction4GeneCode_SimENS.TemplateNum, //TemplateNum
ProgLangTypeId = objvFunction4GeneCode_SimENS.ProgLangTypeId, //编程语言类型Id
FuncCodeTypeId = objvFunction4GeneCode_SimENS.FuncCodeTypeId, //函数代码类型Id
UsedTimes = objvFunction4GeneCode_SimENS.UsedTimes, //使用次数
};
 return objvFunction4GeneCode_SimENT;
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
public static void CheckProperty4Condition(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
 clsvFunction4GeneCode_SimBL.vFunction4GeneCode_SimDA.CheckProperty4Condition(objvFunction4GeneCode_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncId4GC, objvFunction4GeneCode_SimCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncName) == true)
{
string strComparisonOpFuncName = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncName, objvFunction4GeneCode_SimCond.FuncName, strComparisonOpFuncName);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncId4Code, objvFunction4GeneCode_SimCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.SqlDsTypeId, objvFunction4GeneCode_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FeatureId, objvFunction4GeneCode_SimCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.InUse) == true)
{
if (objvFunction4GeneCode_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4GeneCode_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4GeneCode_Sim.InUse);
}
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncGCTypeId, objvFunction4GeneCode_SimCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.TemplateNum) == true)
{
string strComparisonOpTemplateNum = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.TemplateNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode_Sim.TemplateNum, objvFunction4GeneCode_SimCond.TemplateNum, strComparisonOpTemplateNum);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.ProgLangTypeId, objvFunction4GeneCode_SimCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncCodeTypeId, objvFunction4GeneCode_SimCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode_Sim.UsedTimes, objvFunction4GeneCode_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunction4GeneCode_Sim
{
public virtual bool UpdRelaTabDate(string strFuncId4GC, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数4GC_Sim(vFunction4GeneCode_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4GeneCode_SimBL
{
public static RelatedActions_vFunction4GeneCode_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunction4GeneCode_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunction4GeneCode_SimDA vFunction4GeneCode_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunction4GeneCode_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunction4GeneCode_SimBL()
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
if (string.IsNullOrEmpty(clsvFunction4GeneCode_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunction4GeneCode_SimEN._ConnectString);
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
public static DataTable GetDataTable_vFunction4GeneCode_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunction4GeneCode_SimDA.GetDataTable_vFunction4GeneCode_Sim(strWhereCond);
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
objDT = vFunction4GeneCode_SimDA.GetDataTable(strWhereCond);
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
objDT = vFunction4GeneCode_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunction4GeneCode_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunction4GeneCode_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunction4GeneCode_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vFunction4GeneCode_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunction4GeneCode_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunction4GeneCode_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncId4GCLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByFuncId4GCLst(List<string> arrFuncId4GCLst)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncId4GCLst, true);
 string strWhereCond = string.Format("FuncId4GC in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncId4GCLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunction4GeneCode_SimEN> GetObjLstByFuncId4GCLstCache(List<string> arrFuncId4GCLst)
{
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel =
arrvFunction4GeneCode_SimObjLstCache
.Where(x => arrFuncId4GCLst.Contains(x.FuncId4GC));
return arrvFunction4GeneCode_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLst(string strWhereCond)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
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
public static List<clsvFunction4GeneCode_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunction4GeneCode_SimEN> GetSubObjLstCache(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimCond)
{
List<clsvFunction4GeneCode_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunction4GeneCode_Sim.AttributeName)
{
if (objvFunction4GeneCode_SimCond.IsUpdated(strFldName) == false) continue;
if (objvFunction4GeneCode_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCode_SimCond[strFldName].ToString());
}
else
{
if (objvFunction4GeneCode_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunction4GeneCode_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCode_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunction4GeneCode_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCode_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCode_SimCond[strFldName]));
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
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
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
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
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
List<clsvFunction4GeneCode_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunction4GeneCode_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunction4GeneCode_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
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
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
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
public static List<clsvFunction4GeneCode_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
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
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCode_SimEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunction4GeneCode_Sim(ref clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
bool bolResult = vFunction4GeneCode_SimDA.GetvFunction4GeneCode_Sim(ref objvFunction4GeneCode_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4GeneCode_SimEN GetObjByFuncId4GC(string strFuncId4GC)
{
if (strFuncId4GC.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId4GC]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId4GC]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = vFunction4GeneCode_SimDA.GetObjByFuncId4GC(strFuncId4GC);
return objvFunction4GeneCode_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunction4GeneCode_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = vFunction4GeneCode_SimDA.GetFirstObj(strWhereCond);
 return objvFunction4GeneCode_SimEN;
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
public static clsvFunction4GeneCode_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = vFunction4GeneCode_SimDA.GetObjByDataRow(objRow);
 return objvFunction4GeneCode_SimEN;
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
public static clsvFunction4GeneCode_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = vFunction4GeneCode_SimDA.GetObjByDataRow(objRow);
 return objvFunction4GeneCode_SimEN;
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
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <param name = "lstvFunction4GeneCode_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4GeneCode_SimEN GetObjByFuncId4GCFromList(string strFuncId4GC, List<clsvFunction4GeneCode_SimEN> lstvFunction4GeneCode_SimObjLst)
{
foreach (clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN in lstvFunction4GeneCode_SimObjLst)
{
if (objvFunction4GeneCode_SimEN.FuncId4GC == strFuncId4GC)
{
return objvFunction4GeneCode_SimEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxFuncId4GC;
 try
 {
 strMaxFuncId4GC = clsvFunction4GeneCode_SimDA.GetMaxStrId();
 return strMaxFuncId4GC;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strFuncId4GC;
 try
 {
 strFuncId4GC = new clsvFunction4GeneCode_SimDA().GetFirstID(strWhereCond);
 return strFuncId4GC;
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
 arrList = vFunction4GeneCode_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vFunction4GeneCode_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId4GC]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFunction4GeneCode_SimDA.IsExist(strFuncId4GC);
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
 bolIsExist = clsvFunction4GeneCode_SimDA.IsExistTable();
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
 bolIsExist = vFunction4GeneCode_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
 /// <param name = "objvFunction4GeneCode_SimENT">目标对象</param>
 public static void CopyTo(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS, clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENT)
{
try
{
objvFunction4GeneCode_SimENT.FuncId4GC = objvFunction4GeneCode_SimENS.FuncId4GC; //函数ID
objvFunction4GeneCode_SimENT.FuncName = objvFunction4GeneCode_SimENS.FuncName; //函数名
objvFunction4GeneCode_SimENT.FuncId4Code = objvFunction4GeneCode_SimENS.FuncId4Code; //函数Id4Code
objvFunction4GeneCode_SimENT.SqlDsTypeId = objvFunction4GeneCode_SimENS.SqlDsTypeId; //数据源类型Id
objvFunction4GeneCode_SimENT.FeatureId = objvFunction4GeneCode_SimENS.FeatureId; //功能Id
objvFunction4GeneCode_SimENT.InUse = objvFunction4GeneCode_SimENS.InUse; //是否在用
objvFunction4GeneCode_SimENT.FuncGCTypeId = objvFunction4GeneCode_SimENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4GeneCode_SimENT.TemplateNum = objvFunction4GeneCode_SimENS.TemplateNum; //TemplateNum
objvFunction4GeneCode_SimENT.ProgLangTypeId = objvFunction4GeneCode_SimENS.ProgLangTypeId; //编程语言类型Id
objvFunction4GeneCode_SimENT.FuncCodeTypeId = objvFunction4GeneCode_SimENS.FuncCodeTypeId; //函数代码类型Id
objvFunction4GeneCode_SimENT.UsedTimes = objvFunction4GeneCode_SimENS.UsedTimes; //使用次数
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
 /// <param name = "objvFunction4GeneCode_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
try
{
objvFunction4GeneCode_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunction4GeneCode_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunction4GeneCode_Sim.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.FuncId4GC = objvFunction4GeneCode_SimEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.FuncName = objvFunction4GeneCode_SimEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.FuncId4Code = objvFunction4GeneCode_SimEN.FuncId4Code == "[null]" ? null :  objvFunction4GeneCode_SimEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.SqlDsTypeId = objvFunction4GeneCode_SimEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.FeatureId = objvFunction4GeneCode_SimEN.FeatureId == "[null]" ? null :  objvFunction4GeneCode_SimEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.InUse = objvFunction4GeneCode_SimEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.FuncGCTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.FuncGCTypeId = objvFunction4GeneCode_SimEN.FuncGCTypeId; //函数生成代码类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.TemplateNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.TemplateNum = objvFunction4GeneCode_SimEN.TemplateNum; //TemplateNum
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.ProgLangTypeId = objvFunction4GeneCode_SimEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.FuncCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objvFunction4GeneCode_SimEN.FuncCodeTypeId == "[null]" ? null :  objvFunction4GeneCode_SimEN.FuncCodeTypeId; //函数代码类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode_Sim.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCode_SimEN.UsedTimes = objvFunction4GeneCode_SimEN.UsedTimes; //使用次数
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
 /// <param name = "objvFunction4GeneCode_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
try
{
if (objvFunction4GeneCode_SimEN.FuncId4Code == "[null]") objvFunction4GeneCode_SimEN.FuncId4Code = null; //函数Id4Code
if (objvFunction4GeneCode_SimEN.FeatureId == "[null]") objvFunction4GeneCode_SimEN.FeatureId = null; //功能Id
if (objvFunction4GeneCode_SimEN.FuncCodeTypeId == "[null]") objvFunction4GeneCode_SimEN.FuncCodeTypeId = null; //函数代码类型Id
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
public static void CheckProperty4Condition(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
 vFunction4GeneCode_SimDA.CheckProperty4Condition(objvFunction4GeneCode_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncCodeTypeId"></param>
public static void BindCbo_FuncId4GC(System.Windows.Forms.ComboBox objComboBox , string strFuncCodeTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFunction4GeneCode_Sim.FuncId4GC); 
List<clsvFunction4GeneCode_SimEN> arrObjLst = clsvFunction4GeneCode_SimBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncCodeTypeId == strFuncCodeTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN()
{
FuncId4GC = "0",
FuncName = "选[v函数4GC_Sim]..."
};
arrObjLstSel.Insert(0, objvFunction4GeneCode_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFunction4GeneCode_Sim.FuncId4GC;
objComboBox.DisplayMember = convFunction4GeneCode_Sim.FuncName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncCodeTypeId"></param>
public static void BindDdl_FuncId4GC(System.Web.UI.WebControls.DropDownList objDDL , string strFuncCodeTypeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v函数4GC_Sim]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convFunction4GeneCode_Sim.FuncId4GC); 
IEnumerable<clsvFunction4GeneCode_SimEN> arrObjLst = clsvFunction4GeneCode_SimBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncCodeTypeId == strFuncCodeTypeId).ToList();
objDDL.DataValueField = convFunction4GeneCode_Sim.FuncId4GC;
objDDL.DataTextField = convFunction4GeneCode_Sim.FuncName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncId4GCCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v函数4GC_Sim]...","0");
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst = GetAllvFunction4GeneCode_SimObjLstCache(); 
objDDL.DataValueField = convFunction4GeneCode_Sim.FuncId4GC;
objDDL.DataTextField = convFunction4GeneCode_Sim.FuncName;
objDDL.DataSource = arrvFunction4GeneCode_SimObjLst;
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
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncId4GC");
//if (arrvFunction4GeneCode_SimObjLstCache == null)
//{
//arrvFunction4GeneCode_SimObjLstCache = vFunction4GeneCode_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4GeneCode_SimEN GetObjByFuncId4GCCache(string strFuncId4GC)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel =
arrvFunction4GeneCode_SimObjLstCache
.Where(x=> x.FuncId4GC == strFuncId4GC 
);
if (arrvFunction4GeneCode_SimObjLst_Sel.Count() == 0)
{
   clsvFunction4GeneCode_SimEN obj = clsvFunction4GeneCode_SimBL.GetObjByFuncId4GC(strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunction4GeneCode_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncNameByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return "";
//获取缓存中的对象列表
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_Sim = GetObjByFuncId4GCCache(strFuncId4GC);
if (objvFunction4GeneCode_Sim == null) return "";
return objvFunction4GeneCode_Sim.FuncName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return "";
//获取缓存中的对象列表
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_Sim = GetObjByFuncId4GCCache(strFuncId4GC);
if (objvFunction4GeneCode_Sim == null) return "";
return objvFunction4GeneCode_Sim.FuncName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetAllvFunction4GeneCode_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache(); 
return arrvFunction4GeneCode_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunction4GeneCode_SimObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunction4GeneCode_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunction4GeneCode_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvFunction4GeneCode_SimEN._RefreshTimeLst[clsvFunction4GeneCode_SimEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncId4GC)
{
if (strInFldName != convFunction4GeneCode_Sim.FuncId4GC)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunction4GeneCode_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunction4GeneCode_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvFunction4GeneCode_Sim = clsvFunction4GeneCode_SimBL.GetObjByFuncId4GCCache(strFuncId4GC);
if (objvFunction4GeneCode_Sim == null) return "";
return objvFunction4GeneCode_Sim[strOutFldName].ToString();
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
int intRecCount = clsvFunction4GeneCode_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunction4GeneCode_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunction4GeneCode_SimDA.GetRecCount();
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
int intRecCount = clsvFunction4GeneCode_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimCond)
{
List<clsvFunction4GeneCode_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunction4GeneCode_Sim.AttributeName)
{
if (objvFunction4GeneCode_SimCond.IsUpdated(strFldName) == false) continue;
if (objvFunction4GeneCode_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCode_SimCond[strFldName].ToString());
}
else
{
if (objvFunction4GeneCode_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunction4GeneCode_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCode_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunction4GeneCode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunction4GeneCode_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCode_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCode_SimCond[strFldName]));
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
 List<string> arrList = clsvFunction4GeneCode_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunction4GeneCode_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunction4GeneCode_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}