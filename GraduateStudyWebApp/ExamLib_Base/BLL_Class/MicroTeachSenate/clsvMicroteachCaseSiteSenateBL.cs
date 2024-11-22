
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseSiteSenateBL
 表名:vMicroteachCaseSiteSenate(01120457)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvMicroteachCaseSiteSenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObj(this K_IdMicroteachCaseSiteSenate_vMicroteachCaseSiteSenate myKey)
{
clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = clsvMicroteachCaseSiteSenateBL.vMicroteachCaseSiteSenateDA.GetObjByIdMicroteachCaseSiteSenate(myKey.Value);
return objvMicroteachCaseSiteSenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdMicroteachCaseSiteSenate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, long lngIdMicroteachCaseSiteSenate, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = lngIdMicroteachCaseSiteSenate; //微格现场评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFuncModuleId(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCaseSiteSenate.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCaseSiteSenate.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCaseSiteSenate.FuncModuleId);
}
objvMicroteachCaseSiteSenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FuncModuleId) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFuncModuleName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCaseSiteSenate.FuncModuleName);
}
objvMicroteachCaseSiteSenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FuncModuleName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdMicroteachCase(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroteachCaseSiteSenate.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCaseSiteSenate.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCaseSiteSenate.IdMicroteachCase);
}
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdMicroteachCase) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCaseSiteSenate.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCaseSiteSenate.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCaseSiteSenate.MicroteachCaseID);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCaseSiteSenate.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCaseSiteSenate.MicroteachCaseName);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseTheme(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCaseSiteSenate.MicroteachCaseTheme);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseTheme) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCaseSiteSenate.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCaseSiteSenate.MicroteachCaseDate);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCaseSiteSenate.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCaseSiteSenate.MicroteachCaseTime);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseDateIn(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseDateIn) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdStudyLevel(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convMicroteachCaseSiteSenate.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroteachCaseSiteSenate.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroteachCaseSiteSenate.IdStudyLevel);
}
objvMicroteachCaseSiteSenateEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdStudyLevel) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStudyLevelName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convMicroteachCaseSiteSenate.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCaseSiteSenate.StudyLevelName);
}
objvMicroteachCaseSiteSenateEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StudyLevelName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdTeachingPlan(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convMicroteachCaseSiteSenate.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroteachCaseSiteSenate.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroteachCaseSiteSenate.IdTeachingPlan);
}
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdTeachingPlan) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroTeachCaseTimeIn(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
}
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIsVisible(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IsVisible) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetmicroteachCaseText(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCaseSiteSenate.microteachCaseText);
}
objvMicroteachCaseSiteSenateEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.microteachCaseText) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetOwnerId(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCaseSiteSenate.OwnerId);
}
objvMicroteachCaseSiteSenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.OwnerId) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convMicroteachCaseSiteSenate.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convMicroteachCaseSiteSenate.StuName);
}
objvMicroteachCaseSiteSenateEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, convMicroteachCaseSiteSenate.StuID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convMicroteachCaseSiteSenate.StuID);
}
objvMicroteachCaseSiteSenateEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetPoliticsName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, convMicroteachCaseSiteSenate.PoliticsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convMicroteachCaseSiteSenate.PoliticsName);
}
objvMicroteachCaseSiteSenateEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.PoliticsName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.PoliticsName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.PoliticsName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSexDesc(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convMicroteachCaseSiteSenate.SexDesc);
}
objvMicroteachCaseSiteSenateEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SexDesc) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SexDesc, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SexDesc] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetEthnicName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEthnicName, convMicroteachCaseSiteSenate.EthnicName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convMicroteachCaseSiteSenate.EthnicName);
}
objvMicroteachCaseSiteSenateEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.EthnicName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.EthnicName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.EthnicName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetUniZoneDesc(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneDesc, convMicroteachCaseSiteSenate.UniZoneDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convMicroteachCaseSiteSenate.UniZoneDesc);
}
objvMicroteachCaseSiteSenateEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.UniZoneDesc) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.UniZoneDesc, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.UniZoneDesc] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuTypeDesc(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTypeDesc, convMicroteachCaseSiteSenate.StuTypeDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convMicroteachCaseSiteSenate.StuTypeDesc);
}
objvMicroteachCaseSiteSenateEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuTypeDesc) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuTypeDesc, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuTypeDesc] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdXzCollege(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCaseSiteSenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCaseSiteSenate.IdXzCollege);
}
objvMicroteachCaseSiteSenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdXzCollege) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetCollegeName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convMicroteachCaseSiteSenate.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCaseSiteSenate.CollegeName);
}
objvMicroteachCaseSiteSenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.CollegeName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdXzMajor(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convMicroteachCaseSiteSenate.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convMicroteachCaseSiteSenate.IdXzMajor);
}
objvMicroteachCaseSiteSenateEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdXzMajor) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdXzMajor, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdXzMajor] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMajorName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convMicroteachCaseSiteSenate.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMicroteachCaseSiteSenate.MajorName);
}
objvMicroteachCaseSiteSenateEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MajorName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MajorName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MajorName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdGradeBase(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGradeBase, convMicroteachCaseSiteSenate.IdGradeBase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convMicroteachCaseSiteSenate.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convMicroteachCaseSiteSenate.IdGradeBase);
}
objvMicroteachCaseSiteSenateEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdGradeBase) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdGradeBase, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdGradeBase] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetGradeBaseName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMicroteachCaseSiteSenate.GradeBaseName);
}
objvMicroteachCaseSiteSenateEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.GradeBaseName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.GradeBaseName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.GradeBaseName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetBirthday(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convMicroteachCaseSiteSenate.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convMicroteachCaseSiteSenate.Birthday);
}
objvMicroteachCaseSiteSenateEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.Birthday) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.Birthday, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.Birthday] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetNativePlace(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convMicroteachCaseSiteSenate.NativePlace);
}
objvMicroteachCaseSiteSenateEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.NativePlace) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.NativePlace, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.NativePlace] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetDuty(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convMicroteachCaseSiteSenate.Duty);
}
objvMicroteachCaseSiteSenateEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.Duty) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.Duty, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.Duty] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIDCardNo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIDCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convMicroteachCaseSiteSenate.IDCardNo);
}
objvMicroteachCaseSiteSenateEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IDCardNo) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IDCardNo, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IDCardNo] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuCardNo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convMicroteachCaseSiteSenate.StuCardNo);
}
objvMicroteachCaseSiteSenateEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuCardNo) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuCardNo, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuCardNo] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetLiveAddress(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convMicroteachCaseSiteSenate.LiveAddress);
}
objvMicroteachCaseSiteSenateEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.LiveAddress) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.LiveAddress, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.LiveAddress] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetHomePhone(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convMicroteachCaseSiteSenate.HomePhone);
}
objvMicroteachCaseSiteSenateEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.HomePhone) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.HomePhone, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.HomePhone] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetEnrollmentDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convMicroteachCaseSiteSenate.EnrollmentDate);
}
objvMicroteachCaseSiteSenateEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.EnrollmentDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.EnrollmentDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.EnrollmentDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetPostCode(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convMicroteachCaseSiteSenate.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convMicroteachCaseSiteSenate.PostCode);
}
objvMicroteachCaseSiteSenateEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.PostCode) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.PostCode, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.PostCode] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetBrowseCount4Case(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.BrowseCount4Case) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdMicroteachCaseSiteSenateType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdMicroteachCaseSiteSenateType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCaseSiteSenateType, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseSiteSenateType, 4, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseSiteSenateType, 4, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = strIdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseSiteSenateTypeID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseSiteSenateTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseSiteSenateTypeID, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseSiteSenateTypeID, 4, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseSiteSenateTypeID, 4, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = strMicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseSiteSenateTypeName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseSiteSenateTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseSiteSenateTypeName, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseSiteSenateTypeName, 50, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
}
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = strMicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdResource(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convMicroteachCaseSiteSenate.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convMicroteachCaseSiteSenate.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convMicroteachCaseSiteSenate.IdResource);
}
objvMicroteachCaseSiteSenateEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdResource) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdResource, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdResource] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convMicroteachCaseSiteSenate.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCaseSiteSenate.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCaseSiteSenate.ResourceID);
}
objvMicroteachCaseSiteSenateEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCaseSiteSenate.ResourceName);
}
objvMicroteachCaseSiteSenateEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdFtpResource(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convMicroteachCaseSiteSenate.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convMicroteachCaseSiteSenate.IdFtpResource);
}
objvMicroteachCaseSiteSenateEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdFtpResource) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdFtpResource, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdFtpResource] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdFile(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convMicroteachCaseSiteSenate.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convMicroteachCaseSiteSenate.IdFile);
}
objvMicroteachCaseSiteSenateEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdFile) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdFile, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdFile] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCaseSiteSenate.FileName);
}
objvMicroteachCaseSiteSenateEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCaseSiteSenate.FileType);
}
objvMicroteachCaseSiteSenateEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSaveDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCaseSiteSenate.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCaseSiteSenate.SaveDate);
}
objvMicroteachCaseSiteSenateEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SaveDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileSize(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCaseSiteSenate.FileSize);
}
objvMicroteachCaseSiteSenateEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileSize) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileSize, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileSize] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSaveTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCaseSiteSenate.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCaseSiteSenate.SaveTime);
}
objvMicroteachCaseSiteSenateEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SaveTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFtpResourceID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convMicroteachCaseSiteSenate.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCaseSiteSenate.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCaseSiteSenate.FtpResourceID);
}
objvMicroteachCaseSiteSenateEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FtpResourceID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileOriginalName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCaseSiteSenate.FileOriginalName);
}
objvMicroteachCaseSiteSenateEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileOriginalName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileDirName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCaseSiteSenate.FileDirName);
}
objvMicroteachCaseSiteSenateEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileDirName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileRename(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCaseSiteSenate.FileRename);
}
objvMicroteachCaseSiteSenateEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileRename) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileRename, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileRename] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileUpDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCaseSiteSenate.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCaseSiteSenate.FileUpDate);
}
objvMicroteachCaseSiteSenateEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileUpDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileUpTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCaseSiteSenate.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCaseSiteSenate.FileUpTime);
}
objvMicroteachCaseSiteSenateEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileUpTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSaveMode(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SaveMode) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIdResourceType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convMicroteachCaseSiteSenate.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convMicroteachCaseSiteSenate.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convMicroteachCaseSiteSenate.IdResourceType);
}
objvMicroteachCaseSiteSenateEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IdResourceType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IdResourceType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdResourceType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceTypeID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convMicroteachCaseSiteSenate.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCaseSiteSenate.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCaseSiteSenate.ResourceTypeID);
}
objvMicroteachCaseSiteSenateEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceTypeID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceTypeName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convMicroteachCaseSiteSenate.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCaseSiteSenate.ResourceTypeName);
}
objvMicroteachCaseSiteSenateEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceTypeName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceOwner(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convMicroteachCaseSiteSenate.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCaseSiteSenate.ResourceOwner);
}
objvMicroteachCaseSiteSenateEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceOwner) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetftpFileType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCaseSiteSenate.ftpFileType);
}
objvMicroteachCaseSiteSenateEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ftpFileType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetftpFileSize(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCaseSiteSenate.ftpFileSize);
}
objvMicroteachCaseSiteSenateEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ftpFileSize) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetftpResourceOwner(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCaseSiteSenate.ftpResourceOwner);
}
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ftpResourceOwner) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileOriginName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCaseSiteSenate.FileOriginName);
}
objvMicroteachCaseSiteSenateEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileOriginName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIsExistFile(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IsExistFile) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileNewName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCaseSiteSenate.FileNewName);
}
objvMicroteachCaseSiteSenateEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileNewName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileOldName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCaseSiteSenate.FileOldName);
}
objvMicroteachCaseSiteSenateEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileOldName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateSenator(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateSenator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateSenator, 50, convMicroteachCaseSiteSenate.SiteSenateSenator);
}
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = strSiteSenateSenator; //评议者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateSenator) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateSenator, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateSenator] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateTitle(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteSenateTitle, convMicroteachCaseSiteSenate.SiteSenateTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateTitle, 50, convMicroteachCaseSiteSenate.SiteSenateTitle);
}
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = strSiteSenateTitle; //评议名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateTitle) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateTitle, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTitle] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateContent(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateContent, 2000, convMicroteachCaseSiteSenate.SiteSenateContent);
}
objvMicroteachCaseSiteSenateEN.SiteSenateContent = strSiteSenateContent; //现场评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateContent) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateContent, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateContent] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateData(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateData, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateData, 8, convMicroteachCaseSiteSenate.SiteSenateData);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSiteSenateData, 8, convMicroteachCaseSiteSenate.SiteSenateData);
}
objvMicroteachCaseSiteSenateEN.SiteSenateData = strSiteSenateData; //现场评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateData) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateData, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateData] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateTime, 6, convMicroteachCaseSiteSenate.SiteSenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSiteSenateTime, 6, convMicroteachCaseSiteSenate.SiteSenateTime);
}
objvMicroteachCaseSiteSenateEN.SiteSenateTime = strSiteSenateTime; //现场评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateReadCount(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, int? intSiteSenateReadCount, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = intSiteSenateReadCount; //现场评议阅读次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateReadCount) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateReadCount, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateReadCount] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMemo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCaseSiteSenate.Memo);
}
objvMicroteachCaseSiteSenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.Memo) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.Memo, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.Memo] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseSiteSenateENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENS, clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENT)
{
try
{
objvMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate; //微格现场评议流水号
objvMicroteachCaseSiteSenateENT.FuncModuleId = objvMicroteachCaseSiteSenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseSiteSenateENT.FuncModuleName = objvMicroteachCaseSiteSenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseSiteSenateENT.IdMicroteachCase = objvMicroteachCaseSiteSenateENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseID = objvMicroteachCaseSiteSenateENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseName = objvMicroteachCaseSiteSenateENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseSiteSenateENT.MicroteachCaseTheme = objvMicroteachCaseSiteSenateENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCaseSiteSenateENT.MicroteachCaseDate = objvMicroteachCaseSiteSenateENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCaseSiteSenateENT.MicroteachCaseTime = objvMicroteachCaseSiteSenateENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCaseSiteSenateENT.MicroteachCaseDateIn = objvMicroteachCaseSiteSenateENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCaseSiteSenateENT.IdStudyLevel = objvMicroteachCaseSiteSenateENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCaseSiteSenateENT.StudyLevelName = objvMicroteachCaseSiteSenateENS.StudyLevelName; //学段名称
objvMicroteachCaseSiteSenateENT.IdTeachingPlan = objvMicroteachCaseSiteSenateENS.IdTeachingPlan; //教案流水号
objvMicroteachCaseSiteSenateENT.MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCaseSiteSenateENT.IsVisible = objvMicroteachCaseSiteSenateENS.IsVisible; //是否显示
objvMicroteachCaseSiteSenateENT.microteachCaseText = objvMicroteachCaseSiteSenateENS.microteachCaseText; //案例文本内容
objvMicroteachCaseSiteSenateENT.OwnerId = objvMicroteachCaseSiteSenateENS.OwnerId; //拥有者Id
objvMicroteachCaseSiteSenateENT.StuName = objvMicroteachCaseSiteSenateENS.StuName; //姓名
objvMicroteachCaseSiteSenateENT.StuID = objvMicroteachCaseSiteSenateENS.StuID; //学号
objvMicroteachCaseSiteSenateENT.PoliticsName = objvMicroteachCaseSiteSenateENS.PoliticsName; //政治面貌
objvMicroteachCaseSiteSenateENT.SexDesc = objvMicroteachCaseSiteSenateENS.SexDesc; //性别名称
objvMicroteachCaseSiteSenateENT.EthnicName = objvMicroteachCaseSiteSenateENS.EthnicName; //民族名称
objvMicroteachCaseSiteSenateENT.UniZoneDesc = objvMicroteachCaseSiteSenateENS.UniZoneDesc; //校区名称
objvMicroteachCaseSiteSenateENT.StuTypeDesc = objvMicroteachCaseSiteSenateENS.StuTypeDesc; //学生类别名称
objvMicroteachCaseSiteSenateENT.IdXzCollege = objvMicroteachCaseSiteSenateENS.IdXzCollege; //学院流水号
objvMicroteachCaseSiteSenateENT.CollegeName = objvMicroteachCaseSiteSenateENS.CollegeName; //学院名称
objvMicroteachCaseSiteSenateENT.IdXzMajor = objvMicroteachCaseSiteSenateENS.IdXzMajor; //专业流水号
objvMicroteachCaseSiteSenateENT.MajorName = objvMicroteachCaseSiteSenateENS.MajorName; //专业名称
objvMicroteachCaseSiteSenateENT.IdGradeBase = objvMicroteachCaseSiteSenateENS.IdGradeBase; //年级流水号
objvMicroteachCaseSiteSenateENT.GradeBaseName = objvMicroteachCaseSiteSenateENS.GradeBaseName; //年级名称
objvMicroteachCaseSiteSenateENT.Birthday = objvMicroteachCaseSiteSenateENS.Birthday; //出生日期
objvMicroteachCaseSiteSenateENT.NativePlace = objvMicroteachCaseSiteSenateENS.NativePlace; //籍贯
objvMicroteachCaseSiteSenateENT.Duty = objvMicroteachCaseSiteSenateENS.Duty; //职位
objvMicroteachCaseSiteSenateENT.IDCardNo = objvMicroteachCaseSiteSenateENS.IDCardNo; //身份证号
objvMicroteachCaseSiteSenateENT.StuCardNo = objvMicroteachCaseSiteSenateENS.StuCardNo; //学生证号
objvMicroteachCaseSiteSenateENT.LiveAddress = objvMicroteachCaseSiteSenateENS.LiveAddress; //居住地址
objvMicroteachCaseSiteSenateENT.HomePhone = objvMicroteachCaseSiteSenateENS.HomePhone; //住宅电话
objvMicroteachCaseSiteSenateENT.EnrollmentDate = objvMicroteachCaseSiteSenateENS.EnrollmentDate; //入校日期
objvMicroteachCaseSiteSenateENT.PostCode = objvMicroteachCaseSiteSenateENS.PostCode; //邮编
objvMicroteachCaseSiteSenateENT.BrowseCount4Case = objvMicroteachCaseSiteSenateENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
objvMicroteachCaseSiteSenateENT.IdResource = objvMicroteachCaseSiteSenateENS.IdResource; //资源流水号
objvMicroteachCaseSiteSenateENT.ResourceID = objvMicroteachCaseSiteSenateENS.ResourceID; //资源ID
objvMicroteachCaseSiteSenateENT.ResourceName = objvMicroteachCaseSiteSenateENS.ResourceName; //资源名称
objvMicroteachCaseSiteSenateENT.IdFtpResource = objvMicroteachCaseSiteSenateENS.IdFtpResource; //FTP资源流水号
objvMicroteachCaseSiteSenateENT.IdFile = objvMicroteachCaseSiteSenateENS.IdFile; //文件流水号
objvMicroteachCaseSiteSenateENT.FileName = objvMicroteachCaseSiteSenateENS.FileName; //文件名称
objvMicroteachCaseSiteSenateENT.FileType = objvMicroteachCaseSiteSenateENS.FileType; //文件类型
objvMicroteachCaseSiteSenateENT.SaveDate = objvMicroteachCaseSiteSenateENS.SaveDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileSize = objvMicroteachCaseSiteSenateENS.FileSize; //文件大小
objvMicroteachCaseSiteSenateENT.SaveTime = objvMicroteachCaseSiteSenateENS.SaveTime; //创建时间
objvMicroteachCaseSiteSenateENT.FtpResourceID = objvMicroteachCaseSiteSenateENS.FtpResourceID; //FTP资源ID
objvMicroteachCaseSiteSenateENT.FileOriginalName = objvMicroteachCaseSiteSenateENS.FileOriginalName; //文件原名
objvMicroteachCaseSiteSenateENT.FileDirName = objvMicroteachCaseSiteSenateENS.FileDirName; //文件目录名
objvMicroteachCaseSiteSenateENT.FileRename = objvMicroteachCaseSiteSenateENS.FileRename; //文件新名
objvMicroteachCaseSiteSenateENT.FileUpDate = objvMicroteachCaseSiteSenateENS.FileUpDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileUpTime = objvMicroteachCaseSiteSenateENS.FileUpTime; //创建时间
objvMicroteachCaseSiteSenateENT.SaveMode = objvMicroteachCaseSiteSenateENS.SaveMode; //文件存放方式
objvMicroteachCaseSiteSenateENT.IdResourceType = objvMicroteachCaseSiteSenateENS.IdResourceType; //资源类型流水号
objvMicroteachCaseSiteSenateENT.ResourceTypeID = objvMicroteachCaseSiteSenateENS.ResourceTypeID; //资源类型ID
objvMicroteachCaseSiteSenateENT.ResourceTypeName = objvMicroteachCaseSiteSenateENS.ResourceTypeName; //资源类型名称
objvMicroteachCaseSiteSenateENT.ResourceOwner = objvMicroteachCaseSiteSenateENS.ResourceOwner; //上传者
objvMicroteachCaseSiteSenateENT.ftpFileType = objvMicroteachCaseSiteSenateENS.ftpFileType; //ftp文件类型
objvMicroteachCaseSiteSenateENT.ftpFileSize = objvMicroteachCaseSiteSenateENS.ftpFileSize; //ftp文件大小
objvMicroteachCaseSiteSenateENT.ftpResourceOwner = objvMicroteachCaseSiteSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCaseSiteSenateENT.FileOriginName = objvMicroteachCaseSiteSenateENS.FileOriginName; //原文件名
objvMicroteachCaseSiteSenateENT.IsExistFile = objvMicroteachCaseSiteSenateENS.IsExistFile; //是否存在文件
objvMicroteachCaseSiteSenateENT.FileNewName = objvMicroteachCaseSiteSenateENS.FileNewName; //新文件名
objvMicroteachCaseSiteSenateENT.FileOldName = objvMicroteachCaseSiteSenateENS.FileOldName; //旧文件名
objvMicroteachCaseSiteSenateENT.SiteSenateSenator = objvMicroteachCaseSiteSenateENS.SiteSenateSenator; //评议者
objvMicroteachCaseSiteSenateENT.SiteSenateTitle = objvMicroteachCaseSiteSenateENS.SiteSenateTitle; //评议名称
objvMicroteachCaseSiteSenateENT.SiteSenateContent = objvMicroteachCaseSiteSenateENS.SiteSenateContent; //现场评议内容
objvMicroteachCaseSiteSenateENT.SiteSenateData = objvMicroteachCaseSiteSenateENS.SiteSenateData; //现场评议日期
objvMicroteachCaseSiteSenateENT.SiteSenateTime = objvMicroteachCaseSiteSenateENS.SiteSenateTime; //现场评议时间
objvMicroteachCaseSiteSenateENT.SiteSenateReadCount = objvMicroteachCaseSiteSenateENS.SiteSenateReadCount; //现场评议阅读次数
objvMicroteachCaseSiteSenateENT.Memo = objvMicroteachCaseSiteSenateENS.Memo; //备注
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
 /// <param name = "objvMicroteachCaseSiteSenateENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCaseSiteSenateEN:objvMicroteachCaseSiteSenateENT</returns>
 public static clsvMicroteachCaseSiteSenateEN CopyTo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENS)
{
try
{
 clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENT = new clsvMicroteachCaseSiteSenateEN()
{
IdMicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate, //微格现场评议流水号
FuncModuleId = objvMicroteachCaseSiteSenateENS.FuncModuleId, //功能模块Id
FuncModuleName = objvMicroteachCaseSiteSenateENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvMicroteachCaseSiteSenateENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroteachCaseSiteSenateENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCaseSiteSenateENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroteachCaseSiteSenateENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroteachCaseSiteSenateENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroteachCaseSiteSenateENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroteachCaseSiteSenateENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroteachCaseSiteSenateENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroteachCaseSiteSenateENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroteachCaseSiteSenateENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateENS.MicroTeachCaseTimeIn, //案例入库时间
IsVisible = objvMicroteachCaseSiteSenateENS.IsVisible, //是否显示
microteachCaseText = objvMicroteachCaseSiteSenateENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroteachCaseSiteSenateENS.OwnerId, //拥有者Id
StuName = objvMicroteachCaseSiteSenateENS.StuName, //姓名
StuID = objvMicroteachCaseSiteSenateENS.StuID, //学号
PoliticsName = objvMicroteachCaseSiteSenateENS.PoliticsName, //政治面貌
SexDesc = objvMicroteachCaseSiteSenateENS.SexDesc, //性别名称
EthnicName = objvMicroteachCaseSiteSenateENS.EthnicName, //民族名称
UniZoneDesc = objvMicroteachCaseSiteSenateENS.UniZoneDesc, //校区名称
StuTypeDesc = objvMicroteachCaseSiteSenateENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvMicroteachCaseSiteSenateENS.IdXzCollege, //学院流水号
CollegeName = objvMicroteachCaseSiteSenateENS.CollegeName, //学院名称
IdXzMajor = objvMicroteachCaseSiteSenateENS.IdXzMajor, //专业流水号
MajorName = objvMicroteachCaseSiteSenateENS.MajorName, //专业名称
IdGradeBase = objvMicroteachCaseSiteSenateENS.IdGradeBase, //年级流水号
GradeBaseName = objvMicroteachCaseSiteSenateENS.GradeBaseName, //年级名称
Birthday = objvMicroteachCaseSiteSenateENS.Birthday, //出生日期
NativePlace = objvMicroteachCaseSiteSenateENS.NativePlace, //籍贯
Duty = objvMicroteachCaseSiteSenateENS.Duty, //职位
IDCardNo = objvMicroteachCaseSiteSenateENS.IDCardNo, //身份证号
StuCardNo = objvMicroteachCaseSiteSenateENS.StuCardNo, //学生证号
LiveAddress = objvMicroteachCaseSiteSenateENS.LiveAddress, //居住地址
HomePhone = objvMicroteachCaseSiteSenateENS.HomePhone, //住宅电话
EnrollmentDate = objvMicroteachCaseSiteSenateENS.EnrollmentDate, //入校日期
PostCode = objvMicroteachCaseSiteSenateENS.PostCode, //邮编
BrowseCount4Case = objvMicroteachCaseSiteSenateENS.BrowseCount4Case, //课例浏览次数
IdMicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType, //微格现场评价类型流水号
MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeID, //微格现场评价类型ID
MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeName, //微格现场评价类型名称
IdResource = objvMicroteachCaseSiteSenateENS.IdResource, //资源流水号
ResourceID = objvMicroteachCaseSiteSenateENS.ResourceID, //资源ID
ResourceName = objvMicroteachCaseSiteSenateENS.ResourceName, //资源名称
IdFtpResource = objvMicroteachCaseSiteSenateENS.IdFtpResource, //FTP资源流水号
IdFile = objvMicroteachCaseSiteSenateENS.IdFile, //文件流水号
FileName = objvMicroteachCaseSiteSenateENS.FileName, //文件名称
FileType = objvMicroteachCaseSiteSenateENS.FileType, //文件类型
SaveDate = objvMicroteachCaseSiteSenateENS.SaveDate, //创建日期
FileSize = objvMicroteachCaseSiteSenateENS.FileSize, //文件大小
SaveTime = objvMicroteachCaseSiteSenateENS.SaveTime, //创建时间
FtpResourceID = objvMicroteachCaseSiteSenateENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvMicroteachCaseSiteSenateENS.FileOriginalName, //文件原名
FileDirName = objvMicroteachCaseSiteSenateENS.FileDirName, //文件目录名
FileRename = objvMicroteachCaseSiteSenateENS.FileRename, //文件新名
FileUpDate = objvMicroteachCaseSiteSenateENS.FileUpDate, //创建日期
FileUpTime = objvMicroteachCaseSiteSenateENS.FileUpTime, //创建时间
SaveMode = objvMicroteachCaseSiteSenateENS.SaveMode, //文件存放方式
IdResourceType = objvMicroteachCaseSiteSenateENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvMicroteachCaseSiteSenateENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvMicroteachCaseSiteSenateENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvMicroteachCaseSiteSenateENS.ResourceOwner, //上传者
ftpFileType = objvMicroteachCaseSiteSenateENS.ftpFileType, //ftp文件类型
ftpFileSize = objvMicroteachCaseSiteSenateENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvMicroteachCaseSiteSenateENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvMicroteachCaseSiteSenateENS.FileOriginName, //原文件名
IsExistFile = objvMicroteachCaseSiteSenateENS.IsExistFile, //是否存在文件
FileNewName = objvMicroteachCaseSiteSenateENS.FileNewName, //新文件名
FileOldName = objvMicroteachCaseSiteSenateENS.FileOldName, //旧文件名
SiteSenateSenator = objvMicroteachCaseSiteSenateENS.SiteSenateSenator, //评议者
SiteSenateTitle = objvMicroteachCaseSiteSenateENS.SiteSenateTitle, //评议名称
SiteSenateContent = objvMicroteachCaseSiteSenateENS.SiteSenateContent, //现场评议内容
SiteSenateData = objvMicroteachCaseSiteSenateENS.SiteSenateData, //现场评议日期
SiteSenateTime = objvMicroteachCaseSiteSenateENS.SiteSenateTime, //现场评议时间
SiteSenateReadCount = objvMicroteachCaseSiteSenateENS.SiteSenateReadCount, //现场评议阅读次数
Memo = objvMicroteachCaseSiteSenateENS.Memo, //备注
};
 return objvMicroteachCaseSiteSenateENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
 clsvMicroteachCaseSiteSenateBL.vMicroteachCaseSiteSenateDA.CheckProperty4Condition(objvMicroteachCaseSiteSenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate) == true)
{
string strComparisonOpIdMicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, objvMicroteachCaseSiteSenateCond.IdMicroteachCaseSiteSenate, strComparisonOpIdMicroteachCaseSiteSenate);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FuncModuleId, objvMicroteachCaseSiteSenateCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FuncModuleName, objvMicroteachCaseSiteSenateCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdMicroteachCase, objvMicroteachCaseSiteSenateCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseID, objvMicroteachCaseSiteSenateCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseName, objvMicroteachCaseSiteSenateCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseTheme, objvMicroteachCaseSiteSenateCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseDate, objvMicroteachCaseSiteSenateCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseTime, objvMicroteachCaseSiteSenateCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseDateIn, objvMicroteachCaseSiteSenateCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdStudyLevel, objvMicroteachCaseSiteSenateCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StudyLevelName, objvMicroteachCaseSiteSenateCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdTeachingPlan, objvMicroteachCaseSiteSenateCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn, objvMicroteachCaseSiteSenateCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IsVisible) == true)
{
if (objvMicroteachCaseSiteSenateCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseSiteSenate.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseSiteSenate.IsVisible);
}
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.microteachCaseText, objvMicroteachCaseSiteSenateCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.OwnerId, objvMicroteachCaseSiteSenateCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.StuName) == true)
{
string strComparisonOpStuName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuName, objvMicroteachCaseSiteSenateCond.StuName, strComparisonOpStuName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.StuID) == true)
{
string strComparisonOpStuID = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuID, objvMicroteachCaseSiteSenateCond.StuID, strComparisonOpStuID);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.PoliticsName, objvMicroteachCaseSiteSenateCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SexDesc) == true)
{
string strComparisonOpSexDesc = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SexDesc, objvMicroteachCaseSiteSenateCond.SexDesc, strComparisonOpSexDesc);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.EthnicName) == true)
{
string strComparisonOpEthnicName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.EthnicName, objvMicroteachCaseSiteSenateCond.EthnicName, strComparisonOpEthnicName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.UniZoneDesc, objvMicroteachCaseSiteSenateCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuTypeDesc, objvMicroteachCaseSiteSenateCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdXzCollege, objvMicroteachCaseSiteSenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.CollegeName, objvMicroteachCaseSiteSenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdXzMajor, objvMicroteachCaseSiteSenateCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MajorName) == true)
{
string strComparisonOpMajorName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MajorName, objvMicroteachCaseSiteSenateCond.MajorName, strComparisonOpMajorName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdGradeBase, objvMicroteachCaseSiteSenateCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.GradeBaseName, objvMicroteachCaseSiteSenateCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.Birthday) == true)
{
string strComparisonOpBirthday = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.Birthday, objvMicroteachCaseSiteSenateCond.Birthday, strComparisonOpBirthday);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.NativePlace) == true)
{
string strComparisonOpNativePlace = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.NativePlace, objvMicroteachCaseSiteSenateCond.NativePlace, strComparisonOpNativePlace);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.Duty) == true)
{
string strComparisonOpDuty = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.Duty, objvMicroteachCaseSiteSenateCond.Duty, strComparisonOpDuty);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IDCardNo) == true)
{
string strComparisonOpIDCardNo = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IDCardNo, objvMicroteachCaseSiteSenateCond.IDCardNo, strComparisonOpIDCardNo);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuCardNo, objvMicroteachCaseSiteSenateCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.LiveAddress, objvMicroteachCaseSiteSenateCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.HomePhone) == true)
{
string strComparisonOpHomePhone = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.HomePhone, objvMicroteachCaseSiteSenateCond.HomePhone, strComparisonOpHomePhone);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.EnrollmentDate, objvMicroteachCaseSiteSenateCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.PostCode) == true)
{
string strComparisonOpPostCode = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.PostCode, objvMicroteachCaseSiteSenateCond.PostCode, strComparisonOpPostCode);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseSiteSenate.BrowseCount4Case, objvMicroteachCaseSiteSenateCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType) == true)
{
string strComparisonOpIdMicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, objvMicroteachCaseSiteSenateCond.IdMicroteachCaseSiteSenateType, strComparisonOpIdMicroteachCaseSiteSenateType);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID) == true)
{
string strComparisonOpMicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID, objvMicroteachCaseSiteSenateCond.MicroteachCaseSiteSenateTypeID, strComparisonOpMicroteachCaseSiteSenateTypeID);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName) == true)
{
string strComparisonOpMicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName, objvMicroteachCaseSiteSenateCond.MicroteachCaseSiteSenateTypeName, strComparisonOpMicroteachCaseSiteSenateTypeName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdResource) == true)
{
string strComparisonOpIdResource = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdResource, objvMicroteachCaseSiteSenateCond.IdResource, strComparisonOpIdResource);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ResourceID) == true)
{
string strComparisonOpResourceID = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceID, objvMicroteachCaseSiteSenateCond.ResourceID, strComparisonOpResourceID);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ResourceName) == true)
{
string strComparisonOpResourceName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceName, objvMicroteachCaseSiteSenateCond.ResourceName, strComparisonOpResourceName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdFtpResource, objvMicroteachCaseSiteSenateCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdFile) == true)
{
string strComparisonOpIdFile = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdFile, objvMicroteachCaseSiteSenateCond.IdFile, strComparisonOpIdFile);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileName) == true)
{
string strComparisonOpFileName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileName, objvMicroteachCaseSiteSenateCond.FileName, strComparisonOpFileName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileType) == true)
{
string strComparisonOpFileType = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileType, objvMicroteachCaseSiteSenateCond.FileType, strComparisonOpFileType);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SaveDate) == true)
{
string strComparisonOpSaveDate = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SaveDate, objvMicroteachCaseSiteSenateCond.SaveDate, strComparisonOpSaveDate);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileSize) == true)
{
string strComparisonOpFileSize = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileSize, objvMicroteachCaseSiteSenateCond.FileSize, strComparisonOpFileSize);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SaveTime) == true)
{
string strComparisonOpSaveTime = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SaveTime, objvMicroteachCaseSiteSenateCond.SaveTime, strComparisonOpSaveTime);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FtpResourceID, objvMicroteachCaseSiteSenateCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileOriginalName, objvMicroteachCaseSiteSenateCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileDirName) == true)
{
string strComparisonOpFileDirName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileDirName, objvMicroteachCaseSiteSenateCond.FileDirName, strComparisonOpFileDirName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileRename) == true)
{
string strComparisonOpFileRename = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileRename, objvMicroteachCaseSiteSenateCond.FileRename, strComparisonOpFileRename);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileUpDate, objvMicroteachCaseSiteSenateCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileUpTime, objvMicroteachCaseSiteSenateCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SaveMode) == true)
{
if (objvMicroteachCaseSiteSenateCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseSiteSenate.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseSiteSenate.SaveMode);
}
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IdResourceType, objvMicroteachCaseSiteSenateCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceTypeID, objvMicroteachCaseSiteSenateCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceTypeName, objvMicroteachCaseSiteSenateCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceOwner, objvMicroteachCaseSiteSenateCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ftpFileType, objvMicroteachCaseSiteSenateCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ftpFileSize, objvMicroteachCaseSiteSenateCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ftpResourceOwner, objvMicroteachCaseSiteSenateCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileOriginName, objvMicroteachCaseSiteSenateCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.IsExistFile) == true)
{
if (objvMicroteachCaseSiteSenateCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseSiteSenate.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseSiteSenate.IsExistFile);
}
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileNewName) == true)
{
string strComparisonOpFileNewName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileNewName, objvMicroteachCaseSiteSenateCond.FileNewName, strComparisonOpFileNewName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.FileOldName) == true)
{
string strComparisonOpFileOldName = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileOldName, objvMicroteachCaseSiteSenateCond.FileOldName, strComparisonOpFileOldName);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateSenator) == true)
{
string strComparisonOpSiteSenateSenator = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateSenator, objvMicroteachCaseSiteSenateCond.SiteSenateSenator, strComparisonOpSiteSenateSenator);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateTitle) == true)
{
string strComparisonOpSiteSenateTitle = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateTitle, objvMicroteachCaseSiteSenateCond.SiteSenateTitle, strComparisonOpSiteSenateTitle);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateContent) == true)
{
string strComparisonOpSiteSenateContent = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateContent, objvMicroteachCaseSiteSenateCond.SiteSenateContent, strComparisonOpSiteSenateContent);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateData) == true)
{
string strComparisonOpSiteSenateData = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateData];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateData, objvMicroteachCaseSiteSenateCond.SiteSenateData, strComparisonOpSiteSenateData);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateTime) == true)
{
string strComparisonOpSiteSenateTime = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateTime, objvMicroteachCaseSiteSenateCond.SiteSenateTime, strComparisonOpSiteSenateTime);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateReadCount) == true)
{
string strComparisonOpSiteSenateReadCount = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseSiteSenate.SiteSenateReadCount, objvMicroteachCaseSiteSenateCond.SiteSenateReadCount, strComparisonOpSiteSenateReadCount);
}
if (objvMicroteachCaseSiteSenateCond.IsUpdated(convMicroteachCaseSiteSenate.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[convMicroteachCaseSiteSenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.Memo, objvMicroteachCaseSiteSenateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCaseSiteSenate
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseSiteSenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格教学现场评议(vMicroteachCaseSiteSenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseSiteSenateBL
{
public static RelatedActions_vMicroteachCaseSiteSenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCaseSiteSenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCaseSiteSenateDA vMicroteachCaseSiteSenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCaseSiteSenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCaseSiteSenateBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCaseSiteSenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseSiteSenateEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCaseSiteSenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCaseSiteSenateDA.GetDataTable_vMicroteachCaseSiteSenate(strWhereCond);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCaseSiteSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseSiteSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByIdMicroteachCaseSiteSenateLst(List<long> arrIdMicroteachCaseSiteSenateLst)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseSiteSenateLst);
 string strWhereCond = string.Format("IdMicroteachCaseSiteSenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseSiteSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCaseSiteSenateEN> GetObjLstByIdMicroteachCaseSiteSenateLstCache(List<long> arrIdMicroteachCaseSiteSenateLst)
{
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName);
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Sel =
arrvMicroteachCaseSiteSenateObjLstCache
.Where(x => arrIdMicroteachCaseSiteSenateLst.Contains(x.IdMicroteachCaseSiteSenate));
return arrvMicroteachCaseSiteSenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCaseSiteSenateEN> GetSubObjLstCache(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateCond)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseSiteSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseSiteSenate.AttributeName)
{
if (objvMicroteachCaseSiteSenateCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseSiteSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseSiteSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseSiteSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseSiteSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseSiteSenateCond[strFldName]));
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
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
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCaseSiteSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
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
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCaseSiteSenate(ref clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
bool bolResult = vMicroteachCaseSiteSenateDA.GetvMicroteachCaseSiteSenate(ref objvMicroteachCaseSiteSenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenate(long lngIdMicroteachCaseSiteSenate)
{
clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = vMicroteachCaseSiteSenateDA.GetObjByIdMicroteachCaseSiteSenate(lngIdMicroteachCaseSiteSenate);
return objvMicroteachCaseSiteSenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = vMicroteachCaseSiteSenateDA.GetFirstObj(strWhereCond);
 return objvMicroteachCaseSiteSenateEN;
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
public static clsvMicroteachCaseSiteSenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = vMicroteachCaseSiteSenateDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseSiteSenateEN;
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
public static clsvMicroteachCaseSiteSenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = vMicroteachCaseSiteSenateDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseSiteSenateEN;
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
 /// <param name = "lngIdMicroteachCaseSiteSenate">所给的关键字</param>
 /// <param name = "lstvMicroteachCaseSiteSenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenateFromList(long lngIdMicroteachCaseSiteSenate, List<clsvMicroteachCaseSiteSenateEN> lstvMicroteachCaseSiteSenateObjLst)
{
foreach (clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN in lstvMicroteachCaseSiteSenateObjLst)
{
if (objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == lngIdMicroteachCaseSiteSenate)
{
return objvMicroteachCaseSiteSenateEN;
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
 long lngIdMicroteachCaseSiteSenate;
 try
 {
 lngIdMicroteachCaseSiteSenate = new clsvMicroteachCaseSiteSenateDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseSiteSenate;
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
 arrList = vMicroteachCaseSiteSenateDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCaseSiteSenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseSiteSenate)
{
//检测记录是否存在
bool bolIsExist = vMicroteachCaseSiteSenateDA.IsExist(lngIdMicroteachCaseSiteSenate);
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
 bolIsExist = clsvMicroteachCaseSiteSenateDA.IsExistTable();
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
 bolIsExist = vMicroteachCaseSiteSenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCaseSiteSenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseSiteSenateENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENS, clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENT)
{
try
{
objvMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate; //微格现场评议流水号
objvMicroteachCaseSiteSenateENT.FuncModuleId = objvMicroteachCaseSiteSenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseSiteSenateENT.FuncModuleName = objvMicroteachCaseSiteSenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseSiteSenateENT.IdMicroteachCase = objvMicroteachCaseSiteSenateENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseID = objvMicroteachCaseSiteSenateENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseName = objvMicroteachCaseSiteSenateENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseSiteSenateENT.MicroteachCaseTheme = objvMicroteachCaseSiteSenateENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCaseSiteSenateENT.MicroteachCaseDate = objvMicroteachCaseSiteSenateENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCaseSiteSenateENT.MicroteachCaseTime = objvMicroteachCaseSiteSenateENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCaseSiteSenateENT.MicroteachCaseDateIn = objvMicroteachCaseSiteSenateENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCaseSiteSenateENT.IdStudyLevel = objvMicroteachCaseSiteSenateENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCaseSiteSenateENT.StudyLevelName = objvMicroteachCaseSiteSenateENS.StudyLevelName; //学段名称
objvMicroteachCaseSiteSenateENT.IdTeachingPlan = objvMicroteachCaseSiteSenateENS.IdTeachingPlan; //教案流水号
objvMicroteachCaseSiteSenateENT.MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCaseSiteSenateENT.IsVisible = objvMicroteachCaseSiteSenateENS.IsVisible; //是否显示
objvMicroteachCaseSiteSenateENT.microteachCaseText = objvMicroteachCaseSiteSenateENS.microteachCaseText; //案例文本内容
objvMicroteachCaseSiteSenateENT.OwnerId = objvMicroteachCaseSiteSenateENS.OwnerId; //拥有者Id
objvMicroteachCaseSiteSenateENT.StuName = objvMicroteachCaseSiteSenateENS.StuName; //姓名
objvMicroteachCaseSiteSenateENT.StuID = objvMicroteachCaseSiteSenateENS.StuID; //学号
objvMicroteachCaseSiteSenateENT.PoliticsName = objvMicroteachCaseSiteSenateENS.PoliticsName; //政治面貌
objvMicroteachCaseSiteSenateENT.SexDesc = objvMicroteachCaseSiteSenateENS.SexDesc; //性别名称
objvMicroteachCaseSiteSenateENT.EthnicName = objvMicroteachCaseSiteSenateENS.EthnicName; //民族名称
objvMicroteachCaseSiteSenateENT.UniZoneDesc = objvMicroteachCaseSiteSenateENS.UniZoneDesc; //校区名称
objvMicroteachCaseSiteSenateENT.StuTypeDesc = objvMicroteachCaseSiteSenateENS.StuTypeDesc; //学生类别名称
objvMicroteachCaseSiteSenateENT.IdXzCollege = objvMicroteachCaseSiteSenateENS.IdXzCollege; //学院流水号
objvMicroteachCaseSiteSenateENT.CollegeName = objvMicroteachCaseSiteSenateENS.CollegeName; //学院名称
objvMicroteachCaseSiteSenateENT.IdXzMajor = objvMicroteachCaseSiteSenateENS.IdXzMajor; //专业流水号
objvMicroteachCaseSiteSenateENT.MajorName = objvMicroteachCaseSiteSenateENS.MajorName; //专业名称
objvMicroteachCaseSiteSenateENT.IdGradeBase = objvMicroteachCaseSiteSenateENS.IdGradeBase; //年级流水号
objvMicroteachCaseSiteSenateENT.GradeBaseName = objvMicroteachCaseSiteSenateENS.GradeBaseName; //年级名称
objvMicroteachCaseSiteSenateENT.Birthday = objvMicroteachCaseSiteSenateENS.Birthday; //出生日期
objvMicroteachCaseSiteSenateENT.NativePlace = objvMicroteachCaseSiteSenateENS.NativePlace; //籍贯
objvMicroteachCaseSiteSenateENT.Duty = objvMicroteachCaseSiteSenateENS.Duty; //职位
objvMicroteachCaseSiteSenateENT.IDCardNo = objvMicroteachCaseSiteSenateENS.IDCardNo; //身份证号
objvMicroteachCaseSiteSenateENT.StuCardNo = objvMicroteachCaseSiteSenateENS.StuCardNo; //学生证号
objvMicroteachCaseSiteSenateENT.LiveAddress = objvMicroteachCaseSiteSenateENS.LiveAddress; //居住地址
objvMicroteachCaseSiteSenateENT.HomePhone = objvMicroteachCaseSiteSenateENS.HomePhone; //住宅电话
objvMicroteachCaseSiteSenateENT.EnrollmentDate = objvMicroteachCaseSiteSenateENS.EnrollmentDate; //入校日期
objvMicroteachCaseSiteSenateENT.PostCode = objvMicroteachCaseSiteSenateENS.PostCode; //邮编
objvMicroteachCaseSiteSenateENT.BrowseCount4Case = objvMicroteachCaseSiteSenateENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
objvMicroteachCaseSiteSenateENT.IdResource = objvMicroteachCaseSiteSenateENS.IdResource; //资源流水号
objvMicroteachCaseSiteSenateENT.ResourceID = objvMicroteachCaseSiteSenateENS.ResourceID; //资源ID
objvMicroteachCaseSiteSenateENT.ResourceName = objvMicroteachCaseSiteSenateENS.ResourceName; //资源名称
objvMicroteachCaseSiteSenateENT.IdFtpResource = objvMicroteachCaseSiteSenateENS.IdFtpResource; //FTP资源流水号
objvMicroteachCaseSiteSenateENT.IdFile = objvMicroteachCaseSiteSenateENS.IdFile; //文件流水号
objvMicroteachCaseSiteSenateENT.FileName = objvMicroteachCaseSiteSenateENS.FileName; //文件名称
objvMicroteachCaseSiteSenateENT.FileType = objvMicroteachCaseSiteSenateENS.FileType; //文件类型
objvMicroteachCaseSiteSenateENT.SaveDate = objvMicroteachCaseSiteSenateENS.SaveDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileSize = objvMicroteachCaseSiteSenateENS.FileSize; //文件大小
objvMicroteachCaseSiteSenateENT.SaveTime = objvMicroteachCaseSiteSenateENS.SaveTime; //创建时间
objvMicroteachCaseSiteSenateENT.FtpResourceID = objvMicroteachCaseSiteSenateENS.FtpResourceID; //FTP资源ID
objvMicroteachCaseSiteSenateENT.FileOriginalName = objvMicroteachCaseSiteSenateENS.FileOriginalName; //文件原名
objvMicroteachCaseSiteSenateENT.FileDirName = objvMicroteachCaseSiteSenateENS.FileDirName; //文件目录名
objvMicroteachCaseSiteSenateENT.FileRename = objvMicroteachCaseSiteSenateENS.FileRename; //文件新名
objvMicroteachCaseSiteSenateENT.FileUpDate = objvMicroteachCaseSiteSenateENS.FileUpDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileUpTime = objvMicroteachCaseSiteSenateENS.FileUpTime; //创建时间
objvMicroteachCaseSiteSenateENT.SaveMode = objvMicroteachCaseSiteSenateENS.SaveMode; //文件存放方式
objvMicroteachCaseSiteSenateENT.IdResourceType = objvMicroteachCaseSiteSenateENS.IdResourceType; //资源类型流水号
objvMicroteachCaseSiteSenateENT.ResourceTypeID = objvMicroteachCaseSiteSenateENS.ResourceTypeID; //资源类型ID
objvMicroteachCaseSiteSenateENT.ResourceTypeName = objvMicroteachCaseSiteSenateENS.ResourceTypeName; //资源类型名称
objvMicroteachCaseSiteSenateENT.ResourceOwner = objvMicroteachCaseSiteSenateENS.ResourceOwner; //上传者
objvMicroteachCaseSiteSenateENT.ftpFileType = objvMicroteachCaseSiteSenateENS.ftpFileType; //ftp文件类型
objvMicroteachCaseSiteSenateENT.ftpFileSize = objvMicroteachCaseSiteSenateENS.ftpFileSize; //ftp文件大小
objvMicroteachCaseSiteSenateENT.ftpResourceOwner = objvMicroteachCaseSiteSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCaseSiteSenateENT.FileOriginName = objvMicroteachCaseSiteSenateENS.FileOriginName; //原文件名
objvMicroteachCaseSiteSenateENT.IsExistFile = objvMicroteachCaseSiteSenateENS.IsExistFile; //是否存在文件
objvMicroteachCaseSiteSenateENT.FileNewName = objvMicroteachCaseSiteSenateENS.FileNewName; //新文件名
objvMicroteachCaseSiteSenateENT.FileOldName = objvMicroteachCaseSiteSenateENS.FileOldName; //旧文件名
objvMicroteachCaseSiteSenateENT.SiteSenateSenator = objvMicroteachCaseSiteSenateENS.SiteSenateSenator; //评议者
objvMicroteachCaseSiteSenateENT.SiteSenateTitle = objvMicroteachCaseSiteSenateENS.SiteSenateTitle; //评议名称
objvMicroteachCaseSiteSenateENT.SiteSenateContent = objvMicroteachCaseSiteSenateENS.SiteSenateContent; //现场评议内容
objvMicroteachCaseSiteSenateENT.SiteSenateData = objvMicroteachCaseSiteSenateENS.SiteSenateData; //现场评议日期
objvMicroteachCaseSiteSenateENT.SiteSenateTime = objvMicroteachCaseSiteSenateENS.SiteSenateTime; //现场评议时间
objvMicroteachCaseSiteSenateENT.SiteSenateReadCount = objvMicroteachCaseSiteSenateENS.SiteSenateReadCount; //现场评议阅读次数
objvMicroteachCaseSiteSenateENT.Memo = objvMicroteachCaseSiteSenateENS.Memo; //备注
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
 /// <param name = "objvMicroteachCaseSiteSenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
try
{
objvMicroteachCaseSiteSenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCaseSiteSenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate; //微格现场评议流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FuncModuleId = objvMicroteachCaseSiteSenateEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FuncModuleName = objvMicroteachCaseSiteSenateEN.FuncModuleName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objvMicroteachCaseSiteSenateEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objvMicroteachCaseSiteSenateEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objvMicroteachCaseSiteSenateEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objvMicroteachCaseSiteSenateEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objvMicroteachCaseSiteSenateEN.MicroteachCaseTime == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objvMicroteachCaseSiteSenateEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.StudyLevelName = objvMicroteachCaseSiteSenateEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objvMicroteachCaseSiteSenateEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IsVisible = objvMicroteachCaseSiteSenateEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.microteachCaseText = objvMicroteachCaseSiteSenateEN.microteachCaseText == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.OwnerId = objvMicroteachCaseSiteSenateEN.OwnerId == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.StuName = objvMicroteachCaseSiteSenateEN.StuName; //姓名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.StuID = objvMicroteachCaseSiteSenateEN.StuID; //学号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.PoliticsName = objvMicroteachCaseSiteSenateEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SexDesc = objvMicroteachCaseSiteSenateEN.SexDesc == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.EthnicName = objvMicroteachCaseSiteSenateEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objvMicroteachCaseSiteSenateEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objvMicroteachCaseSiteSenateEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdXzCollege = objvMicroteachCaseSiteSenateEN.IdXzCollege == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.CollegeName = objvMicroteachCaseSiteSenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdXzMajor = objvMicroteachCaseSiteSenateEN.IdXzMajor == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MajorName = objvMicroteachCaseSiteSenateEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdGradeBase = objvMicroteachCaseSiteSenateEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.GradeBaseName = objvMicroteachCaseSiteSenateEN.GradeBaseName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.Birthday = objvMicroteachCaseSiteSenateEN.Birthday == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.NativePlace = objvMicroteachCaseSiteSenateEN.NativePlace == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.Duty = objvMicroteachCaseSiteSenateEN.Duty == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.Duty; //职位
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IDCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IDCardNo = objvMicroteachCaseSiteSenateEN.IDCardNo == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.IDCardNo; //身份证号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.StuCardNo = objvMicroteachCaseSiteSenateEN.StuCardNo == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.LiveAddress = objvMicroteachCaseSiteSenateEN.LiveAddress == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.HomePhone = objvMicroteachCaseSiteSenateEN.HomePhone == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objvMicroteachCaseSiteSenateEN.EnrollmentDate == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.PostCode = objvMicroteachCaseSiteSenateEN.PostCode == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.PostCode; //邮编
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objvMicroteachCaseSiteSenateEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdResource = objvMicroteachCaseSiteSenateEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ResourceID = objvMicroteachCaseSiteSenateEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ResourceName = objvMicroteachCaseSiteSenateEN.ResourceName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdFtpResource = objvMicroteachCaseSiteSenateEN.IdFtpResource == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdFile = objvMicroteachCaseSiteSenateEN.IdFile == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileName = objvMicroteachCaseSiteSenateEN.FileName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileName; //文件名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileType = objvMicroteachCaseSiteSenateEN.FileType == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileType; //文件类型
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SaveDate = objvMicroteachCaseSiteSenateEN.SaveDate == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileSize = objvMicroteachCaseSiteSenateEN.FileSize == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SaveTime = objvMicroteachCaseSiteSenateEN.SaveTime == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FtpResourceID = objvMicroteachCaseSiteSenateEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileOriginalName = objvMicroteachCaseSiteSenateEN.FileOriginalName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileDirName = objvMicroteachCaseSiteSenateEN.FileDirName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileRename = objvMicroteachCaseSiteSenateEN.FileRename == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileUpDate = objvMicroteachCaseSiteSenateEN.FileUpDate == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileUpTime = objvMicroteachCaseSiteSenateEN.FileUpTime == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SaveMode = objvMicroteachCaseSiteSenateEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IdResourceType = objvMicroteachCaseSiteSenateEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objvMicroteachCaseSiteSenateEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objvMicroteachCaseSiteSenateEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ResourceOwner = objvMicroteachCaseSiteSenateEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ftpFileType = objvMicroteachCaseSiteSenateEN.ftpFileType == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ftpFileSize = objvMicroteachCaseSiteSenateEN.ftpFileSize == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objvMicroteachCaseSiteSenateEN.ftpResourceOwner == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileOriginName = objvMicroteachCaseSiteSenateEN.FileOriginName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.IsExistFile = objvMicroteachCaseSiteSenateEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileNewName = objvMicroteachCaseSiteSenateEN.FileNewName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.FileOldName = objvMicroteachCaseSiteSenateEN.FileOldName == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SiteSenateSenator, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objvMicroteachCaseSiteSenateEN.SiteSenateSenator == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SiteSenateSenator; //评议者
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SiteSenateTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objvMicroteachCaseSiteSenateEN.SiteSenateTitle; //评议名称
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SiteSenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objvMicroteachCaseSiteSenateEN.SiteSenateContent == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SiteSenateContent; //现场评议内容
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SiteSenateData, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SiteSenateData = objvMicroteachCaseSiteSenateEN.SiteSenateData == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SiteSenateData; //现场评议日期
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SiteSenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objvMicroteachCaseSiteSenateEN.SiteSenateTime == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.SiteSenateTime; //现场评议时间
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.SiteSenateReadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objvMicroteachCaseSiteSenateEN.SiteSenateReadCount; //现场评议阅读次数
}
if (arrFldSet.Contains(convMicroteachCaseSiteSenate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseSiteSenateEN.Memo = objvMicroteachCaseSiteSenateEN.Memo == "[null]" ? null :  objvMicroteachCaseSiteSenateEN.Memo; //备注
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
 /// <param name = "objvMicroteachCaseSiteSenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
try
{
if (objvMicroteachCaseSiteSenateEN.FuncModuleName == "[null]") objvMicroteachCaseSiteSenateEN.FuncModuleName = null; //功能模块名称
if (objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme == "[null]") objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroteachCaseSiteSenateEN.MicroteachCaseDate == "[null]") objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCaseSiteSenateEN.MicroteachCaseTime == "[null]") objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn == "[null]") objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn == "[null]") objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroteachCaseSiteSenateEN.microteachCaseText == "[null]") objvMicroteachCaseSiteSenateEN.microteachCaseText = null; //案例文本内容
if (objvMicroteachCaseSiteSenateEN.OwnerId == "[null]") objvMicroteachCaseSiteSenateEN.OwnerId = null; //拥有者Id
if (objvMicroteachCaseSiteSenateEN.SexDesc == "[null]") objvMicroteachCaseSiteSenateEN.SexDesc = null; //性别名称
if (objvMicroteachCaseSiteSenateEN.IdXzCollege == "[null]") objvMicroteachCaseSiteSenateEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCaseSiteSenateEN.IdXzMajor == "[null]") objvMicroteachCaseSiteSenateEN.IdXzMajor = null; //专业流水号
if (objvMicroteachCaseSiteSenateEN.GradeBaseName == "[null]") objvMicroteachCaseSiteSenateEN.GradeBaseName = null; //年级名称
if (objvMicroteachCaseSiteSenateEN.Birthday == "[null]") objvMicroteachCaseSiteSenateEN.Birthday = null; //出生日期
if (objvMicroteachCaseSiteSenateEN.NativePlace == "[null]") objvMicroteachCaseSiteSenateEN.NativePlace = null; //籍贯
if (objvMicroteachCaseSiteSenateEN.Duty == "[null]") objvMicroteachCaseSiteSenateEN.Duty = null; //职位
if (objvMicroteachCaseSiteSenateEN.IDCardNo == "[null]") objvMicroteachCaseSiteSenateEN.IDCardNo = null; //身份证号
if (objvMicroteachCaseSiteSenateEN.StuCardNo == "[null]") objvMicroteachCaseSiteSenateEN.StuCardNo = null; //学生证号
if (objvMicroteachCaseSiteSenateEN.LiveAddress == "[null]") objvMicroteachCaseSiteSenateEN.LiveAddress = null; //居住地址
if (objvMicroteachCaseSiteSenateEN.HomePhone == "[null]") objvMicroteachCaseSiteSenateEN.HomePhone = null; //住宅电话
if (objvMicroteachCaseSiteSenateEN.EnrollmentDate == "[null]") objvMicroteachCaseSiteSenateEN.EnrollmentDate = null; //入校日期
if (objvMicroteachCaseSiteSenateEN.PostCode == "[null]") objvMicroteachCaseSiteSenateEN.PostCode = null; //邮编
if (objvMicroteachCaseSiteSenateEN.ResourceName == "[null]") objvMicroteachCaseSiteSenateEN.ResourceName = null; //资源名称
if (objvMicroteachCaseSiteSenateEN.IdFtpResource == "[null]") objvMicroteachCaseSiteSenateEN.IdFtpResource = null; //FTP资源流水号
if (objvMicroteachCaseSiteSenateEN.IdFile == "[null]") objvMicroteachCaseSiteSenateEN.IdFile = null; //文件流水号
if (objvMicroteachCaseSiteSenateEN.FileName == "[null]") objvMicroteachCaseSiteSenateEN.FileName = null; //文件名称
if (objvMicroteachCaseSiteSenateEN.FileType == "[null]") objvMicroteachCaseSiteSenateEN.FileType = null; //文件类型
if (objvMicroteachCaseSiteSenateEN.SaveDate == "[null]") objvMicroteachCaseSiteSenateEN.SaveDate = null; //创建日期
if (objvMicroteachCaseSiteSenateEN.FileSize == "[null]") objvMicroteachCaseSiteSenateEN.FileSize = null; //文件大小
if (objvMicroteachCaseSiteSenateEN.SaveTime == "[null]") objvMicroteachCaseSiteSenateEN.SaveTime = null; //创建时间
if (objvMicroteachCaseSiteSenateEN.FileOriginalName == "[null]") objvMicroteachCaseSiteSenateEN.FileOriginalName = null; //文件原名
if (objvMicroteachCaseSiteSenateEN.FileDirName == "[null]") objvMicroteachCaseSiteSenateEN.FileDirName = null; //文件目录名
if (objvMicroteachCaseSiteSenateEN.FileRename == "[null]") objvMicroteachCaseSiteSenateEN.FileRename = null; //文件新名
if (objvMicroteachCaseSiteSenateEN.FileUpDate == "[null]") objvMicroteachCaseSiteSenateEN.FileUpDate = null; //创建日期
if (objvMicroteachCaseSiteSenateEN.FileUpTime == "[null]") objvMicroteachCaseSiteSenateEN.FileUpTime = null; //创建时间
if (objvMicroteachCaseSiteSenateEN.ftpFileType == "[null]") objvMicroteachCaseSiteSenateEN.ftpFileType = null; //ftp文件类型
if (objvMicroteachCaseSiteSenateEN.ftpFileSize == "[null]") objvMicroteachCaseSiteSenateEN.ftpFileSize = null; //ftp文件大小
if (objvMicroteachCaseSiteSenateEN.ftpResourceOwner == "[null]") objvMicroteachCaseSiteSenateEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvMicroteachCaseSiteSenateEN.FileOriginName == "[null]") objvMicroteachCaseSiteSenateEN.FileOriginName = null; //原文件名
if (objvMicroteachCaseSiteSenateEN.FileNewName == "[null]") objvMicroteachCaseSiteSenateEN.FileNewName = null; //新文件名
if (objvMicroteachCaseSiteSenateEN.FileOldName == "[null]") objvMicroteachCaseSiteSenateEN.FileOldName = null; //旧文件名
if (objvMicroteachCaseSiteSenateEN.SiteSenateSenator == "[null]") objvMicroteachCaseSiteSenateEN.SiteSenateSenator = null; //评议者
if (objvMicroteachCaseSiteSenateEN.SiteSenateContent == "[null]") objvMicroteachCaseSiteSenateEN.SiteSenateContent = null; //现场评议内容
if (objvMicroteachCaseSiteSenateEN.SiteSenateData == "[null]") objvMicroteachCaseSiteSenateEN.SiteSenateData = null; //现场评议日期
if (objvMicroteachCaseSiteSenateEN.SiteSenateTime == "[null]") objvMicroteachCaseSiteSenateEN.SiteSenateTime = null; //现场评议时间
if (objvMicroteachCaseSiteSenateEN.Memo == "[null]") objvMicroteachCaseSiteSenateEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
 vMicroteachCaseSiteSenateDA.CheckProperty4Condition(objvMicroteachCaseSiteSenateEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseSiteSenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseSiteSenateBL没有刷新缓存机制(clsMicroteachCaseSiteSenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseSiteSenateTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseSiteSenateTypeBL没有刷新缓存机制(clsMicroteachCaseSiteSenateTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseBL没有刷新缓存机制(clsMicroteachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeBL没有刷新缓存机制(clsMicroteachCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseSiteSenate");
//if (arrvMicroteachCaseSiteSenateObjLstCache == null)
//{
//arrvMicroteachCaseSiteSenateObjLstCache = vMicroteachCaseSiteSenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenateCache(long lngIdMicroteachCaseSiteSenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName);
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Sel =
arrvMicroteachCaseSiteSenateObjLstCache
.Where(x=> x.IdMicroteachCaseSiteSenate == lngIdMicroteachCaseSiteSenate 
);
if (arrvMicroteachCaseSiteSenateObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseSiteSenateEN obj = clsvMicroteachCaseSiteSenateBL.GetObjByIdMicroteachCaseSiteSenate(lngIdMicroteachCaseSiteSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCaseSiteSenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetAllvMicroteachCaseSiteSenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLstCache = GetObjLstCache(); 
return arrvMicroteachCaseSiteSenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName);
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseSiteSenateObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseSiteSenate)
{
if (strInFldName != convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCaseSiteSenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCaseSiteSenate.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCaseSiteSenate = clsvMicroteachCaseSiteSenateBL.GetObjByIdMicroteachCaseSiteSenateCache(lngIdMicroteachCaseSiteSenate);
if (objvMicroteachCaseSiteSenate == null) return "";
return objvMicroteachCaseSiteSenate[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCaseSiteSenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCaseSiteSenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCaseSiteSenateDA.GetRecCount();
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
int intRecCount = clsvMicroteachCaseSiteSenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateCond)
{
List<clsvMicroteachCaseSiteSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseSiteSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseSiteSenate.AttributeName)
{
if (objvMicroteachCaseSiteSenateCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseSiteSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseSiteSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseSiteSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseSiteSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseSiteSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseSiteSenateCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCaseSiteSenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseSiteSenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseSiteSenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}