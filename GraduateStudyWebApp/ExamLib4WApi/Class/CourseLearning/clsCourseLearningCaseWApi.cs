
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCourseLearningCaseWApi
 表名:CourseLearningCase(01120274)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:38
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
 框架-层名:WA_访问层_CS(WA_Access)
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
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsCourseLearningCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetId_CourseLearningCase(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, conCourseLearningCase.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, conCourseLearningCase.Id_CourseLearningCase);
objCourseLearningCaseEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.Id_CourseLearningCase) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.Id_CourseLearningCase, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.Id_CourseLearningCase] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseID(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
objCourseLearningCaseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseID) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseID, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseID] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseName(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, conCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, conCourseLearningCase.CourseLearningCaseName);
objCourseLearningCaseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseName) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseName, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseName] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseText(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, conCourseLearningCase.CourseLearningCaseText);
objCourseLearningCaseEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseText) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseText, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseText] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseTheme(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, conCourseLearningCase.CourseLearningCaseTheme);
objCourseLearningCaseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseTheme) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseDate(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
objCourseLearningCaseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseDate) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseDate, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDate] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseTime(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
objCourseLearningCaseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseTime) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseTime, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTime] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseDateIn(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
objCourseLearningCaseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseDateIn) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseTimeIn(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
objCourseLearningCaseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseTimeIn) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetId_CaseType(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conCourseLearningCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conCourseLearningCase.Id_CaseType);
objCourseLearningCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.Id_CaseType) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.Id_CaseType, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.Id_CaseType] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_CourseLearningCaseType(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_CourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseLearningCaseType, conCourseLearningCase.id_CourseLearningCaseType);
clsCheckSql.CheckFieldLen(strid_CourseLearningCaseType, 4, conCourseLearningCase.id_CourseLearningCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseLearningCaseType, 4, conCourseLearningCase.id_CourseLearningCaseType);
objCourseLearningCaseEN.id_CourseLearningCaseType = strid_CourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_CourseLearningCaseType) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_CourseLearningCaseType, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_CourseLearningCaseType] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetOwnerId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conCourseLearningCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCourseLearningCase.OwnerId);
objCourseLearningCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.OwnerId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.OwnerId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.OwnerId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_StudyLevel(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conCourseLearningCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conCourseLearningCase.id_StudyLevel);
objCourseLearningCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_StudyLevel) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_StudyLevel, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_StudyLevel] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_TeachingPlan(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conCourseLearningCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conCourseLearningCase.id_TeachingPlan);
objCourseLearningCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_TeachingPlan) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_TeachingPlan, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_TeachingPlan] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_Discipline(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conCourseLearningCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conCourseLearningCase.id_Discipline);
objCourseLearningCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_Discipline) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_Discipline, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_Discipline] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetBrowseCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.BrowseCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.BrowseCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.BrowseCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_SenateGaugeVersion(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conCourseLearningCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conCourseLearningCase.id_SenateGaugeVersion);
objCourseLearningCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_SenateGaugeVersion) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_TeachSkill(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conCourseLearningCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conCourseLearningCase.id_TeachSkill);
objCourseLearningCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_TeachSkill) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_TeachSkill, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_TeachSkill] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCaseLevelId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conCourseLearningCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conCourseLearningCase.CaseLevelId);
objCourseLearningCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CaseLevelId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CaseLevelId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CaseLevelId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetDocFile(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conCourseLearningCase.DocFile);
objCourseLearningCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.DocFile) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.DocFile, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.DocFile] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsNeedGeneWord(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsNeedGeneWord) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetWordCreateDate(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conCourseLearningCase.WordCreateDate);
objCourseLearningCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.WordCreateDate) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.WordCreateDate, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.WordCreateDate] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsVisible(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsVisible) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsVisible, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsVisible] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsDualVideo(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsDualVideo) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsDualVideo, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsDualVideo] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_XzCollege(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conCourseLearningCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conCourseLearningCase.id_XzCollege);
objCourseLearningCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_XzCollege) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_XzCollege, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_XzCollege] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN Setid_XzMajor(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conCourseLearningCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conCourseLearningCase.id_XzMajor);
objCourseLearningCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.id_XzMajor) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.id_XzMajor, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.id_XzMajor] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCourseLearningCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conCourseLearningCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCourseLearningCase.CourseId);
objCourseLearningCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetTeachingSolutionId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
objCourseLearningCaseEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.TeachingSolutionId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.TeachingSolutionId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.TeachingSolutionId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseChapterId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conCourseLearningCase.CourseChapterId);
objCourseLearningCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseChapterId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseChapterId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseChapterId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetViewCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, int intViewCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ViewCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ViewCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ViewCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsShow(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsShow) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsShow, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsShow] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetDownloadNumber(this clsCourseLearningCaseEN objCourseLearningCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objCourseLearningCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.DownloadNumber) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.DownloadNumber, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.DownloadNumber] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetFileIntegration(this clsCourseLearningCaseEN objCourseLearningCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objCourseLearningCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.FileIntegration) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.FileIntegration, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.FileIntegration] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetLikeCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.LikeCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.LikeCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.LikeCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetCollectionCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CollectionCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CollectionCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CollectionCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetRecommendedDegreeId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
objCourseLearningCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.RecommendedDegreeId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetftpFileType(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conCourseLearningCase.ftpFileType);
objCourseLearningCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ftpFileType) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ftpFileType, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ftpFileType] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetVideoUrl(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conCourseLearningCase.VideoUrl);
objCourseLearningCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.VideoUrl) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.VideoUrl, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.VideoUrl] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetVideoPath(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conCourseLearningCase.VideoPath);
objCourseLearningCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.VideoPath) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.VideoPath, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.VideoPath] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetImageUrl(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, conCourseLearningCase.ImageUrl);
objCourseLearningCaseEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ImageUrl) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ImageUrl, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ImageUrl] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetResErrMsg(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conCourseLearningCase.ResErrMsg);
objCourseLearningCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ResErrMsg) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ResErrMsg, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ResErrMsg] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetOrderNum(this clsCourseLearningCaseEN objCourseLearningCaseEN, int intOrderNum, string strComparisonOp="")
	{
objCourseLearningCaseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.OrderNum) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.OrderNum, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.OrderNum] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetUpdDate(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCourseLearningCase.UpdDate);
objCourseLearningCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.UpdDate) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.UpdDate, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.UpdDate] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetUpdUserId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCourseLearningCase.UpdUserId);
objCourseLearningCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.UpdUserId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.UpdUserId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.UpdUserId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCourseLearningCaseEN SetMemo(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCourseLearningCase.Memo);
objCourseLearningCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.Memo) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.Memo, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.Memo] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCourseLearningCaseEN objCourseLearningCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.Id_CourseLearningCase, objCourseLearningCase_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseID, objCourseLearningCase_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseName, objCourseLearningCase_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseText) == true)
{
string strComparisonOp_CourseLearningCaseText = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseText, objCourseLearningCase_Cond.CourseLearningCaseText, strComparisonOp_CourseLearningCaseText);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseTheme, objCourseLearningCase_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseDate, objCourseLearningCase_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseTime, objCourseLearningCase_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseDateIn, objCourseLearningCase_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseTimeIn, objCourseLearningCase_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.Id_CaseType, objCourseLearningCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_CourseLearningCaseType) == true)
{
string strComparisonOp_id_CourseLearningCaseType = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_CourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_CourseLearningCaseType, objCourseLearningCase_Cond.id_CourseLearningCaseType, strComparisonOp_id_CourseLearningCaseType);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.OwnerId, objCourseLearningCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_StudyLevel, objCourseLearningCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_TeachingPlan, objCourseLearningCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_Discipline, objCourseLearningCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.BrowseCount, objCourseLearningCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_SenateGaugeVersion, objCourseLearningCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_TeachSkill, objCourseLearningCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CaseLevelId, objCourseLearningCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.DocFile) == true)
{
string strComparisonOp_DocFile = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.DocFile, objCourseLearningCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.IsNeedGeneWord) == true)
{
if (objCourseLearningCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsNeedGeneWord);
}
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.WordCreateDate, objCourseLearningCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.IsVisible) == true)
{
if (objCourseLearningCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsVisible);
}
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.IsDualVideo) == true)
{
if (objCourseLearningCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsDualVideo);
}
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_XzCollege, objCourseLearningCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.id_XzMajor, objCourseLearningCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseId) == true)
{
string strComparisonOp_CourseId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseId, objCourseLearningCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.TeachingSolutionId, objCourseLearningCase_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseChapterId, objCourseLearningCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.ViewCount, objCourseLearningCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.IsShow) == true)
{
if (objCourseLearningCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsShow);
}
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.DownloadNumber, objCourseLearningCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.FileIntegration, objCourseLearningCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.LikeCount, objCourseLearningCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.CollectionCount, objCourseLearningCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.RecommendedDegreeId, objCourseLearningCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.ftpFileType, objCourseLearningCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.VideoUrl, objCourseLearningCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.VideoPath, objCourseLearningCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.ImageUrl, objCourseLearningCase_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.ResErrMsg, objCourseLearningCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.OrderNum) == true)
{
string strComparisonOp_OrderNum = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.OrderNum, objCourseLearningCase_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.UpdDate, objCourseLearningCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.UpdUserId, objCourseLearningCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCourseLearningCase_Cond.IsUpdated(conCourseLearningCase.Memo) == true)
{
string strComparisonOp_Memo = objCourseLearningCase_Cond.dicFldComparisonOp[conCourseLearningCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.Memo, objCourseLearningCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.Id_CourseLearningCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCourseLearningCaseEN.sf_UpdFldSetStr = objCourseLearningCaseEN.getsf_UpdFldSetStr();
clsCourseLearningCaseWApi.CheckPropertyNew(objCourseLearningCaseEN); 
bool bolResult = clsCourseLearningCaseWApi.UpdateRecord(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CourseLearningCase(课程学习案例), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseLearningCaseID(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCourseLearningCaseEN == null) return "";
if (objCourseLearningCaseEN.Id_CourseLearningCase == null || objCourseLearningCaseEN.Id_CourseLearningCase == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_CourseLearningCase !=  '{0}'", objCourseLearningCaseEN.Id_CourseLearningCase);
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
try
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.Id_CourseLearningCase) == true || clsCourseLearningCaseWApi.IsExist(objCourseLearningCaseEN.Id_CourseLearningCase) == true)
 {
     objCourseLearningCaseEN.Id_CourseLearningCase = clsCourseLearningCaseWApi.GetMaxStrId();
 }
clsCourseLearningCaseWApi.CheckPropertyNew(objCourseLearningCaseEN); 
bool bolResult = clsCourseLearningCaseWApi.AddNewRecord(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
try
{
clsCourseLearningCaseWApi.CheckPropertyNew(objCourseLearningCaseEN); 
string strId_CourseLearningCase = clsCourseLearningCaseWApi.AddNewRecordWithMaxId(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
return strId_CourseLearningCase;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strWhereCond)
{
try
{
clsCourseLearningCaseWApi.CheckPropertyNew(objCourseLearningCaseEN); 
bool bolResult = clsCourseLearningCaseWApi.UpdateWithCondition(objCourseLearningCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 课程学习案例(CourseLearningCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCourseLearningCaseWApi
{
private static readonly string mstrApiControllerName = "CourseLearningCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsCourseLearningCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_CourseLearningCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程学习案例]...","0");
List<clsCourseLearningCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_CourseLearningCase";
objDDL.DataTextField="CourseLearningCaseName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_Id_CourseLearningCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCourseLearningCase.Id_CourseLearningCase); 
List<clsCourseLearningCaseEN> arrObjLst = clsCourseLearningCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN()
{
Id_CourseLearningCase = "0",
CourseLearningCaseName = "选[课程学习案例]..."
};
arrObjLst.Insert(0, objCourseLearningCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCourseLearningCase.Id_CourseLearningCase;
objComboBox.DisplayMember = conCourseLearningCase.CourseLearningCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
if (!Object.Equals(null, objCourseLearningCaseEN.Id_CourseLearningCase) && GetStrLen(objCourseLearningCaseEN.Id_CourseLearningCase) > 8)
{
 throw new Exception("字段[课程学习案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseID) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseID) > 8)
{
 throw new Exception("字段[课程学习案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseName) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseName) > 100)
{
 throw new Exception("字段[课程学习案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseText) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseTheme) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseTheme) > 200)
{
 throw new Exception("字段[课程学习案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseDate) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseDate) > 8)
{
 throw new Exception("字段[课程学习日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseTime) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseTime) > 6)
{
 throw new Exception("字段[课程学习时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseDateIn) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseLearningCaseTimeIn) && GetStrLen(objCourseLearningCaseEN.CourseLearningCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.Id_CaseType) && GetStrLen(objCourseLearningCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_CourseLearningCaseType) && GetStrLen(objCourseLearningCaseEN.id_CourseLearningCaseType) > 4)
{
 throw new Exception("字段[课程学习案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.OwnerId) && GetStrLen(objCourseLearningCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_StudyLevel) && GetStrLen(objCourseLearningCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_TeachingPlan) && GetStrLen(objCourseLearningCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_Discipline) && GetStrLen(objCourseLearningCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_SenateGaugeVersion) && GetStrLen(objCourseLearningCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_TeachSkill) && GetStrLen(objCourseLearningCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CaseLevelId) && GetStrLen(objCourseLearningCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.DocFile) && GetStrLen(objCourseLearningCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.WordCreateDate) && GetStrLen(objCourseLearningCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_XzCollege) && GetStrLen(objCourseLearningCaseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.id_XzMajor) && GetStrLen(objCourseLearningCaseEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseId) && GetStrLen(objCourseLearningCaseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.TeachingSolutionId) && GetStrLen(objCourseLearningCaseEN.TeachingSolutionId) > 8)
{
 throw new Exception("字段[教学方案Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.CourseChapterId) && GetStrLen(objCourseLearningCaseEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.RecommendedDegreeId) && GetStrLen(objCourseLearningCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.ftpFileType) && GetStrLen(objCourseLearningCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.VideoUrl) && GetStrLen(objCourseLearningCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.VideoPath) && GetStrLen(objCourseLearningCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.ImageUrl) && GetStrLen(objCourseLearningCaseEN.ImageUrl) > 50)
{
 throw new Exception("字段[ImageUrl]的长度不能超过50!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.ResErrMsg) && GetStrLen(objCourseLearningCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.UpdDate) && GetStrLen(objCourseLearningCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.UpdUserId) && GetStrLen(objCourseLearningCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCourseLearningCaseEN.Memo) && GetStrLen(objCourseLearningCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCourseLearningCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCourseLearningCaseEN GetObjById_CourseLearningCase(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase";
string strErrMsg = string.Empty;
string strResult = "";
clsCourseLearningCaseEN objCourseLearningCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCourseLearningCaseEN = JsonConvert.DeserializeObject<clsCourseLearningCaseEN>((string)jobjReturn["ReturnObj"]);
return objCourseLearningCaseEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCourseLearningCaseEN GetObjById_CourseLearningCase_WA_Cache(string strId_CourseLearningCase, string strCourseId)
{
string strAction = "GetObjById_CourseLearningCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCourseLearningCaseEN objCourseLearningCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCourseLearningCaseEN = JsonConvert.DeserializeObject<clsCourseLearningCaseEN>((string)jobjReturn["ReturnObj"]);
return objCourseLearningCaseEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsCourseLearningCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCourseLearningCaseEN objCourseLearningCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCourseLearningCaseEN = JsonConvert.DeserializeObject<clsCourseLearningCaseEN>((string)jobjReturn["ReturnObj"]);
return objCourseLearningCaseEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCourseLearningCaseEN GetObjById_CourseLearningCase_Cache(string strId_CourseLearningCase, string strCourseId)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel =
from objCourseLearningCaseEN in arrCourseLearningCaseObjLst_Cache
where objCourseLearningCaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objCourseLearningCaseEN;
if (arrCourseLearningCaseObjLst_Sel.Count() == 0)
{
   clsCourseLearningCaseEN obj = clsCourseLearningCaseWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCourseLearningCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseLearningCaseNameById_CourseLearningCase_Cache(string strId_CourseLearningCase, string strCourseId)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel1 =
from objCourseLearningCaseEN in arrCourseLearningCaseObjLst_Cache
where objCourseLearningCaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objCourseLearningCaseEN;
List <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel = new List<clsCourseLearningCaseEN>();
foreach (clsCourseLearningCaseEN obj in arrCourseLearningCaseObjLst_Sel1)
{
arrCourseLearningCaseObjLst_Sel.Add(obj);
}
if (arrCourseLearningCaseObjLst_Sel.Count > 0)
{
return arrCourseLearningCaseObjLst_Sel[0].CourseLearningCaseName;
}
string strErrMsgForGetObjById = string.Format("在CourseLearningCase对象缓存列表中,找不到记录[Id_CourseLearningCase = {0}](函数:{1})", strId_CourseLearningCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCourseLearningCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_CourseLearningCase_Cache(string strId_CourseLearningCase, string strCourseId)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel1 =
from objCourseLearningCaseEN in arrCourseLearningCaseObjLst_Cache
where objCourseLearningCaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objCourseLearningCaseEN;
List <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel = new List<clsCourseLearningCaseEN>();
foreach (clsCourseLearningCaseEN obj in arrCourseLearningCaseObjLst_Sel1)
{
arrCourseLearningCaseObjLst_Sel.Add(obj);
}
if (arrCourseLearningCaseObjLst_Sel.Count > 0)
{
return arrCourseLearningCaseObjLst_Sel[0].CourseLearningCaseName;
}
string strErrMsgForGetObjById = string.Format("在CourseLearningCase对象缓存列表中,找不到记录的相关名称[Id_CourseLearningCase = {0}](函数:{1})", strId_CourseLearningCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCourseLearningCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLst(string strWhereCond)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstById_CourseLearningCaseLst(List<string> arrId_CourseLearningCase)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCourseLearningCaseEN> GetObjLstById_CourseLearningCaseLst_Cache(List<string> arrId_CourseLearningCase, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel =
from objCourseLearningCaseEN in arrCourseLearningCaseObjLst_Cache
where arrId_CourseLearningCase.Contains(objCourseLearningCaseEN.Id_CourseLearningCase)
select objCourseLearningCaseEN;
return arrCourseLearningCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstById_CourseLearningCaseLst_WA_Cache(List<string> arrId_CourseLearningCase, string strCourseId)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsCourseLearningCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsCourseLearningCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCourseLearningCaseEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strId_CourseLearningCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCourseLearningCaseEN objCourseLearningCaseEN = clsCourseLearningCaseWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_CourseLearningCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCourseLearningCases(List<string> arrId_CourseLearningCase)
{
string strAction = "DelCourseLearningCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsCourseLearningCaseEN objCourseLearningCaseEN = clsCourseLearningCaseWApi.GetObjById_CourseLearningCase(arrId_CourseLearningCase[0]);
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCourseLearningCasesByCond(string strWhereCond)
{
string strAction = "DelCourseLearningCasesByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCourseLearningCaseEN>(objCourseLearningCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCourseLearningCaseEN>(objCourseLearningCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshCache(objCourseLearningCaseEN.CourseId);
var strId_CourseLearningCase = (string)jobjReturn["ReturnStr"];
return strId_CourseLearningCase;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
if (string.IsNullOrEmpty(objCourseLearningCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCourseLearningCaseEN.Id_CourseLearningCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCourseLearningCaseEN>(objCourseLearningCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCourseLearningCaseEN objCourseLearningCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCourseLearningCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCourseLearningCaseEN.Id_CourseLearningCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCourseLearningCaseEN.Id_CourseLearningCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCourseLearningCaseEN>(objCourseLearningCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool IsExist(string strId_CourseLearningCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objCourseLearningCaseENS">源对象</param>
 /// <param name = "objCourseLearningCaseENT">目标对象</param>
 public static void CopyTo(clsCourseLearningCaseEN objCourseLearningCaseENS, clsCourseLearningCaseEN objCourseLearningCaseENT)
{
try
{
objCourseLearningCaseENT.Id_CourseLearningCase = objCourseLearningCaseENS.Id_CourseLearningCase; //课程学习案例流水号
objCourseLearningCaseENT.CourseLearningCaseID = objCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objCourseLearningCaseENT.CourseLearningCaseName = objCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objCourseLearningCaseENT.CourseLearningCaseText = objCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objCourseLearningCaseENT.CourseLearningCaseTheme = objCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objCourseLearningCaseENT.CourseLearningCaseDate = objCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objCourseLearningCaseENT.CourseLearningCaseTime = objCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objCourseLearningCaseENT.CourseLearningCaseDateIn = objCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objCourseLearningCaseENT.CourseLearningCaseTimeIn = objCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objCourseLearningCaseENT.Id_CaseType = objCourseLearningCaseENS.Id_CaseType; //案例类型流水号
objCourseLearningCaseENT.id_CourseLearningCaseType = objCourseLearningCaseENS.id_CourseLearningCaseType; //课程学习案例类型流水号
objCourseLearningCaseENT.OwnerId = objCourseLearningCaseENS.OwnerId; //拥有者Id
objCourseLearningCaseENT.id_StudyLevel = objCourseLearningCaseENS.id_StudyLevel; //id_StudyLevel
objCourseLearningCaseENT.id_TeachingPlan = objCourseLearningCaseENS.id_TeachingPlan; //教案流水号
objCourseLearningCaseENT.id_Discipline = objCourseLearningCaseENS.id_Discipline; //学科流水号
objCourseLearningCaseENT.BrowseCount = objCourseLearningCaseENS.BrowseCount; //浏览次数
objCourseLearningCaseENT.id_SenateGaugeVersion = objCourseLearningCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objCourseLearningCaseENT.id_TeachSkill = objCourseLearningCaseENS.id_TeachSkill; //教学技能流水号
objCourseLearningCaseENT.CaseLevelId = objCourseLearningCaseENS.CaseLevelId; //课例等级Id
objCourseLearningCaseENT.DocFile = objCourseLearningCaseENS.DocFile; //生成的Word文件名
objCourseLearningCaseENT.IsNeedGeneWord = objCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objCourseLearningCaseENT.WordCreateDate = objCourseLearningCaseENS.WordCreateDate; //Word生成日期
objCourseLearningCaseENT.IsVisible = objCourseLearningCaseENS.IsVisible; //是否显示
objCourseLearningCaseENT.IsDualVideo = objCourseLearningCaseENS.IsDualVideo; //是否双视频
objCourseLearningCaseENT.id_XzCollege = objCourseLearningCaseENS.id_XzCollege; //学院流水号
objCourseLearningCaseENT.id_XzMajor = objCourseLearningCaseENS.id_XzMajor; //专业流水号
objCourseLearningCaseENT.CourseId = objCourseLearningCaseENS.CourseId; //课程Id
objCourseLearningCaseENT.TeachingSolutionId = objCourseLearningCaseENS.TeachingSolutionId; //教学方案Id
objCourseLearningCaseENT.CourseChapterId = objCourseLearningCaseENS.CourseChapterId; //课程章节ID
objCourseLearningCaseENT.ViewCount = objCourseLearningCaseENS.ViewCount; //浏览量
objCourseLearningCaseENT.IsShow = objCourseLearningCaseENS.IsShow; //是否启用
objCourseLearningCaseENT.DownloadNumber = objCourseLearningCaseENS.DownloadNumber; //下载数目
objCourseLearningCaseENT.FileIntegration = objCourseLearningCaseENS.FileIntegration; //文件积分
objCourseLearningCaseENT.LikeCount = objCourseLearningCaseENS.LikeCount; //资源喜欢数量
objCourseLearningCaseENT.CollectionCount = objCourseLearningCaseENS.CollectionCount; //收藏数量
objCourseLearningCaseENT.RecommendedDegreeId = objCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objCourseLearningCaseENT.ftpFileType = objCourseLearningCaseENS.ftpFileType; //ftp文件类型
objCourseLearningCaseENT.VideoUrl = objCourseLearningCaseENS.VideoUrl; //视频Url
objCourseLearningCaseENT.VideoPath = objCourseLearningCaseENS.VideoPath; //视频目录
objCourseLearningCaseENT.ImageUrl = objCourseLearningCaseENS.ImageUrl; //ImageUrl
objCourseLearningCaseENT.ResErrMsg = objCourseLearningCaseENS.ResErrMsg; //资源错误信息
objCourseLearningCaseENT.OrderNum = objCourseLearningCaseENS.OrderNum; //序号
objCourseLearningCaseENT.UpdDate = objCourseLearningCaseENS.UpdDate; //修改日期
objCourseLearningCaseENT.UpdUserId = objCourseLearningCaseENS.UpdUserId; //修改用户Id
objCourseLearningCaseENT.Memo = objCourseLearningCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCourseLearningCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCourseLearningCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCourseLearningCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCourseLearningCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCourseLearningCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCourseLearningCaseEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CourseLearningCase");
//if (arrCourseLearningCaseObjLst_Cache == null)
//{
//arrCourseLearningCaseObjLst_Cache = await clsCourseLearningCaseWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCourseLearningCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsCourseLearningCaseWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName_S, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrCourseLearningCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCourseLearningCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCourseLearningCase.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.id_CourseLearningCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCourseLearningCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCourseLearningCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCourseLearningCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCourseLearningCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCourseLearningCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCourseLearningCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conCourseLearningCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(conCourseLearningCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conCourseLearningCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conCourseLearningCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCourseLearningCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCourseLearningCase.Memo, Type.GetType("System.String"));
foreach (clsCourseLearningCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCourseLearningCase.Id_CourseLearningCase] = objInFor[conCourseLearningCase.Id_CourseLearningCase];
objDR[conCourseLearningCase.CourseLearningCaseID] = objInFor[conCourseLearningCase.CourseLearningCaseID];
objDR[conCourseLearningCase.CourseLearningCaseName] = objInFor[conCourseLearningCase.CourseLearningCaseName];
objDR[conCourseLearningCase.CourseLearningCaseText] = objInFor[conCourseLearningCase.CourseLearningCaseText];
objDR[conCourseLearningCase.CourseLearningCaseTheme] = objInFor[conCourseLearningCase.CourseLearningCaseTheme];
objDR[conCourseLearningCase.CourseLearningCaseDate] = objInFor[conCourseLearningCase.CourseLearningCaseDate];
objDR[conCourseLearningCase.CourseLearningCaseTime] = objInFor[conCourseLearningCase.CourseLearningCaseTime];
objDR[conCourseLearningCase.CourseLearningCaseDateIn] = objInFor[conCourseLearningCase.CourseLearningCaseDateIn];
objDR[conCourseLearningCase.CourseLearningCaseTimeIn] = objInFor[conCourseLearningCase.CourseLearningCaseTimeIn];
objDR[conCourseLearningCase.Id_CaseType] = objInFor[conCourseLearningCase.Id_CaseType];
objDR[conCourseLearningCase.id_CourseLearningCaseType] = objInFor[conCourseLearningCase.id_CourseLearningCaseType];
objDR[conCourseLearningCase.OwnerId] = objInFor[conCourseLearningCase.OwnerId];
objDR[conCourseLearningCase.id_StudyLevel] = objInFor[conCourseLearningCase.id_StudyLevel];
objDR[conCourseLearningCase.id_TeachingPlan] = objInFor[conCourseLearningCase.id_TeachingPlan];
objDR[conCourseLearningCase.id_Discipline] = objInFor[conCourseLearningCase.id_Discipline];
objDR[conCourseLearningCase.BrowseCount] = objInFor[conCourseLearningCase.BrowseCount];
objDR[conCourseLearningCase.id_SenateGaugeVersion] = objInFor[conCourseLearningCase.id_SenateGaugeVersion];
objDR[conCourseLearningCase.id_TeachSkill] = objInFor[conCourseLearningCase.id_TeachSkill];
objDR[conCourseLearningCase.CaseLevelId] = objInFor[conCourseLearningCase.CaseLevelId];
objDR[conCourseLearningCase.DocFile] = objInFor[conCourseLearningCase.DocFile];
objDR[conCourseLearningCase.IsNeedGeneWord] = objInFor[conCourseLearningCase.IsNeedGeneWord];
objDR[conCourseLearningCase.WordCreateDate] = objInFor[conCourseLearningCase.WordCreateDate];
objDR[conCourseLearningCase.IsVisible] = objInFor[conCourseLearningCase.IsVisible];
objDR[conCourseLearningCase.IsDualVideo] = objInFor[conCourseLearningCase.IsDualVideo];
objDR[conCourseLearningCase.id_XzCollege] = objInFor[conCourseLearningCase.id_XzCollege];
objDR[conCourseLearningCase.id_XzMajor] = objInFor[conCourseLearningCase.id_XzMajor];
objDR[conCourseLearningCase.CourseId] = objInFor[conCourseLearningCase.CourseId];
objDR[conCourseLearningCase.TeachingSolutionId] = objInFor[conCourseLearningCase.TeachingSolutionId];
objDR[conCourseLearningCase.CourseChapterId] = objInFor[conCourseLearningCase.CourseChapterId];
objDR[conCourseLearningCase.ViewCount] = objInFor[conCourseLearningCase.ViewCount];
objDR[conCourseLearningCase.IsShow] = objInFor[conCourseLearningCase.IsShow];
objDR[conCourseLearningCase.DownloadNumber] = objInFor[conCourseLearningCase.DownloadNumber];
objDR[conCourseLearningCase.FileIntegration] = objInFor[conCourseLearningCase.FileIntegration];
objDR[conCourseLearningCase.LikeCount] = objInFor[conCourseLearningCase.LikeCount];
objDR[conCourseLearningCase.CollectionCount] = objInFor[conCourseLearningCase.CollectionCount];
objDR[conCourseLearningCase.RecommendedDegreeId] = objInFor[conCourseLearningCase.RecommendedDegreeId];
objDR[conCourseLearningCase.ftpFileType] = objInFor[conCourseLearningCase.ftpFileType];
objDR[conCourseLearningCase.VideoUrl] = objInFor[conCourseLearningCase.VideoUrl];
objDR[conCourseLearningCase.VideoPath] = objInFor[conCourseLearningCase.VideoPath];
objDR[conCourseLearningCase.ImageUrl] = objInFor[conCourseLearningCase.ImageUrl];
objDR[conCourseLearningCase.ResErrMsg] = objInFor[conCourseLearningCase.ResErrMsg];
objDR[conCourseLearningCase.OrderNum] = objInFor[conCourseLearningCase.OrderNum];
objDR[conCourseLearningCase.UpdDate] = objInFor[conCourseLearningCase.UpdDate];
objDR[conCourseLearningCase.UpdUserId] = objInFor[conCourseLearningCase.UpdUserId];
objDR[conCourseLearningCase.Memo] = objInFor[conCourseLearningCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课程学习案例(CourseLearningCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CourseLearningCase : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseWApi.ReFreshThisCache(strCourseId);
}
}

}