
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4AllBL
 表名:vMicroteachCase4All(01120327)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvMicroteachCase4AllBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4AllEN GetObj(this K_IdMicroteachCase_vMicroteachCase4All myKey)
{
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = clsvMicroteachCase4AllBL.vMicroteachCase4AllDA.GetObjByIdMicroteachCase(myKey.Value);
return objvMicroteachCase4AllEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdMicroteachCase(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase4All.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase4All.IdMicroteachCase);
}
objvMicroteachCase4AllEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdMicroteachCase) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseTypeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, convMicroteachCase4All.MicroteachCaseTypeName);
}
objvMicroteachCase4AllEN.MicroteachCaseTypeName = strMicroteachCaseTypeName; //微格案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseTypeName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseTypeName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTypeName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCase4All.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase4All.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase4All.MicroteachCaseID);
}
objvMicroteachCase4AllEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseID) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCase4All.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase4All.MicroteachCaseName);
}
objvMicroteachCase4AllEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseTheme(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase4All.MicroteachCaseTheme);
}
objvMicroteachCase4AllEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseTheme) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseDate(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase4All.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase4All.MicroteachCaseDate);
}
objvMicroteachCase4AllEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseDate) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseTime(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase4All.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase4All.MicroteachCaseTime);
}
objvMicroteachCase4AllEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseTime) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseDateIn(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase4All.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase4All.MicroteachCaseDateIn);
}
objvMicroteachCase4AllEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroteachCaseDateIn) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdStudyLevel(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroteachCase4All.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroteachCase4All.IdStudyLevel);
}
objvMicroteachCase4AllEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdStudyLevel) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetStudyLevelName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase4All.StudyLevelName);
}
objvMicroteachCase4AllEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.StudyLevelName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdTeachingPlan(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroteachCase4All.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroteachCase4All.IdTeachingPlan);
}
objvMicroteachCase4AllEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdTeachingPlan) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase4All.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase4All.MicroTeachCaseTimeIn);
}
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdMicroteachCaseType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdMicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCaseType, convMicroteachCase4All.IdMicroteachCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseType, 4, convMicroteachCase4All.IdMicroteachCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseType, 4, convMicroteachCase4All.IdMicroteachCaseType);
}
objvMicroteachCase4AllEN.IdMicroteachCaseType = strIdMicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdMicroteachCaseType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdMicroteachCaseType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdMicroteachCaseType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdCaseType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, convMicroteachCase4All.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convMicroteachCase4All.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convMicroteachCase4All.IdCaseType);
}
objvMicroteachCase4AllEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdCaseType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdCaseType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdCaseType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdDiscipline(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convMicroteachCase4All.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convMicroteachCase4All.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convMicroteachCase4All.IdDiscipline);
}
objvMicroteachCase4AllEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdDiscipline) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdDiscipline, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdDiscipline] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetDisciplineID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase4All.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase4All.DisciplineID);
}
objvMicroteachCase4AllEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.DisciplineID) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.DisciplineID, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.DisciplineID] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetDisciplineName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase4All.DisciplineName);
}
objvMicroteachCase4AllEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.DisciplineName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.DisciplineName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.DisciplineName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdSenateGaugeVersion(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convMicroteachCase4All.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convMicroteachCase4All.IdSenateGaugeVersion);
}
objvMicroteachCase4AllEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdSenateGaugeVersion) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetsenateGaugeVersionID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase4All.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase4All.senateGaugeVersionID);
}
objvMicroteachCase4AllEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.senateGaugeVersionID) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetsenateGaugeVersionName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase4All.senateGaugeVersionName);
}
objvMicroteachCase4AllEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.senateGaugeVersionName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.senateGaugeVersionTtlScore) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetVersionNo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, int? intVersionNo, string strComparisonOp="")
	{
objvMicroteachCase4AllEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.VersionNo) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.VersionNo, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.VersionNo] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdTeachSkill(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convMicroteachCase4All.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convMicroteachCase4All.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convMicroteachCase4All.IdTeachSkill);
}
objvMicroteachCase4AllEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdTeachSkill) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdTeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdTeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase4All.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase4All.TeachSkillID);
}
objvMicroteachCase4AllEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.TeachSkillID) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.TeachSkillID, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.TeachSkillID] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetSkillTypeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase4All.SkillTypeName);
}
objvMicroteachCase4AllEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.SkillTypeName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.SkillTypeName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.SkillTypeName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase4All.TeachSkillName);
}
objvMicroteachCase4AllEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.TeachSkillName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.TeachSkillName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.TeachSkillName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillTheory(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase4All.TeachSkillTheory);
}
objvMicroteachCase4AllEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.TeachSkillTheory) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.TeachSkillTheory, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.TeachSkillTheory] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillOperMethod(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase4All.TeachSkillOperMethod);
}
objvMicroteachCase4AllEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.TeachSkillOperMethod) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdSkillType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convMicroteachCase4All.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convMicroteachCase4All.IdSkillType);
}
objvMicroteachCase4AllEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdSkillType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdSkillType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdSkillType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetSkillTypeID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase4All.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase4All.SkillTypeID);
}
objvMicroteachCase4AllEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.SkillTypeID) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.SkillTypeID, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.SkillTypeID] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCaseLevelId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase4All.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase4All.CaseLevelId);
}
objvMicroteachCase4AllEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.CaseLevelId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.CaseLevelId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.CaseLevelId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCaseLevelName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convMicroteachCase4All.CaseLevelName);
}
objvMicroteachCase4AllEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.CaseLevelName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.CaseLevelName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.CaseLevelName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetDocFile(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMicroteachCase4All.DocFile);
}
objvMicroteachCase4AllEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.DocFile) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.DocFile, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.DocFile] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIsNeedGeneWord(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvMicroteachCase4AllEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IsNeedGeneWord) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IsNeedGeneWord, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IsNeedGeneWord] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetWordCreateDate(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMicroteachCase4All.WordCreateDate);
}
objvMicroteachCase4AllEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.WordCreateDate) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.WordCreateDate, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.WordCreateDate] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIsVisible(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCase4AllEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IsVisible) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetmicroteachCaseText(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase4All.microteachCaseText);
}
objvMicroteachCase4AllEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.microteachCaseText) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetOwnerId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroteachCase4All.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase4All.OwnerId);
}
objvMicroteachCase4AllEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.OwnerId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetOwnerName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase4All.OwnerName);
}
objvMicroteachCase4AllEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.OwnerName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.OwnerName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.OwnerName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCollegeId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convMicroteachCase4All.CollegeId);
}
objvMicroteachCase4AllEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.CollegeId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.CollegeId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.CollegeId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCollegeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase4All.CollegeName);
}
objvMicroteachCase4AllEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.CollegeName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetOwnerNameWithId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCase4All.OwnerNameWithId);
}
objvMicroteachCase4AllEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.OwnerNameWithId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.OwnerNameWithId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.OwnerNameWithId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIdXzCollege(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCase4All.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCase4All.IdXzCollege);
}
objvMicroteachCase4AllEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IdXzCollege) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIsDualVideo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convMicroteachCase4All.IsDualVideo);
objvMicroteachCase4AllEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IsDualVideo) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IsDualVideo, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IsDualVideo] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserKindId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convMicroteachCase4All.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCase4All.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCase4All.UserKindId);
}
objvMicroteachCase4AllEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.UserKindId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.UserKindId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.UserKindId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserKindName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCase4All.UserKindName);
}
objvMicroteachCase4AllEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.UserKindName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.UserKindName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.UserKindName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserTypeId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase4All.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase4All.UserTypeId);
}
objvMicroteachCase4AllEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.UserTypeId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserTypeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCase4All.UserTypeName);
}
objvMicroteachCase4AllEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.UserTypeName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.UserTypeName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.UserTypeName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetRecommendedDegreeId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroteachCase4All.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase4All.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase4All.RecommendedDegreeId);
}
objvMicroteachCase4AllEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.RecommendedDegreeId) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetRecommendedDegreeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase4All.RecommendedDegreeName);
}
objvMicroteachCase4AllEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.RecommendedDegreeName) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMemo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase4All.Memo);
}
objvMicroteachCase4AllEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.Memo) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.Memo, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.Memo] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetBrowseCount4Case(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCase4AllEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.BrowseCount4Case) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIsHaveVideo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convMicroteachCase4All.IsHaveVideo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convMicroteachCase4All.IsHaveVideo);
}
objvMicroteachCase4AllEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.IsHaveVideo) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.IsHaveVideo, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.IsHaveVideo] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCollegeNameA(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase4All.CollegeNameA);
}
objvMicroteachCase4AllEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.CollegeNameA) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetftpFileType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase4All.ftpFileType);
}
objvMicroteachCase4AllEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.ftpFileType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase4AllENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllENS, clsvMicroteachCase4AllEN objvMicroteachCase4AllENT)
{
try
{
objvMicroteachCase4AllENT.IdMicroteachCase = objvMicroteachCase4AllENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase4AllENT.MicroteachCaseTypeName = objvMicroteachCase4AllENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4AllENT.MicroteachCaseID = objvMicroteachCase4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4AllENT.MicroteachCaseName = objvMicroteachCase4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4AllENT.MicroteachCaseTheme = objvMicroteachCase4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4AllENT.MicroteachCaseDate = objvMicroteachCase4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4AllENT.MicroteachCaseTime = objvMicroteachCase4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4AllENT.MicroteachCaseDateIn = objvMicroteachCase4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4AllENT.IdStudyLevel = objvMicroteachCase4AllENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase4AllENT.StudyLevelName = objvMicroteachCase4AllENS.StudyLevelName; //学段名称
objvMicroteachCase4AllENT.IdTeachingPlan = objvMicroteachCase4AllENS.IdTeachingPlan; //教案流水号
objvMicroteachCase4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4AllENT.IdMicroteachCaseType = objvMicroteachCase4AllENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4AllENT.IdCaseType = objvMicroteachCase4AllENS.IdCaseType; //案例类型流水号
objvMicroteachCase4AllENT.IdDiscipline = objvMicroteachCase4AllENS.IdDiscipline; //学科流水号
objvMicroteachCase4AllENT.DisciplineID = objvMicroteachCase4AllENS.DisciplineID; //学科ID
objvMicroteachCase4AllENT.DisciplineName = objvMicroteachCase4AllENS.DisciplineName; //学科名称
objvMicroteachCase4AllENT.IdSenateGaugeVersion = objvMicroteachCase4AllENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4AllENT.senateGaugeVersionID = objvMicroteachCase4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4AllENT.senateGaugeVersionName = objvMicroteachCase4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4AllENT.VersionNo = objvMicroteachCase4AllENS.VersionNo; //版本号
objvMicroteachCase4AllENT.IdTeachSkill = objvMicroteachCase4AllENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase4AllENT.TeachSkillID = objvMicroteachCase4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase4AllENT.SkillTypeName = objvMicroteachCase4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase4AllENT.TeachSkillName = objvMicroteachCase4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase4AllENT.TeachSkillTheory = objvMicroteachCase4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4AllENT.TeachSkillOperMethod = objvMicroteachCase4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4AllENT.IdSkillType = objvMicroteachCase4AllENS.IdSkillType; //技能类型流水号
objvMicroteachCase4AllENT.SkillTypeID = objvMicroteachCase4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase4AllENT.CaseLevelId = objvMicroteachCase4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase4AllENT.CaseLevelName = objvMicroteachCase4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase4AllENT.DocFile = objvMicroteachCase4AllENS.DocFile; //生成的Word文件名
objvMicroteachCase4AllENT.IsNeedGeneWord = objvMicroteachCase4AllENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4AllENT.WordCreateDate = objvMicroteachCase4AllENS.WordCreateDate; //Word生成日期
objvMicroteachCase4AllENT.IsVisible = objvMicroteachCase4AllENS.IsVisible; //是否显示
objvMicroteachCase4AllENT.microteachCaseText = objvMicroteachCase4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase4AllENT.OwnerId = objvMicroteachCase4AllENS.OwnerId; //拥有者Id
objvMicroteachCase4AllENT.OwnerName = objvMicroteachCase4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase4AllENT.CollegeId = objvMicroteachCase4AllENS.CollegeId; //学院ID
objvMicroteachCase4AllENT.CollegeName = objvMicroteachCase4AllENS.CollegeName; //学院名称
objvMicroteachCase4AllENT.OwnerNameWithId = objvMicroteachCase4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase4AllENT.IdXzCollege = objvMicroteachCase4AllENS.IdXzCollege; //学院流水号
objvMicroteachCase4AllENT.IsDualVideo = objvMicroteachCase4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase4AllENT.UserKindId = objvMicroteachCase4AllENS.UserKindId; //用户类别Id
objvMicroteachCase4AllENT.UserKindName = objvMicroteachCase4AllENS.UserKindName; //用户类别名
objvMicroteachCase4AllENT.UserTypeId = objvMicroteachCase4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase4AllENT.UserTypeName = objvMicroteachCase4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase4AllENT.RecommendedDegreeId = objvMicroteachCase4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase4AllENT.RecommendedDegreeName = objvMicroteachCase4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase4AllENT.Memo = objvMicroteachCase4AllENS.Memo; //备注
objvMicroteachCase4AllENT.BrowseCount4Case = objvMicroteachCase4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase4AllENT.IsHaveVideo = objvMicroteachCase4AllENS.IsHaveVideo; //IsHaveVideo
objvMicroteachCase4AllENT.CollegeNameA = objvMicroteachCase4AllENS.CollegeNameA; //学院名称简写
objvMicroteachCase4AllENT.ftpFileType = objvMicroteachCase4AllENS.ftpFileType; //ftp文件类型
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
 /// <param name = "objvMicroteachCase4AllENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase4AllEN:objvMicroteachCase4AllENT</returns>
 public static clsvMicroteachCase4AllEN CopyTo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllENS)
{
try
{
 clsvMicroteachCase4AllEN objvMicroteachCase4AllENT = new clsvMicroteachCase4AllEN()
{
IdMicroteachCase = objvMicroteachCase4AllENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseTypeName = objvMicroteachCase4AllENS.MicroteachCaseTypeName, //微格案例类型名称
MicroteachCaseID = objvMicroteachCase4AllENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCase4AllENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroteachCase4AllENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroteachCase4AllENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroteachCase4AllENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroteachCase4AllENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroteachCase4AllENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroteachCase4AllENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroteachCase4AllENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroteachCase4AllENS.MicroTeachCaseTimeIn, //案例入库时间
IdMicroteachCaseType = objvMicroteachCase4AllENS.IdMicroteachCaseType, //微格案例类型流水号
IdCaseType = objvMicroteachCase4AllENS.IdCaseType, //案例类型流水号
IdDiscipline = objvMicroteachCase4AllENS.IdDiscipline, //学科流水号
DisciplineID = objvMicroteachCase4AllENS.DisciplineID, //学科ID
DisciplineName = objvMicroteachCase4AllENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvMicroteachCase4AllENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvMicroteachCase4AllENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCase4AllENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroteachCase4AllENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvMicroteachCase4AllENS.VersionNo, //版本号
IdTeachSkill = objvMicroteachCase4AllENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvMicroteachCase4AllENS.TeachSkillID, //教学技能ID
SkillTypeName = objvMicroteachCase4AllENS.SkillTypeName, //技能类型名称
TeachSkillName = objvMicroteachCase4AllENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvMicroteachCase4AllENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvMicroteachCase4AllENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvMicroteachCase4AllENS.IdSkillType, //技能类型流水号
SkillTypeID = objvMicroteachCase4AllENS.SkillTypeID, //技能类型ID
CaseLevelId = objvMicroteachCase4AllENS.CaseLevelId, //课例等级Id
CaseLevelName = objvMicroteachCase4AllENS.CaseLevelName, //案例等级名称
DocFile = objvMicroteachCase4AllENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvMicroteachCase4AllENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvMicroteachCase4AllENS.WordCreateDate, //Word生成日期
IsVisible = objvMicroteachCase4AllENS.IsVisible, //是否显示
microteachCaseText = objvMicroteachCase4AllENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroteachCase4AllENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachCase4AllENS.OwnerName, //拥有者姓名
CollegeId = objvMicroteachCase4AllENS.CollegeId, //学院ID
CollegeName = objvMicroteachCase4AllENS.CollegeName, //学院名称
OwnerNameWithId = objvMicroteachCase4AllENS.OwnerNameWithId, //拥有者名称附Id
IdXzCollege = objvMicroteachCase4AllENS.IdXzCollege, //学院流水号
IsDualVideo = objvMicroteachCase4AllENS.IsDualVideo, //是否双视频
UserKindId = objvMicroteachCase4AllENS.UserKindId, //用户类别Id
UserKindName = objvMicroteachCase4AllENS.UserKindName, //用户类别名
UserTypeId = objvMicroteachCase4AllENS.UserTypeId, //用户类型Id
UserTypeName = objvMicroteachCase4AllENS.UserTypeName, //用户类型名称
RecommendedDegreeId = objvMicroteachCase4AllENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvMicroteachCase4AllENS.RecommendedDegreeName, //推荐度名称
Memo = objvMicroteachCase4AllENS.Memo, //备注
BrowseCount4Case = objvMicroteachCase4AllENS.BrowseCount4Case, //课例浏览次数
IsHaveVideo = objvMicroteachCase4AllENS.IsHaveVideo, //IsHaveVideo
CollegeNameA = objvMicroteachCase4AllENS.CollegeNameA, //学院名称简写
ftpFileType = objvMicroteachCase4AllENS.ftpFileType, //ftp文件类型
};
 return objvMicroteachCase4AllENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
 clsvMicroteachCase4AllBL.vMicroteachCase4AllDA.CheckProperty4Condition(objvMicroteachCase4AllEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase4AllEN objvMicroteachCase4AllCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdMicroteachCase, objvMicroteachCase4AllCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseTypeName) == true)
{
string strComparisonOpMicroteachCaseTypeName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseTypeName, objvMicroteachCase4AllCond.MicroteachCaseTypeName, strComparisonOpMicroteachCaseTypeName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseID, objvMicroteachCase4AllCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseName, objvMicroteachCase4AllCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseTheme, objvMicroteachCase4AllCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseDate, objvMicroteachCase4AllCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseTime, objvMicroteachCase4AllCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseDateIn, objvMicroteachCase4AllCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdStudyLevel, objvMicroteachCase4AllCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.StudyLevelName, objvMicroteachCase4AllCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdTeachingPlan, objvMicroteachCase4AllCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroTeachCaseTimeIn, objvMicroteachCase4AllCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdMicroteachCaseType) == true)
{
string strComparisonOpIdMicroteachCaseType = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdMicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdMicroteachCaseType, objvMicroteachCase4AllCond.IdMicroteachCaseType, strComparisonOpIdMicroteachCaseType);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdCaseType, objvMicroteachCase4AllCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdDiscipline, objvMicroteachCase4AllCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.DisciplineID, objvMicroteachCase4AllCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.DisciplineName, objvMicroteachCase4AllCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdSenateGaugeVersion, objvMicroteachCase4AllCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.senateGaugeVersionID, objvMicroteachCase4AllCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.senateGaugeVersionName, objvMicroteachCase4AllCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4All.senateGaugeVersionTtlScore, objvMicroteachCase4AllCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.VersionNo) == true)
{
string strComparisonOpVersionNo = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4All.VersionNo, objvMicroteachCase4AllCond.VersionNo, strComparisonOpVersionNo);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdTeachSkill, objvMicroteachCase4AllCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillID, objvMicroteachCase4AllCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.SkillTypeName, objvMicroteachCase4AllCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillName, objvMicroteachCase4AllCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillTheory, objvMicroteachCase4AllCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillOperMethod, objvMicroteachCase4AllCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdSkillType, objvMicroteachCase4AllCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.SkillTypeID, objvMicroteachCase4AllCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CaseLevelId, objvMicroteachCase4AllCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CaseLevelName, objvMicroteachCase4AllCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.DocFile) == true)
{
string strComparisonOpDocFile = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.DocFile, objvMicroteachCase4AllCond.DocFile, strComparisonOpDocFile);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IsNeedGeneWord) == true)
{
if (objvMicroteachCase4AllCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4All.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4All.IsNeedGeneWord);
}
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.WordCreateDate, objvMicroteachCase4AllCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IsVisible) == true)
{
if (objvMicroteachCase4AllCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4All.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4All.IsVisible);
}
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.microteachCaseText, objvMicroteachCase4AllCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.OwnerId, objvMicroteachCase4AllCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.OwnerName, objvMicroteachCase4AllCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.CollegeId) == true)
{
string strComparisonOpCollegeId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CollegeId, objvMicroteachCase4AllCond.CollegeId, strComparisonOpCollegeId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CollegeName, objvMicroteachCase4AllCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.OwnerNameWithId, objvMicroteachCase4AllCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IdXzCollege, objvMicroteachCase4AllCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IsDualVideo) == true)
{
if (objvMicroteachCase4AllCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4All.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4All.IsDualVideo);
}
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.UserKindId) == true)
{
string strComparisonOpUserKindId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserKindId, objvMicroteachCase4AllCond.UserKindId, strComparisonOpUserKindId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.UserKindName) == true)
{
string strComparisonOpUserKindName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserKindName, objvMicroteachCase4AllCond.UserKindName, strComparisonOpUserKindName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserTypeId, objvMicroteachCase4AllCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserTypeName, objvMicroteachCase4AllCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.RecommendedDegreeId, objvMicroteachCase4AllCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.RecommendedDegreeName, objvMicroteachCase4AllCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.Memo, objvMicroteachCase4AllCond.Memo, strComparisonOpMemo);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4All.BrowseCount4Case, objvMicroteachCase4AllCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IsHaveVideo, objvMicroteachCase4AllCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CollegeNameA, objvMicroteachCase4AllCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvMicroteachCase4AllCond.IsUpdated(convMicroteachCase4All.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCase4AllCond.dicFldComparisonOp[convMicroteachCase4All.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.ftpFileType, objvMicroteachCase4AllCond.ftpFileType, strComparisonOpftpFileType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase4All
{
public virtual bool UpdRelaTabDate(string strIdMicroteachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格教学案例_All(vMicroteachCase4All)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase4AllBL
{
public static RelatedActions_vMicroteachCase4All relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase4AllDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase4AllDA vMicroteachCase4AllDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase4AllDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase4AllBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase4AllEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase4AllEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase4All(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase4AllDA.GetDataTable_vMicroteachCase4All(strWhereCond);
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
objDT = vMicroteachCase4AllDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase4AllDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase4AllDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase4AllDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase4AllDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase4AllDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase4AllDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase4AllDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLstByIdMicroteachCaseLst(List<string> arrIdMicroteachCaseLst)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseLst, true);
 string strWhereCond = string.Format("IdMicroteachCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase4AllEN> GetObjLstByIdMicroteachCaseLstCache(List<string> arrIdMicroteachCaseLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel =
arrvMicroteachCase4AllObjLstCache
.Where(x => arrIdMicroteachCaseLst.Contains(x.IdMicroteachCase));
return arrvMicroteachCase4AllObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
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
public static List<clsvMicroteachCase4AllEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase4AllEN> GetSubObjLstCache(clsvMicroteachCase4AllEN objvMicroteachCase4AllCond)
{
List<clsvMicroteachCase4AllEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4AllEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase4All.AttributeName)
{
if (objvMicroteachCase4AllCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase4AllCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4AllCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase4AllCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase4AllCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4AllCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase4AllCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4AllCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4AllCond[strFldName]));
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
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
List<clsvMicroteachCase4AllEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase4AllEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase4AllEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
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
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
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
public static List<clsvMicroteachCase4AllEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4AllEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4AllEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase4All(ref clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
bool bolResult = vMicroteachCase4AllDA.GetvMicroteachCase4All(ref objvMicroteachCase4AllEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4AllEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
if (strIdMicroteachCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdMicroteachCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdMicroteachCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = vMicroteachCase4AllDA.GetObjByIdMicroteachCase(strIdMicroteachCase);
return objvMicroteachCase4AllEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase4AllEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = vMicroteachCase4AllDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase4AllEN;
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
public static clsvMicroteachCase4AllEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = vMicroteachCase4AllDA.GetObjByDataRow(objRow);
 return objvMicroteachCase4AllEN;
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
public static clsvMicroteachCase4AllEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = vMicroteachCase4AllDA.GetObjByDataRow(objRow);
 return objvMicroteachCase4AllEN;
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
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <param name = "lstvMicroteachCase4AllObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase4AllEN GetObjByIdMicroteachCaseFromList(string strIdMicroteachCase, List<clsvMicroteachCase4AllEN> lstvMicroteachCase4AllObjLst)
{
foreach (clsvMicroteachCase4AllEN objvMicroteachCase4AllEN in lstvMicroteachCase4AllObjLst)
{
if (objvMicroteachCase4AllEN.IdMicroteachCase == strIdMicroteachCase)
{
return objvMicroteachCase4AllEN;
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
 string strIdMicroteachCase;
 try
 {
 strIdMicroteachCase = new clsvMicroteachCase4AllDA().GetFirstID(strWhereCond);
 return strIdMicroteachCase;
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
 arrList = vMicroteachCase4AllDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase4AllDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdMicroteachCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vMicroteachCase4AllDA.IsExist(strIdMicroteachCase);
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
 bolIsExist = clsvMicroteachCase4AllDA.IsExistTable();
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
 bolIsExist = vMicroteachCase4AllDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase4AllENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase4AllEN objvMicroteachCase4AllENS, clsvMicroteachCase4AllEN objvMicroteachCase4AllENT)
{
try
{
objvMicroteachCase4AllENT.IdMicroteachCase = objvMicroteachCase4AllENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase4AllENT.MicroteachCaseTypeName = objvMicroteachCase4AllENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4AllENT.MicroteachCaseID = objvMicroteachCase4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4AllENT.MicroteachCaseName = objvMicroteachCase4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4AllENT.MicroteachCaseTheme = objvMicroteachCase4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4AllENT.MicroteachCaseDate = objvMicroteachCase4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4AllENT.MicroteachCaseTime = objvMicroteachCase4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4AllENT.MicroteachCaseDateIn = objvMicroteachCase4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4AllENT.IdStudyLevel = objvMicroteachCase4AllENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase4AllENT.StudyLevelName = objvMicroteachCase4AllENS.StudyLevelName; //学段名称
objvMicroteachCase4AllENT.IdTeachingPlan = objvMicroteachCase4AllENS.IdTeachingPlan; //教案流水号
objvMicroteachCase4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4AllENT.IdMicroteachCaseType = objvMicroteachCase4AllENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4AllENT.IdCaseType = objvMicroteachCase4AllENS.IdCaseType; //案例类型流水号
objvMicroteachCase4AllENT.IdDiscipline = objvMicroteachCase4AllENS.IdDiscipline; //学科流水号
objvMicroteachCase4AllENT.DisciplineID = objvMicroteachCase4AllENS.DisciplineID; //学科ID
objvMicroteachCase4AllENT.DisciplineName = objvMicroteachCase4AllENS.DisciplineName; //学科名称
objvMicroteachCase4AllENT.IdSenateGaugeVersion = objvMicroteachCase4AllENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4AllENT.senateGaugeVersionID = objvMicroteachCase4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4AllENT.senateGaugeVersionName = objvMicroteachCase4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4AllENT.VersionNo = objvMicroteachCase4AllENS.VersionNo; //版本号
objvMicroteachCase4AllENT.IdTeachSkill = objvMicroteachCase4AllENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase4AllENT.TeachSkillID = objvMicroteachCase4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase4AllENT.SkillTypeName = objvMicroteachCase4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase4AllENT.TeachSkillName = objvMicroteachCase4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase4AllENT.TeachSkillTheory = objvMicroteachCase4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4AllENT.TeachSkillOperMethod = objvMicroteachCase4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4AllENT.IdSkillType = objvMicroteachCase4AllENS.IdSkillType; //技能类型流水号
objvMicroteachCase4AllENT.SkillTypeID = objvMicroteachCase4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase4AllENT.CaseLevelId = objvMicroteachCase4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase4AllENT.CaseLevelName = objvMicroteachCase4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase4AllENT.DocFile = objvMicroteachCase4AllENS.DocFile; //生成的Word文件名
objvMicroteachCase4AllENT.IsNeedGeneWord = objvMicroteachCase4AllENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4AllENT.WordCreateDate = objvMicroteachCase4AllENS.WordCreateDate; //Word生成日期
objvMicroteachCase4AllENT.IsVisible = objvMicroteachCase4AllENS.IsVisible; //是否显示
objvMicroteachCase4AllENT.microteachCaseText = objvMicroteachCase4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase4AllENT.OwnerId = objvMicroteachCase4AllENS.OwnerId; //拥有者Id
objvMicroteachCase4AllENT.OwnerName = objvMicroteachCase4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase4AllENT.CollegeId = objvMicroteachCase4AllENS.CollegeId; //学院ID
objvMicroteachCase4AllENT.CollegeName = objvMicroteachCase4AllENS.CollegeName; //学院名称
objvMicroteachCase4AllENT.OwnerNameWithId = objvMicroteachCase4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase4AllENT.IdXzCollege = objvMicroteachCase4AllENS.IdXzCollege; //学院流水号
objvMicroteachCase4AllENT.IsDualVideo = objvMicroteachCase4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase4AllENT.UserKindId = objvMicroteachCase4AllENS.UserKindId; //用户类别Id
objvMicroteachCase4AllENT.UserKindName = objvMicroteachCase4AllENS.UserKindName; //用户类别名
objvMicroteachCase4AllENT.UserTypeId = objvMicroteachCase4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase4AllENT.UserTypeName = objvMicroteachCase4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase4AllENT.RecommendedDegreeId = objvMicroteachCase4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase4AllENT.RecommendedDegreeName = objvMicroteachCase4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase4AllENT.Memo = objvMicroteachCase4AllENS.Memo; //备注
objvMicroteachCase4AllENT.BrowseCount4Case = objvMicroteachCase4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase4AllENT.IsHaveVideo = objvMicroteachCase4AllENS.IsHaveVideo; //IsHaveVideo
objvMicroteachCase4AllENT.CollegeNameA = objvMicroteachCase4AllENS.CollegeNameA; //学院名称简写
objvMicroteachCase4AllENT.ftpFileType = objvMicroteachCase4AllENS.ftpFileType; //ftp文件类型
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
 /// <param name = "objvMicroteachCase4AllEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
try
{
objvMicroteachCase4AllEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase4AllEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase4All.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdMicroteachCase = objvMicroteachCase4AllEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objvMicroteachCase4AllEN.MicroteachCaseTypeName == "[null]" ? null :  objvMicroteachCase4AllEN.MicroteachCaseTypeName; //微格案例类型名称
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseID = objvMicroteachCase4AllEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseName = objvMicroteachCase4AllEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseTheme = objvMicroteachCase4AllEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroteachCase4AllEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseDate = objvMicroteachCase4AllEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCase4AllEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseTime = objvMicroteachCase4AllEN.MicroteachCaseTime == "[null]" ? null :  objvMicroteachCase4AllEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objvMicroteachCase4AllEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroteachCase4AllEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroteachCase4All.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdStudyLevel = objvMicroteachCase4AllEN.IdStudyLevel == "[null]" ? null :  objvMicroteachCase4AllEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroteachCase4All.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.StudyLevelName = objvMicroteachCase4AllEN.StudyLevelName == "[null]" ? null :  objvMicroteachCase4AllEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroteachCase4All.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdTeachingPlan = objvMicroteachCase4AllEN.IdTeachingPlan == "[null]" ? null :  objvMicroteachCase4AllEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objvMicroteachCase4AllEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroteachCase4AllEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroteachCase4All.IdMicroteachCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdMicroteachCaseType = objvMicroteachCase4AllEN.IdMicroteachCaseType; //微格案例类型流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdCaseType = objvMicroteachCase4AllEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdDiscipline = objvMicroteachCase4AllEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.DisciplineID = objvMicroteachCase4AllEN.DisciplineID == "[null]" ? null :  objvMicroteachCase4AllEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convMicroteachCase4All.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.DisciplineName = objvMicroteachCase4AllEN.DisciplineName == "[null]" ? null :  objvMicroteachCase4AllEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convMicroteachCase4All.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objvMicroteachCase4AllEN.IdSenateGaugeVersion == "[null]" ? null :  objvMicroteachCase4AllEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.senateGaugeVersionID = objvMicroteachCase4AllEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCase4AllEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCase4All.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.senateGaugeVersionName = objvMicroteachCase4AllEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCase4AllEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCase4All.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objvMicroteachCase4AllEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroteachCase4All.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.VersionNo = objvMicroteachCase4AllEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convMicroteachCase4All.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdTeachSkill = objvMicroteachCase4AllEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.TeachSkillID = objvMicroteachCase4AllEN.TeachSkillID == "[null]" ? null :  objvMicroteachCase4AllEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convMicroteachCase4All.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.SkillTypeName = objvMicroteachCase4AllEN.SkillTypeName == "[null]" ? null :  objvMicroteachCase4AllEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convMicroteachCase4All.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.TeachSkillName = objvMicroteachCase4AllEN.TeachSkillName == "[null]" ? null :  objvMicroteachCase4AllEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convMicroteachCase4All.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.TeachSkillTheory = objvMicroteachCase4AllEN.TeachSkillTheory == "[null]" ? null :  objvMicroteachCase4AllEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convMicroteachCase4All.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.TeachSkillOperMethod = objvMicroteachCase4AllEN.TeachSkillOperMethod == "[null]" ? null :  objvMicroteachCase4AllEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convMicroteachCase4All.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdSkillType = objvMicroteachCase4AllEN.IdSkillType == "[null]" ? null :  objvMicroteachCase4AllEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.SkillTypeID = objvMicroteachCase4AllEN.SkillTypeID == "[null]" ? null :  objvMicroteachCase4AllEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convMicroteachCase4All.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.CaseLevelId = objvMicroteachCase4AllEN.CaseLevelId == "[null]" ? null :  objvMicroteachCase4AllEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convMicroteachCase4All.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.CaseLevelName = objvMicroteachCase4AllEN.CaseLevelName == "[null]" ? null :  objvMicroteachCase4AllEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convMicroteachCase4All.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.DocFile = objvMicroteachCase4AllEN.DocFile == "[null]" ? null :  objvMicroteachCase4AllEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convMicroteachCase4All.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IsNeedGeneWord = objvMicroteachCase4AllEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convMicroteachCase4All.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.WordCreateDate = objvMicroteachCase4AllEN.WordCreateDate == "[null]" ? null :  objvMicroteachCase4AllEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convMicroteachCase4All.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IsVisible = objvMicroteachCase4AllEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroteachCase4All.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.microteachCaseText = objvMicroteachCase4AllEN.microteachCaseText == "[null]" ? null :  objvMicroteachCase4AllEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroteachCase4All.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.OwnerId = objvMicroteachCase4AllEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCase4All.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.OwnerName = objvMicroteachCase4AllEN.OwnerName == "[null]" ? null :  objvMicroteachCase4AllEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachCase4All.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.CollegeId = objvMicroteachCase4AllEN.CollegeId == "[null]" ? null :  objvMicroteachCase4AllEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convMicroteachCase4All.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.CollegeName = objvMicroteachCase4AllEN.CollegeName == "[null]" ? null :  objvMicroteachCase4AllEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCase4All.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.OwnerNameWithId = objvMicroteachCase4AllEN.OwnerNameWithId == "[null]" ? null :  objvMicroteachCase4AllEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convMicroteachCase4All.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IdXzCollege = objvMicroteachCase4AllEN.IdXzCollege == "[null]" ? null :  objvMicroteachCase4AllEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCase4All.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IsDualVideo = objvMicroteachCase4AllEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convMicroteachCase4All.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.UserKindId = objvMicroteachCase4AllEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convMicroteachCase4All.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.UserKindName = objvMicroteachCase4AllEN.UserKindName == "[null]" ? null :  objvMicroteachCase4AllEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convMicroteachCase4All.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.UserTypeId = objvMicroteachCase4AllEN.UserTypeId == "[null]" ? null :  objvMicroteachCase4AllEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCase4All.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.UserTypeName = objvMicroteachCase4AllEN.UserTypeName == "[null]" ? null :  objvMicroteachCase4AllEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convMicroteachCase4All.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.RecommendedDegreeId = objvMicroteachCase4AllEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convMicroteachCase4All.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.RecommendedDegreeName = objvMicroteachCase4AllEN.RecommendedDegreeName == "[null]" ? null :  objvMicroteachCase4AllEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convMicroteachCase4All.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.Memo = objvMicroteachCase4AllEN.Memo == "[null]" ? null :  objvMicroteachCase4AllEN.Memo; //备注
}
if (arrFldSet.Contains(convMicroteachCase4All.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.BrowseCount4Case = objvMicroteachCase4AllEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachCase4All.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.IsHaveVideo = objvMicroteachCase4AllEN.IsHaveVideo; //IsHaveVideo
}
if (arrFldSet.Contains(convMicroteachCase4All.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.CollegeNameA = objvMicroteachCase4AllEN.CollegeNameA == "[null]" ? null :  objvMicroteachCase4AllEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convMicroteachCase4All.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4AllEN.ftpFileType = objvMicroteachCase4AllEN.ftpFileType == "[null]" ? null :  objvMicroteachCase4AllEN.ftpFileType; //ftp文件类型
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
 /// <param name = "objvMicroteachCase4AllEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
try
{
if (objvMicroteachCase4AllEN.MicroteachCaseTypeName == "[null]") objvMicroteachCase4AllEN.MicroteachCaseTypeName = null; //微格案例类型名称
if (objvMicroteachCase4AllEN.MicroteachCaseTheme == "[null]") objvMicroteachCase4AllEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroteachCase4AllEN.MicroteachCaseDate == "[null]") objvMicroteachCase4AllEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCase4AllEN.MicroteachCaseTime == "[null]") objvMicroteachCase4AllEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroteachCase4AllEN.MicroteachCaseDateIn == "[null]") objvMicroteachCase4AllEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroteachCase4AllEN.IdStudyLevel == "[null]") objvMicroteachCase4AllEN.IdStudyLevel = null; //id_StudyLevel
if (objvMicroteachCase4AllEN.StudyLevelName == "[null]") objvMicroteachCase4AllEN.StudyLevelName = null; //学段名称
if (objvMicroteachCase4AllEN.IdTeachingPlan == "[null]") objvMicroteachCase4AllEN.IdTeachingPlan = null; //教案流水号
if (objvMicroteachCase4AllEN.MicroTeachCaseTimeIn == "[null]") objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroteachCase4AllEN.DisciplineID == "[null]") objvMicroteachCase4AllEN.DisciplineID = null; //学科ID
if (objvMicroteachCase4AllEN.DisciplineName == "[null]") objvMicroteachCase4AllEN.DisciplineName = null; //学科名称
if (objvMicroteachCase4AllEN.IdSenateGaugeVersion == "[null]") objvMicroteachCase4AllEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvMicroteachCase4AllEN.senateGaugeVersionID == "[null]") objvMicroteachCase4AllEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCase4AllEN.senateGaugeVersionName == "[null]") objvMicroteachCase4AllEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCase4AllEN.TeachSkillID == "[null]") objvMicroteachCase4AllEN.TeachSkillID = null; //教学技能ID
if (objvMicroteachCase4AllEN.SkillTypeName == "[null]") objvMicroteachCase4AllEN.SkillTypeName = null; //技能类型名称
if (objvMicroteachCase4AllEN.TeachSkillName == "[null]") objvMicroteachCase4AllEN.TeachSkillName = null; //教学技能名称
if (objvMicroteachCase4AllEN.TeachSkillTheory == "[null]") objvMicroteachCase4AllEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvMicroteachCase4AllEN.TeachSkillOperMethod == "[null]") objvMicroteachCase4AllEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvMicroteachCase4AllEN.IdSkillType == "[null]") objvMicroteachCase4AllEN.IdSkillType = null; //技能类型流水号
if (objvMicroteachCase4AllEN.SkillTypeID == "[null]") objvMicroteachCase4AllEN.SkillTypeID = null; //技能类型ID
if (objvMicroteachCase4AllEN.CaseLevelId == "[null]") objvMicroteachCase4AllEN.CaseLevelId = null; //课例等级Id
if (objvMicroteachCase4AllEN.CaseLevelName == "[null]") objvMicroteachCase4AllEN.CaseLevelName = null; //案例等级名称
if (objvMicroteachCase4AllEN.DocFile == "[null]") objvMicroteachCase4AllEN.DocFile = null; //生成的Word文件名
if (objvMicroteachCase4AllEN.WordCreateDate == "[null]") objvMicroteachCase4AllEN.WordCreateDate = null; //Word生成日期
if (objvMicroteachCase4AllEN.microteachCaseText == "[null]") objvMicroteachCase4AllEN.microteachCaseText = null; //案例文本内容
if (objvMicroteachCase4AllEN.OwnerName == "[null]") objvMicroteachCase4AllEN.OwnerName = null; //拥有者姓名
if (objvMicroteachCase4AllEN.CollegeId == "[null]") objvMicroteachCase4AllEN.CollegeId = null; //学院ID
if (objvMicroteachCase4AllEN.CollegeName == "[null]") objvMicroteachCase4AllEN.CollegeName = null; //学院名称
if (objvMicroteachCase4AllEN.OwnerNameWithId == "[null]") objvMicroteachCase4AllEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvMicroteachCase4AllEN.IdXzCollege == "[null]") objvMicroteachCase4AllEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCase4AllEN.UserKindName == "[null]") objvMicroteachCase4AllEN.UserKindName = null; //用户类别名
if (objvMicroteachCase4AllEN.UserTypeId == "[null]") objvMicroteachCase4AllEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCase4AllEN.UserTypeName == "[null]") objvMicroteachCase4AllEN.UserTypeName = null; //用户类型名称
if (objvMicroteachCase4AllEN.RecommendedDegreeName == "[null]") objvMicroteachCase4AllEN.RecommendedDegreeName = null; //推荐度名称
if (objvMicroteachCase4AllEN.Memo == "[null]") objvMicroteachCase4AllEN.Memo = null; //备注
if (objvMicroteachCase4AllEN.CollegeNameA == "[null]") objvMicroteachCase4AllEN.CollegeNameA = null; //学院名称简写
if (objvMicroteachCase4AllEN.ftpFileType == "[null]") objvMicroteachCase4AllEN.ftpFileType = null; //ftp文件类型
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
public static void CheckProperty4Condition(clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
 vMicroteachCase4AllDA.CheckProperty4Condition(objvMicroteachCase4AllEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdMicroteachCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convMicroteachCase4All.IdMicroteachCase); 
List<clsvMicroteachCase4AllEN> arrObjLst = clsvMicroteachCase4AllBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN()
{
IdMicroteachCase = "0",
MicroteachCaseName = "选[v微格教学案例_All]..."
};
arrObjLst.Insert(0, objvMicroteachCase4AllEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convMicroteachCase4All.IdMicroteachCase;
objComboBox.DisplayMember = convMicroteachCase4All.MicroteachCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdMicroteachCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v微格教学案例_All]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convMicroteachCase4All.IdMicroteachCase); 
IEnumerable<clsvMicroteachCase4AllEN> arrObjLst = clsvMicroteachCase4AllBL.GetObjLst(strCondition);
objDDL.DataValueField = convMicroteachCase4All.IdMicroteachCase;
objDDL.DataTextField = convMicroteachCase4All.MicroteachCaseName;
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
public static void BindDdl_IdMicroteachCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v微格教学案例_All]...","0");
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst = GetAllvMicroteachCase4AllObjLstCache(); 
objDDL.DataValueField = convMicroteachCase4All.IdMicroteachCase;
objDDL.DataTextField = convMicroteachCase4All.MicroteachCaseName;
objDDL.DataSource = arrvMicroteachCase4AllObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCase");
//if (arrvMicroteachCase4AllObjLstCache == null)
//{
//arrvMicroteachCase4AllObjLstCache = vMicroteachCase4AllDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase4AllEN GetObjByIdMicroteachCaseCache(string strIdMicroteachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel =
arrvMicroteachCase4AllObjLstCache
.Where(x=> x.IdMicroteachCase == strIdMicroteachCase 
);
if (arrvMicroteachCase4AllObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase4AllEN obj = clsvMicroteachCase4AllBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase4AllObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroteachCaseNameByIdMicroteachCaseCache(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return "";
//获取缓存中的对象列表
clsvMicroteachCase4AllEN objvMicroteachCase4All = GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase4All == null) return "";
return objvMicroteachCase4All.MicroteachCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdMicroteachCaseCache(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return "";
//获取缓存中的对象列表
clsvMicroteachCase4AllEN objvMicroteachCase4All = GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase4All == null) return "";
return objvMicroteachCase4All.MicroteachCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetAllvMicroteachCase4AllObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase4AllObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase4AllObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdMicroteachCase)
{
if (strInFldName != convMicroteachCase4All.IdMicroteachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase4All.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase4All.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase4All = clsvMicroteachCase4AllBL.GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase4All == null) return "";
return objvMicroteachCase4All[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase4AllDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase4AllDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase4AllDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase4AllDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase4AllEN objvMicroteachCase4AllCond)
{
List<clsvMicroteachCase4AllEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4AllEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase4All.AttributeName)
{
if (objvMicroteachCase4AllCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase4AllCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4AllCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase4AllCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase4AllCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4AllCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase4AllCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4AllCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4AllCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase4AllDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase4AllDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase4AllDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}