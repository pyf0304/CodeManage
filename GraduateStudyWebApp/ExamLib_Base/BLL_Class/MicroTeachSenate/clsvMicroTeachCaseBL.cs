
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseBL
 表名:vMicroTeachCase(01120324)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:22
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
public static class  clsvMicroTeachCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseEN GetObj(this K_IdMicroteachCase_vMicroTeachCase myKey)
{
clsvMicroTeachCaseEN objvMicroTeachCaseEN = clsvMicroTeachCaseBL.vMicroTeachCaseDA.GetObjByIdMicroteachCase(myKey.Value);
return objvMicroTeachCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdMicroteachCase(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroTeachCase.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroTeachCase.IdMicroteachCase);
}
objvMicroTeachCaseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdMicroteachCase) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroTeachCase.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroTeachCase.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroTeachCase.MicroteachCaseID);
}
objvMicroTeachCaseEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroTeachCase.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroTeachCase.MicroteachCaseName);
}
objvMicroTeachCaseEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseTheme(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroTeachCase.MicroteachCaseTheme);
}
objvMicroTeachCaseEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseTheme) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseDate(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroTeachCase.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroTeachCase.MicroteachCaseDate);
}
objvMicroTeachCaseEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseDate) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseTime(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroTeachCase.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroTeachCase.MicroteachCaseTime);
}
objvMicroTeachCaseEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseTime) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseDateIn(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroTeachCase.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroTeachCase.MicroteachCaseDateIn);
}
objvMicroTeachCaseEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseDateIn) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdStudyLevel(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convMicroTeachCase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroTeachCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroTeachCase.IdStudyLevel);
}
objvMicroTeachCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdStudyLevel) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStudyLevelName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convMicroTeachCase.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroTeachCase.StudyLevelName);
}
objvMicroTeachCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.StudyLevelName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.StudyLevelName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.StudyLevelName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdTeachingPlan(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convMicroTeachCase.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroTeachCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroTeachCase.IdTeachingPlan);
}
objvMicroTeachCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdTeachingPlan) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroTeachCaseTimeIn(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroTeachCase.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroTeachCase.MicroTeachCaseTimeIn);
}
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroTeachCaseTimeIn) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdMicroteachCaseType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdMicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCaseType, convMicroTeachCase.IdMicroteachCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseType, 4, convMicroTeachCase.IdMicroteachCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseType, 4, convMicroTeachCase.IdMicroteachCaseType);
}
objvMicroTeachCaseEN.IdMicroteachCaseType = strIdMicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdMicroteachCaseType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdMicroteachCaseType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdMicroteachCaseType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseTypeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, convMicroTeachCase.MicroteachCaseTypeName);
}
objvMicroTeachCaseEN.MicroteachCaseTypeName = strMicroteachCaseTypeName; //微格案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MicroteachCaseTypeName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MicroteachCaseTypeName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTypeName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdCaseType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, convMicroTeachCase.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convMicroTeachCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convMicroTeachCase.IdCaseType);
}
objvMicroTeachCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdCaseType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdCaseType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdCaseType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdDiscipline(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convMicroTeachCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convMicroTeachCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convMicroTeachCase.IdDiscipline);
}
objvMicroTeachCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdDiscipline) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdDiscipline, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdDiscipline] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDisciplineID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroTeachCase.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroTeachCase.DisciplineID);
}
objvMicroTeachCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.DisciplineID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.DisciplineID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.DisciplineID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDisciplineName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroTeachCase.DisciplineName);
}
objvMicroTeachCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.DisciplineName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.DisciplineName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.DisciplineName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdSenateGaugeVersion(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convMicroTeachCase.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convMicroTeachCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convMicroTeachCase.IdSenateGaugeVersion);
}
objvMicroTeachCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdSenateGaugeVersion) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetsenateGaugeVersionID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convMicroTeachCase.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroTeachCase.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroTeachCase.senateGaugeVersionID);
}
objvMicroTeachCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.senateGaugeVersionID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetsenateGaugeVersionName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroTeachCase.senateGaugeVersionName);
}
objvMicroTeachCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.senateGaugeVersionName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetsenateGaugeVersionTtlScore(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convMicroTeachCase.senateGaugeVersionTtlScore);
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.senateGaugeVersionTtlScore) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetVersionNo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, int? intVersionNo, string strComparisonOp="")
	{
objvMicroTeachCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.VersionNo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.VersionNo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.VersionNo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdTeachSkill(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convMicroTeachCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convMicroTeachCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convMicroTeachCase.IdTeachSkill);
}
objvMicroTeachCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdTeachSkill) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdTeachSkill, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdTeachSkill] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroTeachCase.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroTeachCase.TeachSkillID);
}
objvMicroTeachCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.TeachSkillID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.TeachSkillID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.TeachSkillID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetSkillTypeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroTeachCase.SkillTypeName);
}
objvMicroTeachCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.SkillTypeName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.SkillTypeName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.SkillTypeName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroTeachCase.TeachSkillName);
}
objvMicroTeachCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.TeachSkillName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.TeachSkillName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.TeachSkillName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillTheory(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroTeachCase.TeachSkillTheory);
}
objvMicroTeachCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.TeachSkillTheory) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillOperMethod(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroTeachCase.TeachSkillOperMethod);
}
objvMicroTeachCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.TeachSkillOperMethod) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdSkillType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convMicroTeachCase.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convMicroTeachCase.IdSkillType);
}
objvMicroTeachCaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdSkillType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdSkillType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdSkillType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetSkillTypeID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroTeachCase.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroTeachCase.SkillTypeID);
}
objvMicroTeachCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.SkillTypeID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.SkillTypeID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.SkillTypeID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCaseLevelId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroTeachCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroTeachCase.CaseLevelId);
}
objvMicroTeachCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.CaseLevelId) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.CaseLevelId, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.CaseLevelId] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCaseLevelName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convMicroTeachCase.CaseLevelName);
}
objvMicroTeachCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.CaseLevelName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.CaseLevelName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.CaseLevelName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDocFile(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMicroTeachCase.DocFile);
}
objvMicroTeachCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.DocFile) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.DocFile, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.DocFile] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIsNeedGeneWord(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvMicroTeachCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IsNeedGeneWord) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetWordCreateDate(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMicroTeachCase.WordCreateDate);
}
objvMicroTeachCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.WordCreateDate) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.WordCreateDate, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.WordCreateDate] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIsVisible(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroTeachCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IsVisible) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IsVisible, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IsVisible] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetmicroteachCaseText(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroTeachCase.microteachCaseText);
}
objvMicroTeachCaseEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.microteachCaseText) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.microteachCaseText, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.microteachCaseText] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetOwnerId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroTeachCase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroTeachCase.OwnerId);
}
objvMicroTeachCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.OwnerId) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.OwnerId, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.OwnerId] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdStudentInfo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convMicroTeachCase.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convMicroTeachCase.IdStudentInfo);
}
objvMicroTeachCaseEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdStudentInfo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdStudentInfo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdStudentInfo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convMicroTeachCase.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convMicroTeachCase.StuName);
}
objvMicroTeachCaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.StuName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.StuName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.StuName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convMicroTeachCase.StuID);
}
objvMicroTeachCaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.StuID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.StuID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.StuID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetPoliticsName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strPoliticsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convMicroTeachCase.PoliticsName);
}
objvMicroTeachCaseEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.PoliticsName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.PoliticsName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.PoliticsName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetSexDesc(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convMicroTeachCase.SexDesc);
}
objvMicroTeachCaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.SexDesc) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.SexDesc, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.SexDesc] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetEthnicName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convMicroTeachCase.EthnicName);
}
objvMicroTeachCaseEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.EthnicName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.EthnicName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.EthnicName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUniZoneDesc(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convMicroTeachCase.UniZoneDesc);
}
objvMicroTeachCaseEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.UniZoneDesc) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.UniZoneDesc, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.UniZoneDesc] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuTypeDesc(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convMicroTeachCase.StuTypeDesc);
}
objvMicroTeachCaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.StuTypeDesc) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.StuTypeDesc, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.StuTypeDesc] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdXzCollege(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroTeachCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroTeachCase.IdXzCollege);
}
objvMicroTeachCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdXzCollege) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdXzCollege, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdXzCollege] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCollegeID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroTeachCase.CollegeID);
}
objvMicroTeachCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.CollegeID) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.CollegeID, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.CollegeID] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCollegeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convMicroTeachCase.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroTeachCase.CollegeName);
}
objvMicroTeachCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.CollegeName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.CollegeName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.CollegeName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCollegeNameA(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroTeachCase.CollegeNameA);
}
objvMicroTeachCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.CollegeNameA) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.CollegeNameA, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.CollegeNameA] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdXzMajor(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convMicroTeachCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convMicroTeachCase.IdXzMajor);
}
objvMicroTeachCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdXzMajor) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdXzMajor, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdXzMajor] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMajorName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convMicroTeachCase.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMicroTeachCase.MajorName);
}
objvMicroTeachCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.MajorName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.MajorName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.MajorName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdGradeBase(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGradeBase, convMicroTeachCase.IdGradeBase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convMicroTeachCase.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convMicroTeachCase.IdGradeBase);
}
objvMicroTeachCaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdGradeBase) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdGradeBase, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdGradeBase] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetGradeBaseName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMicroTeachCase.GradeBaseName);
}
objvMicroTeachCaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.GradeBaseName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.GradeBaseName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.GradeBaseName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIdAdminCls(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convMicroTeachCase.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convMicroTeachCase.IdAdminCls);
}
objvMicroTeachCaseEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IdAdminCls) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IdAdminCls, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IdAdminCls] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetAdminClsId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convMicroTeachCase.AdminClsId);
}
objvMicroTeachCaseEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.AdminClsId) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.AdminClsId, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.AdminClsId] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetAdminClsName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convMicroTeachCase.AdminClsName);
}
objvMicroTeachCaseEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.AdminClsName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.AdminClsName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.AdminClsName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetBirthday(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convMicroTeachCase.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convMicroTeachCase.Birthday);
}
objvMicroTeachCaseEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.Birthday) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.Birthday, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.Birthday] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetNativePlace(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convMicroTeachCase.NativePlace);
}
objvMicroTeachCaseEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.NativePlace) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.NativePlace, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.NativePlace] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDuty(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convMicroTeachCase.Duty);
}
objvMicroTeachCaseEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.Duty) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.Duty, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.Duty] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIDCardNo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIDCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convMicroTeachCase.IDCardNo);
}
objvMicroTeachCaseEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IDCardNo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IDCardNo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IDCardNo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuCardNo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convMicroTeachCase.StuCardNo);
}
objvMicroTeachCaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.StuCardNo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.StuCardNo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.StuCardNo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetLiveAddress(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convMicroTeachCase.LiveAddress);
}
objvMicroTeachCaseEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.LiveAddress) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.LiveAddress, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.LiveAddress] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetHomePhone(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convMicroTeachCase.HomePhone);
}
objvMicroTeachCaseEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.HomePhone) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.HomePhone, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.HomePhone] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetEnrollmentDate(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convMicroTeachCase.EnrollmentDate);
}
objvMicroTeachCaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.EnrollmentDate) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.EnrollmentDate, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.EnrollmentDate] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetPostCode(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convMicroTeachCase.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convMicroTeachCase.PostCode);
}
objvMicroTeachCaseEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.PostCode) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.PostCode, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.PostCode] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIsDualVideo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convMicroTeachCase.IsDualVideo);
objvMicroTeachCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IsDualVideo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IsDualVideo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IsDualVideo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserKindId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convMicroTeachCase.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroTeachCase.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroTeachCase.UserKindId);
}
objvMicroTeachCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.UserKindId) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.UserKindId, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.UserKindId] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserKindName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroTeachCase.UserKindName);
}
objvMicroTeachCaseEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.UserKindName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.UserKindName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.UserKindName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserTypeId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroTeachCase.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroTeachCase.UserTypeId);
}
objvMicroTeachCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.UserTypeId) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.UserTypeId, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.UserTypeId] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserTypeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroTeachCase.UserTypeName);
}
objvMicroTeachCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.UserTypeName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.UserTypeName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.UserTypeName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetRecommendedDegreeId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroTeachCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroTeachCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroTeachCase.RecommendedDegreeId);
}
objvMicroTeachCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.RecommendedDegreeId) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetRecommendedDegreeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroTeachCase.RecommendedDegreeName);
}
objvMicroTeachCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.RecommendedDegreeName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetftpFileType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroTeachCase.ftpFileType);
}
objvMicroTeachCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.ftpFileType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.ftpFileType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.ftpFileType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetVideoUrl(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convMicroTeachCase.VideoUrl);
}
objvMicroTeachCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.VideoUrl) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.VideoUrl, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.VideoUrl] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetVideoPath(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convMicroTeachCase.VideoPath);
}
objvMicroTeachCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.VideoPath) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.VideoPath, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.VideoPath] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetResErrMsg(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convMicroTeachCase.ResErrMsg);
}
objvMicroTeachCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.ResErrMsg) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.ResErrMsg, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.ResErrMsg] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMemo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroTeachCase.Memo);
}
objvMicroTeachCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.Memo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.Memo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.Memo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIsHaveVideo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convMicroTeachCase.IsHaveVideo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convMicroTeachCase.IsHaveVideo);
}
objvMicroTeachCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.IsHaveVideo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.IsHaveVideo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.IsHaveVideo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetOwnerName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroTeachCase.OwnerName);
}
objvMicroTeachCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.OwnerName) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.OwnerName, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.OwnerName] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseEN SetBrowseCount4Case(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroTeachCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.BrowseCount4Case) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroTeachCaseENS">源对象</param>
 /// <param name = "objvMicroTeachCaseENT">目标对象</param>
 public static void CopyTo(this clsvMicroTeachCaseEN objvMicroTeachCaseENS, clsvMicroTeachCaseEN objvMicroTeachCaseENT)
{
try
{
objvMicroTeachCaseENT.IdMicroteachCase = objvMicroTeachCaseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroTeachCaseENT.MicroteachCaseID = objvMicroTeachCaseENS.MicroteachCaseID; //微格教学案例ID
objvMicroTeachCaseENT.MicroteachCaseName = objvMicroTeachCaseENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseENT.MicroteachCaseTheme = objvMicroTeachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroTeachCaseENT.MicroteachCaseDate = objvMicroTeachCaseENS.MicroteachCaseDate; //微格教学日期
objvMicroTeachCaseENT.MicroteachCaseTime = objvMicroTeachCaseENS.MicroteachCaseTime; //微格教学时间
objvMicroTeachCaseENT.MicroteachCaseDateIn = objvMicroTeachCaseENS.MicroteachCaseDateIn; //案例入库日期
objvMicroTeachCaseENT.IdStudyLevel = objvMicroTeachCaseENS.IdStudyLevel; //id_StudyLevel
objvMicroTeachCaseENT.StudyLevelName = objvMicroTeachCaseENS.StudyLevelName; //学段名称
objvMicroTeachCaseENT.IdTeachingPlan = objvMicroTeachCaseENS.IdTeachingPlan; //教案流水号
objvMicroTeachCaseENT.MicroTeachCaseTimeIn = objvMicroTeachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroTeachCaseENT.IdMicroteachCaseType = objvMicroTeachCaseENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroTeachCaseENT.MicroteachCaseTypeName = objvMicroTeachCaseENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroTeachCaseENT.IdCaseType = objvMicroTeachCaseENS.IdCaseType; //案例类型流水号
objvMicroTeachCaseENT.IdDiscipline = objvMicroTeachCaseENS.IdDiscipline; //学科流水号
objvMicroTeachCaseENT.DisciplineID = objvMicroTeachCaseENS.DisciplineID; //学科ID
objvMicroTeachCaseENT.DisciplineName = objvMicroTeachCaseENS.DisciplineName; //学科名称
objvMicroTeachCaseENT.IdSenateGaugeVersion = objvMicroTeachCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroTeachCaseENT.senateGaugeVersionID = objvMicroTeachCaseENS.senateGaugeVersionID; //评价量表版本ID
objvMicroTeachCaseENT.senateGaugeVersionName = objvMicroTeachCaseENS.senateGaugeVersionName; //评价量表版本名称
objvMicroTeachCaseENT.senateGaugeVersionTtlScore = objvMicroTeachCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroTeachCaseENT.VersionNo = objvMicroTeachCaseENS.VersionNo; //版本号
objvMicroTeachCaseENT.IdTeachSkill = objvMicroTeachCaseENS.IdTeachSkill; //教学技能流水号
objvMicroTeachCaseENT.TeachSkillID = objvMicroTeachCaseENS.TeachSkillID; //教学技能ID
objvMicroTeachCaseENT.SkillTypeName = objvMicroTeachCaseENS.SkillTypeName; //技能类型名称
objvMicroTeachCaseENT.TeachSkillName = objvMicroTeachCaseENS.TeachSkillName; //教学技能名称
objvMicroTeachCaseENT.TeachSkillTheory = objvMicroTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvMicroTeachCaseENT.TeachSkillOperMethod = objvMicroTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroTeachCaseENT.IdSkillType = objvMicroTeachCaseENS.IdSkillType; //技能类型流水号
objvMicroTeachCaseENT.SkillTypeID = objvMicroTeachCaseENS.SkillTypeID; //技能类型ID
objvMicroTeachCaseENT.CaseLevelId = objvMicroTeachCaseENS.CaseLevelId; //课例等级Id
objvMicroTeachCaseENT.CaseLevelName = objvMicroTeachCaseENS.CaseLevelName; //案例等级名称
objvMicroTeachCaseENT.DocFile = objvMicroTeachCaseENS.DocFile; //生成的Word文件名
objvMicroTeachCaseENT.IsNeedGeneWord = objvMicroTeachCaseENS.IsNeedGeneWord; //是否需要生成Word
objvMicroTeachCaseENT.WordCreateDate = objvMicroTeachCaseENS.WordCreateDate; //Word生成日期
objvMicroTeachCaseENT.IsVisible = objvMicroTeachCaseENS.IsVisible; //是否显示
objvMicroTeachCaseENT.microteachCaseText = objvMicroTeachCaseENS.microteachCaseText; //案例文本内容
objvMicroTeachCaseENT.OwnerId = objvMicroTeachCaseENS.OwnerId; //拥有者Id
objvMicroTeachCaseENT.IdStudentInfo = objvMicroTeachCaseENS.IdStudentInfo; //学生流水号
objvMicroTeachCaseENT.StuName = objvMicroTeachCaseENS.StuName; //姓名
objvMicroTeachCaseENT.StuID = objvMicroTeachCaseENS.StuID; //学号
objvMicroTeachCaseENT.PoliticsName = objvMicroTeachCaseENS.PoliticsName; //政治面貌
objvMicroTeachCaseENT.SexDesc = objvMicroTeachCaseENS.SexDesc; //性别名称
objvMicroTeachCaseENT.EthnicName = objvMicroTeachCaseENS.EthnicName; //民族名称
objvMicroTeachCaseENT.UniZoneDesc = objvMicroTeachCaseENS.UniZoneDesc; //校区名称
objvMicroTeachCaseENT.StuTypeDesc = objvMicroTeachCaseENS.StuTypeDesc; //学生类别名称
objvMicroTeachCaseENT.IdXzCollege = objvMicroTeachCaseENS.IdXzCollege; //学院流水号
objvMicroTeachCaseENT.CollegeID = objvMicroTeachCaseENS.CollegeID; //学院ID
objvMicroTeachCaseENT.CollegeName = objvMicroTeachCaseENS.CollegeName; //学院名称
objvMicroTeachCaseENT.CollegeNameA = objvMicroTeachCaseENS.CollegeNameA; //学院名称简写
objvMicroTeachCaseENT.IdXzMajor = objvMicroTeachCaseENS.IdXzMajor; //专业流水号
objvMicroTeachCaseENT.MajorName = objvMicroTeachCaseENS.MajorName; //专业名称
objvMicroTeachCaseENT.IdGradeBase = objvMicroTeachCaseENS.IdGradeBase; //年级流水号
objvMicroTeachCaseENT.GradeBaseName = objvMicroTeachCaseENS.GradeBaseName; //年级名称
objvMicroTeachCaseENT.IdAdminCls = objvMicroTeachCaseENS.IdAdminCls; //行政班流水号
objvMicroTeachCaseENT.AdminClsId = objvMicroTeachCaseENS.AdminClsId; //行政班代号
objvMicroTeachCaseENT.AdminClsName = objvMicroTeachCaseENS.AdminClsName; //行政班名称
objvMicroTeachCaseENT.Birthday = objvMicroTeachCaseENS.Birthday; //出生日期
objvMicroTeachCaseENT.NativePlace = objvMicroTeachCaseENS.NativePlace; //籍贯
objvMicroTeachCaseENT.Duty = objvMicroTeachCaseENS.Duty; //职位
objvMicroTeachCaseENT.IDCardNo = objvMicroTeachCaseENS.IDCardNo; //身份证号
objvMicroTeachCaseENT.StuCardNo = objvMicroTeachCaseENS.StuCardNo; //学生证号
objvMicroTeachCaseENT.LiveAddress = objvMicroTeachCaseENS.LiveAddress; //居住地址
objvMicroTeachCaseENT.HomePhone = objvMicroTeachCaseENS.HomePhone; //住宅电话
objvMicroTeachCaseENT.EnrollmentDate = objvMicroTeachCaseENS.EnrollmentDate; //入校日期
objvMicroTeachCaseENT.PostCode = objvMicroTeachCaseENS.PostCode; //邮编
objvMicroTeachCaseENT.IsDualVideo = objvMicroTeachCaseENS.IsDualVideo; //是否双视频
objvMicroTeachCaseENT.UserKindId = objvMicroTeachCaseENS.UserKindId; //用户类别Id
objvMicroTeachCaseENT.UserKindName = objvMicroTeachCaseENS.UserKindName; //用户类别名
objvMicroTeachCaseENT.UserTypeId = objvMicroTeachCaseENS.UserTypeId; //用户类型Id
objvMicroTeachCaseENT.UserTypeName = objvMicroTeachCaseENS.UserTypeName; //用户类型名称
objvMicroTeachCaseENT.RecommendedDegreeId = objvMicroTeachCaseENS.RecommendedDegreeId; //推荐度Id
objvMicroTeachCaseENT.RecommendedDegreeName = objvMicroTeachCaseENS.RecommendedDegreeName; //推荐度名称
objvMicroTeachCaseENT.ftpFileType = objvMicroTeachCaseENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseENT.VideoUrl = objvMicroTeachCaseENS.VideoUrl; //视频Url
objvMicroTeachCaseENT.VideoPath = objvMicroTeachCaseENS.VideoPath; //视频目录
objvMicroTeachCaseENT.ResErrMsg = objvMicroTeachCaseENS.ResErrMsg; //资源错误信息
objvMicroTeachCaseENT.Memo = objvMicroTeachCaseENS.Memo; //备注
objvMicroTeachCaseENT.IsHaveVideo = objvMicroTeachCaseENS.IsHaveVideo; //IsHaveVideo
objvMicroTeachCaseENT.OwnerName = objvMicroTeachCaseENS.OwnerName; //拥有者姓名
objvMicroTeachCaseENT.BrowseCount4Case = objvMicroTeachCaseENS.BrowseCount4Case; //课例浏览次数
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
 /// <param name = "objvMicroTeachCaseENS">源对象</param>
 /// <returns>目标对象=>clsvMicroTeachCaseEN:objvMicroTeachCaseENT</returns>
 public static clsvMicroTeachCaseEN CopyTo(this clsvMicroTeachCaseEN objvMicroTeachCaseENS)
{
try
{
 clsvMicroTeachCaseEN objvMicroTeachCaseENT = new clsvMicroTeachCaseEN()
{
IdMicroteachCase = objvMicroTeachCaseENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroTeachCaseENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroTeachCaseENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroTeachCaseENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroTeachCaseENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroTeachCaseENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroTeachCaseENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroTeachCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroTeachCaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroTeachCaseENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroTeachCaseENS.MicroTeachCaseTimeIn, //案例入库时间
IdMicroteachCaseType = objvMicroTeachCaseENS.IdMicroteachCaseType, //微格案例类型流水号
MicroteachCaseTypeName = objvMicroTeachCaseENS.MicroteachCaseTypeName, //微格案例类型名称
IdCaseType = objvMicroTeachCaseENS.IdCaseType, //案例类型流水号
IdDiscipline = objvMicroTeachCaseENS.IdDiscipline, //学科流水号
DisciplineID = objvMicroTeachCaseENS.DisciplineID, //学科ID
DisciplineName = objvMicroTeachCaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvMicroTeachCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvMicroTeachCaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroTeachCaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroTeachCaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvMicroTeachCaseENS.VersionNo, //版本号
IdTeachSkill = objvMicroTeachCaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvMicroTeachCaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvMicroTeachCaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvMicroTeachCaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvMicroTeachCaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvMicroTeachCaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvMicroTeachCaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvMicroTeachCaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvMicroTeachCaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvMicroTeachCaseENS.CaseLevelName, //案例等级名称
DocFile = objvMicroTeachCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvMicroTeachCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvMicroTeachCaseENS.WordCreateDate, //Word生成日期
IsVisible = objvMicroTeachCaseENS.IsVisible, //是否显示
microteachCaseText = objvMicroTeachCaseENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroTeachCaseENS.OwnerId, //拥有者Id
IdStudentInfo = objvMicroTeachCaseENS.IdStudentInfo, //学生流水号
StuName = objvMicroTeachCaseENS.StuName, //姓名
StuID = objvMicroTeachCaseENS.StuID, //学号
PoliticsName = objvMicroTeachCaseENS.PoliticsName, //政治面貌
SexDesc = objvMicroTeachCaseENS.SexDesc, //性别名称
EthnicName = objvMicroTeachCaseENS.EthnicName, //民族名称
UniZoneDesc = objvMicroTeachCaseENS.UniZoneDesc, //校区名称
StuTypeDesc = objvMicroTeachCaseENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvMicroTeachCaseENS.IdXzCollege, //学院流水号
CollegeID = objvMicroTeachCaseENS.CollegeID, //学院ID
CollegeName = objvMicroTeachCaseENS.CollegeName, //学院名称
CollegeNameA = objvMicroTeachCaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvMicroTeachCaseENS.IdXzMajor, //专业流水号
MajorName = objvMicroTeachCaseENS.MajorName, //专业名称
IdGradeBase = objvMicroTeachCaseENS.IdGradeBase, //年级流水号
GradeBaseName = objvMicroTeachCaseENS.GradeBaseName, //年级名称
IdAdminCls = objvMicroTeachCaseENS.IdAdminCls, //行政班流水号
AdminClsId = objvMicroTeachCaseENS.AdminClsId, //行政班代号
AdminClsName = objvMicroTeachCaseENS.AdminClsName, //行政班名称
Birthday = objvMicroTeachCaseENS.Birthday, //出生日期
NativePlace = objvMicroTeachCaseENS.NativePlace, //籍贯
Duty = objvMicroTeachCaseENS.Duty, //职位
IDCardNo = objvMicroTeachCaseENS.IDCardNo, //身份证号
StuCardNo = objvMicroTeachCaseENS.StuCardNo, //学生证号
LiveAddress = objvMicroTeachCaseENS.LiveAddress, //居住地址
HomePhone = objvMicroTeachCaseENS.HomePhone, //住宅电话
EnrollmentDate = objvMicroTeachCaseENS.EnrollmentDate, //入校日期
PostCode = objvMicroTeachCaseENS.PostCode, //邮编
IsDualVideo = objvMicroTeachCaseENS.IsDualVideo, //是否双视频
UserKindId = objvMicroTeachCaseENS.UserKindId, //用户类别Id
UserKindName = objvMicroTeachCaseENS.UserKindName, //用户类别名
UserTypeId = objvMicroTeachCaseENS.UserTypeId, //用户类型Id
UserTypeName = objvMicroTeachCaseENS.UserTypeName, //用户类型名称
RecommendedDegreeId = objvMicroTeachCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvMicroTeachCaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvMicroTeachCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvMicroTeachCaseENS.VideoUrl, //视频Url
VideoPath = objvMicroTeachCaseENS.VideoPath, //视频目录
ResErrMsg = objvMicroTeachCaseENS.ResErrMsg, //资源错误信息
Memo = objvMicroTeachCaseENS.Memo, //备注
IsHaveVideo = objvMicroTeachCaseENS.IsHaveVideo, //IsHaveVideo
OwnerName = objvMicroTeachCaseENS.OwnerName, //拥有者姓名
BrowseCount4Case = objvMicroTeachCaseENS.BrowseCount4Case, //课例浏览次数
};
 return objvMicroTeachCaseENT;
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
public static void CheckProperty4Condition(this clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
 clsvMicroTeachCaseBL.vMicroTeachCaseDA.CheckProperty4Condition(objvMicroTeachCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroTeachCaseEN objvMicroTeachCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdMicroteachCase, objvMicroTeachCaseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseID, objvMicroTeachCaseCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseName, objvMicroTeachCaseCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseTheme, objvMicroTeachCaseCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseDate, objvMicroTeachCaseCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseTime, objvMicroTeachCaseCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseDateIn, objvMicroTeachCaseCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdStudyLevel, objvMicroTeachCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StudyLevelName, objvMicroTeachCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdTeachingPlan, objvMicroTeachCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroTeachCaseTimeIn, objvMicroTeachCaseCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdMicroteachCaseType) == true)
{
string strComparisonOpIdMicroteachCaseType = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdMicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdMicroteachCaseType, objvMicroTeachCaseCond.IdMicroteachCaseType, strComparisonOpIdMicroteachCaseType);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MicroteachCaseTypeName) == true)
{
string strComparisonOpMicroteachCaseTypeName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseTypeName, objvMicroTeachCaseCond.MicroteachCaseTypeName, strComparisonOpMicroteachCaseTypeName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdCaseType, objvMicroTeachCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdDiscipline, objvMicroTeachCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.DisciplineID, objvMicroTeachCaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.DisciplineName, objvMicroTeachCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdSenateGaugeVersion, objvMicroTeachCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.senateGaugeVersionID, objvMicroTeachCaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.senateGaugeVersionName, objvMicroTeachCaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCase.senateGaugeVersionTtlScore, objvMicroTeachCaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.VersionNo) == true)
{
string strComparisonOpVersionNo = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCase.VersionNo, objvMicroTeachCaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdTeachSkill, objvMicroTeachCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillID, objvMicroTeachCaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.SkillTypeName, objvMicroTeachCaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillName, objvMicroTeachCaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillTheory, objvMicroTeachCaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillOperMethod, objvMicroTeachCaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdSkillType, objvMicroTeachCaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.SkillTypeID, objvMicroTeachCaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CaseLevelId, objvMicroTeachCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CaseLevelName, objvMicroTeachCaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.DocFile) == true)
{
string strComparisonOpDocFile = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.DocFile, objvMicroTeachCaseCond.DocFile, strComparisonOpDocFile);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IsNeedGeneWord) == true)
{
if (objvMicroTeachCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCase.IsNeedGeneWord);
}
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.WordCreateDate, objvMicroTeachCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IsVisible) == true)
{
if (objvMicroTeachCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCase.IsVisible);
}
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.microteachCaseText, objvMicroTeachCaseCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.OwnerId, objvMicroTeachCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdStudentInfo, objvMicroTeachCaseCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.StuName) == true)
{
string strComparisonOpStuName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuName, objvMicroTeachCaseCond.StuName, strComparisonOpStuName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.StuID) == true)
{
string strComparisonOpStuID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuID, objvMicroTeachCaseCond.StuID, strComparisonOpStuID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.PoliticsName, objvMicroTeachCaseCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.SexDesc) == true)
{
string strComparisonOpSexDesc = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.SexDesc, objvMicroTeachCaseCond.SexDesc, strComparisonOpSexDesc);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.EthnicName) == true)
{
string strComparisonOpEthnicName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.EthnicName, objvMicroTeachCaseCond.EthnicName, strComparisonOpEthnicName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UniZoneDesc, objvMicroTeachCaseCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuTypeDesc, objvMicroTeachCaseCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdXzCollege, objvMicroTeachCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.CollegeID) == true)
{
string strComparisonOpCollegeID = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CollegeID, objvMicroTeachCaseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CollegeName, objvMicroTeachCaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CollegeNameA, objvMicroTeachCaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdXzMajor, objvMicroTeachCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.MajorName) == true)
{
string strComparisonOpMajorName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MajorName, objvMicroTeachCaseCond.MajorName, strComparisonOpMajorName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdGradeBase, objvMicroTeachCaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.GradeBaseName, objvMicroTeachCaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IdAdminCls, objvMicroTeachCaseCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.AdminClsId, objvMicroTeachCaseCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.AdminClsName, objvMicroTeachCaseCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.Birthday) == true)
{
string strComparisonOpBirthday = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Birthday, objvMicroTeachCaseCond.Birthday, strComparisonOpBirthday);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.NativePlace) == true)
{
string strComparisonOpNativePlace = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.NativePlace, objvMicroTeachCaseCond.NativePlace, strComparisonOpNativePlace);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.Duty) == true)
{
string strComparisonOpDuty = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Duty, objvMicroTeachCaseCond.Duty, strComparisonOpDuty);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IDCardNo) == true)
{
string strComparisonOpIDCardNo = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IDCardNo, objvMicroTeachCaseCond.IDCardNo, strComparisonOpIDCardNo);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuCardNo, objvMicroTeachCaseCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.LiveAddress, objvMicroTeachCaseCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.HomePhone) == true)
{
string strComparisonOpHomePhone = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.HomePhone, objvMicroTeachCaseCond.HomePhone, strComparisonOpHomePhone);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.EnrollmentDate, objvMicroTeachCaseCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.PostCode) == true)
{
string strComparisonOpPostCode = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.PostCode, objvMicroTeachCaseCond.PostCode, strComparisonOpPostCode);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IsDualVideo) == true)
{
if (objvMicroTeachCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCase.IsDualVideo);
}
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.UserKindId) == true)
{
string strComparisonOpUserKindId = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserKindId, objvMicroTeachCaseCond.UserKindId, strComparisonOpUserKindId);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.UserKindName) == true)
{
string strComparisonOpUserKindName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserKindName, objvMicroTeachCaseCond.UserKindName, strComparisonOpUserKindName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserTypeId, objvMicroTeachCaseCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserTypeName, objvMicroTeachCaseCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.RecommendedDegreeId, objvMicroTeachCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.RecommendedDegreeName, objvMicroTeachCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.ftpFileType, objvMicroTeachCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.VideoUrl, objvMicroTeachCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.VideoPath, objvMicroTeachCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.ResErrMsg, objvMicroTeachCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.Memo) == true)
{
string strComparisonOpMemo = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Memo, objvMicroTeachCaseCond.Memo, strComparisonOpMemo);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IsHaveVideo, objvMicroTeachCaseCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.OwnerName, objvMicroTeachCaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroTeachCaseCond.IsUpdated(convMicroTeachCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroTeachCaseCond.dicFldComparisonOp[convMicroTeachCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCase.BrowseCount4Case, objvMicroTeachCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroTeachCase
{
public virtual bool UpdRelaTabDate(string strIdMicroteachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格教学案例(vMicroTeachCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroTeachCaseBL
{
public static RelatedActions_vMicroTeachCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroTeachCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroTeachCaseDA vMicroTeachCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroTeachCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroTeachCaseBL()
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
if (string.IsNullOrEmpty(clsvMicroTeachCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroTeachCaseEN._ConnectString);
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
public static DataTable GetDataTable_vMicroTeachCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroTeachCaseDA.GetDataTable_vMicroTeachCase(strWhereCond);
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
objDT = vMicroTeachCaseDA.GetDataTable(strWhereCond);
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
objDT = vMicroTeachCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroTeachCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroTeachCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroTeachCaseDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroTeachCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroTeachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroTeachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMicroTeachCaseEN> GetObjLstByIdMicroteachCaseLst(List<string> arrIdMicroteachCaseLst)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
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
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroTeachCaseEN> GetObjLstByIdMicroteachCaseLstCache(List<string> arrIdMicroteachCaseLst)
{
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName);
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Sel =
arrvMicroTeachCaseObjLstCache
.Where(x => arrIdMicroteachCaseLst.Contains(x.IdMicroteachCase));
return arrvMicroTeachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetObjLst(string strWhereCond)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
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
public static List<clsvMicroTeachCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroTeachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroTeachCaseEN> GetSubObjLstCache(clsvMicroTeachCaseEN objvMicroTeachCaseCond)
{
List<clsvMicroTeachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroTeachCase.AttributeName)
{
if (objvMicroTeachCaseCond.IsUpdated(strFldName) == false) continue;
if (objvMicroTeachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseCond[strFldName].ToString());
}
else
{
if (objvMicroTeachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroTeachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroTeachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseCond[strFldName]));
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
public static List<clsvMicroTeachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
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
public static List<clsvMicroTeachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
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
List<clsvMicroTeachCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroTeachCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroTeachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
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
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
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
public static List<clsvMicroTeachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroTeachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
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
public static List<clsvMicroTeachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroTeachCase(ref clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
bool bolResult = vMicroTeachCaseDA.GetvMicroTeachCase(ref objvMicroTeachCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
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
clsvMicroTeachCaseEN objvMicroTeachCaseEN = vMicroTeachCaseDA.GetObjByIdMicroteachCase(strIdMicroteachCase);
return objvMicroTeachCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroTeachCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroTeachCaseEN objvMicroTeachCaseEN = vMicroTeachCaseDA.GetFirstObj(strWhereCond);
 return objvMicroTeachCaseEN;
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
public static clsvMicroTeachCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroTeachCaseEN objvMicroTeachCaseEN = vMicroTeachCaseDA.GetObjByDataRow(objRow);
 return objvMicroTeachCaseEN;
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
public static clsvMicroTeachCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroTeachCaseEN objvMicroTeachCaseEN = vMicroTeachCaseDA.GetObjByDataRow(objRow);
 return objvMicroTeachCaseEN;
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
 /// <param name = "lstvMicroTeachCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroTeachCaseEN GetObjByIdMicroteachCaseFromList(string strIdMicroteachCase, List<clsvMicroTeachCaseEN> lstvMicroTeachCaseObjLst)
{
foreach (clsvMicroTeachCaseEN objvMicroTeachCaseEN in lstvMicroTeachCaseObjLst)
{
if (objvMicroTeachCaseEN.IdMicroteachCase == strIdMicroteachCase)
{
return objvMicroTeachCaseEN;
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
 strIdMicroteachCase = new clsvMicroTeachCaseDA().GetFirstID(strWhereCond);
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
 arrList = vMicroTeachCaseDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroTeachCaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMicroTeachCaseDA.IsExist(strIdMicroteachCase);
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
 bolIsExist = clsvMicroTeachCaseDA.IsExistTable();
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
 bolIsExist = vMicroTeachCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroTeachCaseENS">源对象</param>
 /// <param name = "objvMicroTeachCaseENT">目标对象</param>
 public static void CopyTo(clsvMicroTeachCaseEN objvMicroTeachCaseENS, clsvMicroTeachCaseEN objvMicroTeachCaseENT)
{
try
{
objvMicroTeachCaseENT.IdMicroteachCase = objvMicroTeachCaseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroTeachCaseENT.MicroteachCaseID = objvMicroTeachCaseENS.MicroteachCaseID; //微格教学案例ID
objvMicroTeachCaseENT.MicroteachCaseName = objvMicroTeachCaseENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseENT.MicroteachCaseTheme = objvMicroTeachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroTeachCaseENT.MicroteachCaseDate = objvMicroTeachCaseENS.MicroteachCaseDate; //微格教学日期
objvMicroTeachCaseENT.MicroteachCaseTime = objvMicroTeachCaseENS.MicroteachCaseTime; //微格教学时间
objvMicroTeachCaseENT.MicroteachCaseDateIn = objvMicroTeachCaseENS.MicroteachCaseDateIn; //案例入库日期
objvMicroTeachCaseENT.IdStudyLevel = objvMicroTeachCaseENS.IdStudyLevel; //id_StudyLevel
objvMicroTeachCaseENT.StudyLevelName = objvMicroTeachCaseENS.StudyLevelName; //学段名称
objvMicroTeachCaseENT.IdTeachingPlan = objvMicroTeachCaseENS.IdTeachingPlan; //教案流水号
objvMicroTeachCaseENT.MicroTeachCaseTimeIn = objvMicroTeachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroTeachCaseENT.IdMicroteachCaseType = objvMicroTeachCaseENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroTeachCaseENT.MicroteachCaseTypeName = objvMicroTeachCaseENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroTeachCaseENT.IdCaseType = objvMicroTeachCaseENS.IdCaseType; //案例类型流水号
objvMicroTeachCaseENT.IdDiscipline = objvMicroTeachCaseENS.IdDiscipline; //学科流水号
objvMicroTeachCaseENT.DisciplineID = objvMicroTeachCaseENS.DisciplineID; //学科ID
objvMicroTeachCaseENT.DisciplineName = objvMicroTeachCaseENS.DisciplineName; //学科名称
objvMicroTeachCaseENT.IdSenateGaugeVersion = objvMicroTeachCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroTeachCaseENT.senateGaugeVersionID = objvMicroTeachCaseENS.senateGaugeVersionID; //评价量表版本ID
objvMicroTeachCaseENT.senateGaugeVersionName = objvMicroTeachCaseENS.senateGaugeVersionName; //评价量表版本名称
objvMicroTeachCaseENT.senateGaugeVersionTtlScore = objvMicroTeachCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroTeachCaseENT.VersionNo = objvMicroTeachCaseENS.VersionNo; //版本号
objvMicroTeachCaseENT.IdTeachSkill = objvMicroTeachCaseENS.IdTeachSkill; //教学技能流水号
objvMicroTeachCaseENT.TeachSkillID = objvMicroTeachCaseENS.TeachSkillID; //教学技能ID
objvMicroTeachCaseENT.SkillTypeName = objvMicroTeachCaseENS.SkillTypeName; //技能类型名称
objvMicroTeachCaseENT.TeachSkillName = objvMicroTeachCaseENS.TeachSkillName; //教学技能名称
objvMicroTeachCaseENT.TeachSkillTheory = objvMicroTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvMicroTeachCaseENT.TeachSkillOperMethod = objvMicroTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroTeachCaseENT.IdSkillType = objvMicroTeachCaseENS.IdSkillType; //技能类型流水号
objvMicroTeachCaseENT.SkillTypeID = objvMicroTeachCaseENS.SkillTypeID; //技能类型ID
objvMicroTeachCaseENT.CaseLevelId = objvMicroTeachCaseENS.CaseLevelId; //课例等级Id
objvMicroTeachCaseENT.CaseLevelName = objvMicroTeachCaseENS.CaseLevelName; //案例等级名称
objvMicroTeachCaseENT.DocFile = objvMicroTeachCaseENS.DocFile; //生成的Word文件名
objvMicroTeachCaseENT.IsNeedGeneWord = objvMicroTeachCaseENS.IsNeedGeneWord; //是否需要生成Word
objvMicroTeachCaseENT.WordCreateDate = objvMicroTeachCaseENS.WordCreateDate; //Word生成日期
objvMicroTeachCaseENT.IsVisible = objvMicroTeachCaseENS.IsVisible; //是否显示
objvMicroTeachCaseENT.microteachCaseText = objvMicroTeachCaseENS.microteachCaseText; //案例文本内容
objvMicroTeachCaseENT.OwnerId = objvMicroTeachCaseENS.OwnerId; //拥有者Id
objvMicroTeachCaseENT.IdStudentInfo = objvMicroTeachCaseENS.IdStudentInfo; //学生流水号
objvMicroTeachCaseENT.StuName = objvMicroTeachCaseENS.StuName; //姓名
objvMicroTeachCaseENT.StuID = objvMicroTeachCaseENS.StuID; //学号
objvMicroTeachCaseENT.PoliticsName = objvMicroTeachCaseENS.PoliticsName; //政治面貌
objvMicroTeachCaseENT.SexDesc = objvMicroTeachCaseENS.SexDesc; //性别名称
objvMicroTeachCaseENT.EthnicName = objvMicroTeachCaseENS.EthnicName; //民族名称
objvMicroTeachCaseENT.UniZoneDesc = objvMicroTeachCaseENS.UniZoneDesc; //校区名称
objvMicroTeachCaseENT.StuTypeDesc = objvMicroTeachCaseENS.StuTypeDesc; //学生类别名称
objvMicroTeachCaseENT.IdXzCollege = objvMicroTeachCaseENS.IdXzCollege; //学院流水号
objvMicroTeachCaseENT.CollegeID = objvMicroTeachCaseENS.CollegeID; //学院ID
objvMicroTeachCaseENT.CollegeName = objvMicroTeachCaseENS.CollegeName; //学院名称
objvMicroTeachCaseENT.CollegeNameA = objvMicroTeachCaseENS.CollegeNameA; //学院名称简写
objvMicroTeachCaseENT.IdXzMajor = objvMicroTeachCaseENS.IdXzMajor; //专业流水号
objvMicroTeachCaseENT.MajorName = objvMicroTeachCaseENS.MajorName; //专业名称
objvMicroTeachCaseENT.IdGradeBase = objvMicroTeachCaseENS.IdGradeBase; //年级流水号
objvMicroTeachCaseENT.GradeBaseName = objvMicroTeachCaseENS.GradeBaseName; //年级名称
objvMicroTeachCaseENT.IdAdminCls = objvMicroTeachCaseENS.IdAdminCls; //行政班流水号
objvMicroTeachCaseENT.AdminClsId = objvMicroTeachCaseENS.AdminClsId; //行政班代号
objvMicroTeachCaseENT.AdminClsName = objvMicroTeachCaseENS.AdminClsName; //行政班名称
objvMicroTeachCaseENT.Birthday = objvMicroTeachCaseENS.Birthday; //出生日期
objvMicroTeachCaseENT.NativePlace = objvMicroTeachCaseENS.NativePlace; //籍贯
objvMicroTeachCaseENT.Duty = objvMicroTeachCaseENS.Duty; //职位
objvMicroTeachCaseENT.IDCardNo = objvMicroTeachCaseENS.IDCardNo; //身份证号
objvMicroTeachCaseENT.StuCardNo = objvMicroTeachCaseENS.StuCardNo; //学生证号
objvMicroTeachCaseENT.LiveAddress = objvMicroTeachCaseENS.LiveAddress; //居住地址
objvMicroTeachCaseENT.HomePhone = objvMicroTeachCaseENS.HomePhone; //住宅电话
objvMicroTeachCaseENT.EnrollmentDate = objvMicroTeachCaseENS.EnrollmentDate; //入校日期
objvMicroTeachCaseENT.PostCode = objvMicroTeachCaseENS.PostCode; //邮编
objvMicroTeachCaseENT.IsDualVideo = objvMicroTeachCaseENS.IsDualVideo; //是否双视频
objvMicroTeachCaseENT.UserKindId = objvMicroTeachCaseENS.UserKindId; //用户类别Id
objvMicroTeachCaseENT.UserKindName = objvMicroTeachCaseENS.UserKindName; //用户类别名
objvMicroTeachCaseENT.UserTypeId = objvMicroTeachCaseENS.UserTypeId; //用户类型Id
objvMicroTeachCaseENT.UserTypeName = objvMicroTeachCaseENS.UserTypeName; //用户类型名称
objvMicroTeachCaseENT.RecommendedDegreeId = objvMicroTeachCaseENS.RecommendedDegreeId; //推荐度Id
objvMicroTeachCaseENT.RecommendedDegreeName = objvMicroTeachCaseENS.RecommendedDegreeName; //推荐度名称
objvMicroTeachCaseENT.ftpFileType = objvMicroTeachCaseENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseENT.VideoUrl = objvMicroTeachCaseENS.VideoUrl; //视频Url
objvMicroTeachCaseENT.VideoPath = objvMicroTeachCaseENS.VideoPath; //视频目录
objvMicroTeachCaseENT.ResErrMsg = objvMicroTeachCaseENS.ResErrMsg; //资源错误信息
objvMicroTeachCaseENT.Memo = objvMicroTeachCaseENS.Memo; //备注
objvMicroTeachCaseENT.IsHaveVideo = objvMicroTeachCaseENS.IsHaveVideo; //IsHaveVideo
objvMicroTeachCaseENT.OwnerName = objvMicroTeachCaseENS.OwnerName; //拥有者姓名
objvMicroTeachCaseENT.BrowseCount4Case = objvMicroTeachCaseENS.BrowseCount4Case; //课例浏览次数
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
 /// <param name = "objvMicroTeachCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
try
{
objvMicroTeachCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroTeachCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroTeachCase.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdMicroteachCase = objvMicroTeachCaseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseID = objvMicroTeachCaseEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseName = objvMicroTeachCaseEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseTheme = objvMicroTeachCaseEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroTeachCaseEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseDate = objvMicroTeachCaseEN.MicroteachCaseDate == "[null]" ? null :  objvMicroTeachCaseEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseTime = objvMicroTeachCaseEN.MicroteachCaseTime == "[null]" ? null :  objvMicroTeachCaseEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseDateIn = objvMicroTeachCaseEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroTeachCaseEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroTeachCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdStudyLevel = objvMicroTeachCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroTeachCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.StudyLevelName = objvMicroTeachCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroTeachCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdTeachingPlan = objvMicroTeachCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroTeachCase.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objvMicroTeachCaseEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroTeachCaseEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroTeachCase.IdMicroteachCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdMicroteachCaseType = objvMicroTeachCaseEN.IdMicroteachCaseType; //微格案例类型流水号
}
if (arrFldSet.Contains(convMicroTeachCase.MicroteachCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MicroteachCaseTypeName = objvMicroTeachCaseEN.MicroteachCaseTypeName == "[null]" ? null :  objvMicroTeachCaseEN.MicroteachCaseTypeName; //微格案例类型名称
}
if (arrFldSet.Contains(convMicroTeachCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdCaseType = objvMicroTeachCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convMicroTeachCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdDiscipline = objvMicroTeachCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convMicroTeachCase.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.DisciplineID = objvMicroTeachCaseEN.DisciplineID == "[null]" ? null :  objvMicroTeachCaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convMicroTeachCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.DisciplineName = objvMicroTeachCaseEN.DisciplineName == "[null]" ? null :  objvMicroTeachCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convMicroTeachCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdSenateGaugeVersion = objvMicroTeachCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convMicroTeachCase.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.senateGaugeVersionID = objvMicroTeachCaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroTeachCase.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.senateGaugeVersionName = objvMicroTeachCaseEN.senateGaugeVersionName == "[null]" ? null :  objvMicroTeachCaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroTeachCase.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = objvMicroTeachCaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroTeachCase.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.VersionNo = objvMicroTeachCaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convMicroTeachCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdTeachSkill = objvMicroTeachCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convMicroTeachCase.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.TeachSkillID = objvMicroTeachCaseEN.TeachSkillID == "[null]" ? null :  objvMicroTeachCaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convMicroTeachCase.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.SkillTypeName = objvMicroTeachCaseEN.SkillTypeName == "[null]" ? null :  objvMicroTeachCaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convMicroTeachCase.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.TeachSkillName = objvMicroTeachCaseEN.TeachSkillName == "[null]" ? null :  objvMicroTeachCaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convMicroTeachCase.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.TeachSkillTheory = objvMicroTeachCaseEN.TeachSkillTheory == "[null]" ? null :  objvMicroTeachCaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convMicroTeachCase.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.TeachSkillOperMethod = objvMicroTeachCaseEN.TeachSkillOperMethod == "[null]" ? null :  objvMicroTeachCaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convMicroTeachCase.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdSkillType = objvMicroTeachCaseEN.IdSkillType == "[null]" ? null :  objvMicroTeachCaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convMicroTeachCase.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.SkillTypeID = objvMicroTeachCaseEN.SkillTypeID == "[null]" ? null :  objvMicroTeachCaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convMicroTeachCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.CaseLevelId = objvMicroTeachCaseEN.CaseLevelId == "[null]" ? null :  objvMicroTeachCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convMicroTeachCase.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.CaseLevelName = objvMicroTeachCaseEN.CaseLevelName == "[null]" ? null :  objvMicroTeachCaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convMicroTeachCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.DocFile = objvMicroTeachCaseEN.DocFile == "[null]" ? null :  objvMicroTeachCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convMicroTeachCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IsNeedGeneWord = objvMicroTeachCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convMicroTeachCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.WordCreateDate = objvMicroTeachCaseEN.WordCreateDate == "[null]" ? null :  objvMicroTeachCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convMicroTeachCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IsVisible = objvMicroTeachCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroTeachCase.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.microteachCaseText = objvMicroTeachCaseEN.microteachCaseText == "[null]" ? null :  objvMicroTeachCaseEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroTeachCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.OwnerId = objvMicroTeachCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroTeachCase.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdStudentInfo = objvMicroTeachCaseEN.IdStudentInfo == "[null]" ? null :  objvMicroTeachCaseEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convMicroTeachCase.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.StuName = objvMicroTeachCaseEN.StuName; //姓名
}
if (arrFldSet.Contains(convMicroTeachCase.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.StuID = objvMicroTeachCaseEN.StuID == "[null]" ? null :  objvMicroTeachCaseEN.StuID; //学号
}
if (arrFldSet.Contains(convMicroTeachCase.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.PoliticsName = objvMicroTeachCaseEN.PoliticsName == "[null]" ? null :  objvMicroTeachCaseEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convMicroTeachCase.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.SexDesc = objvMicroTeachCaseEN.SexDesc == "[null]" ? null :  objvMicroTeachCaseEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convMicroTeachCase.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.EthnicName = objvMicroTeachCaseEN.EthnicName == "[null]" ? null :  objvMicroTeachCaseEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convMicroTeachCase.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.UniZoneDesc = objvMicroTeachCaseEN.UniZoneDesc == "[null]" ? null :  objvMicroTeachCaseEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convMicroTeachCase.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.StuTypeDesc = objvMicroTeachCaseEN.StuTypeDesc == "[null]" ? null :  objvMicroTeachCaseEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convMicroTeachCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdXzCollege = objvMicroTeachCaseEN.IdXzCollege == "[null]" ? null :  objvMicroTeachCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroTeachCase.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.CollegeID = objvMicroTeachCaseEN.CollegeID == "[null]" ? null :  objvMicroTeachCaseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convMicroTeachCase.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.CollegeName = objvMicroTeachCaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroTeachCase.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.CollegeNameA = objvMicroTeachCaseEN.CollegeNameA == "[null]" ? null :  objvMicroTeachCaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convMicroTeachCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdXzMajor = objvMicroTeachCaseEN.IdXzMajor == "[null]" ? null :  objvMicroTeachCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convMicroTeachCase.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.MajorName = objvMicroTeachCaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convMicroTeachCase.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdGradeBase = objvMicroTeachCaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convMicroTeachCase.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.GradeBaseName = objvMicroTeachCaseEN.GradeBaseName == "[null]" ? null :  objvMicroTeachCaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convMicroTeachCase.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IdAdminCls = objvMicroTeachCaseEN.IdAdminCls == "[null]" ? null :  objvMicroTeachCaseEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convMicroTeachCase.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.AdminClsId = objvMicroTeachCaseEN.AdminClsId == "[null]" ? null :  objvMicroTeachCaseEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convMicroTeachCase.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.AdminClsName = objvMicroTeachCaseEN.AdminClsName == "[null]" ? null :  objvMicroTeachCaseEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convMicroTeachCase.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.Birthday = objvMicroTeachCaseEN.Birthday == "[null]" ? null :  objvMicroTeachCaseEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convMicroTeachCase.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.NativePlace = objvMicroTeachCaseEN.NativePlace == "[null]" ? null :  objvMicroTeachCaseEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convMicroTeachCase.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.Duty = objvMicroTeachCaseEN.Duty == "[null]" ? null :  objvMicroTeachCaseEN.Duty; //职位
}
if (arrFldSet.Contains(convMicroTeachCase.IDCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IDCardNo = objvMicroTeachCaseEN.IDCardNo == "[null]" ? null :  objvMicroTeachCaseEN.IDCardNo; //身份证号
}
if (arrFldSet.Contains(convMicroTeachCase.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.StuCardNo = objvMicroTeachCaseEN.StuCardNo == "[null]" ? null :  objvMicroTeachCaseEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convMicroTeachCase.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.LiveAddress = objvMicroTeachCaseEN.LiveAddress == "[null]" ? null :  objvMicroTeachCaseEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convMicroTeachCase.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.HomePhone = objvMicroTeachCaseEN.HomePhone == "[null]" ? null :  objvMicroTeachCaseEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convMicroTeachCase.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.EnrollmentDate = objvMicroTeachCaseEN.EnrollmentDate == "[null]" ? null :  objvMicroTeachCaseEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convMicroTeachCase.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.PostCode = objvMicroTeachCaseEN.PostCode == "[null]" ? null :  objvMicroTeachCaseEN.PostCode; //邮编
}
if (arrFldSet.Contains(convMicroTeachCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IsDualVideo = objvMicroTeachCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convMicroTeachCase.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.UserKindId = objvMicroTeachCaseEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convMicroTeachCase.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.UserKindName = objvMicroTeachCaseEN.UserKindName == "[null]" ? null :  objvMicroTeachCaseEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convMicroTeachCase.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.UserTypeId = objvMicroTeachCaseEN.UserTypeId == "[null]" ? null :  objvMicroTeachCaseEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroTeachCase.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.UserTypeName = objvMicroTeachCaseEN.UserTypeName == "[null]" ? null :  objvMicroTeachCaseEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convMicroTeachCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.RecommendedDegreeId = objvMicroTeachCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convMicroTeachCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.RecommendedDegreeName = objvMicroTeachCaseEN.RecommendedDegreeName == "[null]" ? null :  objvMicroTeachCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convMicroTeachCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.ftpFileType = objvMicroTeachCaseEN.ftpFileType == "[null]" ? null :  objvMicroTeachCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroTeachCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.VideoUrl = objvMicroTeachCaseEN.VideoUrl == "[null]" ? null :  objvMicroTeachCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convMicroTeachCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.VideoPath = objvMicroTeachCaseEN.VideoPath == "[null]" ? null :  objvMicroTeachCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convMicroTeachCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.ResErrMsg = objvMicroTeachCaseEN.ResErrMsg == "[null]" ? null :  objvMicroTeachCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convMicroTeachCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.Memo = objvMicroTeachCaseEN.Memo == "[null]" ? null :  objvMicroTeachCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convMicroTeachCase.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.IsHaveVideo = objvMicroTeachCaseEN.IsHaveVideo; //IsHaveVideo
}
if (arrFldSet.Contains(convMicroTeachCase.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.OwnerName = objvMicroTeachCaseEN.OwnerName == "[null]" ? null :  objvMicroTeachCaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroTeachCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseEN.BrowseCount4Case = objvMicroTeachCaseEN.BrowseCount4Case; //课例浏览次数
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
 /// <param name = "objvMicroTeachCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
try
{
if (objvMicroTeachCaseEN.MicroteachCaseTheme == "[null]") objvMicroTeachCaseEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroTeachCaseEN.MicroteachCaseDate == "[null]") objvMicroTeachCaseEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroTeachCaseEN.MicroteachCaseTime == "[null]") objvMicroTeachCaseEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroTeachCaseEN.MicroteachCaseDateIn == "[null]") objvMicroTeachCaseEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroTeachCaseEN.MicroTeachCaseTimeIn == "[null]") objvMicroTeachCaseEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroTeachCaseEN.MicroteachCaseTypeName == "[null]") objvMicroTeachCaseEN.MicroteachCaseTypeName = null; //微格案例类型名称
if (objvMicroTeachCaseEN.DisciplineID == "[null]") objvMicroTeachCaseEN.DisciplineID = null; //学科ID
if (objvMicroTeachCaseEN.DisciplineName == "[null]") objvMicroTeachCaseEN.DisciplineName = null; //学科名称
if (objvMicroTeachCaseEN.senateGaugeVersionName == "[null]") objvMicroTeachCaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroTeachCaseEN.TeachSkillID == "[null]") objvMicroTeachCaseEN.TeachSkillID = null; //教学技能ID
if (objvMicroTeachCaseEN.SkillTypeName == "[null]") objvMicroTeachCaseEN.SkillTypeName = null; //技能类型名称
if (objvMicroTeachCaseEN.TeachSkillName == "[null]") objvMicroTeachCaseEN.TeachSkillName = null; //教学技能名称
if (objvMicroTeachCaseEN.TeachSkillTheory == "[null]") objvMicroTeachCaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvMicroTeachCaseEN.TeachSkillOperMethod == "[null]") objvMicroTeachCaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvMicroTeachCaseEN.IdSkillType == "[null]") objvMicroTeachCaseEN.IdSkillType = null; //技能类型流水号
if (objvMicroTeachCaseEN.SkillTypeID == "[null]") objvMicroTeachCaseEN.SkillTypeID = null; //技能类型ID
if (objvMicroTeachCaseEN.CaseLevelId == "[null]") objvMicroTeachCaseEN.CaseLevelId = null; //课例等级Id
if (objvMicroTeachCaseEN.CaseLevelName == "[null]") objvMicroTeachCaseEN.CaseLevelName = null; //案例等级名称
if (objvMicroTeachCaseEN.DocFile == "[null]") objvMicroTeachCaseEN.DocFile = null; //生成的Word文件名
if (objvMicroTeachCaseEN.WordCreateDate == "[null]") objvMicroTeachCaseEN.WordCreateDate = null; //Word生成日期
if (objvMicroTeachCaseEN.microteachCaseText == "[null]") objvMicroTeachCaseEN.microteachCaseText = null; //案例文本内容
if (objvMicroTeachCaseEN.IdStudentInfo == "[null]") objvMicroTeachCaseEN.IdStudentInfo = null; //学生流水号
if (objvMicroTeachCaseEN.StuID == "[null]") objvMicroTeachCaseEN.StuID = null; //学号
if (objvMicroTeachCaseEN.PoliticsName == "[null]") objvMicroTeachCaseEN.PoliticsName = null; //政治面貌
if (objvMicroTeachCaseEN.SexDesc == "[null]") objvMicroTeachCaseEN.SexDesc = null; //性别名称
if (objvMicroTeachCaseEN.EthnicName == "[null]") objvMicroTeachCaseEN.EthnicName = null; //民族名称
if (objvMicroTeachCaseEN.UniZoneDesc == "[null]") objvMicroTeachCaseEN.UniZoneDesc = null; //校区名称
if (objvMicroTeachCaseEN.StuTypeDesc == "[null]") objvMicroTeachCaseEN.StuTypeDesc = null; //学生类别名称
if (objvMicroTeachCaseEN.IdXzCollege == "[null]") objvMicroTeachCaseEN.IdXzCollege = null; //学院流水号
if (objvMicroTeachCaseEN.CollegeID == "[null]") objvMicroTeachCaseEN.CollegeID = null; //学院ID
if (objvMicroTeachCaseEN.CollegeNameA == "[null]") objvMicroTeachCaseEN.CollegeNameA = null; //学院名称简写
if (objvMicroTeachCaseEN.IdXzMajor == "[null]") objvMicroTeachCaseEN.IdXzMajor = null; //专业流水号
if (objvMicroTeachCaseEN.GradeBaseName == "[null]") objvMicroTeachCaseEN.GradeBaseName = null; //年级名称
if (objvMicroTeachCaseEN.IdAdminCls == "[null]") objvMicroTeachCaseEN.IdAdminCls = null; //行政班流水号
if (objvMicroTeachCaseEN.AdminClsId == "[null]") objvMicroTeachCaseEN.AdminClsId = null; //行政班代号
if (objvMicroTeachCaseEN.AdminClsName == "[null]") objvMicroTeachCaseEN.AdminClsName = null; //行政班名称
if (objvMicroTeachCaseEN.Birthday == "[null]") objvMicroTeachCaseEN.Birthday = null; //出生日期
if (objvMicroTeachCaseEN.NativePlace == "[null]") objvMicroTeachCaseEN.NativePlace = null; //籍贯
if (objvMicroTeachCaseEN.Duty == "[null]") objvMicroTeachCaseEN.Duty = null; //职位
if (objvMicroTeachCaseEN.IDCardNo == "[null]") objvMicroTeachCaseEN.IDCardNo = null; //身份证号
if (objvMicroTeachCaseEN.StuCardNo == "[null]") objvMicroTeachCaseEN.StuCardNo = null; //学生证号
if (objvMicroTeachCaseEN.LiveAddress == "[null]") objvMicroTeachCaseEN.LiveAddress = null; //居住地址
if (objvMicroTeachCaseEN.HomePhone == "[null]") objvMicroTeachCaseEN.HomePhone = null; //住宅电话
if (objvMicroTeachCaseEN.EnrollmentDate == "[null]") objvMicroTeachCaseEN.EnrollmentDate = null; //入校日期
if (objvMicroTeachCaseEN.PostCode == "[null]") objvMicroTeachCaseEN.PostCode = null; //邮编
if (objvMicroTeachCaseEN.UserKindName == "[null]") objvMicroTeachCaseEN.UserKindName = null; //用户类别名
if (objvMicroTeachCaseEN.UserTypeId == "[null]") objvMicroTeachCaseEN.UserTypeId = null; //用户类型Id
if (objvMicroTeachCaseEN.UserTypeName == "[null]") objvMicroTeachCaseEN.UserTypeName = null; //用户类型名称
if (objvMicroTeachCaseEN.RecommendedDegreeName == "[null]") objvMicroTeachCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvMicroTeachCaseEN.ftpFileType == "[null]") objvMicroTeachCaseEN.ftpFileType = null; //ftp文件类型
if (objvMicroTeachCaseEN.VideoUrl == "[null]") objvMicroTeachCaseEN.VideoUrl = null; //视频Url
if (objvMicroTeachCaseEN.VideoPath == "[null]") objvMicroTeachCaseEN.VideoPath = null; //视频目录
if (objvMicroTeachCaseEN.ResErrMsg == "[null]") objvMicroTeachCaseEN.ResErrMsg = null; //资源错误信息
if (objvMicroTeachCaseEN.Memo == "[null]") objvMicroTeachCaseEN.Memo = null; //备注
if (objvMicroTeachCaseEN.OwnerName == "[null]") objvMicroTeachCaseEN.OwnerName = null; //拥有者姓名
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
public static void CheckProperty4Condition(clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
 vMicroTeachCaseDA.CheckProperty4Condition(objvMicroTeachCaseEN);
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
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCase");
//if (arrvMicroTeachCaseObjLstCache == null)
//{
//arrvMicroTeachCaseObjLstCache = vMicroTeachCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroTeachCaseEN GetObjByIdMicroteachCaseCache(string strIdMicroteachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName);
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Sel =
arrvMicroTeachCaseObjLstCache
.Where(x=> x.IdMicroteachCase == strIdMicroteachCase 
);
if (arrvMicroTeachCaseObjLst_Sel.Count() == 0)
{
   clsvMicroTeachCaseEN obj = clsvMicroTeachCaseBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroTeachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetAllvMicroTeachCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLstCache = GetObjLstCache(); 
return arrvMicroTeachCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName);
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroTeachCaseObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdMicroteachCase)
{
if (strInFldName != convMicroTeachCase.IdMicroteachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroTeachCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroTeachCase.AttributeName));
throw new Exception(strMsg);
}
var objvMicroTeachCase = clsvMicroTeachCaseBL.GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroTeachCase == null) return "";
return objvMicroTeachCase[strOutFldName].ToString();
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
int intRecCount = clsvMicroTeachCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroTeachCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroTeachCaseDA.GetRecCount();
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
int intRecCount = clsvMicroTeachCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroTeachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroTeachCaseEN objvMicroTeachCaseCond)
{
List<clsvMicroTeachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroTeachCase.AttributeName)
{
if (objvMicroTeachCaseCond.IsUpdated(strFldName) == false) continue;
if (objvMicroTeachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseCond[strFldName].ToString());
}
else
{
if (objvMicroTeachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroTeachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroTeachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseCond[strFldName]));
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
 List<string> arrList = clsvMicroTeachCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroTeachCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroTeachCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}