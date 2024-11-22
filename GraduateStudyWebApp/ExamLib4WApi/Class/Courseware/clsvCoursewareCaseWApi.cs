
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseWApi
 表名:vCoursewareCase(01120417)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:18
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件
 模块英文名:Courseware
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
public static class clsvCoursewareCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetId_CoursewareCase(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strId_CoursewareCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareCase, 8, convCoursewareCase.Id_CoursewareCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareCase, 8, convCoursewareCase.Id_CoursewareCase);
objvCoursewareCaseEN.Id_CoursewareCase = strId_CoursewareCase; //课件教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.Id_CoursewareCase) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.Id_CoursewareCase, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.Id_CoursewareCase] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareCaseID, convCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldLen(strCoursewareCaseID, 8, convCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseID, 8, convCoursewareCase.CoursewareCaseID);
objvCoursewareCaseEN.CoursewareCaseID = strCoursewareCaseID; //课件教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareCaseName, convCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldLen(strCoursewareCaseName, 100, convCoursewareCase.CoursewareCaseName);
objvCoursewareCaseEN.CoursewareCaseName = strCoursewareCaseName; //课件教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseTheme(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTheme, 200, convCoursewareCase.CoursewareCaseTheme);
objvCoursewareCaseEN.CoursewareCaseTheme = strCoursewareCaseTheme; //课件教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseTheme) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseTheme, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTheme] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_CoursewareCaseType(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_CoursewareCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CoursewareCaseType, convCoursewareCase.id_CoursewareCaseType);
clsCheckSql.CheckFieldLen(strid_CoursewareCaseType, 4, convCoursewareCase.id_CoursewareCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareCaseType, 4, convCoursewareCase.id_CoursewareCaseType);
objvCoursewareCaseEN.id_CoursewareCaseType = strid_CoursewareCaseType; //课件案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_CoursewareCaseType) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_CoursewareCaseType, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_CoursewareCaseType] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseTypeName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTypeName, 50, convCoursewareCase.CoursewareCaseTypeName);
objvCoursewareCaseEN.CoursewareCaseTypeName = strCoursewareCaseTypeName; //课件案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseTypeName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseText(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseText, 8000, convCoursewareCase.CoursewareCaseText);
objvCoursewareCaseEN.CoursewareCaseText = strCoursewareCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseText) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseText, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseText] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseDate(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDate, 8, convCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDate, 8, convCoursewareCase.CoursewareCaseDate);
objvCoursewareCaseEN.CoursewareCaseDate = strCoursewareCaseDate; //课件教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseDate) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseDate, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseDate] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseTime(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTime, 6, convCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTime, 6, convCoursewareCase.CoursewareCaseTime);
objvCoursewareCaseEN.CoursewareCaseTime = strCoursewareCaseTime; //课件教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseTime) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseTime, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTime] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseDateIn(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDateIn, 8, convCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDateIn, 8, convCoursewareCase.CoursewareCaseDateIn);
objvCoursewareCaseEN.CoursewareCaseDateIn = strCoursewareCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseDateIn) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCoursewareCaseTimeIn(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCoursewareCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTimeIn, 6, convCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTimeIn, 6, convCoursewareCase.CoursewareCaseTimeIn);
objvCoursewareCaseEN.CoursewareCaseTimeIn = strCoursewareCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CoursewareCaseTimeIn) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CoursewareCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_StudyLevel(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convCoursewareCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCoursewareCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCoursewareCase.id_StudyLevel);
objvCoursewareCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_StudyLevel) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_StudyLevel, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_StudyLevel] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetStudyLevelName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCoursewareCase.StudyLevelName);
objvCoursewareCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.StudyLevelName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.StudyLevelName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.StudyLevelName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_TeachingPlan(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCoursewareCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCoursewareCase.id_TeachingPlan);
objvCoursewareCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_TeachingPlan) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetId_CaseType(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCoursewareCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCoursewareCase.Id_CaseType);
objvCoursewareCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.Id_CaseType) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.Id_CaseType, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.Id_CaseType] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_Discipline(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCoursewareCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCoursewareCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCoursewareCase.id_Discipline);
objvCoursewareCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_Discipline) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_Discipline, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_Discipline] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetDisciplineID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCoursewareCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCoursewareCase.DisciplineID);
objvCoursewareCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.DisciplineID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.DisciplineID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.DisciplineID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetDisciplineName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCoursewareCase.DisciplineName);
objvCoursewareCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.DisciplineName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.DisciplineName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.DisciplineName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_SenateGaugeVersion(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCoursewareCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCoursewareCase.id_SenateGaugeVersion);
objvCoursewareCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_SenateGaugeVersion) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetsenateGaugeVersionID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareCase.senateGaugeVersionID);
objvCoursewareCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.senateGaugeVersionID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetsenateGaugeVersionName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareCase.senateGaugeVersionName);
objvCoursewareCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.senateGaugeVersionName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetsenateGaugeVersionTtlScore(this clsvCoursewareCaseEN objvCoursewareCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.senateGaugeVersionTtlScore) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetVersionNo(this clsvCoursewareCaseEN objvCoursewareCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvCoursewareCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.VersionNo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.VersionNo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.VersionNo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_TeachSkill(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCoursewareCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCoursewareCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCoursewareCase.id_TeachSkill);
objvCoursewareCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_TeachSkill) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_TeachSkill, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_TeachSkill] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetTeachSkillID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCoursewareCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCoursewareCase.TeachSkillID);
objvCoursewareCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.TeachSkillID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.TeachSkillID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.TeachSkillID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetSkillTypeName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCoursewareCase.SkillTypeName);
objvCoursewareCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.SkillTypeName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.SkillTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.SkillTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetTeachSkillName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCoursewareCase.TeachSkillName);
objvCoursewareCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.TeachSkillName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.TeachSkillName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.TeachSkillName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetTeachSkillTheory(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCoursewareCase.TeachSkillTheory);
objvCoursewareCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.TeachSkillTheory) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetTeachSkillOperMethod(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCoursewareCase.TeachSkillOperMethod);
objvCoursewareCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.TeachSkillOperMethod) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_SkillType(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCoursewareCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCoursewareCase.id_SkillType);
objvCoursewareCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_SkillType) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_SkillType, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_SkillType] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetSkillTypeID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCoursewareCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCoursewareCase.SkillTypeID);
objvCoursewareCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.SkillTypeID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.SkillTypeID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.SkillTypeID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCaseLevelId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCoursewareCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCoursewareCase.CaseLevelId);
objvCoursewareCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CaseLevelId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CaseLevelId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CaseLevelId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCaseLevelName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCoursewareCase.CaseLevelName);
objvCoursewareCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CaseLevelName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CaseLevelName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CaseLevelName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetDocFile(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCoursewareCase.DocFile);
objvCoursewareCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.DocFile) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.DocFile, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.DocFile] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetIsNeedGeneWord(this clsvCoursewareCaseEN objvCoursewareCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCoursewareCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.IsNeedGeneWord) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetWordCreateDate(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCoursewareCase.WordCreateDate);
objvCoursewareCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.WordCreateDate) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.WordCreateDate, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.WordCreateDate] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetIsVisible(this clsvCoursewareCaseEN objvCoursewareCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.IsVisible) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.IsVisible, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.IsVisible] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetOwnerId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCoursewareCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareCase.OwnerId);
objvCoursewareCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.OwnerId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.OwnerId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.OwnerId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_StudentInfo(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convCoursewareCase.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convCoursewareCase.id_StudentInfo);
objvCoursewareCaseEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_StudentInfo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_StudentInfo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_StudentInfo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetStuName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCoursewareCase.StuName);
objvCoursewareCaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.StuName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.StuName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.StuName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetStuID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCoursewareCase.StuID);
objvCoursewareCaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.StuID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.StuID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.StuID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetPoliticsName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convCoursewareCase.PoliticsName);
objvCoursewareCaseEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.PoliticsName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.PoliticsName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.PoliticsName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetSexDesc(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCoursewareCase.SexDesc);
objvCoursewareCaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.SexDesc) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.SexDesc, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.SexDesc] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetEthnicName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convCoursewareCase.EthnicName);
objvCoursewareCaseEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.EthnicName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.EthnicName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.EthnicName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetUniZoneDesc(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convCoursewareCase.UniZoneDesc);
objvCoursewareCaseEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.UniZoneDesc) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.UniZoneDesc, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.UniZoneDesc] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetStuTypeDesc(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convCoursewareCase.StuTypeDesc);
objvCoursewareCaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.StuTypeDesc) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.StuTypeDesc, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.StuTypeDesc] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_XzCollege(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareCase.id_XzCollege);
objvCoursewareCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_XzCollege) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCollegeID(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareCase.CollegeID);
objvCoursewareCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CollegeID) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CollegeID, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CollegeID] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCollegeName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareCase.CollegeName);
objvCoursewareCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CollegeName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CollegeName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CollegeName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetCollegeNameA(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareCase.CollegeNameA);
objvCoursewareCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.CollegeNameA) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_XzMajor(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareCase.id_XzMajor);
objvCoursewareCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_XzMajor) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetMajorName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareCase.MajorName);
objvCoursewareCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.MajorName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.MajorName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.MajorName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_GradeBase(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCoursewareCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCoursewareCase.id_GradeBase);
objvCoursewareCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_GradeBase) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_GradeBase, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_GradeBase] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetGradeBaseName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCoursewareCase.GradeBaseName);
objvCoursewareCaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.GradeBaseName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.GradeBaseName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.GradeBaseName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN Setid_AdminCls(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convCoursewareCase.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convCoursewareCase.id_AdminCls);
objvCoursewareCaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.id_AdminCls) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.id_AdminCls, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.id_AdminCls] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetAdminClsId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convCoursewareCase.AdminClsId);
objvCoursewareCaseEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.AdminClsId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.AdminClsId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.AdminClsId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetAdminClsName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convCoursewareCase.AdminClsName);
objvCoursewareCaseEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.AdminClsName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.AdminClsName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.AdminClsName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetBirthday(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCoursewareCase.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCoursewareCase.Birthday);
objvCoursewareCaseEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.Birthday) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.Birthday, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.Birthday] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetNativePlace(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convCoursewareCase.NativePlace);
objvCoursewareCaseEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.NativePlace) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.NativePlace, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.NativePlace] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetDuty(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convCoursewareCase.Duty);
objvCoursewareCaseEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.Duty) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.Duty, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.Duty] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetIDCardNo(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convCoursewareCase.IDCardNo);
objvCoursewareCaseEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.IDCardNo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.IDCardNo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.IDCardNo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetStuCardNo(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convCoursewareCase.StuCardNo);
objvCoursewareCaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.StuCardNo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.StuCardNo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.StuCardNo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetLiveAddress(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convCoursewareCase.LiveAddress);
objvCoursewareCaseEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.LiveAddress) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.LiveAddress, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.LiveAddress] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetHomePhone(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convCoursewareCase.HomePhone);
objvCoursewareCaseEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.HomePhone) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.HomePhone, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.HomePhone] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetEnrollmentDate(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convCoursewareCase.EnrollmentDate);
objvCoursewareCaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.EnrollmentDate) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.EnrollmentDate, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.EnrollmentDate] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetPostCode(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convCoursewareCase.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convCoursewareCase.PostCode);
objvCoursewareCaseEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.PostCode) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.PostCode, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.PostCode] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetUserKindId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convCoursewareCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCoursewareCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCoursewareCase.UserKindId);
objvCoursewareCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.UserKindId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.UserKindId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.UserKindId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetUserKindName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCoursewareCase.UserKindName);
objvCoursewareCaseEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.UserKindName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.UserKindName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.UserKindName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetUserTypeId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convCoursewareCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convCoursewareCase.UserTypeId);
objvCoursewareCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.UserTypeId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.UserTypeId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.UserTypeId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetUserTypeName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convCoursewareCase.UserTypeName);
objvCoursewareCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.UserTypeName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.UserTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.UserTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetIsDualVideo(this clsvCoursewareCaseEN objvCoursewareCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.IsDualVideo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetRecommendedDegreeId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCoursewareCase.RecommendedDegreeId);
objvCoursewareCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.RecommendedDegreeId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetRecommendedDegreeName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCoursewareCase.RecommendedDegreeName);
objvCoursewareCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.RecommendedDegreeName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetftpFileType(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareCase.ftpFileType);
objvCoursewareCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.ftpFileType) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetVideoUrl(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCoursewareCase.VideoUrl);
objvCoursewareCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.VideoUrl) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.VideoUrl, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.VideoUrl] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetVideoPath(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCoursewareCase.VideoPath);
objvCoursewareCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.VideoPath) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.VideoPath, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.VideoPath] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetResErrMsg(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCoursewareCase.ResErrMsg);
objvCoursewareCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.ResErrMsg) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.ResErrMsg, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.ResErrMsg] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetMemo(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareCase.Memo);
objvCoursewareCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.Memo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.Memo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.Memo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetOwnerName(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareCase.OwnerName);
objvCoursewareCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.OwnerName) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.OwnerName, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.OwnerName] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetOwnerNameWithId(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareCase.OwnerNameWithId);
objvCoursewareCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.OwnerNameWithId) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetBrowseCount4Case(this clsvCoursewareCaseEN objvCoursewareCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCoursewareCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.BrowseCount4Case) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseEN SetIsHaveVideo(this clsvCoursewareCaseEN objvCoursewareCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convCoursewareCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convCoursewareCase.IsHaveVideo);
objvCoursewareCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase.IsHaveVideo) == false)
{
objvCoursewareCaseEN.dicFldComparisonOp.Add(convCoursewareCase.IsHaveVideo, strComparisonOp);
}
else
{
objvCoursewareCaseEN.dicFldComparisonOp[convCoursewareCase.IsHaveVideo] = strComparisonOp;
}
}
return objvCoursewareCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareCaseEN objvCoursewareCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.Id_CoursewareCase) == true)
{
string strComparisonOp_Id_CoursewareCase = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.Id_CoursewareCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.Id_CoursewareCase, objvCoursewareCase_Cond.Id_CoursewareCase, strComparisonOp_Id_CoursewareCase);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseID) == true)
{
string strComparisonOp_CoursewareCaseID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseID, objvCoursewareCase_Cond.CoursewareCaseID, strComparisonOp_CoursewareCaseID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseName) == true)
{
string strComparisonOp_CoursewareCaseName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseName, objvCoursewareCase_Cond.CoursewareCaseName, strComparisonOp_CoursewareCaseName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseTheme) == true)
{
string strComparisonOp_CoursewareCaseTheme = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseTheme, objvCoursewareCase_Cond.CoursewareCaseTheme, strComparisonOp_CoursewareCaseTheme);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_CoursewareCaseType) == true)
{
string strComparisonOp_id_CoursewareCaseType = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_CoursewareCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_CoursewareCaseType, objvCoursewareCase_Cond.id_CoursewareCaseType, strComparisonOp_id_CoursewareCaseType);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseTypeName) == true)
{
string strComparisonOp_CoursewareCaseTypeName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseTypeName, objvCoursewareCase_Cond.CoursewareCaseTypeName, strComparisonOp_CoursewareCaseTypeName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseText) == true)
{
string strComparisonOp_CoursewareCaseText = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseText, objvCoursewareCase_Cond.CoursewareCaseText, strComparisonOp_CoursewareCaseText);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseDate) == true)
{
string strComparisonOp_CoursewareCaseDate = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseDate, objvCoursewareCase_Cond.CoursewareCaseDate, strComparisonOp_CoursewareCaseDate);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseTime) == true)
{
string strComparisonOp_CoursewareCaseTime = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseTime, objvCoursewareCase_Cond.CoursewareCaseTime, strComparisonOp_CoursewareCaseTime);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseDateIn) == true)
{
string strComparisonOp_CoursewareCaseDateIn = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseDateIn, objvCoursewareCase_Cond.CoursewareCaseDateIn, strComparisonOp_CoursewareCaseDateIn);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CoursewareCaseTimeIn) == true)
{
string strComparisonOp_CoursewareCaseTimeIn = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CoursewareCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CoursewareCaseTimeIn, objvCoursewareCase_Cond.CoursewareCaseTimeIn, strComparisonOp_CoursewareCaseTimeIn);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_StudyLevel, objvCoursewareCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.StudyLevelName, objvCoursewareCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_TeachingPlan, objvCoursewareCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.Id_CaseType, objvCoursewareCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_Discipline, objvCoursewareCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.DisciplineID, objvCoursewareCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.DisciplineName, objvCoursewareCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_SenateGaugeVersion, objvCoursewareCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.senateGaugeVersionID, objvCoursewareCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.senateGaugeVersionName, objvCoursewareCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase.senateGaugeVersionTtlScore, objvCoursewareCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase.VersionNo, objvCoursewareCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_TeachSkill, objvCoursewareCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.TeachSkillID, objvCoursewareCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.SkillTypeName, objvCoursewareCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.TeachSkillName, objvCoursewareCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.TeachSkillTheory, objvCoursewareCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.TeachSkillOperMethod, objvCoursewareCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_SkillType, objvCoursewareCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.SkillTypeID, objvCoursewareCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CaseLevelId, objvCoursewareCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CaseLevelName, objvCoursewareCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.DocFile, objvCoursewareCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.IsNeedGeneWord) == true)
{
if (objvCoursewareCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase.IsNeedGeneWord);
}
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.WordCreateDate, objvCoursewareCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.IsVisible) == true)
{
if (objvCoursewareCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase.IsVisible);
}
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.OwnerId, objvCoursewareCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_StudentInfo, objvCoursewareCase_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.StuName) == true)
{
string strComparisonOp_StuName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.StuName, objvCoursewareCase_Cond.StuName, strComparisonOp_StuName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.StuID) == true)
{
string strComparisonOp_StuID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.StuID, objvCoursewareCase_Cond.StuID, strComparisonOp_StuID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.PoliticsName, objvCoursewareCase_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.SexDesc, objvCoursewareCase_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.EthnicName, objvCoursewareCase_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.UniZoneDesc, objvCoursewareCase_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.StuTypeDesc, objvCoursewareCase_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_XzCollege, objvCoursewareCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CollegeID, objvCoursewareCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CollegeName, objvCoursewareCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.CollegeNameA, objvCoursewareCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_XzMajor, objvCoursewareCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.MajorName, objvCoursewareCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_GradeBase, objvCoursewareCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.GradeBaseName, objvCoursewareCase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.id_AdminCls, objvCoursewareCase_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.AdminClsId, objvCoursewareCase_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.AdminClsName, objvCoursewareCase_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.Birthday) == true)
{
string strComparisonOp_Birthday = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.Birthday, objvCoursewareCase_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.NativePlace, objvCoursewareCase_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.Duty) == true)
{
string strComparisonOp_Duty = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.Duty, objvCoursewareCase_Cond.Duty, strComparisonOp_Duty);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.IDCardNo, objvCoursewareCase_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.StuCardNo, objvCoursewareCase_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.LiveAddress, objvCoursewareCase_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.HomePhone, objvCoursewareCase_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.EnrollmentDate, objvCoursewareCase_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.PostCode) == true)
{
string strComparisonOp_PostCode = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.PostCode, objvCoursewareCase_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.UserKindId, objvCoursewareCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.UserKindName, objvCoursewareCase_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.UserTypeId, objvCoursewareCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.UserTypeName, objvCoursewareCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.IsDualVideo) == true)
{
if (objvCoursewareCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase.IsDualVideo);
}
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.RecommendedDegreeId, objvCoursewareCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.RecommendedDegreeName, objvCoursewareCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.ftpFileType, objvCoursewareCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.VideoUrl, objvCoursewareCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.VideoPath, objvCoursewareCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.ResErrMsg, objvCoursewareCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.Memo, objvCoursewareCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.OwnerName, objvCoursewareCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.OwnerNameWithId, objvCoursewareCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase.BrowseCount4Case, objvCoursewareCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCoursewareCase_Cond.IsUpdated(convCoursewareCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvCoursewareCase_Cond.dicFldComparisonOp[convCoursewareCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase.IsHaveVideo, objvCoursewareCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件教学案例(vCoursewareCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareCaseWApi
{
private static readonly string mstrApiControllerName = "vCoursewareCaseApi";

 public clsvCoursewareCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareCaseEN GetObjById_CoursewareCase(string strId_CoursewareCase)
{
string strAction = "GetObjById_CoursewareCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseEN objvCoursewareCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareCase"] = strId_CoursewareCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCoursewareCaseEN = JsonConvert.DeserializeObject<clsvCoursewareCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseEN;
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
 /// <param name = "strId_CoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareCaseEN GetObjById_CoursewareCase_WA_Cache(string strId_CoursewareCase)
{
string strAction = "GetObjById_CoursewareCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseEN objvCoursewareCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareCase"] = strId_CoursewareCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCoursewareCaseEN = JsonConvert.DeserializeObject<clsvCoursewareCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseEN;
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
public static clsvCoursewareCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseEN objvCoursewareCaseEN = null;
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
objvCoursewareCaseEN = JsonConvert.DeserializeObject<clsvCoursewareCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseEN;
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
 /// <param name = "strId_CoursewareCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCoursewareCaseEN GetObjById_CoursewareCase_Cache(string strId_CoursewareCase)
{
if (string.IsNullOrEmpty(strId_CoursewareCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCaseEN._CurrTabName_S);
List<clsvCoursewareCaseEN> arrvCoursewareCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCaseEN> arrvCoursewareCaseObjLst_Sel =
from objvCoursewareCaseEN in arrvCoursewareCaseObjLst_Cache
where objvCoursewareCaseEN.Id_CoursewareCase == strId_CoursewareCase
select objvCoursewareCaseEN;
if (arrvCoursewareCaseObjLst_Sel.Count() == 0)
{
   clsvCoursewareCaseEN obj = clsvCoursewareCaseWApi.GetObjById_CoursewareCase(strId_CoursewareCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseEN> GetObjLstById_CoursewareCaseLst(List<string> arrId_CoursewareCase)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_CoursewareCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCoursewareCaseEN> GetObjLstById_CoursewareCaseLst_Cache(List<string> arrId_CoursewareCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCaseEN._CurrTabName_S);
List<clsvCoursewareCaseEN> arrvCoursewareCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCaseEN> arrvCoursewareCaseObjLst_Sel =
from objvCoursewareCaseEN in arrvCoursewareCaseObjLst_Cache
where arrId_CoursewareCase.Contains(objvCoursewareCaseEN.Id_CoursewareCase)
select objvCoursewareCaseEN;
return arrvCoursewareCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCaseEN> GetObjLstById_CoursewareCaseLst_WA_Cache(List<string> arrId_CoursewareCase)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_CoursewareCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareCase"] = strId_CoursewareCase
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareCaseENS">源对象</param>
 /// <param name = "objvCoursewareCaseENT">目标对象</param>
 public static void CopyTo(clsvCoursewareCaseEN objvCoursewareCaseENS, clsvCoursewareCaseEN objvCoursewareCaseENT)
{
try
{
objvCoursewareCaseENT.Id_CoursewareCase = objvCoursewareCaseENS.Id_CoursewareCase; //课件教学案例流水号
objvCoursewareCaseENT.CoursewareCaseID = objvCoursewareCaseENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCaseENT.CoursewareCaseName = objvCoursewareCaseENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCaseENT.CoursewareCaseTheme = objvCoursewareCaseENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCaseENT.id_CoursewareCaseType = objvCoursewareCaseENS.id_CoursewareCaseType; //课件案例类型流水号
objvCoursewareCaseENT.CoursewareCaseTypeName = objvCoursewareCaseENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCaseENT.CoursewareCaseText = objvCoursewareCaseENS.CoursewareCaseText; //案例文本内容
objvCoursewareCaseENT.CoursewareCaseDate = objvCoursewareCaseENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCaseENT.CoursewareCaseTime = objvCoursewareCaseENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCaseENT.CoursewareCaseDateIn = objvCoursewareCaseENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCaseENT.CoursewareCaseTimeIn = objvCoursewareCaseENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCaseENT.id_StudyLevel = objvCoursewareCaseENS.id_StudyLevel; //id_StudyLevel
objvCoursewareCaseENT.StudyLevelName = objvCoursewareCaseENS.StudyLevelName; //学段名称
objvCoursewareCaseENT.id_TeachingPlan = objvCoursewareCaseENS.id_TeachingPlan; //教案流水号
objvCoursewareCaseENT.Id_CaseType = objvCoursewareCaseENS.Id_CaseType; //案例类型流水号
objvCoursewareCaseENT.id_Discipline = objvCoursewareCaseENS.id_Discipline; //学科流水号
objvCoursewareCaseENT.DisciplineID = objvCoursewareCaseENS.DisciplineID; //学科ID
objvCoursewareCaseENT.DisciplineName = objvCoursewareCaseENS.DisciplineName; //学科名称
objvCoursewareCaseENT.id_SenateGaugeVersion = objvCoursewareCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCoursewareCaseENT.senateGaugeVersionID = objvCoursewareCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCaseENT.senateGaugeVersionName = objvCoursewareCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCaseENT.senateGaugeVersionTtlScore = objvCoursewareCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareCaseENT.VersionNo = objvCoursewareCaseENS.VersionNo; //版本号
objvCoursewareCaseENT.id_TeachSkill = objvCoursewareCaseENS.id_TeachSkill; //教学技能流水号
objvCoursewareCaseENT.TeachSkillID = objvCoursewareCaseENS.TeachSkillID; //教学技能ID
objvCoursewareCaseENT.SkillTypeName = objvCoursewareCaseENS.SkillTypeName; //技能类型名称
objvCoursewareCaseENT.TeachSkillName = objvCoursewareCaseENS.TeachSkillName; //教学技能名称
objvCoursewareCaseENT.TeachSkillTheory = objvCoursewareCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareCaseENT.TeachSkillOperMethod = objvCoursewareCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareCaseENT.id_SkillType = objvCoursewareCaseENS.id_SkillType; //技能类型流水号
objvCoursewareCaseENT.SkillTypeID = objvCoursewareCaseENS.SkillTypeID; //技能类型ID
objvCoursewareCaseENT.CaseLevelId = objvCoursewareCaseENS.CaseLevelId; //课例等级Id
objvCoursewareCaseENT.CaseLevelName = objvCoursewareCaseENS.CaseLevelName; //案例等级名称
objvCoursewareCaseENT.DocFile = objvCoursewareCaseENS.DocFile; //生成的Word文件名
objvCoursewareCaseENT.IsNeedGeneWord = objvCoursewareCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareCaseENT.WordCreateDate = objvCoursewareCaseENS.WordCreateDate; //Word生成日期
objvCoursewareCaseENT.IsVisible = objvCoursewareCaseENS.IsVisible; //是否显示
objvCoursewareCaseENT.OwnerId = objvCoursewareCaseENS.OwnerId; //拥有者Id
objvCoursewareCaseENT.id_StudentInfo = objvCoursewareCaseENS.id_StudentInfo; //学生流水号
objvCoursewareCaseENT.StuName = objvCoursewareCaseENS.StuName; //姓名
objvCoursewareCaseENT.StuID = objvCoursewareCaseENS.StuID; //学号
objvCoursewareCaseENT.PoliticsName = objvCoursewareCaseENS.PoliticsName; //政治面貌
objvCoursewareCaseENT.SexDesc = objvCoursewareCaseENS.SexDesc; //性别名称
objvCoursewareCaseENT.EthnicName = objvCoursewareCaseENS.EthnicName; //民族名称
objvCoursewareCaseENT.UniZoneDesc = objvCoursewareCaseENS.UniZoneDesc; //校区名称
objvCoursewareCaseENT.StuTypeDesc = objvCoursewareCaseENS.StuTypeDesc; //学生类别名称
objvCoursewareCaseENT.id_XzCollege = objvCoursewareCaseENS.id_XzCollege; //学院流水号
objvCoursewareCaseENT.CollegeID = objvCoursewareCaseENS.CollegeID; //学院ID
objvCoursewareCaseENT.CollegeName = objvCoursewareCaseENS.CollegeName; //学院名称
objvCoursewareCaseENT.CollegeNameA = objvCoursewareCaseENS.CollegeNameA; //学院名称简写
objvCoursewareCaseENT.id_XzMajor = objvCoursewareCaseENS.id_XzMajor; //专业流水号
objvCoursewareCaseENT.MajorName = objvCoursewareCaseENS.MajorName; //专业名称
objvCoursewareCaseENT.id_GradeBase = objvCoursewareCaseENS.id_GradeBase; //年级流水号
objvCoursewareCaseENT.GradeBaseName = objvCoursewareCaseENS.GradeBaseName; //年级名称
objvCoursewareCaseENT.id_AdminCls = objvCoursewareCaseENS.id_AdminCls; //行政班流水号
objvCoursewareCaseENT.AdminClsId = objvCoursewareCaseENS.AdminClsId; //行政班代号
objvCoursewareCaseENT.AdminClsName = objvCoursewareCaseENS.AdminClsName; //行政班名称
objvCoursewareCaseENT.Birthday = objvCoursewareCaseENS.Birthday; //出生日期
objvCoursewareCaseENT.NativePlace = objvCoursewareCaseENS.NativePlace; //籍贯
objvCoursewareCaseENT.Duty = objvCoursewareCaseENS.Duty; //职位
objvCoursewareCaseENT.IDCardNo = objvCoursewareCaseENS.IDCardNo; //身份证号
objvCoursewareCaseENT.StuCardNo = objvCoursewareCaseENS.StuCardNo; //学生证号
objvCoursewareCaseENT.LiveAddress = objvCoursewareCaseENS.LiveAddress; //居住地址
objvCoursewareCaseENT.HomePhone = objvCoursewareCaseENS.HomePhone; //住宅电话
objvCoursewareCaseENT.EnrollmentDate = objvCoursewareCaseENS.EnrollmentDate; //入校日期
objvCoursewareCaseENT.PostCode = objvCoursewareCaseENS.PostCode; //邮编
objvCoursewareCaseENT.UserKindId = objvCoursewareCaseENS.UserKindId; //用户类别Id
objvCoursewareCaseENT.UserKindName = objvCoursewareCaseENS.UserKindName; //用户类别名
objvCoursewareCaseENT.UserTypeId = objvCoursewareCaseENS.UserTypeId; //用户类型Id
objvCoursewareCaseENT.UserTypeName = objvCoursewareCaseENS.UserTypeName; //用户类型名称
objvCoursewareCaseENT.IsDualVideo = objvCoursewareCaseENS.IsDualVideo; //是否双视频
objvCoursewareCaseENT.RecommendedDegreeId = objvCoursewareCaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareCaseENT.RecommendedDegreeName = objvCoursewareCaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareCaseENT.ftpFileType = objvCoursewareCaseENS.ftpFileType; //ftp文件类型
objvCoursewareCaseENT.VideoUrl = objvCoursewareCaseENS.VideoUrl; //视频Url
objvCoursewareCaseENT.VideoPath = objvCoursewareCaseENS.VideoPath; //视频目录
objvCoursewareCaseENT.ResErrMsg = objvCoursewareCaseENS.ResErrMsg; //资源错误信息
objvCoursewareCaseENT.Memo = objvCoursewareCaseENS.Memo; //备注
objvCoursewareCaseENT.OwnerName = objvCoursewareCaseENS.OwnerName; //拥有者姓名
objvCoursewareCaseENT.OwnerNameWithId = objvCoursewareCaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareCaseENT.BrowseCount4Case = objvCoursewareCaseENS.BrowseCount4Case; //课例浏览次数
objvCoursewareCaseENT.IsHaveVideo = objvCoursewareCaseENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvCoursewareCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareCaseEN.AttributeName)
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseWApi没有刷新缓存机制(clsCoursewareCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseTypeWApi没有刷新缓存机制(clsCoursewareCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CoursewareCase");
//if (arrvCoursewareCaseObjLst_Cache == null)
//{
//arrvCoursewareCaseObjLst_Cache = await clsvCoursewareCaseWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvCoursewareCaseEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCoursewareCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareCaseEN._CurrTabName_S);
List<clsvCoursewareCaseEN> arrvCoursewareCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareCase.Id_CoursewareCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_CoursewareCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CoursewareCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvCoursewareCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareCase.Id_CoursewareCase] = objInFor[convCoursewareCase.Id_CoursewareCase];
objDR[convCoursewareCase.CoursewareCaseID] = objInFor[convCoursewareCase.CoursewareCaseID];
objDR[convCoursewareCase.CoursewareCaseName] = objInFor[convCoursewareCase.CoursewareCaseName];
objDR[convCoursewareCase.CoursewareCaseTheme] = objInFor[convCoursewareCase.CoursewareCaseTheme];
objDR[convCoursewareCase.id_CoursewareCaseType] = objInFor[convCoursewareCase.id_CoursewareCaseType];
objDR[convCoursewareCase.CoursewareCaseTypeName] = objInFor[convCoursewareCase.CoursewareCaseTypeName];
objDR[convCoursewareCase.CoursewareCaseText] = objInFor[convCoursewareCase.CoursewareCaseText];
objDR[convCoursewareCase.CoursewareCaseDate] = objInFor[convCoursewareCase.CoursewareCaseDate];
objDR[convCoursewareCase.CoursewareCaseTime] = objInFor[convCoursewareCase.CoursewareCaseTime];
objDR[convCoursewareCase.CoursewareCaseDateIn] = objInFor[convCoursewareCase.CoursewareCaseDateIn];
objDR[convCoursewareCase.CoursewareCaseTimeIn] = objInFor[convCoursewareCase.CoursewareCaseTimeIn];
objDR[convCoursewareCase.id_StudyLevel] = objInFor[convCoursewareCase.id_StudyLevel];
objDR[convCoursewareCase.StudyLevelName] = objInFor[convCoursewareCase.StudyLevelName];
objDR[convCoursewareCase.id_TeachingPlan] = objInFor[convCoursewareCase.id_TeachingPlan];
objDR[convCoursewareCase.Id_CaseType] = objInFor[convCoursewareCase.Id_CaseType];
objDR[convCoursewareCase.id_Discipline] = objInFor[convCoursewareCase.id_Discipline];
objDR[convCoursewareCase.DisciplineID] = objInFor[convCoursewareCase.DisciplineID];
objDR[convCoursewareCase.DisciplineName] = objInFor[convCoursewareCase.DisciplineName];
objDR[convCoursewareCase.id_SenateGaugeVersion] = objInFor[convCoursewareCase.id_SenateGaugeVersion];
objDR[convCoursewareCase.senateGaugeVersionID] = objInFor[convCoursewareCase.senateGaugeVersionID];
objDR[convCoursewareCase.senateGaugeVersionName] = objInFor[convCoursewareCase.senateGaugeVersionName];
objDR[convCoursewareCase.senateGaugeVersionTtlScore] = objInFor[convCoursewareCase.senateGaugeVersionTtlScore];
objDR[convCoursewareCase.VersionNo] = objInFor[convCoursewareCase.VersionNo];
objDR[convCoursewareCase.id_TeachSkill] = objInFor[convCoursewareCase.id_TeachSkill];
objDR[convCoursewareCase.TeachSkillID] = objInFor[convCoursewareCase.TeachSkillID];
objDR[convCoursewareCase.SkillTypeName] = objInFor[convCoursewareCase.SkillTypeName];
objDR[convCoursewareCase.TeachSkillName] = objInFor[convCoursewareCase.TeachSkillName];
objDR[convCoursewareCase.TeachSkillTheory] = objInFor[convCoursewareCase.TeachSkillTheory];
objDR[convCoursewareCase.TeachSkillOperMethod] = objInFor[convCoursewareCase.TeachSkillOperMethod];
objDR[convCoursewareCase.id_SkillType] = objInFor[convCoursewareCase.id_SkillType];
objDR[convCoursewareCase.SkillTypeID] = objInFor[convCoursewareCase.SkillTypeID];
objDR[convCoursewareCase.CaseLevelId] = objInFor[convCoursewareCase.CaseLevelId];
objDR[convCoursewareCase.CaseLevelName] = objInFor[convCoursewareCase.CaseLevelName];
objDR[convCoursewareCase.DocFile] = objInFor[convCoursewareCase.DocFile];
objDR[convCoursewareCase.IsNeedGeneWord] = objInFor[convCoursewareCase.IsNeedGeneWord];
objDR[convCoursewareCase.WordCreateDate] = objInFor[convCoursewareCase.WordCreateDate];
objDR[convCoursewareCase.IsVisible] = objInFor[convCoursewareCase.IsVisible];
objDR[convCoursewareCase.OwnerId] = objInFor[convCoursewareCase.OwnerId];
objDR[convCoursewareCase.id_StudentInfo] = objInFor[convCoursewareCase.id_StudentInfo];
objDR[convCoursewareCase.StuName] = objInFor[convCoursewareCase.StuName];
objDR[convCoursewareCase.StuID] = objInFor[convCoursewareCase.StuID];
objDR[convCoursewareCase.PoliticsName] = objInFor[convCoursewareCase.PoliticsName];
objDR[convCoursewareCase.SexDesc] = objInFor[convCoursewareCase.SexDesc];
objDR[convCoursewareCase.EthnicName] = objInFor[convCoursewareCase.EthnicName];
objDR[convCoursewareCase.UniZoneDesc] = objInFor[convCoursewareCase.UniZoneDesc];
objDR[convCoursewareCase.StuTypeDesc] = objInFor[convCoursewareCase.StuTypeDesc];
objDR[convCoursewareCase.id_XzCollege] = objInFor[convCoursewareCase.id_XzCollege];
objDR[convCoursewareCase.CollegeID] = objInFor[convCoursewareCase.CollegeID];
objDR[convCoursewareCase.CollegeName] = objInFor[convCoursewareCase.CollegeName];
objDR[convCoursewareCase.CollegeNameA] = objInFor[convCoursewareCase.CollegeNameA];
objDR[convCoursewareCase.id_XzMajor] = objInFor[convCoursewareCase.id_XzMajor];
objDR[convCoursewareCase.MajorName] = objInFor[convCoursewareCase.MajorName];
objDR[convCoursewareCase.id_GradeBase] = objInFor[convCoursewareCase.id_GradeBase];
objDR[convCoursewareCase.GradeBaseName] = objInFor[convCoursewareCase.GradeBaseName];
objDR[convCoursewareCase.id_AdminCls] = objInFor[convCoursewareCase.id_AdminCls];
objDR[convCoursewareCase.AdminClsId] = objInFor[convCoursewareCase.AdminClsId];
objDR[convCoursewareCase.AdminClsName] = objInFor[convCoursewareCase.AdminClsName];
objDR[convCoursewareCase.Birthday] = objInFor[convCoursewareCase.Birthday];
objDR[convCoursewareCase.NativePlace] = objInFor[convCoursewareCase.NativePlace];
objDR[convCoursewareCase.Duty] = objInFor[convCoursewareCase.Duty];
objDR[convCoursewareCase.IDCardNo] = objInFor[convCoursewareCase.IDCardNo];
objDR[convCoursewareCase.StuCardNo] = objInFor[convCoursewareCase.StuCardNo];
objDR[convCoursewareCase.LiveAddress] = objInFor[convCoursewareCase.LiveAddress];
objDR[convCoursewareCase.HomePhone] = objInFor[convCoursewareCase.HomePhone];
objDR[convCoursewareCase.EnrollmentDate] = objInFor[convCoursewareCase.EnrollmentDate];
objDR[convCoursewareCase.PostCode] = objInFor[convCoursewareCase.PostCode];
objDR[convCoursewareCase.UserKindId] = objInFor[convCoursewareCase.UserKindId];
objDR[convCoursewareCase.UserKindName] = objInFor[convCoursewareCase.UserKindName];
objDR[convCoursewareCase.UserTypeId] = objInFor[convCoursewareCase.UserTypeId];
objDR[convCoursewareCase.UserTypeName] = objInFor[convCoursewareCase.UserTypeName];
objDR[convCoursewareCase.IsDualVideo] = objInFor[convCoursewareCase.IsDualVideo];
objDR[convCoursewareCase.RecommendedDegreeId] = objInFor[convCoursewareCase.RecommendedDegreeId];
objDR[convCoursewareCase.RecommendedDegreeName] = objInFor[convCoursewareCase.RecommendedDegreeName];
objDR[convCoursewareCase.ftpFileType] = objInFor[convCoursewareCase.ftpFileType];
objDR[convCoursewareCase.VideoUrl] = objInFor[convCoursewareCase.VideoUrl];
objDR[convCoursewareCase.VideoPath] = objInFor[convCoursewareCase.VideoPath];
objDR[convCoursewareCase.ResErrMsg] = objInFor[convCoursewareCase.ResErrMsg];
objDR[convCoursewareCase.Memo] = objInFor[convCoursewareCase.Memo];
objDR[convCoursewareCase.OwnerName] = objInFor[convCoursewareCase.OwnerName];
objDR[convCoursewareCase.OwnerNameWithId] = objInFor[convCoursewareCase.OwnerNameWithId];
objDR[convCoursewareCase.BrowseCount4Case] = objInFor[convCoursewareCase.BrowseCount4Case];
objDR[convCoursewareCase.IsHaveVideo] = objInFor[convCoursewareCase.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}