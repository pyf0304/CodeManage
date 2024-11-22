﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase_Resource_RelBL
 表名:vCourseLearningCase_Resource_Rel(01120434)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvCourseLearningCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_Resource_RelEN GetObj(this K_IdMicroteachCaseResourceRel_vCourseLearningCase_Resource_Rel myKey)
{
clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = clsvCourseLearningCase_Resource_RelBL.vCourseLearningCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvCourseLearningCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdMicroteachCaseResourceRel(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFuncModuleId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningCase_Resource_Rel.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCase_Resource_Rel.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCase_Resource_Rel.FuncModuleId);
}
objvCourseLearningCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FuncModuleId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFuncModuleName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCase_Resource_Rel.FuncModuleName);
}
objvCourseLearningCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FuncModuleName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdMicroteachCase(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convCourseLearningCase_Resource_Rel.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convCourseLearningCase_Resource_Rel.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convCourseLearningCase_Resource_Rel.IdMicroteachCase);
}
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdMicroteachCase) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdMicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdMicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseID);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase_Resource_Rel.CourseLearningCaseName);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseText(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCase_Resource_Rel.CourseLearningCaseText);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseText) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTheme(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDate);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTime(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTime);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseDateIn(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdCourseLearningCaseType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdCourseLearningCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCaseType, 4, convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCaseType, 4, convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType);
}
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = strIdCourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTypeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName);
}
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetOwnerId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCase_Resource_Rel.OwnerId);
}
objvCourseLearningCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.OwnerId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetOwnerName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCase_Resource_Rel.OwnerName);
}
objvCourseLearningCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.OwnerName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetOwnerNameWithId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCase_Resource_Rel.OwnerNameWithId);
}
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.OwnerNameWithId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdXzMajor(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCourseLearningCase_Resource_Rel.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCourseLearningCase_Resource_Rel.IdXzMajor);
}
objvCourseLearningCase_Resource_RelEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdXzMajor) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdXzMajor, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdXzMajor] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetMajorID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCase_Resource_Rel.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCase_Resource_Rel.MajorID);
}
objvCourseLearningCase_Resource_RelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.MajorID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetMajorName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCase_Resource_Rel.MajorName);
}
objvCourseLearningCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.MajorName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdXzCollege(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningCase_Resource_Rel.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningCase_Resource_Rel.IdXzCollege);
}
objvCourseLearningCase_Resource_RelEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdXzCollege) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollegeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCase_Resource_Rel.CollegeID);
}
objvCourseLearningCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollegeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollegeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCase_Resource_Rel.CollegeName);
}
objvCourseLearningCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollegeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdTeachSkill(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convCourseLearningCase_Resource_Rel.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convCourseLearningCase_Resource_Rel.IdTeachSkill);
}
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdTeachSkill) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdTeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdTeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCase_Resource_Rel.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCase_Resource_Rel.TeachSkillID);
}
objvCourseLearningCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCase_Resource_Rel.TeachSkillName);
}
objvCourseLearningCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillTheory(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCase_Resource_Rel.TeachSkillTheory);
}
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillTheory) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillOperMethod(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCase_Resource_Rel.TeachSkillOperMethod);
}
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSkillTypeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCase_Resource_Rel.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCase_Resource_Rel.SkillTypeID);
}
objvCourseLearningCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SkillTypeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSkillTypeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCase_Resource_Rel.SkillTypeName);
}
objvCourseLearningCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SkillTypeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdDiscipline(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convCourseLearningCase_Resource_Rel.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convCourseLearningCase_Resource_Rel.IdDiscipline);
}
objvCourseLearningCase_Resource_RelEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdDiscipline) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdDiscipline, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdDiscipline] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetDisciplineID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCase_Resource_Rel.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCase_Resource_Rel.DisciplineID);
}
objvCourseLearningCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.DisciplineID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetDisciplineName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCase_Resource_Rel.DisciplineName);
}
objvCourseLearningCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.DisciplineName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdStudyLevel(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convCourseLearningCase_Resource_Rel.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convCourseLearningCase_Resource_Rel.IdStudyLevel);
}
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdStudyLevel) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdStudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdStudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetStudyLevelName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCase_Resource_Rel.StudyLevelName);
}
objvCourseLearningCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.StudyLevelName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdFile(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convCourseLearningCase_Resource_Rel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convCourseLearningCase_Resource_Rel.IdFile);
}
objvCourseLearningCase_Resource_RelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdFile) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdFile, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdFile] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convCourseLearningCase_Resource_Rel.FileName);
}
objvCourseLearningCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convCourseLearningCase_Resource_Rel.FileType);
}
objvCourseLearningCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSaveDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCourseLearningCase_Resource_Rel.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCourseLearningCase_Resource_Rel.SaveDate);
}
objvCourseLearningCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SaveDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileSize(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCourseLearningCase_Resource_Rel.FileSize);
}
objvCourseLearningCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileSize) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSaveTime(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCourseLearningCase_Resource_Rel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCourseLearningCase_Resource_Rel.SaveTime);
}
objvCourseLearningCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SaveTime) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdSkillType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convCourseLearningCase_Resource_Rel.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convCourseLearningCase_Resource_Rel.IdSkillType);
}
objvCourseLearningCase_Resource_RelEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdSkillType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdSkillType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdSkillType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdTeachingPlan(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convCourseLearningCase_Resource_Rel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convCourseLearningCase_Resource_Rel.IdTeachingPlan);
}
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdTeachingPlan) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdTeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdTeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdFtpResource(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convCourseLearningCase_Resource_Rel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convCourseLearningCase_Resource_Rel.IdFtpResource);
}
objvCourseLearningCase_Resource_RelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdFtpResource) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdFtpResource, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdFtpResource] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFtpResourceID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCourseLearningCase_Resource_Rel.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCourseLearningCase_Resource_Rel.FtpResourceID);
}
objvCourseLearningCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FtpResourceID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileOriginalName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCourseLearningCase_Resource_Rel.FileOriginalName);
}
objvCourseLearningCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileOriginalName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileDirName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCourseLearningCase_Resource_Rel.FileDirName);
}
objvCourseLearningCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileDirName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileRename(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCourseLearningCase_Resource_Rel.FileRename);
}
objvCourseLearningCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileRename) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileUpDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCourseLearningCase_Resource_Rel.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCourseLearningCase_Resource_Rel.FileUpDate);
}
objvCourseLearningCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileUpDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileUpTime(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCourseLearningCase_Resource_Rel.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCourseLearningCase_Resource_Rel.FileUpTime);
}
objvCourseLearningCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileUpTime) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdResource(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convCourseLearningCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convCourseLearningCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convCourseLearningCase_Resource_Rel.IdResource);
}
objvCourseLearningCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdResource) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCourseLearningCase_Resource_Rel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCourseLearningCase_Resource_Rel.ResourceID);
}
objvCourseLearningCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSaveMode(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SaveMode) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsMain(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsMain) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdResourceType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convCourseLearningCase_Resource_Rel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convCourseLearningCase_Resource_Rel.IdResourceType);
}
objvCourseLearningCase_Resource_RelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdResourceType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdResourceType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdResourceType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceTypeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCourseLearningCase_Resource_Rel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCourseLearningCase_Resource_Rel.ResourceTypeID);
}
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceTypeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceTypeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCourseLearningCase_Resource_Rel.ResourceTypeName);
}
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceTypeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIdUsingMode(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convCourseLearningCase_Resource_Rel.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convCourseLearningCase_Resource_Rel.IdUsingMode);
}
objvCourseLearningCase_Resource_RelEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IdUsingMode) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IdUsingMode, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdUsingMode] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIndexNO(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IndexNO) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase_Resource_Rel.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase_Resource_Rel.CourseId);
}
objvCourseLearningCase_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseCode(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase_Resource_Rel.CourseCode);
}
objvCourseLearningCase_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseCode) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase_Resource_Rel.CourseName);
}
objvCourseLearningCase_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetBrowseCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.BrowseCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convCourseLearningCase_Resource_Rel.ResourceName);
}
objvCourseLearningCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceOwner(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCourseLearningCase_Resource_Rel.ResourceOwner);
}
objvCourseLearningCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceOwner) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetftpFileType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCase_Resource_Rel.ftpFileType);
}
objvCourseLearningCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ftpFileType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetftpFileSize(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCourseLearningCase_Resource_Rel.ftpFileSize);
}
objvCourseLearningCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ftpFileSize) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetftpResourceOwner(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCourseLearningCase_Resource_Rel.ftpResourceOwner);
}
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ftpResourceOwner) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetVersionNo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.VersionNo) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileOriginName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCourseLearningCase_Resource_Rel.FileOriginName);
}
objvCourseLearningCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileOriginName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetsenateGaugeVersionID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCase_Resource_Rel.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCase_Resource_Rel.senateGaugeVersionID);
}
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetsenateGaugeVersionName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCase_Resource_Rel.senateGaugeVersionName);
}
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCaseLevelId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCase_Resource_Rel.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCase_Resource_Rel.CaseLevelId);
}
objvCourseLearningCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CaseLevelId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsExistFile(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsExistFile) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetBrowseCount4Case(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.BrowseCount4Case) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileNewName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCourseLearningCase_Resource_Rel.FileNewName);
}
objvCourseLearningCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileNewName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileOldName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCourseLearningCase_Resource_Rel.FileOldName);
}
objvCourseLearningCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileOldName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsDualVideo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsDualVideo) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetViewCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intViewCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ViewCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsShow(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsShow) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetDownloadNumber(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.DownloadNumber) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileIntegration(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int? intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileIntegration) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetLikeCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, long? lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.LikeCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollectionCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollectionCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsVisible(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsVisible) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetUpdDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCase_Resource_Rel.UpdDate);
}
objvCourseLearningCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.UpdDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetUpdUser(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCourseLearningCase_Resource_Rel.UpdUser);
}
objvCourseLearningCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.UpdUser) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetMemo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase_Resource_Rel.Memo);
}
objvCourseLearningCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.Memo) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetRecommendedDegreeId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase_Resource_Rel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase_Resource_Rel.RecommendedDegreeId);
}
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetRecommendedDegreeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCase_Resource_Rel.RecommendedDegreeName);
}
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollegeNameA(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCase_Resource_Rel.CollegeNameA);
}
objvCourseLearningCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollegeNameA) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseChapterId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase_Resource_Rel.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase_Resource_Rel.CourseChapterId);
}
objvCourseLearningCase_Resource_RelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseChapterId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseChapterName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCase_Resource_Rel.CourseChapterName);
}
objvCourseLearningCase_Resource_RelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseChapterName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseChapterReferred(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCase_Resource_Rel.CourseChapterReferred);
}
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseChapterReferred) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetParentNodeReferred(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCase_Resource_Rel.ParentNodeReferred);
}
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ParentNodeReferred) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetParentNodeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCourseLearningCase_Resource_Rel.ParentNodeID);
}
objvCourseLearningCase_Resource_RelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ParentNodeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ParentNodeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetParentNodeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCourseLearningCase_Resource_Rel.ParentNodeName);
}
objvCourseLearningCase_Resource_RelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ParentNodeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCourseLearningCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENS, clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENT)
{
try
{
objvCourseLearningCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvCourseLearningCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelENT.FuncModuleId = objvCourseLearningCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCourseLearningCase_Resource_RelENT.FuncModuleName = objvCourseLearningCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCourseLearningCase_Resource_RelENT.IdMicroteachCase = objvCourseLearningCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseID = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseText = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTheme = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDate = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTime = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_Resource_RelENT.IdCourseLearningCaseType = objvCourseLearningCase_Resource_RelENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_Resource_RelENT.OwnerId = objvCourseLearningCase_Resource_RelENS.OwnerId; //拥有者Id
objvCourseLearningCase_Resource_RelENT.OwnerName = objvCourseLearningCase_Resource_RelENS.OwnerName; //拥有者姓名
objvCourseLearningCase_Resource_RelENT.OwnerNameWithId = objvCourseLearningCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_Resource_RelENT.IdXzMajor = objvCourseLearningCase_Resource_RelENS.IdXzMajor; //专业流水号
objvCourseLearningCase_Resource_RelENT.MajorID = objvCourseLearningCase_Resource_RelENS.MajorID; //专业ID
objvCourseLearningCase_Resource_RelENT.MajorName = objvCourseLearningCase_Resource_RelENS.MajorName; //专业名称
objvCourseLearningCase_Resource_RelENT.IdXzCollege = objvCourseLearningCase_Resource_RelENS.IdXzCollege; //学院流水号
objvCourseLearningCase_Resource_RelENT.CollegeID = objvCourseLearningCase_Resource_RelENS.CollegeID; //学院ID
objvCourseLearningCase_Resource_RelENT.CollegeName = objvCourseLearningCase_Resource_RelENS.CollegeName; //学院名称
objvCourseLearningCase_Resource_RelENT.IdTeachSkill = objvCourseLearningCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCase_Resource_RelENT.TeachSkillID = objvCourseLearningCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_Resource_RelENT.TeachSkillName = objvCourseLearningCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_Resource_RelENT.TeachSkillTheory = objvCourseLearningCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_Resource_RelENT.TeachSkillOperMethod = objvCourseLearningCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_Resource_RelENT.SkillTypeID = objvCourseLearningCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_Resource_RelENT.SkillTypeName = objvCourseLearningCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_Resource_RelENT.IdDiscipline = objvCourseLearningCase_Resource_RelENS.IdDiscipline; //学科流水号
objvCourseLearningCase_Resource_RelENT.DisciplineID = objvCourseLearningCase_Resource_RelENS.DisciplineID; //学科ID
objvCourseLearningCase_Resource_RelENT.DisciplineName = objvCourseLearningCase_Resource_RelENS.DisciplineName; //学科名称
objvCourseLearningCase_Resource_RelENT.IdStudyLevel = objvCourseLearningCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCase_Resource_RelENT.StudyLevelName = objvCourseLearningCase_Resource_RelENS.StudyLevelName; //学段名称
objvCourseLearningCase_Resource_RelENT.IdFile = objvCourseLearningCase_Resource_RelENS.IdFile; //文件流水号
objvCourseLearningCase_Resource_RelENT.FileName = objvCourseLearningCase_Resource_RelENS.FileName; //文件名称
objvCourseLearningCase_Resource_RelENT.FileType = objvCourseLearningCase_Resource_RelENS.FileType; //文件类型
objvCourseLearningCase_Resource_RelENT.SaveDate = objvCourseLearningCase_Resource_RelENS.SaveDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileSize = objvCourseLearningCase_Resource_RelENS.FileSize; //文件大小
objvCourseLearningCase_Resource_RelENT.SaveTime = objvCourseLearningCase_Resource_RelENS.SaveTime; //创建时间
objvCourseLearningCase_Resource_RelENT.IdSkillType = objvCourseLearningCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvCourseLearningCase_Resource_RelENT.IdTeachingPlan = objvCourseLearningCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvCourseLearningCase_Resource_RelENT.IdFtpResource = objvCourseLearningCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCase_Resource_RelENT.FtpResourceID = objvCourseLearningCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCourseLearningCase_Resource_RelENT.FileOriginalName = objvCourseLearningCase_Resource_RelENS.FileOriginalName; //文件原名
objvCourseLearningCase_Resource_RelENT.FileDirName = objvCourseLearningCase_Resource_RelENS.FileDirName; //文件目录名
objvCourseLearningCase_Resource_RelENT.FileRename = objvCourseLearningCase_Resource_RelENS.FileRename; //文件新名
objvCourseLearningCase_Resource_RelENT.FileUpDate = objvCourseLearningCase_Resource_RelENS.FileUpDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileUpTime = objvCourseLearningCase_Resource_RelENS.FileUpTime; //创建时间
objvCourseLearningCase_Resource_RelENT.IdResource = objvCourseLearningCase_Resource_RelENS.IdResource; //资源流水号
objvCourseLearningCase_Resource_RelENT.ResourceID = objvCourseLearningCase_Resource_RelENS.ResourceID; //资源ID
objvCourseLearningCase_Resource_RelENT.SaveMode = objvCourseLearningCase_Resource_RelENS.SaveMode; //文件存放方式
objvCourseLearningCase_Resource_RelENT.IsMain = objvCourseLearningCase_Resource_RelENS.IsMain; //是否主资源
objvCourseLearningCase_Resource_RelENT.IdResourceType = objvCourseLearningCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvCourseLearningCase_Resource_RelENT.ResourceTypeID = objvCourseLearningCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCase_Resource_RelENT.ResourceTypeName = objvCourseLearningCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCase_Resource_RelENT.IdUsingMode = objvCourseLearningCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvCourseLearningCase_Resource_RelENT.IndexNO = objvCourseLearningCase_Resource_RelENS.IndexNO; //序号
objvCourseLearningCase_Resource_RelENT.CourseId = objvCourseLearningCase_Resource_RelENS.CourseId; //课程Id
objvCourseLearningCase_Resource_RelENT.CourseCode = objvCourseLearningCase_Resource_RelENS.CourseCode; //课程代码
objvCourseLearningCase_Resource_RelENT.CourseName = objvCourseLearningCase_Resource_RelENS.CourseName; //课程名称
objvCourseLearningCase_Resource_RelENT.BrowseCount = objvCourseLearningCase_Resource_RelENS.BrowseCount; //浏览次数
objvCourseLearningCase_Resource_RelENT.ResourceName = objvCourseLearningCase_Resource_RelENS.ResourceName; //资源名称
objvCourseLearningCase_Resource_RelENT.ResourceOwner = objvCourseLearningCase_Resource_RelENS.ResourceOwner; //上传者
objvCourseLearningCase_Resource_RelENT.ftpFileType = objvCourseLearningCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_Resource_RelENT.ftpFileSize = objvCourseLearningCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCourseLearningCase_Resource_RelENT.ftpResourceOwner = objvCourseLearningCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCase_Resource_RelENT.VersionNo = objvCourseLearningCase_Resource_RelENS.VersionNo; //版本号
objvCourseLearningCase_Resource_RelENT.FileOriginName = objvCourseLearningCase_Resource_RelENS.FileOriginName; //原文件名
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionID = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionName = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_Resource_RelENT.CaseLevelId = objvCourseLearningCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_Resource_RelENT.IsExistFile = objvCourseLearningCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCourseLearningCase_Resource_RelENT.BrowseCount4Case = objvCourseLearningCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_Resource_RelENT.FileNewName = objvCourseLearningCase_Resource_RelENS.FileNewName; //新文件名
objvCourseLearningCase_Resource_RelENT.FileOldName = objvCourseLearningCase_Resource_RelENS.FileOldName; //旧文件名
objvCourseLearningCase_Resource_RelENT.IsDualVideo = objvCourseLearningCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCourseLearningCase_Resource_RelENT.ViewCount = objvCourseLearningCase_Resource_RelENS.ViewCount; //浏览量
objvCourseLearningCase_Resource_RelENT.IsShow = objvCourseLearningCase_Resource_RelENS.IsShow; //是否启用
objvCourseLearningCase_Resource_RelENT.DownloadNumber = objvCourseLearningCase_Resource_RelENS.DownloadNumber; //下载数目
objvCourseLearningCase_Resource_RelENT.FileIntegration = objvCourseLearningCase_Resource_RelENS.FileIntegration; //文件积分
objvCourseLearningCase_Resource_RelENT.LikeCount = objvCourseLearningCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_Resource_RelENT.CollectionCount = objvCourseLearningCase_Resource_RelENS.CollectionCount; //收藏数量
objvCourseLearningCase_Resource_RelENT.IsVisible = objvCourseLearningCase_Resource_RelENS.IsVisible; //是否显示
objvCourseLearningCase_Resource_RelENT.UpdDate = objvCourseLearningCase_Resource_RelENS.UpdDate; //修改日期
objvCourseLearningCase_Resource_RelENT.UpdUser = objvCourseLearningCase_Resource_RelENS.UpdUser; //修改人
objvCourseLearningCase_Resource_RelENT.Memo = objvCourseLearningCase_Resource_RelENS.Memo; //备注
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeId = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeName = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_Resource_RelENT.CollegeNameA = objvCourseLearningCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_Resource_RelENT.CourseChapterId = objvCourseLearningCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_Resource_RelENT.CourseChapterName = objvCourseLearningCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_Resource_RelENT.CourseChapterReferred = objvCourseLearningCase_Resource_RelENS.CourseChapterReferred; //节简称
objvCourseLearningCase_Resource_RelENT.ParentNodeReferred = objvCourseLearningCase_Resource_RelENS.ParentNodeReferred; //章简称
objvCourseLearningCase_Resource_RelENT.ParentNodeID = objvCourseLearningCase_Resource_RelENS.ParentNodeID; //父节点编号
objvCourseLearningCase_Resource_RelENT.ParentNodeName = objvCourseLearningCase_Resource_RelENS.ParentNodeName; //父节点名称
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
 /// <param name = "objvCourseLearningCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCase_Resource_RelEN:objvCourseLearningCase_Resource_RelENT</returns>
 public static clsvCourseLearningCase_Resource_RelEN CopyTo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENS)
{
try
{
 clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENT = new clsvCourseLearningCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = objvCourseLearningCase_Resource_RelENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objvCourseLearningCase_Resource_RelENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCourseLearningCase_Resource_RelENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvCourseLearningCase_Resource_RelENS.IdMicroteachCase, //微格教学案例流水号
CourseLearningCaseID = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseText = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseText, //案例文本内容
CourseLearningCaseTheme = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTimeIn, //案例入库时间
IdCourseLearningCaseType = objvCourseLearningCase_Resource_RelENS.IdCourseLearningCaseType, //课程学习案例类型流水号
CourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTypeName, //课程学习案例类型名称
OwnerId = objvCourseLearningCase_Resource_RelENS.OwnerId, //拥有者Id
OwnerName = objvCourseLearningCase_Resource_RelENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvCourseLearningCase_Resource_RelENS.OwnerNameWithId, //拥有者名称附Id
IdXzMajor = objvCourseLearningCase_Resource_RelENS.IdXzMajor, //专业流水号
MajorID = objvCourseLearningCase_Resource_RelENS.MajorID, //专业ID
MajorName = objvCourseLearningCase_Resource_RelENS.MajorName, //专业名称
IdXzCollege = objvCourseLearningCase_Resource_RelENS.IdXzCollege, //学院流水号
CollegeID = objvCourseLearningCase_Resource_RelENS.CollegeID, //学院ID
CollegeName = objvCourseLearningCase_Resource_RelENS.CollegeName, //学院名称
IdTeachSkill = objvCourseLearningCase_Resource_RelENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvCourseLearningCase_Resource_RelENS.TeachSkillID, //教学技能ID
TeachSkillName = objvCourseLearningCase_Resource_RelENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvCourseLearningCase_Resource_RelENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvCourseLearningCase_Resource_RelENS.TeachSkillOperMethod, //教学技能实践操作方法
SkillTypeID = objvCourseLearningCase_Resource_RelENS.SkillTypeID, //技能类型ID
SkillTypeName = objvCourseLearningCase_Resource_RelENS.SkillTypeName, //技能类型名称
IdDiscipline = objvCourseLearningCase_Resource_RelENS.IdDiscipline, //学科流水号
DisciplineID = objvCourseLearningCase_Resource_RelENS.DisciplineID, //学科ID
DisciplineName = objvCourseLearningCase_Resource_RelENS.DisciplineName, //学科名称
IdStudyLevel = objvCourseLearningCase_Resource_RelENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvCourseLearningCase_Resource_RelENS.StudyLevelName, //学段名称
IdFile = objvCourseLearningCase_Resource_RelENS.IdFile, //文件流水号
FileName = objvCourseLearningCase_Resource_RelENS.FileName, //文件名称
FileType = objvCourseLearningCase_Resource_RelENS.FileType, //文件类型
SaveDate = objvCourseLearningCase_Resource_RelENS.SaveDate, //创建日期
FileSize = objvCourseLearningCase_Resource_RelENS.FileSize, //文件大小
SaveTime = objvCourseLearningCase_Resource_RelENS.SaveTime, //创建时间
IdSkillType = objvCourseLearningCase_Resource_RelENS.IdSkillType, //技能类型流水号
IdTeachingPlan = objvCourseLearningCase_Resource_RelENS.IdTeachingPlan, //教案流水号
IdFtpResource = objvCourseLearningCase_Resource_RelENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvCourseLearningCase_Resource_RelENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvCourseLearningCase_Resource_RelENS.FileOriginalName, //文件原名
FileDirName = objvCourseLearningCase_Resource_RelENS.FileDirName, //文件目录名
FileRename = objvCourseLearningCase_Resource_RelENS.FileRename, //文件新名
FileUpDate = objvCourseLearningCase_Resource_RelENS.FileUpDate, //创建日期
FileUpTime = objvCourseLearningCase_Resource_RelENS.FileUpTime, //创建时间
IdResource = objvCourseLearningCase_Resource_RelENS.IdResource, //资源流水号
ResourceID = objvCourseLearningCase_Resource_RelENS.ResourceID, //资源ID
SaveMode = objvCourseLearningCase_Resource_RelENS.SaveMode, //文件存放方式
IsMain = objvCourseLearningCase_Resource_RelENS.IsMain, //是否主资源
IdResourceType = objvCourseLearningCase_Resource_RelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvCourseLearningCase_Resource_RelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvCourseLearningCase_Resource_RelENS.ResourceTypeName, //资源类型名称
IdUsingMode = objvCourseLearningCase_Resource_RelENS.IdUsingMode, //资源使用模式流水号
IndexNO = objvCourseLearningCase_Resource_RelENS.IndexNO, //序号
CourseId = objvCourseLearningCase_Resource_RelENS.CourseId, //课程Id
CourseCode = objvCourseLearningCase_Resource_RelENS.CourseCode, //课程代码
CourseName = objvCourseLearningCase_Resource_RelENS.CourseName, //课程名称
BrowseCount = objvCourseLearningCase_Resource_RelENS.BrowseCount, //浏览次数
ResourceName = objvCourseLearningCase_Resource_RelENS.ResourceName, //资源名称
ResourceOwner = objvCourseLearningCase_Resource_RelENS.ResourceOwner, //上传者
ftpFileType = objvCourseLearningCase_Resource_RelENS.ftpFileType, //ftp文件类型
ftpFileSize = objvCourseLearningCase_Resource_RelENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvCourseLearningCase_Resource_RelENS.ftpResourceOwner, //Ftp资源拥有者
VersionNo = objvCourseLearningCase_Resource_RelENS.VersionNo, //版本号
FileOriginName = objvCourseLearningCase_Resource_RelENS.FileOriginName, //原文件名
senateGaugeVersionID = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionTtlScore, //评价量表版本总分
CaseLevelId = objvCourseLearningCase_Resource_RelENS.CaseLevelId, //课例等级Id
IsExistFile = objvCourseLearningCase_Resource_RelENS.IsExistFile, //是否存在文件
BrowseCount4Case = objvCourseLearningCase_Resource_RelENS.BrowseCount4Case, //课例浏览次数
FileNewName = objvCourseLearningCase_Resource_RelENS.FileNewName, //新文件名
FileOldName = objvCourseLearningCase_Resource_RelENS.FileOldName, //旧文件名
IsDualVideo = objvCourseLearningCase_Resource_RelENS.IsDualVideo, //是否双视频
ViewCount = objvCourseLearningCase_Resource_RelENS.ViewCount, //浏览量
IsShow = objvCourseLearningCase_Resource_RelENS.IsShow, //是否启用
DownloadNumber = objvCourseLearningCase_Resource_RelENS.DownloadNumber, //下载数目
FileIntegration = objvCourseLearningCase_Resource_RelENS.FileIntegration, //文件积分
LikeCount = objvCourseLearningCase_Resource_RelENS.LikeCount, //资源喜欢数量
CollectionCount = objvCourseLearningCase_Resource_RelENS.CollectionCount, //收藏数量
IsVisible = objvCourseLearningCase_Resource_RelENS.IsVisible, //是否显示
UpdDate = objvCourseLearningCase_Resource_RelENS.UpdDate, //修改日期
UpdUser = objvCourseLearningCase_Resource_RelENS.UpdUser, //修改人
Memo = objvCourseLearningCase_Resource_RelENS.Memo, //备注
RecommendedDegreeId = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeName, //推荐度名称
CollegeNameA = objvCourseLearningCase_Resource_RelENS.CollegeNameA, //学院名称简写
CourseChapterId = objvCourseLearningCase_Resource_RelENS.CourseChapterId, //课程章节ID
CourseChapterName = objvCourseLearningCase_Resource_RelENS.CourseChapterName, //课程章节名称
CourseChapterReferred = objvCourseLearningCase_Resource_RelENS.CourseChapterReferred, //节简称
ParentNodeReferred = objvCourseLearningCase_Resource_RelENS.ParentNodeReferred, //章简称
ParentNodeID = objvCourseLearningCase_Resource_RelENS.ParentNodeID, //父节点编号
ParentNodeName = objvCourseLearningCase_Resource_RelENS.ParentNodeName, //父节点名称
};
 return objvCourseLearningCase_Resource_RelENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
 clsvCourseLearningCase_Resource_RelBL.vCourseLearningCase_Resource_RelDA.CheckProperty4Condition(objvCourseLearningCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel, objvCourseLearningCase_Resource_RelCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FuncModuleId, objvCourseLearningCase_Resource_RelCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FuncModuleName, objvCourseLearningCase_Resource_RelCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdMicroteachCase, objvCourseLearningCase_Resource_RelCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseID, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseName, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseText) == true)
{
string strComparisonOpCourseLearningCaseText = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseText, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseText, strComparisonOpCourseLearningCaseText);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseDate, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTime, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType) == true)
{
string strComparisonOpIdCourseLearningCaseType = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType, objvCourseLearningCase_Resource_RelCond.IdCourseLearningCaseType, strComparisonOpIdCourseLearningCaseType);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName) == true)
{
string strComparisonOpCourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName, objvCourseLearningCase_Resource_RelCond.CourseLearningCaseTypeName, strComparisonOpCourseLearningCaseTypeName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.OwnerId, objvCourseLearningCase_Resource_RelCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.OwnerName, objvCourseLearningCase_Resource_RelCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.OwnerNameWithId, objvCourseLearningCase_Resource_RelCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdXzMajor, objvCourseLearningCase_Resource_RelCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.MajorID, objvCourseLearningCase_Resource_RelCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.MajorName, objvCourseLearningCase_Resource_RelCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdXzCollege, objvCourseLearningCase_Resource_RelCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOpCollegeID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CollegeID, objvCourseLearningCase_Resource_RelCond.CollegeID, strComparisonOpCollegeID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CollegeName, objvCourseLearningCase_Resource_RelCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdTeachSkill, objvCourseLearningCase_Resource_RelCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillID, objvCourseLearningCase_Resource_RelCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillName, objvCourseLearningCase_Resource_RelCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillTheory, objvCourseLearningCase_Resource_RelCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillOperMethod, objvCourseLearningCase_Resource_RelCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SkillTypeID, objvCourseLearningCase_Resource_RelCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SkillTypeName, objvCourseLearningCase_Resource_RelCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdDiscipline, objvCourseLearningCase_Resource_RelCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.DisciplineID, objvCourseLearningCase_Resource_RelCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.DisciplineName, objvCourseLearningCase_Resource_RelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdStudyLevel, objvCourseLearningCase_Resource_RelCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.StudyLevelName, objvCourseLearningCase_Resource_RelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdFile) == true)
{
string strComparisonOpIdFile = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdFile, objvCourseLearningCase_Resource_RelCond.IdFile, strComparisonOpIdFile);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileName) == true)
{
string strComparisonOpFileName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileName, objvCourseLearningCase_Resource_RelCond.FileName, strComparisonOpFileName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileType) == true)
{
string strComparisonOpFileType = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileType, objvCourseLearningCase_Resource_RelCond.FileType, strComparisonOpFileType);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOpSaveDate = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SaveDate, objvCourseLearningCase_Resource_RelCond.SaveDate, strComparisonOpSaveDate);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileSize) == true)
{
string strComparisonOpFileSize = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileSize, objvCourseLearningCase_Resource_RelCond.FileSize, strComparisonOpFileSize);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SaveTime, objvCourseLearningCase_Resource_RelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdSkillType, objvCourseLearningCase_Resource_RelCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdTeachingPlan, objvCourseLearningCase_Resource_RelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdFtpResource, objvCourseLearningCase_Resource_RelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FtpResourceID, objvCourseLearningCase_Resource_RelCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileOriginalName, objvCourseLearningCase_Resource_RelCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOpFileDirName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileDirName, objvCourseLearningCase_Resource_RelCond.FileDirName, strComparisonOpFileDirName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileRename) == true)
{
string strComparisonOpFileRename = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileRename, objvCourseLearningCase_Resource_RelCond.FileRename, strComparisonOpFileRename);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileUpDate, objvCourseLearningCase_Resource_RelCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileUpTime, objvCourseLearningCase_Resource_RelCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdResource, objvCourseLearningCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOpResourceID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceID, objvCourseLearningCase_Resource_RelCond.ResourceID, strComparisonOpResourceID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.SaveMode) == true)
{
if (objvCourseLearningCase_Resource_RelCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.SaveMode);
}
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IsMain) == true)
{
if (objvCourseLearningCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsMain);
}
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdResourceType, objvCourseLearningCase_Resource_RelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceTypeID, objvCourseLearningCase_Resource_RelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceTypeName, objvCourseLearningCase_Resource_RelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.IdUsingMode, objvCourseLearningCase_Resource_RelCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.IndexNO, objvCourseLearningCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseId, objvCourseLearningCase_Resource_RelCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseCode, objvCourseLearningCase_Resource_RelCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseName, objvCourseLearningCase_Resource_RelCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.BrowseCount, objvCourseLearningCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOpResourceName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceName, objvCourseLearningCase_Resource_RelCond.ResourceName, strComparisonOpResourceName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceOwner, objvCourseLearningCase_Resource_RelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ftpFileType, objvCourseLearningCase_Resource_RelCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ftpFileSize, objvCourseLearningCase_Resource_RelCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ftpResourceOwner, objvCourseLearningCase_Resource_RelCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOpVersionNo = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.VersionNo, objvCourseLearningCase_Resource_RelCond.VersionNo, strComparisonOpVersionNo);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileOriginName, objvCourseLearningCase_Resource_RelCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.senateGaugeVersionID, objvCourseLearningCase_Resource_RelCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.senateGaugeVersionName, objvCourseLearningCase_Resource_RelCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore, objvCourseLearningCase_Resource_RelCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CaseLevelId, objvCourseLearningCase_Resource_RelCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IsExistFile) == true)
{
if (objvCourseLearningCase_Resource_RelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsExistFile);
}
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.BrowseCount4Case, objvCourseLearningCase_Resource_RelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileNewName, objvCourseLearningCase_Resource_RelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileOldName, objvCourseLearningCase_Resource_RelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IsDualVideo) == true)
{
if (objvCourseLearningCase_Resource_RelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsDualVideo);
}
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ViewCount) == true)
{
string strComparisonOpViewCount = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.ViewCount, objvCourseLearningCase_Resource_RelCond.ViewCount, strComparisonOpViewCount);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IsShow) == true)
{
if (objvCourseLearningCase_Resource_RelCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsShow);
}
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.DownloadNumber, objvCourseLearningCase_Resource_RelCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.FileIntegration, objvCourseLearningCase_Resource_RelCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.LikeCount) == true)
{
string strComparisonOpLikeCount = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.LikeCount, objvCourseLearningCase_Resource_RelCond.LikeCount, strComparisonOpLikeCount);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.CollectionCount, objvCourseLearningCase_Resource_RelCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.IsVisible) == true)
{
if (objvCourseLearningCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsVisible);
}
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.UpdDate, objvCourseLearningCase_Resource_RelCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.UpdUser, objvCourseLearningCase_Resource_RelCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.Memo, objvCourseLearningCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.RecommendedDegreeId, objvCourseLearningCase_Resource_RelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.RecommendedDegreeName, objvCourseLearningCase_Resource_RelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CollegeNameA, objvCourseLearningCase_Resource_RelCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseChapterId, objvCourseLearningCase_Resource_RelCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseChapterName, objvCourseLearningCase_Resource_RelCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseChapterReferred, objvCourseLearningCase_Resource_RelCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ParentNodeReferred, objvCourseLearningCase_Resource_RelCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ParentNodeID, objvCourseLearningCase_Resource_RelCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(convCourseLearningCase_Resource_Rel.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ParentNodeName, objvCourseLearningCase_Resource_RelCond.ParentNodeName, strComparisonOpParentNodeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例资源关系(vCourseLearningCase_Resource_Rel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase_Resource_RelBL
{
public static RelatedActions_vCourseLearningCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCase_Resource_RelDA vCourseLearningCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCase_Resource_RelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable_vCourseLearningCase_Resource_Rel(strWhereCond);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseResourceRelLst);
 string strWhereCond = string.Format("IdMicroteachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName);
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Sel =
arrvCourseLearningCase_Resource_RelObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvCourseLearningCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCase_Resource_RelEN> GetSubObjLstCache(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelCond)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase_Resource_Rel.AttributeName)
{
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_Resource_RelCond[strFldName]));
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
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
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
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
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCase_Resource_Rel(ref clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
bool bolResult = vCourseLearningCase_Resource_RelDA.GetvCourseLearningCase_Resource_Rel(ref objvCourseLearningCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = vCourseLearningCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvCourseLearningCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = vCourseLearningCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCase_Resource_RelEN;
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
public static clsvCourseLearningCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = vCourseLearningCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase_Resource_RelEN;
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
public static clsvCourseLearningCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = vCourseLearningCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase_Resource_RelEN;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvCourseLearningCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvCourseLearningCase_Resource_RelEN> lstvCourseLearningCase_Resource_RelObjLst)
{
foreach (clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN in lstvCourseLearningCase_Resource_RelObjLst)
{
if (objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvCourseLearningCase_Resource_RelEN;
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
 long lngIdMicroteachCaseResourceRel;
 try
 {
 lngIdMicroteachCaseResourceRel = new clsvCourseLearningCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseResourceRel;
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
 arrList = vCourseLearningCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vCourseLearningCase_Resource_RelDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvCourseLearningCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = vCourseLearningCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCourseLearningCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENS, clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENT)
{
try
{
objvCourseLearningCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvCourseLearningCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelENT.FuncModuleId = objvCourseLearningCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCourseLearningCase_Resource_RelENT.FuncModuleName = objvCourseLearningCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCourseLearningCase_Resource_RelENT.IdMicroteachCase = objvCourseLearningCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseID = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseText = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTheme = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDate = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTime = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_Resource_RelENT.IdCourseLearningCaseType = objvCourseLearningCase_Resource_RelENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_Resource_RelENT.OwnerId = objvCourseLearningCase_Resource_RelENS.OwnerId; //拥有者Id
objvCourseLearningCase_Resource_RelENT.OwnerName = objvCourseLearningCase_Resource_RelENS.OwnerName; //拥有者姓名
objvCourseLearningCase_Resource_RelENT.OwnerNameWithId = objvCourseLearningCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_Resource_RelENT.IdXzMajor = objvCourseLearningCase_Resource_RelENS.IdXzMajor; //专业流水号
objvCourseLearningCase_Resource_RelENT.MajorID = objvCourseLearningCase_Resource_RelENS.MajorID; //专业ID
objvCourseLearningCase_Resource_RelENT.MajorName = objvCourseLearningCase_Resource_RelENS.MajorName; //专业名称
objvCourseLearningCase_Resource_RelENT.IdXzCollege = objvCourseLearningCase_Resource_RelENS.IdXzCollege; //学院流水号
objvCourseLearningCase_Resource_RelENT.CollegeID = objvCourseLearningCase_Resource_RelENS.CollegeID; //学院ID
objvCourseLearningCase_Resource_RelENT.CollegeName = objvCourseLearningCase_Resource_RelENS.CollegeName; //学院名称
objvCourseLearningCase_Resource_RelENT.IdTeachSkill = objvCourseLearningCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCase_Resource_RelENT.TeachSkillID = objvCourseLearningCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_Resource_RelENT.TeachSkillName = objvCourseLearningCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_Resource_RelENT.TeachSkillTheory = objvCourseLearningCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_Resource_RelENT.TeachSkillOperMethod = objvCourseLearningCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_Resource_RelENT.SkillTypeID = objvCourseLearningCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_Resource_RelENT.SkillTypeName = objvCourseLearningCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_Resource_RelENT.IdDiscipline = objvCourseLearningCase_Resource_RelENS.IdDiscipline; //学科流水号
objvCourseLearningCase_Resource_RelENT.DisciplineID = objvCourseLearningCase_Resource_RelENS.DisciplineID; //学科ID
objvCourseLearningCase_Resource_RelENT.DisciplineName = objvCourseLearningCase_Resource_RelENS.DisciplineName; //学科名称
objvCourseLearningCase_Resource_RelENT.IdStudyLevel = objvCourseLearningCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCase_Resource_RelENT.StudyLevelName = objvCourseLearningCase_Resource_RelENS.StudyLevelName; //学段名称
objvCourseLearningCase_Resource_RelENT.IdFile = objvCourseLearningCase_Resource_RelENS.IdFile; //文件流水号
objvCourseLearningCase_Resource_RelENT.FileName = objvCourseLearningCase_Resource_RelENS.FileName; //文件名称
objvCourseLearningCase_Resource_RelENT.FileType = objvCourseLearningCase_Resource_RelENS.FileType; //文件类型
objvCourseLearningCase_Resource_RelENT.SaveDate = objvCourseLearningCase_Resource_RelENS.SaveDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileSize = objvCourseLearningCase_Resource_RelENS.FileSize; //文件大小
objvCourseLearningCase_Resource_RelENT.SaveTime = objvCourseLearningCase_Resource_RelENS.SaveTime; //创建时间
objvCourseLearningCase_Resource_RelENT.IdSkillType = objvCourseLearningCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvCourseLearningCase_Resource_RelENT.IdTeachingPlan = objvCourseLearningCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvCourseLearningCase_Resource_RelENT.IdFtpResource = objvCourseLearningCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCase_Resource_RelENT.FtpResourceID = objvCourseLearningCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCourseLearningCase_Resource_RelENT.FileOriginalName = objvCourseLearningCase_Resource_RelENS.FileOriginalName; //文件原名
objvCourseLearningCase_Resource_RelENT.FileDirName = objvCourseLearningCase_Resource_RelENS.FileDirName; //文件目录名
objvCourseLearningCase_Resource_RelENT.FileRename = objvCourseLearningCase_Resource_RelENS.FileRename; //文件新名
objvCourseLearningCase_Resource_RelENT.FileUpDate = objvCourseLearningCase_Resource_RelENS.FileUpDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileUpTime = objvCourseLearningCase_Resource_RelENS.FileUpTime; //创建时间
objvCourseLearningCase_Resource_RelENT.IdResource = objvCourseLearningCase_Resource_RelENS.IdResource; //资源流水号
objvCourseLearningCase_Resource_RelENT.ResourceID = objvCourseLearningCase_Resource_RelENS.ResourceID; //资源ID
objvCourseLearningCase_Resource_RelENT.SaveMode = objvCourseLearningCase_Resource_RelENS.SaveMode; //文件存放方式
objvCourseLearningCase_Resource_RelENT.IsMain = objvCourseLearningCase_Resource_RelENS.IsMain; //是否主资源
objvCourseLearningCase_Resource_RelENT.IdResourceType = objvCourseLearningCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvCourseLearningCase_Resource_RelENT.ResourceTypeID = objvCourseLearningCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCase_Resource_RelENT.ResourceTypeName = objvCourseLearningCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCase_Resource_RelENT.IdUsingMode = objvCourseLearningCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvCourseLearningCase_Resource_RelENT.IndexNO = objvCourseLearningCase_Resource_RelENS.IndexNO; //序号
objvCourseLearningCase_Resource_RelENT.CourseId = objvCourseLearningCase_Resource_RelENS.CourseId; //课程Id
objvCourseLearningCase_Resource_RelENT.CourseCode = objvCourseLearningCase_Resource_RelENS.CourseCode; //课程代码
objvCourseLearningCase_Resource_RelENT.CourseName = objvCourseLearningCase_Resource_RelENS.CourseName; //课程名称
objvCourseLearningCase_Resource_RelENT.BrowseCount = objvCourseLearningCase_Resource_RelENS.BrowseCount; //浏览次数
objvCourseLearningCase_Resource_RelENT.ResourceName = objvCourseLearningCase_Resource_RelENS.ResourceName; //资源名称
objvCourseLearningCase_Resource_RelENT.ResourceOwner = objvCourseLearningCase_Resource_RelENS.ResourceOwner; //上传者
objvCourseLearningCase_Resource_RelENT.ftpFileType = objvCourseLearningCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_Resource_RelENT.ftpFileSize = objvCourseLearningCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCourseLearningCase_Resource_RelENT.ftpResourceOwner = objvCourseLearningCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCase_Resource_RelENT.VersionNo = objvCourseLearningCase_Resource_RelENS.VersionNo; //版本号
objvCourseLearningCase_Resource_RelENT.FileOriginName = objvCourseLearningCase_Resource_RelENS.FileOriginName; //原文件名
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionID = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionName = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_Resource_RelENT.CaseLevelId = objvCourseLearningCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_Resource_RelENT.IsExistFile = objvCourseLearningCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCourseLearningCase_Resource_RelENT.BrowseCount4Case = objvCourseLearningCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_Resource_RelENT.FileNewName = objvCourseLearningCase_Resource_RelENS.FileNewName; //新文件名
objvCourseLearningCase_Resource_RelENT.FileOldName = objvCourseLearningCase_Resource_RelENS.FileOldName; //旧文件名
objvCourseLearningCase_Resource_RelENT.IsDualVideo = objvCourseLearningCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCourseLearningCase_Resource_RelENT.ViewCount = objvCourseLearningCase_Resource_RelENS.ViewCount; //浏览量
objvCourseLearningCase_Resource_RelENT.IsShow = objvCourseLearningCase_Resource_RelENS.IsShow; //是否启用
objvCourseLearningCase_Resource_RelENT.DownloadNumber = objvCourseLearningCase_Resource_RelENS.DownloadNumber; //下载数目
objvCourseLearningCase_Resource_RelENT.FileIntegration = objvCourseLearningCase_Resource_RelENS.FileIntegration; //文件积分
objvCourseLearningCase_Resource_RelENT.LikeCount = objvCourseLearningCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_Resource_RelENT.CollectionCount = objvCourseLearningCase_Resource_RelENS.CollectionCount; //收藏数量
objvCourseLearningCase_Resource_RelENT.IsVisible = objvCourseLearningCase_Resource_RelENS.IsVisible; //是否显示
objvCourseLearningCase_Resource_RelENT.UpdDate = objvCourseLearningCase_Resource_RelENS.UpdDate; //修改日期
objvCourseLearningCase_Resource_RelENT.UpdUser = objvCourseLearningCase_Resource_RelENS.UpdUser; //修改人
objvCourseLearningCase_Resource_RelENT.Memo = objvCourseLearningCase_Resource_RelENS.Memo; //备注
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeId = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeName = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_Resource_RelENT.CollegeNameA = objvCourseLearningCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_Resource_RelENT.CourseChapterId = objvCourseLearningCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_Resource_RelENT.CourseChapterName = objvCourseLearningCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_Resource_RelENT.CourseChapterReferred = objvCourseLearningCase_Resource_RelENS.CourseChapterReferred; //节简称
objvCourseLearningCase_Resource_RelENT.ParentNodeReferred = objvCourseLearningCase_Resource_RelENS.ParentNodeReferred; //章简称
objvCourseLearningCase_Resource_RelENT.ParentNodeID = objvCourseLearningCase_Resource_RelENS.ParentNodeID; //父节点编号
objvCourseLearningCase_Resource_RelENT.ParentNodeName = objvCourseLearningCase_Resource_RelENS.ParentNodeName; //父节点名称
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
 /// <param name = "objvCourseLearningCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
try
{
objvCourseLearningCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objvCourseLearningCase_Resource_RelEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objvCourseLearningCase_Resource_RelEN.FuncModuleName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objvCourseLearningCase_Resource_RelEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText; //案例文本内容
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType; //课程学习案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName; //课程学习案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.OwnerId = objvCourseLearningCase_Resource_RelEN.OwnerId == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.OwnerName = objvCourseLearningCase_Resource_RelEN.OwnerName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objvCourseLearningCase_Resource_RelEN.OwnerNameWithId == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objvCourseLearningCase_Resource_RelEN.IdXzMajor == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.MajorID = objvCourseLearningCase_Resource_RelEN.MajorID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.MajorName = objvCourseLearningCase_Resource_RelEN.MajorName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objvCourseLearningCase_Resource_RelEN.IdXzCollege == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CollegeID = objvCourseLearningCase_Resource_RelEN.CollegeID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CollegeName = objvCourseLearningCase_Resource_RelEN.CollegeName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objvCourseLearningCase_Resource_RelEN.IdTeachSkill == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objvCourseLearningCase_Resource_RelEN.TeachSkillID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objvCourseLearningCase_Resource_RelEN.TeachSkillName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objvCourseLearningCase_Resource_RelEN.TeachSkillTheory == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objvCourseLearningCase_Resource_RelEN.SkillTypeID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objvCourseLearningCase_Resource_RelEN.SkillTypeName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objvCourseLearningCase_Resource_RelEN.IdDiscipline == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.DisciplineID = objvCourseLearningCase_Resource_RelEN.DisciplineID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.DisciplineName = objvCourseLearningCase_Resource_RelEN.DisciplineName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objvCourseLearningCase_Resource_RelEN.IdStudyLevel == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objvCourseLearningCase_Resource_RelEN.StudyLevelName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdFile = objvCourseLearningCase_Resource_RelEN.IdFile == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileName = objvCourseLearningCase_Resource_RelEN.FileName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileName; //文件名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileType = objvCourseLearningCase_Resource_RelEN.FileType == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileType; //文件类型
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.SaveDate = objvCourseLearningCase_Resource_RelEN.SaveDate == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileSize = objvCourseLearningCase_Resource_RelEN.FileSize == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.SaveTime = objvCourseLearningCase_Resource_RelEN.SaveTime == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdSkillType = objvCourseLearningCase_Resource_RelEN.IdSkillType == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objvCourseLearningCase_Resource_RelEN.IdTeachingPlan == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objvCourseLearningCase_Resource_RelEN.IdFtpResource == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objvCourseLearningCase_Resource_RelEN.FtpResourceID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objvCourseLearningCase_Resource_RelEN.FileOriginalName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileDirName = objvCourseLearningCase_Resource_RelEN.FileDirName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileRename = objvCourseLearningCase_Resource_RelEN.FileRename == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileUpDate = objvCourseLearningCase_Resource_RelEN.FileUpDate == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileUpTime = objvCourseLearningCase_Resource_RelEN.FileUpTime == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdResource = objvCourseLearningCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ResourceID = objvCourseLearningCase_Resource_RelEN.ResourceID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.SaveMode = objvCourseLearningCase_Resource_RelEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IsMain = objvCourseLearningCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdResourceType = objvCourseLearningCase_Resource_RelEN.IdResourceType == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objvCourseLearningCase_Resource_RelEN.ResourceTypeID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objvCourseLearningCase_Resource_RelEN.ResourceTypeName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objvCourseLearningCase_Resource_RelEN.IdUsingMode == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IndexNO = objvCourseLearningCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseId = objvCourseLearningCase_Resource_RelEN.CourseId == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseCode = objvCourseLearningCase_Resource_RelEN.CourseCode == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseName = objvCourseLearningCase_Resource_RelEN.CourseName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.BrowseCount = objvCourseLearningCase_Resource_RelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ResourceName = objvCourseLearningCase_Resource_RelEN.ResourceName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objvCourseLearningCase_Resource_RelEN.ResourceOwner == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ftpFileType = objvCourseLearningCase_Resource_RelEN.ftpFileType == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objvCourseLearningCase_Resource_RelEN.ftpFileSize == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objvCourseLearningCase_Resource_RelEN.ftpResourceOwner == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.VersionNo = objvCourseLearningCase_Resource_RelEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileOriginName = objvCourseLearningCase_Resource_RelEN.FileOriginName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objvCourseLearningCase_Resource_RelEN.CaseLevelId == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IsExistFile = objvCourseLearningCase_Resource_RelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objvCourseLearningCase_Resource_RelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileNewName = objvCourseLearningCase_Resource_RelEN.FileNewName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileOldName = objvCourseLearningCase_Resource_RelEN.FileOldName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IsDualVideo = objvCourseLearningCase_Resource_RelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ViewCount = objvCourseLearningCase_Resource_RelEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IsShow = objvCourseLearningCase_Resource_RelEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objvCourseLearningCase_Resource_RelEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.FileIntegration = objvCourseLearningCase_Resource_RelEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.LikeCount = objvCourseLearningCase_Resource_RelEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CollectionCount = objvCourseLearningCase_Resource_RelEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.IsVisible = objvCourseLearningCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.UpdDate = objvCourseLearningCase_Resource_RelEN.UpdDate == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.UpdUser = objvCourseLearningCase_Resource_RelEN.UpdUser == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.Memo = objvCourseLearningCase_Resource_RelEN.Memo == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.Memo; //备注
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objvCourseLearningCase_Resource_RelEN.CollegeNameA == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objvCourseLearningCase_Resource_RelEN.CourseChapterId == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objvCourseLearningCase_Resource_RelEN.CourseChapterName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objvCourseLearningCase_Resource_RelEN.CourseChapterReferred == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objvCourseLearningCase_Resource_RelEN.ParentNodeReferred == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objvCourseLearningCase_Resource_RelEN.ParentNodeID == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convCourseLearningCase_Resource_Rel.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objvCourseLearningCase_Resource_RelEN.ParentNodeName == "[null]" ? null :  objvCourseLearningCase_Resource_RelEN.ParentNodeName; //父节点名称
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
 /// <param name = "objvCourseLearningCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
try
{
if (objvCourseLearningCase_Resource_RelEN.FuncModuleName == "[null]") objvCourseLearningCase_Resource_RelEN.FuncModuleName = null; //功能模块名称
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = null; //课程学习案例ID
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = null; //课程学习案例名称
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = null; //案例文本内容
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = null; //课程学习日期
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = null; //课程学习时间
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType == "[null]") objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = null; //课程学习案例类型流水号
if (objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName == "[null]") objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = null; //课程学习案例类型名称
if (objvCourseLearningCase_Resource_RelEN.OwnerId == "[null]") objvCourseLearningCase_Resource_RelEN.OwnerId = null; //拥有者Id
if (objvCourseLearningCase_Resource_RelEN.OwnerName == "[null]") objvCourseLearningCase_Resource_RelEN.OwnerName = null; //拥有者姓名
if (objvCourseLearningCase_Resource_RelEN.OwnerNameWithId == "[null]") objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvCourseLearningCase_Resource_RelEN.IdXzMajor == "[null]") objvCourseLearningCase_Resource_RelEN.IdXzMajor = null; //专业流水号
if (objvCourseLearningCase_Resource_RelEN.MajorID == "[null]") objvCourseLearningCase_Resource_RelEN.MajorID = null; //专业ID
if (objvCourseLearningCase_Resource_RelEN.MajorName == "[null]") objvCourseLearningCase_Resource_RelEN.MajorName = null; //专业名称
if (objvCourseLearningCase_Resource_RelEN.IdXzCollege == "[null]") objvCourseLearningCase_Resource_RelEN.IdXzCollege = null; //学院流水号
if (objvCourseLearningCase_Resource_RelEN.CollegeID == "[null]") objvCourseLearningCase_Resource_RelEN.CollegeID = null; //学院ID
if (objvCourseLearningCase_Resource_RelEN.CollegeName == "[null]") objvCourseLearningCase_Resource_RelEN.CollegeName = null; //学院名称
if (objvCourseLearningCase_Resource_RelEN.IdTeachSkill == "[null]") objvCourseLearningCase_Resource_RelEN.IdTeachSkill = null; //教学技能流水号
if (objvCourseLearningCase_Resource_RelEN.TeachSkillID == "[null]") objvCourseLearningCase_Resource_RelEN.TeachSkillID = null; //教学技能ID
if (objvCourseLearningCase_Resource_RelEN.TeachSkillName == "[null]") objvCourseLearningCase_Resource_RelEN.TeachSkillName = null; //教学技能名称
if (objvCourseLearningCase_Resource_RelEN.TeachSkillTheory == "[null]") objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod == "[null]") objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvCourseLearningCase_Resource_RelEN.SkillTypeID == "[null]") objvCourseLearningCase_Resource_RelEN.SkillTypeID = null; //技能类型ID
if (objvCourseLearningCase_Resource_RelEN.SkillTypeName == "[null]") objvCourseLearningCase_Resource_RelEN.SkillTypeName = null; //技能类型名称
if (objvCourseLearningCase_Resource_RelEN.IdDiscipline == "[null]") objvCourseLearningCase_Resource_RelEN.IdDiscipline = null; //学科流水号
if (objvCourseLearningCase_Resource_RelEN.DisciplineID == "[null]") objvCourseLearningCase_Resource_RelEN.DisciplineID = null; //学科ID
if (objvCourseLearningCase_Resource_RelEN.DisciplineName == "[null]") objvCourseLearningCase_Resource_RelEN.DisciplineName = null; //学科名称
if (objvCourseLearningCase_Resource_RelEN.IdStudyLevel == "[null]") objvCourseLearningCase_Resource_RelEN.IdStudyLevel = null; //id_StudyLevel
if (objvCourseLearningCase_Resource_RelEN.StudyLevelName == "[null]") objvCourseLearningCase_Resource_RelEN.StudyLevelName = null; //学段名称
if (objvCourseLearningCase_Resource_RelEN.IdFile == "[null]") objvCourseLearningCase_Resource_RelEN.IdFile = null; //文件流水号
if (objvCourseLearningCase_Resource_RelEN.FileName == "[null]") objvCourseLearningCase_Resource_RelEN.FileName = null; //文件名称
if (objvCourseLearningCase_Resource_RelEN.FileType == "[null]") objvCourseLearningCase_Resource_RelEN.FileType = null; //文件类型
if (objvCourseLearningCase_Resource_RelEN.SaveDate == "[null]") objvCourseLearningCase_Resource_RelEN.SaveDate = null; //创建日期
if (objvCourseLearningCase_Resource_RelEN.FileSize == "[null]") objvCourseLearningCase_Resource_RelEN.FileSize = null; //文件大小
if (objvCourseLearningCase_Resource_RelEN.SaveTime == "[null]") objvCourseLearningCase_Resource_RelEN.SaveTime = null; //创建时间
if (objvCourseLearningCase_Resource_RelEN.IdSkillType == "[null]") objvCourseLearningCase_Resource_RelEN.IdSkillType = null; //技能类型流水号
if (objvCourseLearningCase_Resource_RelEN.IdTeachingPlan == "[null]") objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = null; //教案流水号
if (objvCourseLearningCase_Resource_RelEN.IdFtpResource == "[null]") objvCourseLearningCase_Resource_RelEN.IdFtpResource = null; //FTP资源流水号
if (objvCourseLearningCase_Resource_RelEN.FtpResourceID == "[null]") objvCourseLearningCase_Resource_RelEN.FtpResourceID = null; //FTP资源ID
if (objvCourseLearningCase_Resource_RelEN.FileOriginalName == "[null]") objvCourseLearningCase_Resource_RelEN.FileOriginalName = null; //文件原名
if (objvCourseLearningCase_Resource_RelEN.FileDirName == "[null]") objvCourseLearningCase_Resource_RelEN.FileDirName = null; //文件目录名
if (objvCourseLearningCase_Resource_RelEN.FileRename == "[null]") objvCourseLearningCase_Resource_RelEN.FileRename = null; //文件新名
if (objvCourseLearningCase_Resource_RelEN.FileUpDate == "[null]") objvCourseLearningCase_Resource_RelEN.FileUpDate = null; //创建日期
if (objvCourseLearningCase_Resource_RelEN.FileUpTime == "[null]") objvCourseLearningCase_Resource_RelEN.FileUpTime = null; //创建时间
if (objvCourseLearningCase_Resource_RelEN.ResourceID == "[null]") objvCourseLearningCase_Resource_RelEN.ResourceID = null; //资源ID
if (objvCourseLearningCase_Resource_RelEN.IdResourceType == "[null]") objvCourseLearningCase_Resource_RelEN.IdResourceType = null; //资源类型流水号
if (objvCourseLearningCase_Resource_RelEN.ResourceTypeID == "[null]") objvCourseLearningCase_Resource_RelEN.ResourceTypeID = null; //资源类型ID
if (objvCourseLearningCase_Resource_RelEN.ResourceTypeName == "[null]") objvCourseLearningCase_Resource_RelEN.ResourceTypeName = null; //资源类型名称
if (objvCourseLearningCase_Resource_RelEN.IdUsingMode == "[null]") objvCourseLearningCase_Resource_RelEN.IdUsingMode = null; //资源使用模式流水号
if (objvCourseLearningCase_Resource_RelEN.CourseId == "[null]") objvCourseLearningCase_Resource_RelEN.CourseId = null; //课程Id
if (objvCourseLearningCase_Resource_RelEN.CourseCode == "[null]") objvCourseLearningCase_Resource_RelEN.CourseCode = null; //课程代码
if (objvCourseLearningCase_Resource_RelEN.CourseName == "[null]") objvCourseLearningCase_Resource_RelEN.CourseName = null; //课程名称
if (objvCourseLearningCase_Resource_RelEN.ResourceName == "[null]") objvCourseLearningCase_Resource_RelEN.ResourceName = null; //资源名称
if (objvCourseLearningCase_Resource_RelEN.ResourceOwner == "[null]") objvCourseLearningCase_Resource_RelEN.ResourceOwner = null; //上传者
if (objvCourseLearningCase_Resource_RelEN.ftpFileType == "[null]") objvCourseLearningCase_Resource_RelEN.ftpFileType = null; //ftp文件类型
if (objvCourseLearningCase_Resource_RelEN.ftpFileSize == "[null]") objvCourseLearningCase_Resource_RelEN.ftpFileSize = null; //ftp文件大小
if (objvCourseLearningCase_Resource_RelEN.ftpResourceOwner == "[null]") objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvCourseLearningCase_Resource_RelEN.FileOriginName == "[null]") objvCourseLearningCase_Resource_RelEN.FileOriginName = null; //原文件名
if (objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID == "[null]") objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName == "[null]") objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvCourseLearningCase_Resource_RelEN.CaseLevelId == "[null]") objvCourseLearningCase_Resource_RelEN.CaseLevelId = null; //课例等级Id
if (objvCourseLearningCase_Resource_RelEN.FileNewName == "[null]") objvCourseLearningCase_Resource_RelEN.FileNewName = null; //新文件名
if (objvCourseLearningCase_Resource_RelEN.FileOldName == "[null]") objvCourseLearningCase_Resource_RelEN.FileOldName = null; //旧文件名
if (objvCourseLearningCase_Resource_RelEN.UpdDate == "[null]") objvCourseLearningCase_Resource_RelEN.UpdDate = null; //修改日期
if (objvCourseLearningCase_Resource_RelEN.UpdUser == "[null]") objvCourseLearningCase_Resource_RelEN.UpdUser = null; //修改人
if (objvCourseLearningCase_Resource_RelEN.Memo == "[null]") objvCourseLearningCase_Resource_RelEN.Memo = null; //备注
if (objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId == "[null]") objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = null; //推荐度Id
if (objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName == "[null]") objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = null; //推荐度名称
if (objvCourseLearningCase_Resource_RelEN.CollegeNameA == "[null]") objvCourseLearningCase_Resource_RelEN.CollegeNameA = null; //学院名称简写
if (objvCourseLearningCase_Resource_RelEN.CourseChapterId == "[null]") objvCourseLearningCase_Resource_RelEN.CourseChapterId = null; //课程章节ID
if (objvCourseLearningCase_Resource_RelEN.CourseChapterName == "[null]") objvCourseLearningCase_Resource_RelEN.CourseChapterName = null; //课程章节名称
if (objvCourseLearningCase_Resource_RelEN.CourseChapterReferred == "[null]") objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = null; //节简称
if (objvCourseLearningCase_Resource_RelEN.ParentNodeReferred == "[null]") objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = null; //章简称
if (objvCourseLearningCase_Resource_RelEN.ParentNodeID == "[null]") objvCourseLearningCase_Resource_RelEN.ParentNodeID = null; //父节点编号
if (objvCourseLearningCase_Resource_RelEN.ParentNodeName == "[null]") objvCourseLearningCase_Resource_RelEN.ParentNodeName = null; //父节点名称
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
public static void CheckProperty4Condition(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
 vCourseLearningCase_Resource_RelDA.CheckProperty4Condition(objvCourseLearningCase_Resource_RelEN);
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
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelBL没有刷新缓存机制(clsMicroteachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeBL没有刷新缓存机制(clsCourseLearningCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeBL没有刷新缓存机制(clsCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvCourseLearningCase_Resource_RelObjLstCache == null)
//{
//arrvCourseLearningCase_Resource_RelObjLstCache = vCourseLearningCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName);
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Sel =
arrvCourseLearningCase_Resource_RelObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvCourseLearningCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase_Resource_RelEN obj = clsvCourseLearningCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetAllvCourseLearningCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName);
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseResourceRel)
{
if (strInFldName != convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCase_Resource_Rel = clsvCourseLearningCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvCourseLearningCase_Resource_Rel == null) return "";
return objvCourseLearningCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelCond)
{
List<clsvCourseLearningCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase_Resource_Rel.AttributeName)
{
if (objvCourseLearningCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}