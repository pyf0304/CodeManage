
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseBL
 表名:vCourseLearningCase(01120267)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvCourseLearningCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseEN GetObj(this K_IdCourseLearningCase_vCourseLearningCase myKey)
{
clsvCourseLearningCaseEN objvCourseLearningCaseEN = clsvCourseLearningCaseBL.vCourseLearningCaseDA.GetObjByIdCourseLearningCase(myKey.Value);
return objvCourseLearningCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdCourseLearningCase(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCase.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCase.IdCourseLearningCase);
}
objvCourseLearningCaseEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdCourseLearningCase) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase.CourseLearningCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase.CourseLearningCaseID);
}
objvCourseLearningCaseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase.CourseLearningCaseName);
}
objvCourseLearningCaseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseText(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCase.CourseLearningCaseText);
}
objvCourseLearningCaseEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseText) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTheme(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCase.CourseLearningCaseTheme);
}
objvCourseLearningCaseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTheme) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseDate(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCase.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCase.CourseLearningCaseDate);
}
objvCourseLearningCaseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseDate) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTime(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCase.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCase.CourseLearningCaseTime);
}
objvCourseLearningCaseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTime) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseDateIn(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCase.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCase.CourseLearningCaseDateIn);
}
objvCourseLearningCaseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCase.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCase.CourseLearningCaseTimeIn);
}
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdCaseType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convCourseLearningCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convCourseLearningCase.IdCaseType);
}
objvCourseLearningCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdCaseType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdCaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdCaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCaseTypeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convCourseLearningCase.CaseTypeName);
}
objvCourseLearningCaseEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CaseTypeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdCourseLearningCaseType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdCourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourseLearningCaseType, convCourseLearningCase.IdCourseLearningCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCaseType, 4, convCourseLearningCase.IdCourseLearningCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCaseType, 4, convCourseLearningCase.IdCourseLearningCaseType);
}
objvCourseLearningCaseEN.IdCourseLearningCaseType = strIdCourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdCourseLearningCaseType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdCourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdCourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTypeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCase.CourseLearningCaseTypeName);
}
objvCourseLearningCaseEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOwnerId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCase.OwnerId);
}
objvCourseLearningCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OwnerId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdStudyLevel(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convCourseLearningCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convCourseLearningCase.IdStudyLevel);
}
objvCourseLearningCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdStudyLevel) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdStudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdStudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetStudyLevelName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCase.StudyLevelName);
}
objvCourseLearningCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.StudyLevelName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdTeachingPlan(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convCourseLearningCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convCourseLearningCase.IdTeachingPlan);
}
objvCourseLearningCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdTeachingPlan) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdDiscipline(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convCourseLearningCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convCourseLearningCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convCourseLearningCase.IdDiscipline);
}
objvCourseLearningCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdDiscipline) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdDiscipline, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdDiscipline] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDisciplineID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCase.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCase.DisciplineID);
}
objvCourseLearningCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DisciplineID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDisciplineName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCase.DisciplineName);
}
objvCourseLearningCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DisciplineName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdSenateGaugeVersion(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convCourseLearningCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convCourseLearningCase.IdSenateGaugeVersion);
}
objvCourseLearningCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdSenateGaugeVersion) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetsenateGaugeVersionID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCase.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCase.senateGaugeVersionID);
}
objvCourseLearningCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.senateGaugeVersionID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetsenateGaugeVersionName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCase.senateGaugeVersionName);
}
objvCourseLearningCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.senateGaugeVersionName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsUse(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsUse, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsUse) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsUse, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsUse] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetVersionNo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int? intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.VersionNo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdTeachSkill(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convCourseLearningCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convCourseLearningCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convCourseLearningCase.IdTeachSkill);
}
objvCourseLearningCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdTeachSkill) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdTeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdTeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCase.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCase.TeachSkillID);
}
objvCourseLearningCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSkillTypeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCase.SkillTypeName);
}
objvCourseLearningCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SkillTypeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCase.TeachSkillName);
}
objvCourseLearningCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillTheory(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCase.TeachSkillTheory);
}
objvCourseLearningCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillTheory) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillOperMethod(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCase.TeachSkillOperMethod);
}
objvCourseLearningCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillOperMethod) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdSkillType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convCourseLearningCase.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convCourseLearningCase.IdSkillType);
}
objvCourseLearningCaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdSkillType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdSkillType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdSkillType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSkillTypeID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCase.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCase.SkillTypeID);
}
objvCourseLearningCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SkillTypeID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCaseLevelId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCase.CaseLevelId);
}
objvCourseLearningCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CaseLevelId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCaseLevelName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCourseLearningCase.CaseLevelName);
}
objvCourseLearningCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CaseLevelName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CaseLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CaseLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDocFile(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCourseLearningCase.DocFile);
}
objvCourseLearningCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DocFile) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DocFile, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DocFile] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsNeedGeneWord(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsNeedGeneWord) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetWordCreateDate(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCourseLearningCase.WordCreateDate);
}
objvCourseLearningCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.WordCreateDate) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.WordCreateDate, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.WordCreateDate] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsVisible(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsVisible) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsDualVideo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsDualVideo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdXzCollege(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningCase.IdXzCollege);
}
objvCourseLearningCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdXzCollege) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollegeId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convCourseLearningCase.CollegeId);
}
objvCourseLearningCaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollegeId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollegeId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollegeId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollegeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCase.CollegeName);
}
objvCourseLearningCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollegeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollegeNameA(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCase.CollegeNameA);
}
objvCourseLearningCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollegeNameA) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIdXzMajor(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCourseLearningCase.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCourseLearningCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCourseLearningCase.IdXzMajor);
}
objvCourseLearningCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IdXzMajor) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IdXzMajor, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IdXzMajor] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetMajorID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCase.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCase.MajorID);
}
objvCourseLearningCaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.MajorID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetMajorName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCase.MajorName);
}
objvCourseLearningCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.MajorName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase.CourseId);
}
objvCourseLearningCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseCode(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase.CourseCode);
}
objvCourseLearningCaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseCode) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase.CourseName);
}
objvCourseLearningCaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseChapterId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase.CourseChapterId);
}
objvCourseLearningCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseChapterId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseChapterName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCase.CourseChapterName);
}
objvCourseLearningCaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseChapterName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetChapterId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase.ChapterId);
}
objvCourseLearningCaseEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ChapterId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ChapterId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ChapterId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSectionId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convCourseLearningCase.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convCourseLearningCase.SectionId);
}
objvCourseLearningCaseEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SectionId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SectionId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SectionId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetChapterName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase.ChapterName);
}
objvCourseLearningCaseEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ChapterName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ChapterName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ChapterName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSectionName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convCourseLearningCase.SectionName);
}
objvCourseLearningCaseEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SectionName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SectionName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SectionName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetChapterNameSim(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convCourseLearningCase.ChapterNameSim);
}
objvCourseLearningCaseEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ChapterNameSim) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ChapterNameSim, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ChapterNameSim] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSectionNameSim(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convCourseLearningCase.SectionNameSim);
}
objvCourseLearningCaseEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SectionNameSim) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SectionNameSim, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SectionNameSim] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetParentNodeId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convCourseLearningCase.ParentNodeId);
}
objvCourseLearningCaseEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ParentNodeId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ParentNodeId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ParentNodeId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseChapterReferred(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCase.CourseChapterReferred);
}
objvCourseLearningCaseEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseChapterReferred) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetParentNodeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convCourseLearningCase.ParentNodeName);
}
objvCourseLearningCaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ParentNodeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetParentNodeReferred(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCase.ParentNodeReferred);
}
objvCourseLearningCaseEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ParentNodeReferred) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetViewCount(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int? intViewCount, string strComparisonOp="")
	{
objvCourseLearningCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ViewCount) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsShow(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsShow) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDownloadNumber(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DownloadNumber) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetFileIntegration(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.FileIntegration) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetLikeCount(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.LikeCount) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollectionCount(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollectionCount) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetRecommendedDegreeId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase.RecommendedDegreeId);
}
objvCourseLearningCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.RecommendedDegreeId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetRecommendedDegreeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCase.RecommendedDegreeName);
}
objvCourseLearningCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.RecommendedDegreeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetftpFileType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCase.ftpFileType);
}
objvCourseLearningCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ftpFileType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetVideoUrl(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCourseLearningCase.VideoUrl);
}
objvCourseLearningCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.VideoUrl) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.VideoUrl, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.VideoUrl] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetVideoPath(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCourseLearningCase.VideoPath);
}
objvCourseLearningCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.VideoPath) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.VideoPath, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.VideoPath] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetImageUrl(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convCourseLearningCase.ImageUrl);
}
objvCourseLearningCaseEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ImageUrl) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ImageUrl, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ImageUrl] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetResErrMsg(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCourseLearningCase.ResErrMsg);
}
objvCourseLearningCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ResErrMsg) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ResErrMsg, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ResErrMsg] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOrderNum(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int? intOrderNum, string strComparisonOp="")
	{
objvCourseLearningCaseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OrderNum) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OrderNum, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OrderNum] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetUpdDate(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCase.UpdDate);
}
objvCourseLearningCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.UpdDate) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetUpdUserId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCourseLearningCase.UpdUserId);
}
objvCourseLearningCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.UpdUserId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.UpdUserId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.UpdUserId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetMemo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase.Memo);
}
objvCourseLearningCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.Memo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsHaveVideo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convCourseLearningCase.IsHaveVideo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convCourseLearningCase.IsHaveVideo);
}
objvCourseLearningCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsHaveVideo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsHaveVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsHaveVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetBrowseCount4Case(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.BrowseCount4Case) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOwnerName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCase.OwnerName);
}
objvCourseLearningCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OwnerName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOwnerNameWithId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCase.OwnerNameWithId);
}
objvCourseLearningCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OwnerNameWithId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCaseENS">源对象</param>
 /// <param name = "objvCourseLearningCaseENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCaseEN objvCourseLearningCaseENS, clsvCourseLearningCaseEN objvCourseLearningCaseENT)
{
try
{
objvCourseLearningCaseENT.IdCourseLearningCase = objvCourseLearningCaseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseENT.CourseLearningCaseID = objvCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseENT.CourseLearningCaseName = objvCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseENT.CourseLearningCaseText = objvCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseENT.CourseLearningCaseTheme = objvCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseENT.CourseLearningCaseDate = objvCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseENT.CourseLearningCaseTime = objvCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseENT.CourseLearningCaseDateIn = objvCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseENT.CourseLearningCaseTimeIn = objvCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseENT.IdCaseType = objvCourseLearningCaseENS.IdCaseType; //案例类型流水号
objvCourseLearningCaseENT.CaseTypeName = objvCourseLearningCaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCaseENT.IdCourseLearningCaseType = objvCourseLearningCaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseENT.CourseLearningCaseTypeName = objvCourseLearningCaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseENT.OwnerId = objvCourseLearningCaseENS.OwnerId; //拥有者Id
objvCourseLearningCaseENT.IdStudyLevel = objvCourseLearningCaseENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCaseENT.StudyLevelName = objvCourseLearningCaseENS.StudyLevelName; //学段名称
objvCourseLearningCaseENT.IdTeachingPlan = objvCourseLearningCaseENS.IdTeachingPlan; //教案流水号
objvCourseLearningCaseENT.IdDiscipline = objvCourseLearningCaseENS.IdDiscipline; //学科流水号
objvCourseLearningCaseENT.DisciplineID = objvCourseLearningCaseENS.DisciplineID; //学科ID
objvCourseLearningCaseENT.DisciplineName = objvCourseLearningCaseENS.DisciplineName; //学科名称
objvCourseLearningCaseENT.IdSenateGaugeVersion = objvCourseLearningCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseENT.senateGaugeVersionID = objvCourseLearningCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseENT.senateGaugeVersionName = objvCourseLearningCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseENT.senateGaugeVersionTtlScore = objvCourseLearningCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseENT.IsUse = objvCourseLearningCaseENS.IsUse; //是否使用
objvCourseLearningCaseENT.VersionNo = objvCourseLearningCaseENS.VersionNo; //版本号
objvCourseLearningCaseENT.IdTeachSkill = objvCourseLearningCaseENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCaseENT.TeachSkillID = objvCourseLearningCaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseENT.SkillTypeName = objvCourseLearningCaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseENT.TeachSkillName = objvCourseLearningCaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseENT.TeachSkillTheory = objvCourseLearningCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseENT.TeachSkillOperMethod = objvCourseLearningCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseENT.IdSkillType = objvCourseLearningCaseENS.IdSkillType; //技能类型流水号
objvCourseLearningCaseENT.SkillTypeID = objvCourseLearningCaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseENT.CaseLevelId = objvCourseLearningCaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseENT.CaseLevelName = objvCourseLearningCaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseENT.DocFile = objvCourseLearningCaseENS.DocFile; //生成的Word文件名
objvCourseLearningCaseENT.IsNeedGeneWord = objvCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseENT.WordCreateDate = objvCourseLearningCaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseENT.IsVisible = objvCourseLearningCaseENS.IsVisible; //是否显示
objvCourseLearningCaseENT.IsDualVideo = objvCourseLearningCaseENS.IsDualVideo; //是否双视频
objvCourseLearningCaseENT.IdXzCollege = objvCourseLearningCaseENS.IdXzCollege; //学院流水号
objvCourseLearningCaseENT.CollegeId = objvCourseLearningCaseENS.CollegeId; //学院ID
objvCourseLearningCaseENT.CollegeName = objvCourseLearningCaseENS.CollegeName; //学院名称
objvCourseLearningCaseENT.CollegeNameA = objvCourseLearningCaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseENT.IdXzMajor = objvCourseLearningCaseENS.IdXzMajor; //专业流水号
objvCourseLearningCaseENT.MajorID = objvCourseLearningCaseENS.MajorID; //专业ID
objvCourseLearningCaseENT.MajorName = objvCourseLearningCaseENS.MajorName; //专业名称
objvCourseLearningCaseENT.CourseId = objvCourseLearningCaseENS.CourseId; //课程Id
objvCourseLearningCaseENT.CourseCode = objvCourseLearningCaseENS.CourseCode; //课程代码
objvCourseLearningCaseENT.CourseName = objvCourseLearningCaseENS.CourseName; //课程名称
objvCourseLearningCaseENT.CourseChapterId = objvCourseLearningCaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseENT.CourseChapterName = objvCourseLearningCaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseENT.ChapterId = objvCourseLearningCaseENS.ChapterId; //章Id
objvCourseLearningCaseENT.SectionId = objvCourseLearningCaseENS.SectionId; //节Id
objvCourseLearningCaseENT.ChapterName = objvCourseLearningCaseENS.ChapterName; //章名
objvCourseLearningCaseENT.SectionName = objvCourseLearningCaseENS.SectionName; //节名
objvCourseLearningCaseENT.ChapterNameSim = objvCourseLearningCaseENS.ChapterNameSim; //章名简称
objvCourseLearningCaseENT.SectionNameSim = objvCourseLearningCaseENS.SectionNameSim; //节名简称
objvCourseLearningCaseENT.ParentNodeId = objvCourseLearningCaseENS.ParentNodeId; //父节点编号
objvCourseLearningCaseENT.CourseChapterReferred = objvCourseLearningCaseENS.CourseChapterReferred; //节简称
objvCourseLearningCaseENT.ParentNodeName = objvCourseLearningCaseENS.ParentNodeName; //父节点名称
objvCourseLearningCaseENT.ParentNodeReferred = objvCourseLearningCaseENS.ParentNodeReferred; //章简称
objvCourseLearningCaseENT.ViewCount = objvCourseLearningCaseENS.ViewCount; //浏览量
objvCourseLearningCaseENT.IsShow = objvCourseLearningCaseENS.IsShow; //是否启用
objvCourseLearningCaseENT.DownloadNumber = objvCourseLearningCaseENS.DownloadNumber; //下载数目
objvCourseLearningCaseENT.FileIntegration = objvCourseLearningCaseENS.FileIntegration; //文件积分
objvCourseLearningCaseENT.LikeCount = objvCourseLearningCaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseENT.CollectionCount = objvCourseLearningCaseENS.CollectionCount; //收藏数量
objvCourseLearningCaseENT.RecommendedDegreeId = objvCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseENT.RecommendedDegreeName = objvCourseLearningCaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseENT.ftpFileType = objvCourseLearningCaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseENT.VideoUrl = objvCourseLearningCaseENS.VideoUrl; //视频Url
objvCourseLearningCaseENT.VideoPath = objvCourseLearningCaseENS.VideoPath; //视频目录
objvCourseLearningCaseENT.ImageUrl = objvCourseLearningCaseENS.ImageUrl; //ImageUrl
objvCourseLearningCaseENT.ResErrMsg = objvCourseLearningCaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCaseENT.OrderNum = objvCourseLearningCaseENS.OrderNum; //序号
objvCourseLearningCaseENT.UpdDate = objvCourseLearningCaseENS.UpdDate; //修改日期
objvCourseLearningCaseENT.UpdUserId = objvCourseLearningCaseENS.UpdUserId; //修改用户Id
objvCourseLearningCaseENT.Memo = objvCourseLearningCaseENS.Memo; //备注
objvCourseLearningCaseENT.IsHaveVideo = objvCourseLearningCaseENS.IsHaveVideo; //IsHaveVideo
objvCourseLearningCaseENT.BrowseCount4Case = objvCourseLearningCaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseENT.OwnerName = objvCourseLearningCaseENS.OwnerName; //拥有者姓名
objvCourseLearningCaseENT.OwnerNameWithId = objvCourseLearningCaseENS.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvCourseLearningCaseENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCaseEN:objvCourseLearningCaseENT</returns>
 public static clsvCourseLearningCaseEN CopyTo(this clsvCourseLearningCaseEN objvCourseLearningCaseENS)
{
try
{
 clsvCourseLearningCaseEN objvCourseLearningCaseENT = new clsvCourseLearningCaseEN()
{
IdCourseLearningCase = objvCourseLearningCaseENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objvCourseLearningCaseENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCaseENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseText = objvCourseLearningCaseENS.CourseLearningCaseText, //案例文本内容
CourseLearningCaseTheme = objvCourseLearningCaseENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objvCourseLearningCaseENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objvCourseLearningCaseENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objvCourseLearningCaseENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objvCourseLearningCaseENS.CourseLearningCaseTimeIn, //案例入库时间
IdCaseType = objvCourseLearningCaseENS.IdCaseType, //案例类型流水号
CaseTypeName = objvCourseLearningCaseENS.CaseTypeName, //案例类型名称
IdCourseLearningCaseType = objvCourseLearningCaseENS.IdCourseLearningCaseType, //课程学习案例类型流水号
CourseLearningCaseTypeName = objvCourseLearningCaseENS.CourseLearningCaseTypeName, //课程学习案例类型名称
OwnerId = objvCourseLearningCaseENS.OwnerId, //拥有者Id
IdStudyLevel = objvCourseLearningCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvCourseLearningCaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvCourseLearningCaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objvCourseLearningCaseENS.IdDiscipline, //学科流水号
DisciplineID = objvCourseLearningCaseENS.DisciplineID, //学科ID
DisciplineName = objvCourseLearningCaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvCourseLearningCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvCourseLearningCaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvCourseLearningCaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvCourseLearningCaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
IsUse = objvCourseLearningCaseENS.IsUse, //是否使用
VersionNo = objvCourseLearningCaseENS.VersionNo, //版本号
IdTeachSkill = objvCourseLearningCaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvCourseLearningCaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvCourseLearningCaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvCourseLearningCaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvCourseLearningCaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvCourseLearningCaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvCourseLearningCaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvCourseLearningCaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvCourseLearningCaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvCourseLearningCaseENS.CaseLevelName, //案例等级名称
DocFile = objvCourseLearningCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvCourseLearningCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvCourseLearningCaseENS.WordCreateDate, //Word生成日期
IsVisible = objvCourseLearningCaseENS.IsVisible, //是否显示
IsDualVideo = objvCourseLearningCaseENS.IsDualVideo, //是否双视频
IdXzCollege = objvCourseLearningCaseENS.IdXzCollege, //学院流水号
CollegeId = objvCourseLearningCaseENS.CollegeId, //学院ID
CollegeName = objvCourseLearningCaseENS.CollegeName, //学院名称
CollegeNameA = objvCourseLearningCaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvCourseLearningCaseENS.IdXzMajor, //专业流水号
MajorID = objvCourseLearningCaseENS.MajorID, //专业ID
MajorName = objvCourseLearningCaseENS.MajorName, //专业名称
CourseId = objvCourseLearningCaseENS.CourseId, //课程Id
CourseCode = objvCourseLearningCaseENS.CourseCode, //课程代码
CourseName = objvCourseLearningCaseENS.CourseName, //课程名称
CourseChapterId = objvCourseLearningCaseENS.CourseChapterId, //课程章节ID
CourseChapterName = objvCourseLearningCaseENS.CourseChapterName, //课程章节名称
ChapterId = objvCourseLearningCaseENS.ChapterId, //章Id
SectionId = objvCourseLearningCaseENS.SectionId, //节Id
ChapterName = objvCourseLearningCaseENS.ChapterName, //章名
SectionName = objvCourseLearningCaseENS.SectionName, //节名
ChapterNameSim = objvCourseLearningCaseENS.ChapterNameSim, //章名简称
SectionNameSim = objvCourseLearningCaseENS.SectionNameSim, //节名简称
ParentNodeId = objvCourseLearningCaseENS.ParentNodeId, //父节点编号
CourseChapterReferred = objvCourseLearningCaseENS.CourseChapterReferred, //节简称
ParentNodeName = objvCourseLearningCaseENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvCourseLearningCaseENS.ParentNodeReferred, //章简称
ViewCount = objvCourseLearningCaseENS.ViewCount, //浏览量
IsShow = objvCourseLearningCaseENS.IsShow, //是否启用
DownloadNumber = objvCourseLearningCaseENS.DownloadNumber, //下载数目
FileIntegration = objvCourseLearningCaseENS.FileIntegration, //文件积分
LikeCount = objvCourseLearningCaseENS.LikeCount, //资源喜欢数量
CollectionCount = objvCourseLearningCaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvCourseLearningCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvCourseLearningCaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvCourseLearningCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvCourseLearningCaseENS.VideoUrl, //视频Url
VideoPath = objvCourseLearningCaseENS.VideoPath, //视频目录
ImageUrl = objvCourseLearningCaseENS.ImageUrl, //ImageUrl
ResErrMsg = objvCourseLearningCaseENS.ResErrMsg, //资源错误信息
OrderNum = objvCourseLearningCaseENS.OrderNum, //序号
UpdDate = objvCourseLearningCaseENS.UpdDate, //修改日期
UpdUserId = objvCourseLearningCaseENS.UpdUserId, //修改用户Id
Memo = objvCourseLearningCaseENS.Memo, //备注
IsHaveVideo = objvCourseLearningCaseENS.IsHaveVideo, //IsHaveVideo
BrowseCount4Case = objvCourseLearningCaseENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvCourseLearningCaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvCourseLearningCaseENS.OwnerNameWithId, //拥有者名称附Id
};
 return objvCourseLearningCaseENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
 clsvCourseLearningCaseBL.vCourseLearningCaseDA.CheckProperty4Condition(objvCourseLearningCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseEN objvCourseLearningCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdCourseLearningCase, objvCourseLearningCaseCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseID, objvCourseLearningCaseCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseName, objvCourseLearningCaseCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseText) == true)
{
string strComparisonOpCourseLearningCaseText = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseText, objvCourseLearningCaseCond.CourseLearningCaseText, strComparisonOpCourseLearningCaseText);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTheme, objvCourseLearningCaseCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseDate, objvCourseLearningCaseCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTime, objvCourseLearningCaseCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseDateIn, objvCourseLearningCaseCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTimeIn, objvCourseLearningCaseCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdCaseType, objvCourseLearningCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CaseTypeName) == true)
{
string strComparisonOpCaseTypeName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CaseTypeName, objvCourseLearningCaseCond.CaseTypeName, strComparisonOpCaseTypeName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdCourseLearningCaseType) == true)
{
string strComparisonOpIdCourseLearningCaseType = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdCourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdCourseLearningCaseType, objvCourseLearningCaseCond.IdCourseLearningCaseType, strComparisonOpIdCourseLearningCaseType);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseLearningCaseTypeName) == true)
{
string strComparisonOpCourseLearningCaseTypeName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTypeName, objvCourseLearningCaseCond.CourseLearningCaseTypeName, strComparisonOpCourseLearningCaseTypeName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.OwnerId, objvCourseLearningCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdStudyLevel, objvCourseLearningCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.StudyLevelName, objvCourseLearningCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdTeachingPlan, objvCourseLearningCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdDiscipline, objvCourseLearningCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.DisciplineID, objvCourseLearningCaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.DisciplineName, objvCourseLearningCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdSenateGaugeVersion, objvCourseLearningCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.senateGaugeVersionID, objvCourseLearningCaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.senateGaugeVersionName, objvCourseLearningCaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.senateGaugeVersionTtlScore, objvCourseLearningCaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IsUse) == true)
{
if (objvCourseLearningCaseCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsUse);
}
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.VersionNo) == true)
{
string strComparisonOpVersionNo = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.VersionNo, objvCourseLearningCaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdTeachSkill, objvCourseLearningCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillID, objvCourseLearningCaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SkillTypeName, objvCourseLearningCaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillName, objvCourseLearningCaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillTheory, objvCourseLearningCaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillOperMethod, objvCourseLearningCaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdSkillType, objvCourseLearningCaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SkillTypeID, objvCourseLearningCaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CaseLevelId, objvCourseLearningCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CaseLevelName, objvCourseLearningCaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.DocFile) == true)
{
string strComparisonOpDocFile = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.DocFile, objvCourseLearningCaseCond.DocFile, strComparisonOpDocFile);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IsNeedGeneWord) == true)
{
if (objvCourseLearningCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsNeedGeneWord);
}
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.WordCreateDate, objvCourseLearningCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IsVisible) == true)
{
if (objvCourseLearningCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsVisible);
}
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IsDualVideo) == true)
{
if (objvCourseLearningCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsDualVideo);
}
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdXzCollege, objvCourseLearningCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CollegeId) == true)
{
string strComparisonOpCollegeId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CollegeId, objvCourseLearningCaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CollegeName, objvCourseLearningCaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CollegeNameA, objvCourseLearningCaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IdXzMajor, objvCourseLearningCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.MajorID, objvCourseLearningCaseCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.MajorName, objvCourseLearningCaseCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseId, objvCourseLearningCaseCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseCode, objvCourseLearningCaseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseName, objvCourseLearningCaseCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseChapterId, objvCourseLearningCaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseChapterName, objvCourseLearningCaseCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ChapterId) == true)
{
string strComparisonOpChapterId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ChapterId, objvCourseLearningCaseCond.ChapterId, strComparisonOpChapterId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.SectionId) == true)
{
string strComparisonOpSectionId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SectionId, objvCourseLearningCaseCond.SectionId, strComparisonOpSectionId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ChapterName) == true)
{
string strComparisonOpChapterName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ChapterName, objvCourseLearningCaseCond.ChapterName, strComparisonOpChapterName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.SectionName) == true)
{
string strComparisonOpSectionName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SectionName, objvCourseLearningCaseCond.SectionName, strComparisonOpSectionName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ChapterNameSim, objvCourseLearningCaseCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SectionNameSim, objvCourseLearningCaseCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ParentNodeId, objvCourseLearningCaseCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseChapterReferred, objvCourseLearningCaseCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ParentNodeName, objvCourseLearningCaseCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ParentNodeReferred, objvCourseLearningCaseCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ViewCount) == true)
{
string strComparisonOpViewCount = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.ViewCount, objvCourseLearningCaseCond.ViewCount, strComparisonOpViewCount);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IsShow) == true)
{
if (objvCourseLearningCaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsShow);
}
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.DownloadNumber, objvCourseLearningCaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.FileIntegration, objvCourseLearningCaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.LikeCount) == true)
{
string strComparisonOpLikeCount = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.LikeCount, objvCourseLearningCaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.CollectionCount, objvCourseLearningCaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.RecommendedDegreeId, objvCourseLearningCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.RecommendedDegreeName, objvCourseLearningCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ftpFileType, objvCourseLearningCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.VideoUrl, objvCourseLearningCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.VideoPath, objvCourseLearningCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ImageUrl) == true)
{
string strComparisonOpImageUrl = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ImageUrl, objvCourseLearningCaseCond.ImageUrl, strComparisonOpImageUrl);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ResErrMsg, objvCourseLearningCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.OrderNum, objvCourseLearningCaseCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.UpdDate, objvCourseLearningCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.UpdUserId, objvCourseLearningCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.Memo, objvCourseLearningCaseCond.Memo, strComparisonOpMemo);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IsHaveVideo, objvCourseLearningCaseCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.BrowseCount4Case, objvCourseLearningCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.OwnerName, objvCourseLearningCaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCourseLearningCaseCond.IsUpdated(convCourseLearningCase.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvCourseLearningCaseCond.dicFldComparisonOp[convCourseLearningCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.OwnerNameWithId, objvCourseLearningCaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCase
{
public virtual bool UpdRelaTabDate(string strIdCourseLearningCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例(vCourseLearningCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseBL
{
public static RelatedActions_vCourseLearningCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCaseDA vCourseLearningCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCaseBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCaseDA.GetDataTable_vCourseLearningCase(strWhereCond);
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
objDT = vCourseLearningCaseDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCaseDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLstByIdCourseLearningCaseLst(List<string> arrIdCourseLearningCaseLst)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCourseLearningCaseLst, true);
 string strWhereCond = string.Format("IdCourseLearningCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCaseEN> GetObjLstByIdCourseLearningCaseLstCache(List<string> arrIdCourseLearningCaseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel =
arrvCourseLearningCaseObjLstCache
.Where(x => arrIdCourseLearningCaseLst.Contains(x.IdCourseLearningCase));
return arrvCourseLearningCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
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
public static List<clsvCourseLearningCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCaseEN> GetSubObjLstCache(clsvCourseLearningCaseEN objvCourseLearningCaseCond)
{
List<clsvCourseLearningCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase.AttributeName)
{
if (objvCourseLearningCaseCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseCond[strFldName]));
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
public static List<clsvCourseLearningCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
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
public static List<clsvCourseLearningCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
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
List<clsvCourseLearningCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
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
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
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
public static List<clsvCourseLearningCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
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
public static List<clsvCourseLearningCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCase(ref clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
bool bolResult = vCourseLearningCaseDA.GetvCourseLearningCase(ref objvCourseLearningCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
if (strIdCourseLearningCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCourseLearningCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCourseLearningCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCourseLearningCaseEN objvCourseLearningCaseEN = vCourseLearningCaseDA.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
return objvCourseLearningCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCaseEN objvCourseLearningCaseEN = vCourseLearningCaseDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCaseEN;
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
public static clsvCourseLearningCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCaseEN objvCourseLearningCaseEN = vCourseLearningCaseDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseEN;
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
public static clsvCourseLearningCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCaseEN objvCourseLearningCaseEN = vCourseLearningCaseDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseEN;
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
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <param name = "lstvCourseLearningCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseEN GetObjByIdCourseLearningCaseFromList(string strIdCourseLearningCase, List<clsvCourseLearningCaseEN> lstvCourseLearningCaseObjLst)
{
foreach (clsvCourseLearningCaseEN objvCourseLearningCaseEN in lstvCourseLearningCaseObjLst)
{
if (objvCourseLearningCaseEN.IdCourseLearningCase == strIdCourseLearningCase)
{
return objvCourseLearningCaseEN;
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
 string strIdCourseLearningCase;
 try
 {
 strIdCourseLearningCase = new clsvCourseLearningCaseDA().GetFirstID(strWhereCond);
 return strIdCourseLearningCase;
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
 arrList = vCourseLearningCaseDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCourseLearningCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCourseLearningCaseDA.IsExist(strIdCourseLearningCase);
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
 bolIsExist = clsvCourseLearningCaseDA.IsExistTable();
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
 bolIsExist = vCourseLearningCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCaseENS">源对象</param>
 /// <param name = "objvCourseLearningCaseENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseEN objvCourseLearningCaseENS, clsvCourseLearningCaseEN objvCourseLearningCaseENT)
{
try
{
objvCourseLearningCaseENT.IdCourseLearningCase = objvCourseLearningCaseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseENT.CourseLearningCaseID = objvCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseENT.CourseLearningCaseName = objvCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseENT.CourseLearningCaseText = objvCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseENT.CourseLearningCaseTheme = objvCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseENT.CourseLearningCaseDate = objvCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseENT.CourseLearningCaseTime = objvCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseENT.CourseLearningCaseDateIn = objvCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseENT.CourseLearningCaseTimeIn = objvCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseENT.IdCaseType = objvCourseLearningCaseENS.IdCaseType; //案例类型流水号
objvCourseLearningCaseENT.CaseTypeName = objvCourseLearningCaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCaseENT.IdCourseLearningCaseType = objvCourseLearningCaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseENT.CourseLearningCaseTypeName = objvCourseLearningCaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseENT.OwnerId = objvCourseLearningCaseENS.OwnerId; //拥有者Id
objvCourseLearningCaseENT.IdStudyLevel = objvCourseLearningCaseENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCaseENT.StudyLevelName = objvCourseLearningCaseENS.StudyLevelName; //学段名称
objvCourseLearningCaseENT.IdTeachingPlan = objvCourseLearningCaseENS.IdTeachingPlan; //教案流水号
objvCourseLearningCaseENT.IdDiscipline = objvCourseLearningCaseENS.IdDiscipline; //学科流水号
objvCourseLearningCaseENT.DisciplineID = objvCourseLearningCaseENS.DisciplineID; //学科ID
objvCourseLearningCaseENT.DisciplineName = objvCourseLearningCaseENS.DisciplineName; //学科名称
objvCourseLearningCaseENT.IdSenateGaugeVersion = objvCourseLearningCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseENT.senateGaugeVersionID = objvCourseLearningCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseENT.senateGaugeVersionName = objvCourseLearningCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseENT.senateGaugeVersionTtlScore = objvCourseLearningCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseENT.IsUse = objvCourseLearningCaseENS.IsUse; //是否使用
objvCourseLearningCaseENT.VersionNo = objvCourseLearningCaseENS.VersionNo; //版本号
objvCourseLearningCaseENT.IdTeachSkill = objvCourseLearningCaseENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCaseENT.TeachSkillID = objvCourseLearningCaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseENT.SkillTypeName = objvCourseLearningCaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseENT.TeachSkillName = objvCourseLearningCaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseENT.TeachSkillTheory = objvCourseLearningCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseENT.TeachSkillOperMethod = objvCourseLearningCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseENT.IdSkillType = objvCourseLearningCaseENS.IdSkillType; //技能类型流水号
objvCourseLearningCaseENT.SkillTypeID = objvCourseLearningCaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseENT.CaseLevelId = objvCourseLearningCaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseENT.CaseLevelName = objvCourseLearningCaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseENT.DocFile = objvCourseLearningCaseENS.DocFile; //生成的Word文件名
objvCourseLearningCaseENT.IsNeedGeneWord = objvCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseENT.WordCreateDate = objvCourseLearningCaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseENT.IsVisible = objvCourseLearningCaseENS.IsVisible; //是否显示
objvCourseLearningCaseENT.IsDualVideo = objvCourseLearningCaseENS.IsDualVideo; //是否双视频
objvCourseLearningCaseENT.IdXzCollege = objvCourseLearningCaseENS.IdXzCollege; //学院流水号
objvCourseLearningCaseENT.CollegeId = objvCourseLearningCaseENS.CollegeId; //学院ID
objvCourseLearningCaseENT.CollegeName = objvCourseLearningCaseENS.CollegeName; //学院名称
objvCourseLearningCaseENT.CollegeNameA = objvCourseLearningCaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseENT.IdXzMajor = objvCourseLearningCaseENS.IdXzMajor; //专业流水号
objvCourseLearningCaseENT.MajorID = objvCourseLearningCaseENS.MajorID; //专业ID
objvCourseLearningCaseENT.MajorName = objvCourseLearningCaseENS.MajorName; //专业名称
objvCourseLearningCaseENT.CourseId = objvCourseLearningCaseENS.CourseId; //课程Id
objvCourseLearningCaseENT.CourseCode = objvCourseLearningCaseENS.CourseCode; //课程代码
objvCourseLearningCaseENT.CourseName = objvCourseLearningCaseENS.CourseName; //课程名称
objvCourseLearningCaseENT.CourseChapterId = objvCourseLearningCaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseENT.CourseChapterName = objvCourseLearningCaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseENT.ChapterId = objvCourseLearningCaseENS.ChapterId; //章Id
objvCourseLearningCaseENT.SectionId = objvCourseLearningCaseENS.SectionId; //节Id
objvCourseLearningCaseENT.ChapterName = objvCourseLearningCaseENS.ChapterName; //章名
objvCourseLearningCaseENT.SectionName = objvCourseLearningCaseENS.SectionName; //节名
objvCourseLearningCaseENT.ChapterNameSim = objvCourseLearningCaseENS.ChapterNameSim; //章名简称
objvCourseLearningCaseENT.SectionNameSim = objvCourseLearningCaseENS.SectionNameSim; //节名简称
objvCourseLearningCaseENT.ParentNodeId = objvCourseLearningCaseENS.ParentNodeId; //父节点编号
objvCourseLearningCaseENT.CourseChapterReferred = objvCourseLearningCaseENS.CourseChapterReferred; //节简称
objvCourseLearningCaseENT.ParentNodeName = objvCourseLearningCaseENS.ParentNodeName; //父节点名称
objvCourseLearningCaseENT.ParentNodeReferred = objvCourseLearningCaseENS.ParentNodeReferred; //章简称
objvCourseLearningCaseENT.ViewCount = objvCourseLearningCaseENS.ViewCount; //浏览量
objvCourseLearningCaseENT.IsShow = objvCourseLearningCaseENS.IsShow; //是否启用
objvCourseLearningCaseENT.DownloadNumber = objvCourseLearningCaseENS.DownloadNumber; //下载数目
objvCourseLearningCaseENT.FileIntegration = objvCourseLearningCaseENS.FileIntegration; //文件积分
objvCourseLearningCaseENT.LikeCount = objvCourseLearningCaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseENT.CollectionCount = objvCourseLearningCaseENS.CollectionCount; //收藏数量
objvCourseLearningCaseENT.RecommendedDegreeId = objvCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseENT.RecommendedDegreeName = objvCourseLearningCaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseENT.ftpFileType = objvCourseLearningCaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseENT.VideoUrl = objvCourseLearningCaseENS.VideoUrl; //视频Url
objvCourseLearningCaseENT.VideoPath = objvCourseLearningCaseENS.VideoPath; //视频目录
objvCourseLearningCaseENT.ImageUrl = objvCourseLearningCaseENS.ImageUrl; //ImageUrl
objvCourseLearningCaseENT.ResErrMsg = objvCourseLearningCaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCaseENT.OrderNum = objvCourseLearningCaseENS.OrderNum; //序号
objvCourseLearningCaseENT.UpdDate = objvCourseLearningCaseENS.UpdDate; //修改日期
objvCourseLearningCaseENT.UpdUserId = objvCourseLearningCaseENS.UpdUserId; //修改用户Id
objvCourseLearningCaseENT.Memo = objvCourseLearningCaseENS.Memo; //备注
objvCourseLearningCaseENT.IsHaveVideo = objvCourseLearningCaseENS.IsHaveVideo; //IsHaveVideo
objvCourseLearningCaseENT.BrowseCount4Case = objvCourseLearningCaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseENT.OwnerName = objvCourseLearningCaseENS.OwnerName; //拥有者姓名
objvCourseLearningCaseENT.OwnerNameWithId = objvCourseLearningCaseENS.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvCourseLearningCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
try
{
objvCourseLearningCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCase.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdCourseLearningCase = objvCourseLearningCaseEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseID = objvCourseLearningCaseEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseName = objvCourseLearningCaseEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseText = objvCourseLearningCaseEN.CourseLearningCaseText == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseText; //案例文本内容
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseTheme = objvCourseLearningCaseEN.CourseLearningCaseTheme == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseDate = objvCourseLearningCaseEN.CourseLearningCaseDate == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseTime = objvCourseLearningCaseEN.CourseLearningCaseTime == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objvCourseLearningCaseEN.CourseLearningCaseDateIn == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objvCourseLearningCaseEN.CourseLearningCaseTimeIn == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCourseLearningCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdCaseType = objvCourseLearningCaseEN.IdCaseType == "[null]" ? null :  objvCourseLearningCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase.CaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CaseTypeName = objvCourseLearningCaseEN.CaseTypeName == "[null]" ? null :  objvCourseLearningCaseEN.CaseTypeName; //案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCase.IdCourseLearningCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdCourseLearningCaseType = objvCourseLearningCaseEN.IdCourseLearningCaseType; //课程学习案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase.CourseLearningCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objvCourseLearningCaseEN.CourseLearningCaseTypeName == "[null]" ? null :  objvCourseLearningCaseEN.CourseLearningCaseTypeName; //课程学习案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.OwnerId = objvCourseLearningCaseEN.OwnerId == "[null]" ? null :  objvCourseLearningCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCourseLearningCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdStudyLevel = objvCourseLearningCaseEN.IdStudyLevel == "[null]" ? null :  objvCourseLearningCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convCourseLearningCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.StudyLevelName = objvCourseLearningCaseEN.StudyLevelName == "[null]" ? null :  objvCourseLearningCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convCourseLearningCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdTeachingPlan = objvCourseLearningCaseEN.IdTeachingPlan == "[null]" ? null :  objvCourseLearningCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convCourseLearningCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdDiscipline = objvCourseLearningCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convCourseLearningCase.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.DisciplineID = objvCourseLearningCaseEN.DisciplineID == "[null]" ? null :  objvCourseLearningCaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convCourseLearningCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.DisciplineName = objvCourseLearningCaseEN.DisciplineName == "[null]" ? null :  objvCourseLearningCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convCourseLearningCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdSenateGaugeVersion = objvCourseLearningCaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvCourseLearningCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convCourseLearningCase.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.senateGaugeVersionID = objvCourseLearningCaseEN.senateGaugeVersionID == "[null]" ? null :  objvCourseLearningCaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convCourseLearningCase.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.senateGaugeVersionName = objvCourseLearningCaseEN.senateGaugeVersionName == "[null]" ? null :  objvCourseLearningCaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convCourseLearningCase.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objvCourseLearningCaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convCourseLearningCase.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IsUse = objvCourseLearningCaseEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convCourseLearningCase.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.VersionNo = objvCourseLearningCaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convCourseLearningCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdTeachSkill = objvCourseLearningCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convCourseLearningCase.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.TeachSkillID = objvCourseLearningCaseEN.TeachSkillID == "[null]" ? null :  objvCourseLearningCaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convCourseLearningCase.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.SkillTypeName = objvCourseLearningCaseEN.SkillTypeName == "[null]" ? null :  objvCourseLearningCaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convCourseLearningCase.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.TeachSkillName = objvCourseLearningCaseEN.TeachSkillName == "[null]" ? null :  objvCourseLearningCaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convCourseLearningCase.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.TeachSkillTheory = objvCourseLearningCaseEN.TeachSkillTheory == "[null]" ? null :  objvCourseLearningCaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convCourseLearningCase.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.TeachSkillOperMethod = objvCourseLearningCaseEN.TeachSkillOperMethod == "[null]" ? null :  objvCourseLearningCaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convCourseLearningCase.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdSkillType = objvCourseLearningCaseEN.IdSkillType == "[null]" ? null :  objvCourseLearningCaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.SkillTypeID = objvCourseLearningCaseEN.SkillTypeID == "[null]" ? null :  objvCourseLearningCaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convCourseLearningCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CaseLevelId = objvCourseLearningCaseEN.CaseLevelId == "[null]" ? null :  objvCourseLearningCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convCourseLearningCase.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CaseLevelName = objvCourseLearningCaseEN.CaseLevelName == "[null]" ? null :  objvCourseLearningCaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convCourseLearningCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.DocFile = objvCourseLearningCaseEN.DocFile == "[null]" ? null :  objvCourseLearningCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convCourseLearningCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IsNeedGeneWord = objvCourseLearningCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convCourseLearningCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.WordCreateDate = objvCourseLearningCaseEN.WordCreateDate == "[null]" ? null :  objvCourseLearningCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convCourseLearningCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IsVisible = objvCourseLearningCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convCourseLearningCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IsDualVideo = objvCourseLearningCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCourseLearningCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdXzCollege = objvCourseLearningCaseEN.IdXzCollege == "[null]" ? null :  objvCourseLearningCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningCase.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CollegeId = objvCourseLearningCaseEN.CollegeId == "[null]" ? null :  objvCourseLearningCaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convCourseLearningCase.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CollegeName = objvCourseLearningCaseEN.CollegeName == "[null]" ? null :  objvCourseLearningCaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningCase.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CollegeNameA = objvCourseLearningCaseEN.CollegeNameA == "[null]" ? null :  objvCourseLearningCaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convCourseLearningCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IdXzMajor = objvCourseLearningCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCourseLearningCase.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.MajorID = objvCourseLearningCaseEN.MajorID == "[null]" ? null :  objvCourseLearningCaseEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningCase.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.MajorName = objvCourseLearningCaseEN.MajorName == "[null]" ? null :  objvCourseLearningCaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningCase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseId = objvCourseLearningCaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCase.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseCode = objvCourseLearningCaseEN.CourseCode == "[null]" ? null :  objvCourseLearningCaseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCase.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseName = objvCourseLearningCaseEN.CourseName == "[null]" ? null :  objvCourseLearningCaseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseChapterId = objvCourseLearningCaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCourseLearningCase.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseChapterName = objvCourseLearningCaseEN.CourseChapterName == "[null]" ? null :  objvCourseLearningCaseEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convCourseLearningCase.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ChapterId = objvCourseLearningCaseEN.ChapterId == "[null]" ? null :  objvCourseLearningCaseEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convCourseLearningCase.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.SectionId = objvCourseLearningCaseEN.SectionId == "[null]" ? null :  objvCourseLearningCaseEN.SectionId; //节Id
}
if (arrFldSet.Contains(convCourseLearningCase.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ChapterName = objvCourseLearningCaseEN.ChapterName == "[null]" ? null :  objvCourseLearningCaseEN.ChapterName; //章名
}
if (arrFldSet.Contains(convCourseLearningCase.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.SectionName = objvCourseLearningCaseEN.SectionName == "[null]" ? null :  objvCourseLearningCaseEN.SectionName; //节名
}
if (arrFldSet.Contains(convCourseLearningCase.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ChapterNameSim = objvCourseLearningCaseEN.ChapterNameSim == "[null]" ? null :  objvCourseLearningCaseEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convCourseLearningCase.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.SectionNameSim = objvCourseLearningCaseEN.SectionNameSim == "[null]" ? null :  objvCourseLearningCaseEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convCourseLearningCase.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ParentNodeId = objvCourseLearningCaseEN.ParentNodeId == "[null]" ? null :  objvCourseLearningCaseEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convCourseLearningCase.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CourseChapterReferred = objvCourseLearningCaseEN.CourseChapterReferred == "[null]" ? null :  objvCourseLearningCaseEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convCourseLearningCase.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ParentNodeName = objvCourseLearningCaseEN.ParentNodeName == "[null]" ? null :  objvCourseLearningCaseEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convCourseLearningCase.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ParentNodeReferred = objvCourseLearningCaseEN.ParentNodeReferred == "[null]" ? null :  objvCourseLearningCaseEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convCourseLearningCase.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ViewCount = objvCourseLearningCaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCourseLearningCase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IsShow = objvCourseLearningCaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convCourseLearningCase.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.DownloadNumber = objvCourseLearningCaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convCourseLearningCase.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.FileIntegration = objvCourseLearningCaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convCourseLearningCase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.LikeCount = objvCourseLearningCaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convCourseLearningCase.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.CollectionCount = objvCourseLearningCaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convCourseLearningCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.RecommendedDegreeId = objvCourseLearningCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convCourseLearningCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.RecommendedDegreeName = objvCourseLearningCaseEN.RecommendedDegreeName == "[null]" ? null :  objvCourseLearningCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convCourseLearningCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ftpFileType = objvCourseLearningCaseEN.ftpFileType == "[null]" ? null :  objvCourseLearningCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convCourseLearningCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.VideoUrl = objvCourseLearningCaseEN.VideoUrl == "[null]" ? null :  objvCourseLearningCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convCourseLearningCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.VideoPath = objvCourseLearningCaseEN.VideoPath == "[null]" ? null :  objvCourseLearningCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convCourseLearningCase.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ImageUrl = objvCourseLearningCaseEN.ImageUrl == "[null]" ? null :  objvCourseLearningCaseEN.ImageUrl; //ImageUrl
}
if (arrFldSet.Contains(convCourseLearningCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.ResErrMsg = objvCourseLearningCaseEN.ResErrMsg == "[null]" ? null :  objvCourseLearningCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convCourseLearningCase.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.OrderNum = objvCourseLearningCaseEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCourseLearningCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.UpdDate = objvCourseLearningCaseEN.UpdDate == "[null]" ? null :  objvCourseLearningCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCourseLearningCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.UpdUserId = objvCourseLearningCaseEN.UpdUserId == "[null]" ? null :  objvCourseLearningCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCourseLearningCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.Memo = objvCourseLearningCaseEN.Memo == "[null]" ? null :  objvCourseLearningCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convCourseLearningCase.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.IsHaveVideo = objvCourseLearningCaseEN.IsHaveVideo; //IsHaveVideo
}
if (arrFldSet.Contains(convCourseLearningCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.BrowseCount4Case = objvCourseLearningCaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convCourseLearningCase.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.OwnerName = objvCourseLearningCaseEN.OwnerName == "[null]" ? null :  objvCourseLearningCaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCourseLearningCase.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseEN.OwnerNameWithId = objvCourseLearningCaseEN.OwnerNameWithId == "[null]" ? null :  objvCourseLearningCaseEN.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvCourseLearningCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
try
{
if (objvCourseLearningCaseEN.CourseLearningCaseText == "[null]") objvCourseLearningCaseEN.CourseLearningCaseText = null; //案例文本内容
if (objvCourseLearningCaseEN.CourseLearningCaseTheme == "[null]") objvCourseLearningCaseEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objvCourseLearningCaseEN.CourseLearningCaseDate == "[null]") objvCourseLearningCaseEN.CourseLearningCaseDate = null; //课程学习日期
if (objvCourseLearningCaseEN.CourseLearningCaseTime == "[null]") objvCourseLearningCaseEN.CourseLearningCaseTime = null; //课程学习时间
if (objvCourseLearningCaseEN.CourseLearningCaseDateIn == "[null]") objvCourseLearningCaseEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objvCourseLearningCaseEN.CourseLearningCaseTimeIn == "[null]") objvCourseLearningCaseEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objvCourseLearningCaseEN.IdCaseType == "[null]") objvCourseLearningCaseEN.IdCaseType = null; //案例类型流水号
if (objvCourseLearningCaseEN.CaseTypeName == "[null]") objvCourseLearningCaseEN.CaseTypeName = null; //案例类型名称
if (objvCourseLearningCaseEN.CourseLearningCaseTypeName == "[null]") objvCourseLearningCaseEN.CourseLearningCaseTypeName = null; //课程学习案例类型名称
if (objvCourseLearningCaseEN.OwnerId == "[null]") objvCourseLearningCaseEN.OwnerId = null; //拥有者Id
if (objvCourseLearningCaseEN.IdStudyLevel == "[null]") objvCourseLearningCaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvCourseLearningCaseEN.StudyLevelName == "[null]") objvCourseLearningCaseEN.StudyLevelName = null; //学段名称
if (objvCourseLearningCaseEN.IdTeachingPlan == "[null]") objvCourseLearningCaseEN.IdTeachingPlan = null; //教案流水号
if (objvCourseLearningCaseEN.DisciplineID == "[null]") objvCourseLearningCaseEN.DisciplineID = null; //学科ID
if (objvCourseLearningCaseEN.DisciplineName == "[null]") objvCourseLearningCaseEN.DisciplineName = null; //学科名称
if (objvCourseLearningCaseEN.IdSenateGaugeVersion == "[null]") objvCourseLearningCaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvCourseLearningCaseEN.senateGaugeVersionID == "[null]") objvCourseLearningCaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvCourseLearningCaseEN.senateGaugeVersionName == "[null]") objvCourseLearningCaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvCourseLearningCaseEN.TeachSkillID == "[null]") objvCourseLearningCaseEN.TeachSkillID = null; //教学技能ID
if (objvCourseLearningCaseEN.SkillTypeName == "[null]") objvCourseLearningCaseEN.SkillTypeName = null; //技能类型名称
if (objvCourseLearningCaseEN.TeachSkillName == "[null]") objvCourseLearningCaseEN.TeachSkillName = null; //教学技能名称
if (objvCourseLearningCaseEN.TeachSkillTheory == "[null]") objvCourseLearningCaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvCourseLearningCaseEN.TeachSkillOperMethod == "[null]") objvCourseLearningCaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvCourseLearningCaseEN.IdSkillType == "[null]") objvCourseLearningCaseEN.IdSkillType = null; //技能类型流水号
if (objvCourseLearningCaseEN.SkillTypeID == "[null]") objvCourseLearningCaseEN.SkillTypeID = null; //技能类型ID
if (objvCourseLearningCaseEN.CaseLevelId == "[null]") objvCourseLearningCaseEN.CaseLevelId = null; //课例等级Id
if (objvCourseLearningCaseEN.CaseLevelName == "[null]") objvCourseLearningCaseEN.CaseLevelName = null; //案例等级名称
if (objvCourseLearningCaseEN.DocFile == "[null]") objvCourseLearningCaseEN.DocFile = null; //生成的Word文件名
if (objvCourseLearningCaseEN.WordCreateDate == "[null]") objvCourseLearningCaseEN.WordCreateDate = null; //Word生成日期
if (objvCourseLearningCaseEN.IdXzCollege == "[null]") objvCourseLearningCaseEN.IdXzCollege = null; //学院流水号
if (objvCourseLearningCaseEN.CollegeId == "[null]") objvCourseLearningCaseEN.CollegeId = null; //学院ID
if (objvCourseLearningCaseEN.CollegeName == "[null]") objvCourseLearningCaseEN.CollegeName = null; //学院名称
if (objvCourseLearningCaseEN.CollegeNameA == "[null]") objvCourseLearningCaseEN.CollegeNameA = null; //学院名称简写
if (objvCourseLearningCaseEN.MajorID == "[null]") objvCourseLearningCaseEN.MajorID = null; //专业ID
if (objvCourseLearningCaseEN.MajorName == "[null]") objvCourseLearningCaseEN.MajorName = null; //专业名称
if (objvCourseLearningCaseEN.CourseCode == "[null]") objvCourseLearningCaseEN.CourseCode = null; //课程代码
if (objvCourseLearningCaseEN.CourseName == "[null]") objvCourseLearningCaseEN.CourseName = null; //课程名称
if (objvCourseLearningCaseEN.CourseChapterName == "[null]") objvCourseLearningCaseEN.CourseChapterName = null; //课程章节名称
if (objvCourseLearningCaseEN.ChapterId == "[null]") objvCourseLearningCaseEN.ChapterId = null; //章Id
if (objvCourseLearningCaseEN.SectionId == "[null]") objvCourseLearningCaseEN.SectionId = null; //节Id
if (objvCourseLearningCaseEN.ChapterName == "[null]") objvCourseLearningCaseEN.ChapterName = null; //章名
if (objvCourseLearningCaseEN.SectionName == "[null]") objvCourseLearningCaseEN.SectionName = null; //节名
if (objvCourseLearningCaseEN.ChapterNameSim == "[null]") objvCourseLearningCaseEN.ChapterNameSim = null; //章名简称
if (objvCourseLearningCaseEN.SectionNameSim == "[null]") objvCourseLearningCaseEN.SectionNameSim = null; //节名简称
if (objvCourseLearningCaseEN.ParentNodeId == "[null]") objvCourseLearningCaseEN.ParentNodeId = null; //父节点编号
if (objvCourseLearningCaseEN.CourseChapterReferred == "[null]") objvCourseLearningCaseEN.CourseChapterReferred = null; //节简称
if (objvCourseLearningCaseEN.ParentNodeName == "[null]") objvCourseLearningCaseEN.ParentNodeName = null; //父节点名称
if (objvCourseLearningCaseEN.ParentNodeReferred == "[null]") objvCourseLearningCaseEN.ParentNodeReferred = null; //章简称
if (objvCourseLearningCaseEN.RecommendedDegreeName == "[null]") objvCourseLearningCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvCourseLearningCaseEN.ftpFileType == "[null]") objvCourseLearningCaseEN.ftpFileType = null; //ftp文件类型
if (objvCourseLearningCaseEN.VideoUrl == "[null]") objvCourseLearningCaseEN.VideoUrl = null; //视频Url
if (objvCourseLearningCaseEN.VideoPath == "[null]") objvCourseLearningCaseEN.VideoPath = null; //视频目录
if (objvCourseLearningCaseEN.ImageUrl == "[null]") objvCourseLearningCaseEN.ImageUrl = null; //ImageUrl
if (objvCourseLearningCaseEN.ResErrMsg == "[null]") objvCourseLearningCaseEN.ResErrMsg = null; //资源错误信息
if (objvCourseLearningCaseEN.UpdDate == "[null]") objvCourseLearningCaseEN.UpdDate = null; //修改日期
if (objvCourseLearningCaseEN.UpdUserId == "[null]") objvCourseLearningCaseEN.UpdUserId = null; //修改用户Id
if (objvCourseLearningCaseEN.Memo == "[null]") objvCourseLearningCaseEN.Memo = null; //备注
if (objvCourseLearningCaseEN.OwnerName == "[null]") objvCourseLearningCaseEN.OwnerName = null; //拥有者姓名
if (objvCourseLearningCaseEN.OwnerNameWithId == "[null]") objvCourseLearningCaseEN.OwnerNameWithId = null; //拥有者名称附Id
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
public static void CheckProperty4Condition(clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
 vCourseLearningCaseDA.CheckProperty4Condition(objvCourseLearningCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdCourseLearningCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCourseLearningCase.IdCourseLearningCase); 
List<clsvCourseLearningCaseEN> arrObjLst = clsvCourseLearningCaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN()
{
IdCourseLearningCase = "0",
CourseLearningCaseName = "选[v课程学习案例]..."
};
arrObjLst.Insert(0, objvCourseLearningCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCourseLearningCase.IdCourseLearningCase;
objComboBox.DisplayMember = convCourseLearningCase.CourseLearningCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdCourseLearningCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程学习案例]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCourseLearningCase.IdCourseLearningCase); 
IEnumerable<clsvCourseLearningCaseEN> arrObjLst = clsvCourseLearningCaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convCourseLearningCase.IdCourseLearningCase;
objDDL.DataTextField = convCourseLearningCase.CourseLearningCaseName;
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
public static void BindDdl_IdCourseLearningCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程学习案例]...","0");
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst = GetAllvCourseLearningCaseObjLstCache(); 
objDDL.DataValueField = convCourseLearningCase.IdCourseLearningCase;
objDDL.DataTextField = convCourseLearningCase.CourseLearningCaseName;
objDDL.DataSource = arrvCourseLearningCaseObjLst;
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
//string strWhereCond = string.Format("1 = 1 order by IdCourseLearningCase");
//if (arrvCourseLearningCaseObjLstCache == null)
//{
//arrvCourseLearningCaseObjLstCache = vCourseLearningCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseEN GetObjByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel =
arrvCourseLearningCaseObjLstCache
.Where(x=> x.IdCourseLearningCase == strIdCourseLearningCase 
);
if (arrvCourseLearningCaseObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseEN obj = clsvCourseLearningCaseBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseLearningCaseNameByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true) return "";
//获取缓存中的对象列表
clsvCourseLearningCaseEN objvCourseLearningCase = GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase == null) return "";
return objvCourseLearningCase.CourseLearningCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true) return "";
//获取缓存中的对象列表
clsvCourseLearningCaseEN objvCourseLearningCase = GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase == null) return "";
return objvCourseLearningCase.CourseLearningCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetAllvCourseLearningCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdCourseLearningCase)
{
if (strInFldName != convCourseLearningCase.IdCourseLearningCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCase.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCase = clsvCourseLearningCaseBL.GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase == null) return "";
return objvCourseLearningCase[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCaseDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCaseEN objvCourseLearningCaseCond)
{
List<clsvCourseLearningCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase.AttributeName)
{
if (objvCourseLearningCaseCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}