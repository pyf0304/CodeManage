
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase_BaseBL
 表名:vCourseLearningCase_Base(01120268)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:44
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
public static class  clsvCourseLearningCase_BaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_BaseEN GetObj(this K_IdCourseLearningCase_vCourseLearningCase_Base myKey)
{
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = clsvCourseLearningCase_BaseBL.vCourseLearningCase_BaseDA.GetObjByIdCourseLearningCase(myKey.Value);
return objvCourseLearningCase_BaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdCourseLearningCase(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCase_Base.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCase_Base.IdCourseLearningCase);
}
objvCourseLearningCase_BaseEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdCourseLearningCase) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase_Base.CourseLearningCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase_Base.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase_Base.CourseLearningCaseID);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase_Base.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase_Base.CourseLearningCaseName);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseText(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCase_Base.CourseLearningCaseText);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseText) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTheme(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCase_Base.CourseLearningCaseTheme);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTheme) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseDate(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCase_Base.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCase_Base.CourseLearningCaseDate);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseDate) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTime(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCase_Base.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCase_Base.CourseLearningCaseTime);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTime) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseDateIn(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Base.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Base.CourseLearningCaseDateIn);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Base.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Base.CourseLearningCaseTimeIn);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdCaseType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convCourseLearningCase_Base.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convCourseLearningCase_Base.IdCaseType);
}
objvCourseLearningCase_BaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdCaseType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdCaseType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdCaseType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCaseTypeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convCourseLearningCase_Base.CaseTypeName);
}
objvCourseLearningCase_BaseEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CaseTypeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdCourseLearningCaseType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdCourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourseLearningCaseType, convCourseLearningCase_Base.IdCourseLearningCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCaseType, 4, convCourseLearningCase_Base.IdCourseLearningCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCaseType, 4, convCourseLearningCase_Base.IdCourseLearningCaseType);
}
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = strIdCourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdCourseLearningCaseType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdCourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdCourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTypeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCase_Base.CourseLearningCaseTypeName);
}
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOwnerId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCase_Base.OwnerId);
}
objvCourseLearningCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OwnerId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdStudyLevel(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convCourseLearningCase_Base.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convCourseLearningCase_Base.IdStudyLevel);
}
objvCourseLearningCase_BaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdStudyLevel) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdStudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdStudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetStudyLevelName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCase_Base.StudyLevelName);
}
objvCourseLearningCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.StudyLevelName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdTeachingPlan(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convCourseLearningCase_Base.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convCourseLearningCase_Base.IdTeachingPlan);
}
objvCourseLearningCase_BaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdTeachingPlan) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdTeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdTeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdDiscipline(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convCourseLearningCase_Base.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convCourseLearningCase_Base.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convCourseLearningCase_Base.IdDiscipline);
}
objvCourseLearningCase_BaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdDiscipline) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdDiscipline, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdDiscipline] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDisciplineID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCase_Base.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCase_Base.DisciplineID);
}
objvCourseLearningCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DisciplineID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDisciplineName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCase_Base.DisciplineName);
}
objvCourseLearningCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DisciplineName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdSenateGaugeVersion(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convCourseLearningCase_Base.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convCourseLearningCase_Base.IdSenateGaugeVersion);
}
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdSenateGaugeVersion) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetsenateGaugeVersionID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCase_Base.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCase_Base.senateGaugeVersionID);
}
objvCourseLearningCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.senateGaugeVersionID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetsenateGaugeVersionName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCase_Base.senateGaugeVersionName);
}
objvCourseLearningCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.senateGaugeVersionName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetVersionNo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int? intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.VersionNo) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdTeachSkill(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convCourseLearningCase_Base.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convCourseLearningCase_Base.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convCourseLearningCase_Base.IdTeachSkill);
}
objvCourseLearningCase_BaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdTeachSkill) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdTeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdTeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCase_Base.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCase_Base.TeachSkillID);
}
objvCourseLearningCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSkillTypeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCase_Base.SkillTypeName);
}
objvCourseLearningCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SkillTypeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCase_Base.TeachSkillName);
}
objvCourseLearningCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillTheory(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCase_Base.TeachSkillTheory);
}
objvCourseLearningCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillTheory) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillOperMethod(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCase_Base.TeachSkillOperMethod);
}
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillOperMethod) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdSkillType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convCourseLearningCase_Base.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convCourseLearningCase_Base.IdSkillType);
}
objvCourseLearningCase_BaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdSkillType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdSkillType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdSkillType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSkillTypeID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCase_Base.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCase_Base.SkillTypeID);
}
objvCourseLearningCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SkillTypeID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCaseLevelId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCase_Base.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCase_Base.CaseLevelId);
}
objvCourseLearningCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CaseLevelId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCaseLevelName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCourseLearningCase_Base.CaseLevelName);
}
objvCourseLearningCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CaseLevelName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDocFile(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCourseLearningCase_Base.DocFile);
}
objvCourseLearningCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DocFile) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DocFile, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DocFile] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsNeedGeneWord(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsNeedGeneWord) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetWordCreateDate(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCourseLearningCase_Base.WordCreateDate);
}
objvCourseLearningCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.WordCreateDate) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsVisible(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsVisible) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsDualVideo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsDualVideo) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdXzCollege(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningCase_Base.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningCase_Base.IdXzCollege);
}
objvCourseLearningCase_BaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdXzCollege) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollegeId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convCourseLearningCase_Base.CollegeId);
}
objvCourseLearningCase_BaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollegeId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollegeId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollegeId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollegeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCase_Base.CollegeName);
}
objvCourseLearningCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollegeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollegeNameA(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCase_Base.CollegeNameA);
}
objvCourseLearningCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollegeNameA) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIdXzMajor(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCourseLearningCase_Base.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCourseLearningCase_Base.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCourseLearningCase_Base.IdXzMajor);
}
objvCourseLearningCase_BaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IdXzMajor) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IdXzMajor, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IdXzMajor] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetMajorID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCase_Base.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCase_Base.MajorID);
}
objvCourseLearningCase_BaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.MajorID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetMajorName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCase_Base.MajorName);
}
objvCourseLearningCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.MajorName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase_Base.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase_Base.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase_Base.CourseId);
}
objvCourseLearningCase_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseCode(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase_Base.CourseCode);
}
objvCourseLearningCase_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseCode) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase_Base.CourseName);
}
objvCourseLearningCase_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseChapterId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase_Base.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase_Base.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase_Base.CourseChapterId);
}
objvCourseLearningCase_BaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseChapterId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseChapterName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCase_Base.CourseChapterName);
}
objvCourseLearningCase_BaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseChapterName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetChapterId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase_Base.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase_Base.ChapterId);
}
objvCourseLearningCase_BaseEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ChapterId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetParentNodeId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convCourseLearningCase_Base.ParentNodeId);
}
objvCourseLearningCase_BaseEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ParentNodeId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ParentNodeId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseChapterReferred(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCase_Base.CourseChapterReferred);
}
objvCourseLearningCase_BaseEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseChapterReferred) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetChapterName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase_Base.ChapterName);
}
objvCourseLearningCase_BaseEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ChapterName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetChapterNameSim(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convCourseLearningCase_Base.ChapterNameSim);
}
objvCourseLearningCase_BaseEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ChapterNameSim) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ChapterNameSim, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ChapterNameSim] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSectionName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convCourseLearningCase_Base.SectionName);
}
objvCourseLearningCase_BaseEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SectionName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SectionName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SectionName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSectionNameSim(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convCourseLearningCase_Base.SectionNameSim);
}
objvCourseLearningCase_BaseEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SectionNameSim) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SectionNameSim, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SectionNameSim] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSectionId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convCourseLearningCase_Base.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convCourseLearningCase_Base.SectionId);
}
objvCourseLearningCase_BaseEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SectionId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SectionId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SectionId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetParentNodeReferred(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCase_Base.ParentNodeReferred);
}
objvCourseLearningCase_BaseEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ParentNodeReferred) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetParentNodeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convCourseLearningCase_Base.ParentNodeName);
}
objvCourseLearningCase_BaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ParentNodeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetViewCount(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int? intViewCount, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ViewCount) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsShow(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsShow) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDownloadNumber(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DownloadNumber) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetFileIntegration(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.FileIntegration) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetLikeCount(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.LikeCount) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollectionCount(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollectionCount) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetRecommendedDegreeId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCase_Base.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase_Base.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase_Base.RecommendedDegreeId);
}
objvCourseLearningCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.RecommendedDegreeId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetRecommendedDegreeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCase_Base.RecommendedDegreeName);
}
objvCourseLearningCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.RecommendedDegreeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetftpFileType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCase_Base.ftpFileType);
}
objvCourseLearningCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ftpFileType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetVideoUrl(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCourseLearningCase_Base.VideoUrl);
}
objvCourseLearningCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.VideoUrl) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetVideoPath(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCourseLearningCase_Base.VideoPath);
}
objvCourseLearningCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.VideoPath) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.VideoPath, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.VideoPath] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetResErrMsg(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCourseLearningCase_Base.ResErrMsg);
}
objvCourseLearningCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ResErrMsg) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetMemo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase_Base.Memo);
}
objvCourseLearningCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.Memo) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.Memo, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.Memo] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetBrowseCount4Case(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.BrowseCount4Case) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOwnerName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCase_Base.OwnerName);
}
objvCourseLearningCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OwnerName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOwnerNameWithId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCase_Base.OwnerNameWithId);
}
objvCourseLearningCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OwnerNameWithId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOrderNum(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int? intOrderNum, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OrderNum) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OrderNum, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OrderNum] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsUse(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsUse, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsUse) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsUse, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsUse] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseENS">源对象</param>
 /// <param name = "objvCourseLearningCase_BaseENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENS, clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENT)
{
try
{
objvCourseLearningCase_BaseENT.IdCourseLearningCase = objvCourseLearningCase_BaseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseID = objvCourseLearningCase_BaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_BaseENT.CourseLearningCaseName = objvCourseLearningCase_BaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_BaseENT.CourseLearningCaseText = objvCourseLearningCase_BaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_BaseENT.CourseLearningCaseTheme = objvCourseLearningCase_BaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_BaseENT.CourseLearningCaseDate = objvCourseLearningCase_BaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTime = objvCourseLearningCase_BaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_BaseENT.CourseLearningCaseDateIn = objvCourseLearningCase_BaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTimeIn = objvCourseLearningCase_BaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_BaseENT.IdCaseType = objvCourseLearningCase_BaseENS.IdCaseType; //案例类型流水号
objvCourseLearningCase_BaseENT.CaseTypeName = objvCourseLearningCase_BaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCase_BaseENT.IdCourseLearningCaseType = objvCourseLearningCase_BaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseTypeName = objvCourseLearningCase_BaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_BaseENT.OwnerId = objvCourseLearningCase_BaseENS.OwnerId; //拥有者Id
objvCourseLearningCase_BaseENT.IdStudyLevel = objvCourseLearningCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCase_BaseENT.StudyLevelName = objvCourseLearningCase_BaseENS.StudyLevelName; //学段名称
objvCourseLearningCase_BaseENT.IdTeachingPlan = objvCourseLearningCase_BaseENS.IdTeachingPlan; //教案流水号
objvCourseLearningCase_BaseENT.IdDiscipline = objvCourseLearningCase_BaseENS.IdDiscipline; //学科流水号
objvCourseLearningCase_BaseENT.DisciplineID = objvCourseLearningCase_BaseENS.DisciplineID; //学科ID
objvCourseLearningCase_BaseENT.DisciplineName = objvCourseLearningCase_BaseENS.DisciplineName; //学科名称
objvCourseLearningCase_BaseENT.IdSenateGaugeVersion = objvCourseLearningCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCase_BaseENT.senateGaugeVersionID = objvCourseLearningCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_BaseENT.senateGaugeVersionName = objvCourseLearningCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_BaseENT.senateGaugeVersionTtlScore = objvCourseLearningCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_BaseENT.VersionNo = objvCourseLearningCase_BaseENS.VersionNo; //版本号
objvCourseLearningCase_BaseENT.IdTeachSkill = objvCourseLearningCase_BaseENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCase_BaseENT.TeachSkillID = objvCourseLearningCase_BaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_BaseENT.SkillTypeName = objvCourseLearningCase_BaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_BaseENT.TeachSkillName = objvCourseLearningCase_BaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_BaseENT.TeachSkillTheory = objvCourseLearningCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_BaseENT.TeachSkillOperMethod = objvCourseLearningCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_BaseENT.IdSkillType = objvCourseLearningCase_BaseENS.IdSkillType; //技能类型流水号
objvCourseLearningCase_BaseENT.SkillTypeID = objvCourseLearningCase_BaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_BaseENT.CaseLevelId = objvCourseLearningCase_BaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_BaseENT.CaseLevelName = objvCourseLearningCase_BaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCase_BaseENT.DocFile = objvCourseLearningCase_BaseENS.DocFile; //生成的Word文件名
objvCourseLearningCase_BaseENT.IsNeedGeneWord = objvCourseLearningCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCase_BaseENT.WordCreateDate = objvCourseLearningCase_BaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCase_BaseENT.IsVisible = objvCourseLearningCase_BaseENS.IsVisible; //是否显示
objvCourseLearningCase_BaseENT.IsDualVideo = objvCourseLearningCase_BaseENS.IsDualVideo; //是否双视频
objvCourseLearningCase_BaseENT.IdXzCollege = objvCourseLearningCase_BaseENS.IdXzCollege; //学院流水号
objvCourseLearningCase_BaseENT.CollegeId = objvCourseLearningCase_BaseENS.CollegeId; //学院ID
objvCourseLearningCase_BaseENT.CollegeName = objvCourseLearningCase_BaseENS.CollegeName; //学院名称
objvCourseLearningCase_BaseENT.CollegeNameA = objvCourseLearningCase_BaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_BaseENT.IdXzMajor = objvCourseLearningCase_BaseENS.IdXzMajor; //专业流水号
objvCourseLearningCase_BaseENT.MajorID = objvCourseLearningCase_BaseENS.MajorID; //专业ID
objvCourseLearningCase_BaseENT.MajorName = objvCourseLearningCase_BaseENS.MajorName; //专业名称
objvCourseLearningCase_BaseENT.CourseId = objvCourseLearningCase_BaseENS.CourseId; //课程Id
objvCourseLearningCase_BaseENT.CourseCode = objvCourseLearningCase_BaseENS.CourseCode; //课程代码
objvCourseLearningCase_BaseENT.CourseName = objvCourseLearningCase_BaseENS.CourseName; //课程名称
objvCourseLearningCase_BaseENT.CourseChapterId = objvCourseLearningCase_BaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_BaseENT.CourseChapterName = objvCourseLearningCase_BaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_BaseENT.ChapterId = objvCourseLearningCase_BaseENS.ChapterId; //章Id
objvCourseLearningCase_BaseENT.ParentNodeId = objvCourseLearningCase_BaseENS.ParentNodeId; //父节点编号
objvCourseLearningCase_BaseENT.CourseChapterReferred = objvCourseLearningCase_BaseENS.CourseChapterReferred; //节简称
objvCourseLearningCase_BaseENT.ChapterName = objvCourseLearningCase_BaseENS.ChapterName; //章名
objvCourseLearningCase_BaseENT.ChapterNameSim = objvCourseLearningCase_BaseENS.ChapterNameSim; //章名简称
objvCourseLearningCase_BaseENT.SectionName = objvCourseLearningCase_BaseENS.SectionName; //节名
objvCourseLearningCase_BaseENT.SectionNameSim = objvCourseLearningCase_BaseENS.SectionNameSim; //节名简称
objvCourseLearningCase_BaseENT.SectionId = objvCourseLearningCase_BaseENS.SectionId; //节Id
objvCourseLearningCase_BaseENT.ParentNodeReferred = objvCourseLearningCase_BaseENS.ParentNodeReferred; //章简称
objvCourseLearningCase_BaseENT.ParentNodeName = objvCourseLearningCase_BaseENS.ParentNodeName; //父节点名称
objvCourseLearningCase_BaseENT.ViewCount = objvCourseLearningCase_BaseENS.ViewCount; //浏览量
objvCourseLearningCase_BaseENT.IsShow = objvCourseLearningCase_BaseENS.IsShow; //是否启用
objvCourseLearningCase_BaseENT.DownloadNumber = objvCourseLearningCase_BaseENS.DownloadNumber; //下载数目
objvCourseLearningCase_BaseENT.FileIntegration = objvCourseLearningCase_BaseENS.FileIntegration; //文件积分
objvCourseLearningCase_BaseENT.LikeCount = objvCourseLearningCase_BaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_BaseENT.CollectionCount = objvCourseLearningCase_BaseENS.CollectionCount; //收藏数量
objvCourseLearningCase_BaseENT.RecommendedDegreeId = objvCourseLearningCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_BaseENT.RecommendedDegreeName = objvCourseLearningCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_BaseENT.ftpFileType = objvCourseLearningCase_BaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_BaseENT.VideoUrl = objvCourseLearningCase_BaseENS.VideoUrl; //视频Url
objvCourseLearningCase_BaseENT.VideoPath = objvCourseLearningCase_BaseENS.VideoPath; //视频目录
objvCourseLearningCase_BaseENT.ResErrMsg = objvCourseLearningCase_BaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCase_BaseENT.Memo = objvCourseLearningCase_BaseENS.Memo; //备注
objvCourseLearningCase_BaseENT.BrowseCount4Case = objvCourseLearningCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_BaseENT.OwnerName = objvCourseLearningCase_BaseENS.OwnerName; //拥有者姓名
objvCourseLearningCase_BaseENT.OwnerNameWithId = objvCourseLearningCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_BaseENT.OrderNum = objvCourseLearningCase_BaseENS.OrderNum; //序号
objvCourseLearningCase_BaseENT.IsUse = objvCourseLearningCase_BaseENS.IsUse; //是否使用
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
 /// <param name = "objvCourseLearningCase_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCase_BaseEN:objvCourseLearningCase_BaseENT</returns>
 public static clsvCourseLearningCase_BaseEN CopyTo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENS)
{
try
{
 clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENT = new clsvCourseLearningCase_BaseEN()
{
IdCourseLearningCase = objvCourseLearningCase_BaseENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objvCourseLearningCase_BaseENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCase_BaseENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseText = objvCourseLearningCase_BaseENS.CourseLearningCaseText, //案例文本内容
CourseLearningCaseTheme = objvCourseLearningCase_BaseENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objvCourseLearningCase_BaseENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objvCourseLearningCase_BaseENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objvCourseLearningCase_BaseENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objvCourseLearningCase_BaseENS.CourseLearningCaseTimeIn, //案例入库时间
IdCaseType = objvCourseLearningCase_BaseENS.IdCaseType, //案例类型流水号
CaseTypeName = objvCourseLearningCase_BaseENS.CaseTypeName, //案例类型名称
IdCourseLearningCaseType = objvCourseLearningCase_BaseENS.IdCourseLearningCaseType, //课程学习案例类型流水号
CourseLearningCaseTypeName = objvCourseLearningCase_BaseENS.CourseLearningCaseTypeName, //课程学习案例类型名称
OwnerId = objvCourseLearningCase_BaseENS.OwnerId, //拥有者Id
IdStudyLevel = objvCourseLearningCase_BaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvCourseLearningCase_BaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvCourseLearningCase_BaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objvCourseLearningCase_BaseENS.IdDiscipline, //学科流水号
DisciplineID = objvCourseLearningCase_BaseENS.DisciplineID, //学科ID
DisciplineName = objvCourseLearningCase_BaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvCourseLearningCase_BaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvCourseLearningCase_BaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvCourseLearningCase_BaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvCourseLearningCase_BaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvCourseLearningCase_BaseENS.VersionNo, //版本号
IdTeachSkill = objvCourseLearningCase_BaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvCourseLearningCase_BaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvCourseLearningCase_BaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvCourseLearningCase_BaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvCourseLearningCase_BaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvCourseLearningCase_BaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvCourseLearningCase_BaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvCourseLearningCase_BaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvCourseLearningCase_BaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvCourseLearningCase_BaseENS.CaseLevelName, //案例等级名称
DocFile = objvCourseLearningCase_BaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvCourseLearningCase_BaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvCourseLearningCase_BaseENS.WordCreateDate, //Word生成日期
IsVisible = objvCourseLearningCase_BaseENS.IsVisible, //是否显示
IsDualVideo = objvCourseLearningCase_BaseENS.IsDualVideo, //是否双视频
IdXzCollege = objvCourseLearningCase_BaseENS.IdXzCollege, //学院流水号
CollegeId = objvCourseLearningCase_BaseENS.CollegeId, //学院ID
CollegeName = objvCourseLearningCase_BaseENS.CollegeName, //学院名称
CollegeNameA = objvCourseLearningCase_BaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvCourseLearningCase_BaseENS.IdXzMajor, //专业流水号
MajorID = objvCourseLearningCase_BaseENS.MajorID, //专业ID
MajorName = objvCourseLearningCase_BaseENS.MajorName, //专业名称
CourseId = objvCourseLearningCase_BaseENS.CourseId, //课程Id
CourseCode = objvCourseLearningCase_BaseENS.CourseCode, //课程代码
CourseName = objvCourseLearningCase_BaseENS.CourseName, //课程名称
CourseChapterId = objvCourseLearningCase_BaseENS.CourseChapterId, //课程章节ID
CourseChapterName = objvCourseLearningCase_BaseENS.CourseChapterName, //课程章节名称
ChapterId = objvCourseLearningCase_BaseENS.ChapterId, //章Id
ParentNodeId = objvCourseLearningCase_BaseENS.ParentNodeId, //父节点编号
CourseChapterReferred = objvCourseLearningCase_BaseENS.CourseChapterReferred, //节简称
ChapterName = objvCourseLearningCase_BaseENS.ChapterName, //章名
ChapterNameSim = objvCourseLearningCase_BaseENS.ChapterNameSim, //章名简称
SectionName = objvCourseLearningCase_BaseENS.SectionName, //节名
SectionNameSim = objvCourseLearningCase_BaseENS.SectionNameSim, //节名简称
SectionId = objvCourseLearningCase_BaseENS.SectionId, //节Id
ParentNodeReferred = objvCourseLearningCase_BaseENS.ParentNodeReferred, //章简称
ParentNodeName = objvCourseLearningCase_BaseENS.ParentNodeName, //父节点名称
ViewCount = objvCourseLearningCase_BaseENS.ViewCount, //浏览量
IsShow = objvCourseLearningCase_BaseENS.IsShow, //是否启用
DownloadNumber = objvCourseLearningCase_BaseENS.DownloadNumber, //下载数目
FileIntegration = objvCourseLearningCase_BaseENS.FileIntegration, //文件积分
LikeCount = objvCourseLearningCase_BaseENS.LikeCount, //资源喜欢数量
CollectionCount = objvCourseLearningCase_BaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvCourseLearningCase_BaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvCourseLearningCase_BaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvCourseLearningCase_BaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvCourseLearningCase_BaseENS.VideoUrl, //视频Url
VideoPath = objvCourseLearningCase_BaseENS.VideoPath, //视频目录
ResErrMsg = objvCourseLearningCase_BaseENS.ResErrMsg, //资源错误信息
Memo = objvCourseLearningCase_BaseENS.Memo, //备注
BrowseCount4Case = objvCourseLearningCase_BaseENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvCourseLearningCase_BaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvCourseLearningCase_BaseENS.OwnerNameWithId, //拥有者名称附Id
OrderNum = objvCourseLearningCase_BaseENS.OrderNum, //序号
IsUse = objvCourseLearningCase_BaseENS.IsUse, //是否使用
};
 return objvCourseLearningCase_BaseENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
 clsvCourseLearningCase_BaseBL.vCourseLearningCase_BaseDA.CheckProperty4Condition(objvCourseLearningCase_BaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdCourseLearningCase, objvCourseLearningCase_BaseCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseID, objvCourseLearningCase_BaseCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseName, objvCourseLearningCase_BaseCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseText) == true)
{
string strComparisonOpCourseLearningCaseText = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseText, objvCourseLearningCase_BaseCond.CourseLearningCaseText, strComparisonOpCourseLearningCaseText);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTheme, objvCourseLearningCase_BaseCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseDate, objvCourseLearningCase_BaseCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTime, objvCourseLearningCase_BaseCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseDateIn, objvCourseLearningCase_BaseCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTimeIn, objvCourseLearningCase_BaseCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdCaseType, objvCourseLearningCase_BaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CaseTypeName) == true)
{
string strComparisonOpCaseTypeName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CaseTypeName, objvCourseLearningCase_BaseCond.CaseTypeName, strComparisonOpCaseTypeName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdCourseLearningCaseType) == true)
{
string strComparisonOpIdCourseLearningCaseType = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdCourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdCourseLearningCaseType, objvCourseLearningCase_BaseCond.IdCourseLearningCaseType, strComparisonOpIdCourseLearningCaseType);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTypeName) == true)
{
string strComparisonOpCourseLearningCaseTypeName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTypeName, objvCourseLearningCase_BaseCond.CourseLearningCaseTypeName, strComparisonOpCourseLearningCaseTypeName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.OwnerId, objvCourseLearningCase_BaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdStudyLevel, objvCourseLearningCase_BaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.StudyLevelName, objvCourseLearningCase_BaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdTeachingPlan, objvCourseLearningCase_BaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdDiscipline, objvCourseLearningCase_BaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.DisciplineID, objvCourseLearningCase_BaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.DisciplineName, objvCourseLearningCase_BaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdSenateGaugeVersion, objvCourseLearningCase_BaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.senateGaugeVersionID, objvCourseLearningCase_BaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.senateGaugeVersionName, objvCourseLearningCase_BaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.senateGaugeVersionTtlScore, objvCourseLearningCase_BaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.VersionNo) == true)
{
string strComparisonOpVersionNo = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.VersionNo, objvCourseLearningCase_BaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdTeachSkill, objvCourseLearningCase_BaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillID, objvCourseLearningCase_BaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SkillTypeName, objvCourseLearningCase_BaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillName, objvCourseLearningCase_BaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillTheory, objvCourseLearningCase_BaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillOperMethod, objvCourseLearningCase_BaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdSkillType, objvCourseLearningCase_BaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SkillTypeID, objvCourseLearningCase_BaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CaseLevelId, objvCourseLearningCase_BaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CaseLevelName, objvCourseLearningCase_BaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.DocFile) == true)
{
string strComparisonOpDocFile = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.DocFile, objvCourseLearningCase_BaseCond.DocFile, strComparisonOpDocFile);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IsNeedGeneWord) == true)
{
if (objvCourseLearningCase_BaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsNeedGeneWord);
}
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.WordCreateDate, objvCourseLearningCase_BaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IsVisible) == true)
{
if (objvCourseLearningCase_BaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsVisible);
}
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IsDualVideo) == true)
{
if (objvCourseLearningCase_BaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsDualVideo);
}
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdXzCollege, objvCourseLearningCase_BaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CollegeId) == true)
{
string strComparisonOpCollegeId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CollegeId, objvCourseLearningCase_BaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CollegeName, objvCourseLearningCase_BaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CollegeNameA, objvCourseLearningCase_BaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.IdXzMajor, objvCourseLearningCase_BaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.MajorID, objvCourseLearningCase_BaseCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.MajorName, objvCourseLearningCase_BaseCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseId, objvCourseLearningCase_BaseCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseCode, objvCourseLearningCase_BaseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseName, objvCourseLearningCase_BaseCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseChapterId, objvCourseLearningCase_BaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseChapterName, objvCourseLearningCase_BaseCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ChapterId) == true)
{
string strComparisonOpChapterId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ChapterId, objvCourseLearningCase_BaseCond.ChapterId, strComparisonOpChapterId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ParentNodeId, objvCourseLearningCase_BaseCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseChapterReferred, objvCourseLearningCase_BaseCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ChapterName) == true)
{
string strComparisonOpChapterName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ChapterName, objvCourseLearningCase_BaseCond.ChapterName, strComparisonOpChapterName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ChapterNameSim, objvCourseLearningCase_BaseCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.SectionName) == true)
{
string strComparisonOpSectionName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SectionName, objvCourseLearningCase_BaseCond.SectionName, strComparisonOpSectionName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SectionNameSim, objvCourseLearningCase_BaseCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.SectionId) == true)
{
string strComparisonOpSectionId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SectionId, objvCourseLearningCase_BaseCond.SectionId, strComparisonOpSectionId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ParentNodeReferred, objvCourseLearningCase_BaseCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ParentNodeName, objvCourseLearningCase_BaseCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ViewCount) == true)
{
string strComparisonOpViewCount = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.ViewCount, objvCourseLearningCase_BaseCond.ViewCount, strComparisonOpViewCount);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IsShow) == true)
{
if (objvCourseLearningCase_BaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsShow);
}
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.DownloadNumber, objvCourseLearningCase_BaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.FileIntegration, objvCourseLearningCase_BaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.LikeCount) == true)
{
string strComparisonOpLikeCount = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.LikeCount, objvCourseLearningCase_BaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.CollectionCount, objvCourseLearningCase_BaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.RecommendedDegreeId, objvCourseLearningCase_BaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.RecommendedDegreeName, objvCourseLearningCase_BaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ftpFileType, objvCourseLearningCase_BaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.VideoUrl, objvCourseLearningCase_BaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.VideoPath) == true)
{
string strComparisonOpVideoPath = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.VideoPath, objvCourseLearningCase_BaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ResErrMsg, objvCourseLearningCase_BaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.Memo, objvCourseLearningCase_BaseCond.Memo, strComparisonOpMemo);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.BrowseCount4Case, objvCourseLearningCase_BaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.OwnerName, objvCourseLearningCase_BaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.OwnerNameWithId, objvCourseLearningCase_BaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCourseLearningCase_BaseCond.dicFldComparisonOp[convCourseLearningCase_Base.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.OrderNum, objvCourseLearningCase_BaseCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCourseLearningCase_BaseCond.IsUpdated(convCourseLearningCase_Base.IsUse) == true)
{
if (objvCourseLearningCase_BaseCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsUse);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCase_Base
{
public virtual bool UpdRelaTabDate(string strIdCourseLearningCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例_Base(vCourseLearningCase_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase_BaseBL
{
public static RelatedActions_vCourseLearningCase_Base relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCase_BaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCase_BaseDA vCourseLearningCase_BaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCase_BaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCase_BaseBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCase_BaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase_BaseEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCase_Base(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCase_BaseDA.GetDataTable_vCourseLearningCase_Base(strWhereCond);
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
objDT = vCourseLearningCase_BaseDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCase_BaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCase_BaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCase_BaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCase_BaseDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCase_BaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByIdCourseLearningCaseLst(List<string> arrIdCourseLearningCaseLst)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
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
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCase_BaseEN> GetObjLstByIdCourseLearningCaseLstCache(List<string> arrIdCourseLearningCaseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel =
arrvCourseLearningCase_BaseObjLstCache
.Where(x => arrIdCourseLearningCaseLst.Contains(x.IdCourseLearningCase));
return arrvCourseLearningCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCase_BaseEN> GetSubObjLstCache(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseCond)
{
List<clsvCourseLearningCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase_Base.AttributeName)
{
if (objvCourseLearningCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_BaseCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_BaseCond[strFldName]));
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
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
List<clsvCourseLearningCase_BaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCase_BaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
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
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
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
public static List<clsvCourseLearningCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase_BaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCase_Base(ref clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
bool bolResult = vCourseLearningCase_BaseDA.GetvCourseLearningCase_Base(ref objvCourseLearningCase_BaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_BaseEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
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
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = vCourseLearningCase_BaseDA.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
return objvCourseLearningCase_BaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCase_BaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = vCourseLearningCase_BaseDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCase_BaseEN;
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
public static clsvCourseLearningCase_BaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = vCourseLearningCase_BaseDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase_BaseEN;
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
public static clsvCourseLearningCase_BaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = vCourseLearningCase_BaseDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase_BaseEN;
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
 /// <param name = "lstvCourseLearningCase_BaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase_BaseEN GetObjByIdCourseLearningCaseFromList(string strIdCourseLearningCase, List<clsvCourseLearningCase_BaseEN> lstvCourseLearningCase_BaseObjLst)
{
foreach (clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN in lstvCourseLearningCase_BaseObjLst)
{
if (objvCourseLearningCase_BaseEN.IdCourseLearningCase == strIdCourseLearningCase)
{
return objvCourseLearningCase_BaseEN;
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
 strIdCourseLearningCase = new clsvCourseLearningCase_BaseDA().GetFirstID(strWhereCond);
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
 arrList = vCourseLearningCase_BaseDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCase_BaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCourseLearningCase_BaseDA.IsExist(strIdCourseLearningCase);
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
 bolIsExist = clsvCourseLearningCase_BaseDA.IsExistTable();
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
 bolIsExist = vCourseLearningCase_BaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCase_BaseENS">源对象</param>
 /// <param name = "objvCourseLearningCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENS, clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENT)
{
try
{
objvCourseLearningCase_BaseENT.IdCourseLearningCase = objvCourseLearningCase_BaseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseID = objvCourseLearningCase_BaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_BaseENT.CourseLearningCaseName = objvCourseLearningCase_BaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_BaseENT.CourseLearningCaseText = objvCourseLearningCase_BaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_BaseENT.CourseLearningCaseTheme = objvCourseLearningCase_BaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_BaseENT.CourseLearningCaseDate = objvCourseLearningCase_BaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTime = objvCourseLearningCase_BaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_BaseENT.CourseLearningCaseDateIn = objvCourseLearningCase_BaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTimeIn = objvCourseLearningCase_BaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_BaseENT.IdCaseType = objvCourseLearningCase_BaseENS.IdCaseType; //案例类型流水号
objvCourseLearningCase_BaseENT.CaseTypeName = objvCourseLearningCase_BaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCase_BaseENT.IdCourseLearningCaseType = objvCourseLearningCase_BaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseTypeName = objvCourseLearningCase_BaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_BaseENT.OwnerId = objvCourseLearningCase_BaseENS.OwnerId; //拥有者Id
objvCourseLearningCase_BaseENT.IdStudyLevel = objvCourseLearningCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCase_BaseENT.StudyLevelName = objvCourseLearningCase_BaseENS.StudyLevelName; //学段名称
objvCourseLearningCase_BaseENT.IdTeachingPlan = objvCourseLearningCase_BaseENS.IdTeachingPlan; //教案流水号
objvCourseLearningCase_BaseENT.IdDiscipline = objvCourseLearningCase_BaseENS.IdDiscipline; //学科流水号
objvCourseLearningCase_BaseENT.DisciplineID = objvCourseLearningCase_BaseENS.DisciplineID; //学科ID
objvCourseLearningCase_BaseENT.DisciplineName = objvCourseLearningCase_BaseENS.DisciplineName; //学科名称
objvCourseLearningCase_BaseENT.IdSenateGaugeVersion = objvCourseLearningCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCase_BaseENT.senateGaugeVersionID = objvCourseLearningCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_BaseENT.senateGaugeVersionName = objvCourseLearningCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_BaseENT.senateGaugeVersionTtlScore = objvCourseLearningCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_BaseENT.VersionNo = objvCourseLearningCase_BaseENS.VersionNo; //版本号
objvCourseLearningCase_BaseENT.IdTeachSkill = objvCourseLearningCase_BaseENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCase_BaseENT.TeachSkillID = objvCourseLearningCase_BaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_BaseENT.SkillTypeName = objvCourseLearningCase_BaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_BaseENT.TeachSkillName = objvCourseLearningCase_BaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_BaseENT.TeachSkillTheory = objvCourseLearningCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_BaseENT.TeachSkillOperMethod = objvCourseLearningCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_BaseENT.IdSkillType = objvCourseLearningCase_BaseENS.IdSkillType; //技能类型流水号
objvCourseLearningCase_BaseENT.SkillTypeID = objvCourseLearningCase_BaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_BaseENT.CaseLevelId = objvCourseLearningCase_BaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_BaseENT.CaseLevelName = objvCourseLearningCase_BaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCase_BaseENT.DocFile = objvCourseLearningCase_BaseENS.DocFile; //生成的Word文件名
objvCourseLearningCase_BaseENT.IsNeedGeneWord = objvCourseLearningCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCase_BaseENT.WordCreateDate = objvCourseLearningCase_BaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCase_BaseENT.IsVisible = objvCourseLearningCase_BaseENS.IsVisible; //是否显示
objvCourseLearningCase_BaseENT.IsDualVideo = objvCourseLearningCase_BaseENS.IsDualVideo; //是否双视频
objvCourseLearningCase_BaseENT.IdXzCollege = objvCourseLearningCase_BaseENS.IdXzCollege; //学院流水号
objvCourseLearningCase_BaseENT.CollegeId = objvCourseLearningCase_BaseENS.CollegeId; //学院ID
objvCourseLearningCase_BaseENT.CollegeName = objvCourseLearningCase_BaseENS.CollegeName; //学院名称
objvCourseLearningCase_BaseENT.CollegeNameA = objvCourseLearningCase_BaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_BaseENT.IdXzMajor = objvCourseLearningCase_BaseENS.IdXzMajor; //专业流水号
objvCourseLearningCase_BaseENT.MajorID = objvCourseLearningCase_BaseENS.MajorID; //专业ID
objvCourseLearningCase_BaseENT.MajorName = objvCourseLearningCase_BaseENS.MajorName; //专业名称
objvCourseLearningCase_BaseENT.CourseId = objvCourseLearningCase_BaseENS.CourseId; //课程Id
objvCourseLearningCase_BaseENT.CourseCode = objvCourseLearningCase_BaseENS.CourseCode; //课程代码
objvCourseLearningCase_BaseENT.CourseName = objvCourseLearningCase_BaseENS.CourseName; //课程名称
objvCourseLearningCase_BaseENT.CourseChapterId = objvCourseLearningCase_BaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_BaseENT.CourseChapterName = objvCourseLearningCase_BaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_BaseENT.ChapterId = objvCourseLearningCase_BaseENS.ChapterId; //章Id
objvCourseLearningCase_BaseENT.ParentNodeId = objvCourseLearningCase_BaseENS.ParentNodeId; //父节点编号
objvCourseLearningCase_BaseENT.CourseChapterReferred = objvCourseLearningCase_BaseENS.CourseChapterReferred; //节简称
objvCourseLearningCase_BaseENT.ChapterName = objvCourseLearningCase_BaseENS.ChapterName; //章名
objvCourseLearningCase_BaseENT.ChapterNameSim = objvCourseLearningCase_BaseENS.ChapterNameSim; //章名简称
objvCourseLearningCase_BaseENT.SectionName = objvCourseLearningCase_BaseENS.SectionName; //节名
objvCourseLearningCase_BaseENT.SectionNameSim = objvCourseLearningCase_BaseENS.SectionNameSim; //节名简称
objvCourseLearningCase_BaseENT.SectionId = objvCourseLearningCase_BaseENS.SectionId; //节Id
objvCourseLearningCase_BaseENT.ParentNodeReferred = objvCourseLearningCase_BaseENS.ParentNodeReferred; //章简称
objvCourseLearningCase_BaseENT.ParentNodeName = objvCourseLearningCase_BaseENS.ParentNodeName; //父节点名称
objvCourseLearningCase_BaseENT.ViewCount = objvCourseLearningCase_BaseENS.ViewCount; //浏览量
objvCourseLearningCase_BaseENT.IsShow = objvCourseLearningCase_BaseENS.IsShow; //是否启用
objvCourseLearningCase_BaseENT.DownloadNumber = objvCourseLearningCase_BaseENS.DownloadNumber; //下载数目
objvCourseLearningCase_BaseENT.FileIntegration = objvCourseLearningCase_BaseENS.FileIntegration; //文件积分
objvCourseLearningCase_BaseENT.LikeCount = objvCourseLearningCase_BaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_BaseENT.CollectionCount = objvCourseLearningCase_BaseENS.CollectionCount; //收藏数量
objvCourseLearningCase_BaseENT.RecommendedDegreeId = objvCourseLearningCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_BaseENT.RecommendedDegreeName = objvCourseLearningCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_BaseENT.ftpFileType = objvCourseLearningCase_BaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_BaseENT.VideoUrl = objvCourseLearningCase_BaseENS.VideoUrl; //视频Url
objvCourseLearningCase_BaseENT.VideoPath = objvCourseLearningCase_BaseENS.VideoPath; //视频目录
objvCourseLearningCase_BaseENT.ResErrMsg = objvCourseLearningCase_BaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCase_BaseENT.Memo = objvCourseLearningCase_BaseENS.Memo; //备注
objvCourseLearningCase_BaseENT.BrowseCount4Case = objvCourseLearningCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_BaseENT.OwnerName = objvCourseLearningCase_BaseENS.OwnerName; //拥有者姓名
objvCourseLearningCase_BaseENT.OwnerNameWithId = objvCourseLearningCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_BaseENT.OrderNum = objvCourseLearningCase_BaseENS.OrderNum; //序号
objvCourseLearningCase_BaseENT.IsUse = objvCourseLearningCase_BaseENS.IsUse; //是否使用
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
 /// <param name = "objvCourseLearningCase_BaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
try
{
objvCourseLearningCase_BaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCase_BaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCase_Base.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objvCourseLearningCase_BaseEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objvCourseLearningCase_BaseEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objvCourseLearningCase_BaseEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objvCourseLearningCase_BaseEN.CourseLearningCaseText == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseText; //案例文本内容
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objvCourseLearningCase_BaseEN.CourseLearningCaseTheme == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objvCourseLearningCase_BaseEN.CourseLearningCaseDate == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objvCourseLearningCase_BaseEN.CourseLearningCaseTime == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdCaseType = objvCourseLearningCase_BaseEN.IdCaseType == "[null]" ? null :  objvCourseLearningCase_BaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CaseTypeName = objvCourseLearningCase_BaseEN.CaseTypeName == "[null]" ? null :  objvCourseLearningCase_BaseEN.CaseTypeName; //案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdCourseLearningCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objvCourseLearningCase_BaseEN.IdCourseLearningCaseType; //课程学习案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseLearningCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName; //课程学习案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.OwnerId = objvCourseLearningCase_BaseEN.OwnerId == "[null]" ? null :  objvCourseLearningCase_BaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdStudyLevel = objvCourseLearningCase_BaseEN.IdStudyLevel == "[null]" ? null :  objvCourseLearningCase_BaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convCourseLearningCase_Base.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.StudyLevelName = objvCourseLearningCase_BaseEN.StudyLevelName == "[null]" ? null :  objvCourseLearningCase_BaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdTeachingPlan = objvCourseLearningCase_BaseEN.IdTeachingPlan == "[null]" ? null :  objvCourseLearningCase_BaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdDiscipline = objvCourseLearningCase_BaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.DisciplineID = objvCourseLearningCase_BaseEN.DisciplineID == "[null]" ? null :  objvCourseLearningCase_BaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.DisciplineName = objvCourseLearningCase_BaseEN.DisciplineName == "[null]" ? null :  objvCourseLearningCase_BaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objvCourseLearningCase_BaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvCourseLearningCase_BaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objvCourseLearningCase_BaseEN.senateGaugeVersionID == "[null]" ? null :  objvCourseLearningCase_BaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objvCourseLearningCase_BaseEN.senateGaugeVersionName == "[null]" ? null :  objvCourseLearningCase_BaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convCourseLearningCase_Base.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.VersionNo = objvCourseLearningCase_BaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdTeachSkill = objvCourseLearningCase_BaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.TeachSkillID = objvCourseLearningCase_BaseEN.TeachSkillID == "[null]" ? null :  objvCourseLearningCase_BaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.SkillTypeName = objvCourseLearningCase_BaseEN.SkillTypeName == "[null]" ? null :  objvCourseLearningCase_BaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.TeachSkillName = objvCourseLearningCase_BaseEN.TeachSkillName == "[null]" ? null :  objvCourseLearningCase_BaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.TeachSkillTheory = objvCourseLearningCase_BaseEN.TeachSkillTheory == "[null]" ? null :  objvCourseLearningCase_BaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convCourseLearningCase_Base.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objvCourseLearningCase_BaseEN.TeachSkillOperMethod == "[null]" ? null :  objvCourseLearningCase_BaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdSkillType = objvCourseLearningCase_BaseEN.IdSkillType == "[null]" ? null :  objvCourseLearningCase_BaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.SkillTypeID = objvCourseLearningCase_BaseEN.SkillTypeID == "[null]" ? null :  objvCourseLearningCase_BaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CaseLevelId = objvCourseLearningCase_BaseEN.CaseLevelId == "[null]" ? null :  objvCourseLearningCase_BaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CaseLevelName = objvCourseLearningCase_BaseEN.CaseLevelName == "[null]" ? null :  objvCourseLearningCase_BaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.DocFile = objvCourseLearningCase_BaseEN.DocFile == "[null]" ? null :  objvCourseLearningCase_BaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IsNeedGeneWord = objvCourseLearningCase_BaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convCourseLearningCase_Base.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.WordCreateDate = objvCourseLearningCase_BaseEN.WordCreateDate == "[null]" ? null :  objvCourseLearningCase_BaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IsVisible = objvCourseLearningCase_BaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IsDualVideo = objvCourseLearningCase_BaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdXzCollege = objvCourseLearningCase_BaseEN.IdXzCollege == "[null]" ? null :  objvCourseLearningCase_BaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CollegeId = objvCourseLearningCase_BaseEN.CollegeId == "[null]" ? null :  objvCourseLearningCase_BaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CollegeName = objvCourseLearningCase_BaseEN.CollegeName == "[null]" ? null :  objvCourseLearningCase_BaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CollegeNameA = objvCourseLearningCase_BaseEN.CollegeNameA == "[null]" ? null :  objvCourseLearningCase_BaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IdXzMajor = objvCourseLearningCase_BaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.MajorID = objvCourseLearningCase_BaseEN.MajorID == "[null]" ? null :  objvCourseLearningCase_BaseEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.MajorName = objvCourseLearningCase_BaseEN.MajorName == "[null]" ? null :  objvCourseLearningCase_BaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseId = objvCourseLearningCase_BaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseCode = objvCourseLearningCase_BaseEN.CourseCode == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseName = objvCourseLearningCase_BaseEN.CourseName == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseChapterId = objvCourseLearningCase_BaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseChapterName = objvCourseLearningCase_BaseEN.CourseChapterName == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ChapterId = objvCourseLearningCase_BaseEN.ChapterId == "[null]" ? null :  objvCourseLearningCase_BaseEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ParentNodeId = objvCourseLearningCase_BaseEN.ParentNodeId == "[null]" ? null :  objvCourseLearningCase_BaseEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CourseChapterReferred = objvCourseLearningCase_BaseEN.CourseChapterReferred == "[null]" ? null :  objvCourseLearningCase_BaseEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ChapterName = objvCourseLearningCase_BaseEN.ChapterName == "[null]" ? null :  objvCourseLearningCase_BaseEN.ChapterName; //章名
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ChapterNameSim = objvCourseLearningCase_BaseEN.ChapterNameSim == "[null]" ? null :  objvCourseLearningCase_BaseEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.SectionName = objvCourseLearningCase_BaseEN.SectionName == "[null]" ? null :  objvCourseLearningCase_BaseEN.SectionName; //节名
}
if (arrFldSet.Contains(convCourseLearningCase_Base.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.SectionNameSim = objvCourseLearningCase_BaseEN.SectionNameSim == "[null]" ? null :  objvCourseLearningCase_BaseEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.SectionId = objvCourseLearningCase_BaseEN.SectionId == "[null]" ? null :  objvCourseLearningCase_BaseEN.SectionId; //节Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ParentNodeReferred = objvCourseLearningCase_BaseEN.ParentNodeReferred == "[null]" ? null :  objvCourseLearningCase_BaseEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ParentNodeName = objvCourseLearningCase_BaseEN.ParentNodeName == "[null]" ? null :  objvCourseLearningCase_BaseEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ViewCount = objvCourseLearningCase_BaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IsShow = objvCourseLearningCase_BaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convCourseLearningCase_Base.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.DownloadNumber = objvCourseLearningCase_BaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convCourseLearningCase_Base.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.FileIntegration = objvCourseLearningCase_BaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convCourseLearningCase_Base.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.LikeCount = objvCourseLearningCase_BaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convCourseLearningCase_Base.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.CollectionCount = objvCourseLearningCase_BaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convCourseLearningCase_Base.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objvCourseLearningCase_BaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objvCourseLearningCase_BaseEN.RecommendedDegreeName == "[null]" ? null :  objvCourseLearningCase_BaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ftpFileType = objvCourseLearningCase_BaseEN.ftpFileType == "[null]" ? null :  objvCourseLearningCase_BaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convCourseLearningCase_Base.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.VideoUrl = objvCourseLearningCase_BaseEN.VideoUrl == "[null]" ? null :  objvCourseLearningCase_BaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convCourseLearningCase_Base.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.VideoPath = objvCourseLearningCase_BaseEN.VideoPath == "[null]" ? null :  objvCourseLearningCase_BaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convCourseLearningCase_Base.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.ResErrMsg = objvCourseLearningCase_BaseEN.ResErrMsg == "[null]" ? null :  objvCourseLearningCase_BaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convCourseLearningCase_Base.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.Memo = objvCourseLearningCase_BaseEN.Memo == "[null]" ? null :  objvCourseLearningCase_BaseEN.Memo; //备注
}
if (arrFldSet.Contains(convCourseLearningCase_Base.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.BrowseCount4Case = objvCourseLearningCase_BaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convCourseLearningCase_Base.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.OwnerName = objvCourseLearningCase_BaseEN.OwnerName == "[null]" ? null :  objvCourseLearningCase_BaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCourseLearningCase_Base.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.OwnerNameWithId = objvCourseLearningCase_BaseEN.OwnerNameWithId == "[null]" ? null :  objvCourseLearningCase_BaseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convCourseLearningCase_Base.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.OrderNum = objvCourseLearningCase_BaseEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCourseLearningCase_Base.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase_BaseEN.IsUse = objvCourseLearningCase_BaseEN.IsUse; //是否使用
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
 /// <param name = "objvCourseLearningCase_BaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
try
{
if (objvCourseLearningCase_BaseEN.CourseLearningCaseText == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseText = null; //案例文本内容
if (objvCourseLearningCase_BaseEN.CourseLearningCaseTheme == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objvCourseLearningCase_BaseEN.CourseLearningCaseDate == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseDate = null; //课程学习日期
if (objvCourseLearningCase_BaseEN.CourseLearningCaseTime == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseTime = null; //课程学习时间
if (objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objvCourseLearningCase_BaseEN.IdCaseType == "[null]") objvCourseLearningCase_BaseEN.IdCaseType = null; //案例类型流水号
if (objvCourseLearningCase_BaseEN.CaseTypeName == "[null]") objvCourseLearningCase_BaseEN.CaseTypeName = null; //案例类型名称
if (objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName == "[null]") objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = null; //课程学习案例类型名称
if (objvCourseLearningCase_BaseEN.OwnerId == "[null]") objvCourseLearningCase_BaseEN.OwnerId = null; //拥有者Id
if (objvCourseLearningCase_BaseEN.IdStudyLevel == "[null]") objvCourseLearningCase_BaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvCourseLearningCase_BaseEN.StudyLevelName == "[null]") objvCourseLearningCase_BaseEN.StudyLevelName = null; //学段名称
if (objvCourseLearningCase_BaseEN.IdTeachingPlan == "[null]") objvCourseLearningCase_BaseEN.IdTeachingPlan = null; //教案流水号
if (objvCourseLearningCase_BaseEN.DisciplineID == "[null]") objvCourseLearningCase_BaseEN.DisciplineID = null; //学科ID
if (objvCourseLearningCase_BaseEN.DisciplineName == "[null]") objvCourseLearningCase_BaseEN.DisciplineName = null; //学科名称
if (objvCourseLearningCase_BaseEN.IdSenateGaugeVersion == "[null]") objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvCourseLearningCase_BaseEN.senateGaugeVersionID == "[null]") objvCourseLearningCase_BaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvCourseLearningCase_BaseEN.senateGaugeVersionName == "[null]") objvCourseLearningCase_BaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvCourseLearningCase_BaseEN.TeachSkillID == "[null]") objvCourseLearningCase_BaseEN.TeachSkillID = null; //教学技能ID
if (objvCourseLearningCase_BaseEN.SkillTypeName == "[null]") objvCourseLearningCase_BaseEN.SkillTypeName = null; //技能类型名称
if (objvCourseLearningCase_BaseEN.TeachSkillName == "[null]") objvCourseLearningCase_BaseEN.TeachSkillName = null; //教学技能名称
if (objvCourseLearningCase_BaseEN.TeachSkillTheory == "[null]") objvCourseLearningCase_BaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvCourseLearningCase_BaseEN.TeachSkillOperMethod == "[null]") objvCourseLearningCase_BaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvCourseLearningCase_BaseEN.IdSkillType == "[null]") objvCourseLearningCase_BaseEN.IdSkillType = null; //技能类型流水号
if (objvCourseLearningCase_BaseEN.SkillTypeID == "[null]") objvCourseLearningCase_BaseEN.SkillTypeID = null; //技能类型ID
if (objvCourseLearningCase_BaseEN.CaseLevelId == "[null]") objvCourseLearningCase_BaseEN.CaseLevelId = null; //课例等级Id
if (objvCourseLearningCase_BaseEN.CaseLevelName == "[null]") objvCourseLearningCase_BaseEN.CaseLevelName = null; //案例等级名称
if (objvCourseLearningCase_BaseEN.DocFile == "[null]") objvCourseLearningCase_BaseEN.DocFile = null; //生成的Word文件名
if (objvCourseLearningCase_BaseEN.WordCreateDate == "[null]") objvCourseLearningCase_BaseEN.WordCreateDate = null; //Word生成日期
if (objvCourseLearningCase_BaseEN.IdXzCollege == "[null]") objvCourseLearningCase_BaseEN.IdXzCollege = null; //学院流水号
if (objvCourseLearningCase_BaseEN.CollegeId == "[null]") objvCourseLearningCase_BaseEN.CollegeId = null; //学院ID
if (objvCourseLearningCase_BaseEN.CollegeName == "[null]") objvCourseLearningCase_BaseEN.CollegeName = null; //学院名称
if (objvCourseLearningCase_BaseEN.CollegeNameA == "[null]") objvCourseLearningCase_BaseEN.CollegeNameA = null; //学院名称简写
if (objvCourseLearningCase_BaseEN.MajorID == "[null]") objvCourseLearningCase_BaseEN.MajorID = null; //专业ID
if (objvCourseLearningCase_BaseEN.MajorName == "[null]") objvCourseLearningCase_BaseEN.MajorName = null; //专业名称
if (objvCourseLearningCase_BaseEN.CourseCode == "[null]") objvCourseLearningCase_BaseEN.CourseCode = null; //课程代码
if (objvCourseLearningCase_BaseEN.CourseName == "[null]") objvCourseLearningCase_BaseEN.CourseName = null; //课程名称
if (objvCourseLearningCase_BaseEN.CourseChapterName == "[null]") objvCourseLearningCase_BaseEN.CourseChapterName = null; //课程章节名称
if (objvCourseLearningCase_BaseEN.ChapterId == "[null]") objvCourseLearningCase_BaseEN.ChapterId = null; //章Id
if (objvCourseLearningCase_BaseEN.ParentNodeId == "[null]") objvCourseLearningCase_BaseEN.ParentNodeId = null; //父节点编号
if (objvCourseLearningCase_BaseEN.CourseChapterReferred == "[null]") objvCourseLearningCase_BaseEN.CourseChapterReferred = null; //节简称
if (objvCourseLearningCase_BaseEN.ChapterName == "[null]") objvCourseLearningCase_BaseEN.ChapterName = null; //章名
if (objvCourseLearningCase_BaseEN.ChapterNameSim == "[null]") objvCourseLearningCase_BaseEN.ChapterNameSim = null; //章名简称
if (objvCourseLearningCase_BaseEN.SectionName == "[null]") objvCourseLearningCase_BaseEN.SectionName = null; //节名
if (objvCourseLearningCase_BaseEN.SectionNameSim == "[null]") objvCourseLearningCase_BaseEN.SectionNameSim = null; //节名简称
if (objvCourseLearningCase_BaseEN.SectionId == "[null]") objvCourseLearningCase_BaseEN.SectionId = null; //节Id
if (objvCourseLearningCase_BaseEN.ParentNodeReferred == "[null]") objvCourseLearningCase_BaseEN.ParentNodeReferred = null; //章简称
if (objvCourseLearningCase_BaseEN.ParentNodeName == "[null]") objvCourseLearningCase_BaseEN.ParentNodeName = null; //父节点名称
if (objvCourseLearningCase_BaseEN.RecommendedDegreeName == "[null]") objvCourseLearningCase_BaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvCourseLearningCase_BaseEN.ftpFileType == "[null]") objvCourseLearningCase_BaseEN.ftpFileType = null; //ftp文件类型
if (objvCourseLearningCase_BaseEN.VideoUrl == "[null]") objvCourseLearningCase_BaseEN.VideoUrl = null; //视频Url
if (objvCourseLearningCase_BaseEN.VideoPath == "[null]") objvCourseLearningCase_BaseEN.VideoPath = null; //视频目录
if (objvCourseLearningCase_BaseEN.ResErrMsg == "[null]") objvCourseLearningCase_BaseEN.ResErrMsg = null; //资源错误信息
if (objvCourseLearningCase_BaseEN.Memo == "[null]") objvCourseLearningCase_BaseEN.Memo = null; //备注
if (objvCourseLearningCase_BaseEN.OwnerName == "[null]") objvCourseLearningCase_BaseEN.OwnerName = null; //拥有者姓名
if (objvCourseLearningCase_BaseEN.OwnerNameWithId == "[null]") objvCourseLearningCase_BaseEN.OwnerNameWithId = null; //拥有者名称附Id
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
public static void CheckProperty4Condition(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
 vCourseLearningCase_BaseDA.CheckProperty4Condition(objvCourseLearningCase_BaseEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convCourseLearningCase_Base.IdCourseLearningCase); 
List<clsvCourseLearningCase_BaseEN> arrObjLst = clsvCourseLearningCase_BaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN()
{
IdCourseLearningCase = "0",
CourseLearningCaseName = "选[v课程学习案例_Base]..."
};
arrObjLst.Insert(0, objvCourseLearningCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCourseLearningCase_Base.IdCourseLearningCase;
objComboBox.DisplayMember = convCourseLearningCase_Base.CourseLearningCaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程学习案例_Base]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCourseLearningCase_Base.IdCourseLearningCase); 
IEnumerable<clsvCourseLearningCase_BaseEN> arrObjLst = clsvCourseLearningCase_BaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convCourseLearningCase_Base.IdCourseLearningCase;
objDDL.DataTextField = convCourseLearningCase_Base.CourseLearningCaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程学习案例_Base]...","0");
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst = GetAllvCourseLearningCase_BaseObjLstCache(); 
objDDL.DataValueField = convCourseLearningCase_Base.IdCourseLearningCase;
objDDL.DataTextField = convCourseLearningCase_Base.CourseLearningCaseName;
objDDL.DataSource = arrvCourseLearningCase_BaseObjLst;
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
//if (arrvCourseLearningCase_BaseObjLstCache == null)
//{
//arrvCourseLearningCase_BaseObjLstCache = vCourseLearningCase_BaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase_BaseEN GetObjByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel =
arrvCourseLearningCase_BaseObjLstCache
.Where(x=> x.IdCourseLearningCase == strIdCourseLearningCase 
);
if (arrvCourseLearningCase_BaseObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase_BaseEN obj = clsvCourseLearningCase_BaseBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCase_BaseObjLst_Sel.First();
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
clsvCourseLearningCase_BaseEN objvCourseLearningCase_Base = GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase_Base == null) return "";
return objvCourseLearningCase_Base.CourseLearningCaseName;
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
clsvCourseLearningCase_BaseEN objvCourseLearningCase_Base = GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase_Base == null) return "";
return objvCourseLearningCase_Base.CourseLearningCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetAllvCourseLearningCase_BaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCase_BaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase_BaseObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName);
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
if (strInFldName != convCourseLearningCase_Base.IdCourseLearningCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCase_Base.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCase_Base.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCase_Base = clsvCourseLearningCase_BaseBL.GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase_Base == null) return "";
return objvCourseLearningCase_Base[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCase_BaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCase_BaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCase_BaseDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCase_BaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseCond)
{
List<clsvCourseLearningCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase_Base.AttributeName)
{
if (objvCourseLearningCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_BaseCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase_BaseCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCase_BaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase_BaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase_BaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}