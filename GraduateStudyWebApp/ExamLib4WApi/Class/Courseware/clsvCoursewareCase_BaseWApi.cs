
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCase_BaseWApi
 表名:vCoursewareCase_Base(01120494)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:35
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
public static class clsvCoursewareCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetId_CoursewareCase(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strId_CoursewareCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareCase, 8, convCoursewareCase_Base.Id_CoursewareCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareCase, 8, convCoursewareCase_Base.Id_CoursewareCase);
objvCoursewareCase_BaseEN.Id_CoursewareCase = strId_CoursewareCase; //课件教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.Id_CoursewareCase) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.Id_CoursewareCase, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.Id_CoursewareCase] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareCaseID, convCoursewareCase_Base.CoursewareCaseID);
clsCheckSql.CheckFieldLen(strCoursewareCaseID, 8, convCoursewareCase_Base.CoursewareCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseID, 8, convCoursewareCase_Base.CoursewareCaseID);
objvCoursewareCase_BaseEN.CoursewareCaseID = strCoursewareCaseID; //课件教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareCaseName, convCoursewareCase_Base.CoursewareCaseName);
clsCheckSql.CheckFieldLen(strCoursewareCaseName, 100, convCoursewareCase_Base.CoursewareCaseName);
objvCoursewareCase_BaseEN.CoursewareCaseName = strCoursewareCaseName; //课件教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseTheme(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTheme, 200, convCoursewareCase_Base.CoursewareCaseTheme);
objvCoursewareCase_BaseEN.CoursewareCaseTheme = strCoursewareCaseTheme; //课件教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseTheme) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseTheme, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTheme] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_CoursewareCaseType(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_CoursewareCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CoursewareCaseType, convCoursewareCase_Base.id_CoursewareCaseType);
clsCheckSql.CheckFieldLen(strid_CoursewareCaseType, 4, convCoursewareCase_Base.id_CoursewareCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareCaseType, 4, convCoursewareCase_Base.id_CoursewareCaseType);
objvCoursewareCase_BaseEN.id_CoursewareCaseType = strid_CoursewareCaseType; //课件案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_CoursewareCaseType) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_CoursewareCaseType, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_CoursewareCaseType] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseTypeName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTypeName, 50, convCoursewareCase_Base.CoursewareCaseTypeName);
objvCoursewareCase_BaseEN.CoursewareCaseTypeName = strCoursewareCaseTypeName; //课件案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseTypeName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseText(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseText, 8000, convCoursewareCase_Base.CoursewareCaseText);
objvCoursewareCase_BaseEN.CoursewareCaseText = strCoursewareCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseText) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseText, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseText] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseDate(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDate, 8, convCoursewareCase_Base.CoursewareCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDate, 8, convCoursewareCase_Base.CoursewareCaseDate);
objvCoursewareCase_BaseEN.CoursewareCaseDate = strCoursewareCaseDate; //课件教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseDate) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseDate, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseDate] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseTime(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTime, 6, convCoursewareCase_Base.CoursewareCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTime, 6, convCoursewareCase_Base.CoursewareCaseTime);
objvCoursewareCase_BaseEN.CoursewareCaseTime = strCoursewareCaseTime; //课件教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseTime) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseTime, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTime] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseDateIn(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDateIn, 8, convCoursewareCase_Base.CoursewareCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDateIn, 8, convCoursewareCase_Base.CoursewareCaseDateIn);
objvCoursewareCase_BaseEN.CoursewareCaseDateIn = strCoursewareCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseDateIn) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCoursewareCaseTimeIn(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCoursewareCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTimeIn, 6, convCoursewareCase_Base.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTimeIn, 6, convCoursewareCase_Base.CoursewareCaseTimeIn);
objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = strCoursewareCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CoursewareCaseTimeIn) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CoursewareCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_StudyLevel(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convCoursewareCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCoursewareCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCoursewareCase_Base.id_StudyLevel);
objvCoursewareCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_StudyLevel) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetStudyLevelName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCoursewareCase_Base.StudyLevelName);
objvCoursewareCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.StudyLevelName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_TeachingPlan(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCoursewareCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCoursewareCase_Base.id_TeachingPlan);
objvCoursewareCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_TeachingPlan) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetId_CaseType(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCoursewareCase_Base.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCoursewareCase_Base.Id_CaseType);
objvCoursewareCase_BaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.Id_CaseType) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.Id_CaseType, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.Id_CaseType] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_Discipline(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCoursewareCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCoursewareCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCoursewareCase_Base.id_Discipline);
objvCoursewareCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_Discipline) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetDisciplineID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCoursewareCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCoursewareCase_Base.DisciplineID);
objvCoursewareCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.DisciplineID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetDisciplineName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCoursewareCase_Base.DisciplineName);
objvCoursewareCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.DisciplineName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_SenateGaugeVersion(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCoursewareCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCoursewareCase_Base.id_SenateGaugeVersion);
objvCoursewareCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_SenateGaugeVersion) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetsenateGaugeVersionID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareCase_Base.senateGaugeVersionID);
objvCoursewareCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.senateGaugeVersionID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetsenateGaugeVersionName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareCase_Base.senateGaugeVersionName);
objvCoursewareCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.senateGaugeVersionName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.senateGaugeVersionTtlScore) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetVersionNo(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvCoursewareCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.VersionNo) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.VersionNo, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.VersionNo] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_TeachSkill(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCoursewareCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCoursewareCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCoursewareCase_Base.id_TeachSkill);
objvCoursewareCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_TeachSkill) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetTeachSkillID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCoursewareCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCoursewareCase_Base.TeachSkillID);
objvCoursewareCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.TeachSkillID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetSkillTypeName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCoursewareCase_Base.SkillTypeName);
objvCoursewareCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.SkillTypeName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetTeachSkillName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCoursewareCase_Base.TeachSkillName);
objvCoursewareCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.TeachSkillName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetTeachSkillTheory(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCoursewareCase_Base.TeachSkillTheory);
objvCoursewareCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.TeachSkillTheory) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetTeachSkillOperMethod(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCoursewareCase_Base.TeachSkillOperMethod);
objvCoursewareCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.TeachSkillOperMethod) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_SkillType(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCoursewareCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCoursewareCase_Base.id_SkillType);
objvCoursewareCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_SkillType) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetSkillTypeID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCoursewareCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCoursewareCase_Base.SkillTypeID);
objvCoursewareCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.SkillTypeID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCaseLevelId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCoursewareCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCoursewareCase_Base.CaseLevelId);
objvCoursewareCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CaseLevelId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCaseLevelName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCoursewareCase_Base.CaseLevelName);
objvCoursewareCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CaseLevelName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetDocFile(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCoursewareCase_Base.DocFile);
objvCoursewareCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.DocFile) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.DocFile, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.DocFile] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetIsNeedGeneWord(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCoursewareCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.IsNeedGeneWord) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetWordCreateDate(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCoursewareCase_Base.WordCreateDate);
objvCoursewareCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.WordCreateDate) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetIsVisible(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.IsVisible) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.IsVisible, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.IsVisible] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetOwnerId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCoursewareCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareCase_Base.OwnerId);
objvCoursewareCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.OwnerId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.OwnerId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.OwnerId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_StudentInfo(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convCoursewareCase_Base.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convCoursewareCase_Base.id_StudentInfo);
objvCoursewareCase_BaseEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_StudentInfo) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_StudentInfo, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_StudentInfo] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetStuName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCoursewareCase_Base.StuName);
objvCoursewareCase_BaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.StuName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.StuName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.StuName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetStuID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCoursewareCase_Base.StuID);
objvCoursewareCase_BaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.StuID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.StuID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.StuID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetPoliticsName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convCoursewareCase_Base.PoliticsName);
objvCoursewareCase_BaseEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.PoliticsName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.PoliticsName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.PoliticsName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetSexDesc(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCoursewareCase_Base.SexDesc);
objvCoursewareCase_BaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.SexDesc) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.SexDesc, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.SexDesc] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetEthnicName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convCoursewareCase_Base.EthnicName);
objvCoursewareCase_BaseEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.EthnicName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.EthnicName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.EthnicName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetUniZoneDesc(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convCoursewareCase_Base.UniZoneDesc);
objvCoursewareCase_BaseEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.UniZoneDesc) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.UniZoneDesc, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.UniZoneDesc] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetStuTypeDesc(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convCoursewareCase_Base.StuTypeDesc);
objvCoursewareCase_BaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.StuTypeDesc) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.StuTypeDesc, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.StuTypeDesc] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_XzCollege(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareCase_Base.id_XzCollege);
objvCoursewareCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_XzCollege) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCollegeID(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareCase_Base.CollegeID);
objvCoursewareCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CollegeID) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CollegeID, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CollegeID] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCollegeName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareCase_Base.CollegeName);
objvCoursewareCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CollegeName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CollegeName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CollegeName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetCollegeNameA(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareCase_Base.CollegeNameA);
objvCoursewareCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.CollegeNameA) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_XzMajor(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareCase_Base.id_XzMajor);
objvCoursewareCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_XzMajor) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetMajorName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareCase_Base.MajorName);
objvCoursewareCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.MajorName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.MajorName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.MajorName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_GradeBase(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCoursewareCase_Base.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCoursewareCase_Base.id_GradeBase);
objvCoursewareCase_BaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_GradeBase) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_GradeBase, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_GradeBase] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetGradeBaseName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCoursewareCase_Base.GradeBaseName);
objvCoursewareCase_BaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.GradeBaseName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.GradeBaseName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.GradeBaseName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN Setid_AdminCls(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convCoursewareCase_Base.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convCoursewareCase_Base.id_AdminCls);
objvCoursewareCase_BaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.id_AdminCls) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.id_AdminCls, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.id_AdminCls] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetAdminClsId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convCoursewareCase_Base.AdminClsId);
objvCoursewareCase_BaseEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.AdminClsId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.AdminClsId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.AdminClsId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetAdminClsName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convCoursewareCase_Base.AdminClsName);
objvCoursewareCase_BaseEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.AdminClsName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.AdminClsName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.AdminClsName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetBirthday(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCoursewareCase_Base.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCoursewareCase_Base.Birthday);
objvCoursewareCase_BaseEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.Birthday) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.Birthday, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.Birthday] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetNativePlace(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convCoursewareCase_Base.NativePlace);
objvCoursewareCase_BaseEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.NativePlace) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.NativePlace, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.NativePlace] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetDuty(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convCoursewareCase_Base.Duty);
objvCoursewareCase_BaseEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.Duty) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.Duty, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.Duty] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetIDCardNo(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convCoursewareCase_Base.IDCardNo);
objvCoursewareCase_BaseEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.IDCardNo) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.IDCardNo, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.IDCardNo] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetStuCardNo(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convCoursewareCase_Base.StuCardNo);
objvCoursewareCase_BaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.StuCardNo) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.StuCardNo, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.StuCardNo] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetLiveAddress(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convCoursewareCase_Base.LiveAddress);
objvCoursewareCase_BaseEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.LiveAddress) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.LiveAddress, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.LiveAddress] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetHomePhone(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convCoursewareCase_Base.HomePhone);
objvCoursewareCase_BaseEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.HomePhone) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.HomePhone, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.HomePhone] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetEnrollmentDate(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convCoursewareCase_Base.EnrollmentDate);
objvCoursewareCase_BaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.EnrollmentDate) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.EnrollmentDate, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.EnrollmentDate] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetPostCode(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convCoursewareCase_Base.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convCoursewareCase_Base.PostCode);
objvCoursewareCase_BaseEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.PostCode) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.PostCode, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.PostCode] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetUserKindId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convCoursewareCase_Base.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCoursewareCase_Base.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCoursewareCase_Base.UserKindId);
objvCoursewareCase_BaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.UserKindId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.UserKindId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.UserKindId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetUserKindName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCoursewareCase_Base.UserKindName);
objvCoursewareCase_BaseEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.UserKindName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.UserKindName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.UserKindName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetUserTypeId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convCoursewareCase_Base.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convCoursewareCase_Base.UserTypeId);
objvCoursewareCase_BaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.UserTypeId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.UserTypeId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.UserTypeId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetIsDualVideo(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.IsDualVideo) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetRecommendedDegreeId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCoursewareCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCoursewareCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCoursewareCase_Base.RecommendedDegreeId);
objvCoursewareCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.RecommendedDegreeId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetRecommendedDegreeName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCoursewareCase_Base.RecommendedDegreeName);
objvCoursewareCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.RecommendedDegreeName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetftpFileType(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareCase_Base.ftpFileType);
objvCoursewareCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.ftpFileType) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetVideoUrl(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCoursewareCase_Base.VideoUrl);
objvCoursewareCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.VideoUrl) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetVideoPath(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCoursewareCase_Base.VideoPath);
objvCoursewareCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.VideoPath) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.VideoPath, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.VideoPath] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetResErrMsg(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCoursewareCase_Base.ResErrMsg);
objvCoursewareCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.ResErrMsg) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetMemo(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareCase_Base.Memo);
objvCoursewareCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.Memo) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.Memo, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.Memo] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetOwnerName(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareCase_Base.OwnerName);
objvCoursewareCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.OwnerName) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.OwnerName, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.OwnerName] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetOwnerNameWithId(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareCase_Base.OwnerNameWithId);
objvCoursewareCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.OwnerNameWithId) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_BaseEN SetBrowseCount4Case(this clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCoursewareCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Base.BrowseCount4Case) == false)
{
objvCoursewareCase_BaseEN.dicFldComparisonOp.Add(convCoursewareCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvCoursewareCase_BaseEN.dicFldComparisonOp[convCoursewareCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvCoursewareCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareCase_BaseEN objvCoursewareCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.Id_CoursewareCase) == true)
{
string strComparisonOp_Id_CoursewareCase = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.Id_CoursewareCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.Id_CoursewareCase, objvCoursewareCase_Base_Cond.Id_CoursewareCase, strComparisonOp_Id_CoursewareCase);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseID) == true)
{
string strComparisonOp_CoursewareCaseID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseID, objvCoursewareCase_Base_Cond.CoursewareCaseID, strComparisonOp_CoursewareCaseID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseName) == true)
{
string strComparisonOp_CoursewareCaseName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseName, objvCoursewareCase_Base_Cond.CoursewareCaseName, strComparisonOp_CoursewareCaseName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseTheme) == true)
{
string strComparisonOp_CoursewareCaseTheme = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseTheme, objvCoursewareCase_Base_Cond.CoursewareCaseTheme, strComparisonOp_CoursewareCaseTheme);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_CoursewareCaseType) == true)
{
string strComparisonOp_id_CoursewareCaseType = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_CoursewareCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_CoursewareCaseType, objvCoursewareCase_Base_Cond.id_CoursewareCaseType, strComparisonOp_id_CoursewareCaseType);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseTypeName) == true)
{
string strComparisonOp_CoursewareCaseTypeName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseTypeName, objvCoursewareCase_Base_Cond.CoursewareCaseTypeName, strComparisonOp_CoursewareCaseTypeName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseText) == true)
{
string strComparisonOp_CoursewareCaseText = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseText, objvCoursewareCase_Base_Cond.CoursewareCaseText, strComparisonOp_CoursewareCaseText);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseDate) == true)
{
string strComparisonOp_CoursewareCaseDate = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseDate, objvCoursewareCase_Base_Cond.CoursewareCaseDate, strComparisonOp_CoursewareCaseDate);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseTime) == true)
{
string strComparisonOp_CoursewareCaseTime = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseTime, objvCoursewareCase_Base_Cond.CoursewareCaseTime, strComparisonOp_CoursewareCaseTime);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseDateIn) == true)
{
string strComparisonOp_CoursewareCaseDateIn = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseDateIn, objvCoursewareCase_Base_Cond.CoursewareCaseDateIn, strComparisonOp_CoursewareCaseDateIn);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CoursewareCaseTimeIn) == true)
{
string strComparisonOp_CoursewareCaseTimeIn = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CoursewareCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CoursewareCaseTimeIn, objvCoursewareCase_Base_Cond.CoursewareCaseTimeIn, strComparisonOp_CoursewareCaseTimeIn);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_StudyLevel, objvCoursewareCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.StudyLevelName, objvCoursewareCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_TeachingPlan, objvCoursewareCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.Id_CaseType, objvCoursewareCase_Base_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_Discipline, objvCoursewareCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.DisciplineID, objvCoursewareCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.DisciplineName, objvCoursewareCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_SenateGaugeVersion, objvCoursewareCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.senateGaugeVersionID, objvCoursewareCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.senateGaugeVersionName, objvCoursewareCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Base.senateGaugeVersionTtlScore, objvCoursewareCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Base.VersionNo, objvCoursewareCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_TeachSkill, objvCoursewareCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.TeachSkillID, objvCoursewareCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.SkillTypeName, objvCoursewareCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.TeachSkillName, objvCoursewareCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.TeachSkillTheory, objvCoursewareCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.TeachSkillOperMethod, objvCoursewareCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_SkillType, objvCoursewareCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.SkillTypeID, objvCoursewareCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CaseLevelId, objvCoursewareCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CaseLevelName, objvCoursewareCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.DocFile, objvCoursewareCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.IsNeedGeneWord) == true)
{
if (objvCoursewareCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Base.IsNeedGeneWord);
}
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.WordCreateDate, objvCoursewareCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.IsVisible) == true)
{
if (objvCoursewareCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Base.IsVisible);
}
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.OwnerId, objvCoursewareCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_StudentInfo, objvCoursewareCase_Base_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.StuName) == true)
{
string strComparisonOp_StuName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.StuName, objvCoursewareCase_Base_Cond.StuName, strComparisonOp_StuName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.StuID) == true)
{
string strComparisonOp_StuID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.StuID, objvCoursewareCase_Base_Cond.StuID, strComparisonOp_StuID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.PoliticsName, objvCoursewareCase_Base_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.SexDesc, objvCoursewareCase_Base_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.EthnicName, objvCoursewareCase_Base_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.UniZoneDesc, objvCoursewareCase_Base_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.StuTypeDesc, objvCoursewareCase_Base_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_XzCollege, objvCoursewareCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CollegeID, objvCoursewareCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CollegeName, objvCoursewareCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.CollegeNameA, objvCoursewareCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_XzMajor, objvCoursewareCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.MajorName, objvCoursewareCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_GradeBase, objvCoursewareCase_Base_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.GradeBaseName, objvCoursewareCase_Base_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.id_AdminCls, objvCoursewareCase_Base_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.AdminClsId, objvCoursewareCase_Base_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.AdminClsName, objvCoursewareCase_Base_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.Birthday) == true)
{
string strComparisonOp_Birthday = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.Birthday, objvCoursewareCase_Base_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.NativePlace, objvCoursewareCase_Base_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.Duty) == true)
{
string strComparisonOp_Duty = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.Duty, objvCoursewareCase_Base_Cond.Duty, strComparisonOp_Duty);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.IDCardNo, objvCoursewareCase_Base_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.StuCardNo, objvCoursewareCase_Base_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.LiveAddress, objvCoursewareCase_Base_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.HomePhone, objvCoursewareCase_Base_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.EnrollmentDate, objvCoursewareCase_Base_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.PostCode) == true)
{
string strComparisonOp_PostCode = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.PostCode, objvCoursewareCase_Base_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.UserKindId, objvCoursewareCase_Base_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.UserKindName, objvCoursewareCase_Base_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.UserTypeId, objvCoursewareCase_Base_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.IsDualVideo) == true)
{
if (objvCoursewareCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Base.IsDualVideo);
}
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.RecommendedDegreeId, objvCoursewareCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.RecommendedDegreeName, objvCoursewareCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.ftpFileType, objvCoursewareCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.VideoUrl, objvCoursewareCase_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.VideoPath, objvCoursewareCase_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.ResErrMsg, objvCoursewareCase_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.Memo, objvCoursewareCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.OwnerName, objvCoursewareCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Base.OwnerNameWithId, objvCoursewareCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareCase_Base_Cond.IsUpdated(convCoursewareCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCoursewareCase_Base_Cond.dicFldComparisonOp[convCoursewareCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Base.BrowseCount4Case, objvCoursewareCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件教学案例_Base(vCoursewareCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vCoursewareCase_BaseApi";

 public clsvCoursewareCase_BaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareCase_BaseEN GetObjById_CoursewareCase(string strId_CoursewareCase)
{
string strAction = "GetObjById_CoursewareCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = null;
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
objvCoursewareCase_BaseEN = JsonConvert.DeserializeObject<clsvCoursewareCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCase_BaseEN;
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
public static clsvCoursewareCase_BaseEN GetObjById_CoursewareCase_WA_Cache(string strId_CoursewareCase)
{
string strAction = "GetObjById_CoursewareCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = null;
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
objvCoursewareCase_BaseEN = JsonConvert.DeserializeObject<clsvCoursewareCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCase_BaseEN;
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
public static clsvCoursewareCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = null;
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
objvCoursewareCase_BaseEN = JsonConvert.DeserializeObject<clsvCoursewareCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCase_BaseEN;
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
public static clsvCoursewareCase_BaseEN GetObjById_CoursewareCase_Cache(string strId_CoursewareCase)
{
if (string.IsNullOrEmpty(strId_CoursewareCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCase_BaseEN._CurrTabName_S);
List<clsvCoursewareCase_BaseEN> arrvCoursewareCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCase_BaseEN> arrvCoursewareCase_BaseObjLst_Sel =
from objvCoursewareCase_BaseEN in arrvCoursewareCase_BaseObjLst_Cache
where objvCoursewareCase_BaseEN.Id_CoursewareCase == strId_CoursewareCase
select objvCoursewareCase_BaseEN;
if (arrvCoursewareCase_BaseObjLst_Sel.Count() == 0)
{
   clsvCoursewareCase_BaseEN obj = clsvCoursewareCase_BaseWApi.GetObjById_CoursewareCase(strId_CoursewareCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareCase_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_BaseEN> GetObjLstById_CoursewareCaseLst(List<string> arrId_CoursewareCase)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareCase_BaseEN> GetObjLstById_CoursewareCaseLst_Cache(List<string> arrId_CoursewareCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCase_BaseEN._CurrTabName_S);
List<clsvCoursewareCase_BaseEN> arrvCoursewareCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCase_BaseEN> arrvCoursewareCase_BaseObjLst_Sel =
from objvCoursewareCase_BaseEN in arrvCoursewareCase_BaseObjLst_Cache
where arrId_CoursewareCase.Contains(objvCoursewareCase_BaseEN.Id_CoursewareCase)
select objvCoursewareCase_BaseEN;
return arrvCoursewareCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCase_BaseEN> GetObjLstById_CoursewareCaseLst_WA_Cache(List<string> arrId_CoursewareCase)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareCase_BaseENS">源对象</param>
 /// <param name = "objvCoursewareCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvCoursewareCase_BaseEN objvCoursewareCase_BaseENS, clsvCoursewareCase_BaseEN objvCoursewareCase_BaseENT)
{
try
{
objvCoursewareCase_BaseENT.Id_CoursewareCase = objvCoursewareCase_BaseENS.Id_CoursewareCase; //课件教学案例流水号
objvCoursewareCase_BaseENT.CoursewareCaseID = objvCoursewareCase_BaseENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCase_BaseENT.CoursewareCaseName = objvCoursewareCase_BaseENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCase_BaseENT.CoursewareCaseTheme = objvCoursewareCase_BaseENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCase_BaseENT.id_CoursewareCaseType = objvCoursewareCase_BaseENS.id_CoursewareCaseType; //课件案例类型流水号
objvCoursewareCase_BaseENT.CoursewareCaseTypeName = objvCoursewareCase_BaseENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCase_BaseENT.CoursewareCaseText = objvCoursewareCase_BaseENS.CoursewareCaseText; //案例文本内容
objvCoursewareCase_BaseENT.CoursewareCaseDate = objvCoursewareCase_BaseENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCase_BaseENT.CoursewareCaseTime = objvCoursewareCase_BaseENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCase_BaseENT.CoursewareCaseDateIn = objvCoursewareCase_BaseENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCase_BaseENT.CoursewareCaseTimeIn = objvCoursewareCase_BaseENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCase_BaseENT.id_StudyLevel = objvCoursewareCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvCoursewareCase_BaseENT.StudyLevelName = objvCoursewareCase_BaseENS.StudyLevelName; //学段名称
objvCoursewareCase_BaseENT.id_TeachingPlan = objvCoursewareCase_BaseENS.id_TeachingPlan; //教案流水号
objvCoursewareCase_BaseENT.Id_CaseType = objvCoursewareCase_BaseENS.Id_CaseType; //案例类型流水号
objvCoursewareCase_BaseENT.id_Discipline = objvCoursewareCase_BaseENS.id_Discipline; //学科流水号
objvCoursewareCase_BaseENT.DisciplineID = objvCoursewareCase_BaseENS.DisciplineID; //学科ID
objvCoursewareCase_BaseENT.DisciplineName = objvCoursewareCase_BaseENS.DisciplineName; //学科名称
objvCoursewareCase_BaseENT.id_SenateGaugeVersion = objvCoursewareCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCoursewareCase_BaseENT.senateGaugeVersionID = objvCoursewareCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCase_BaseENT.senateGaugeVersionName = objvCoursewareCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCase_BaseENT.senateGaugeVersionTtlScore = objvCoursewareCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareCase_BaseENT.VersionNo = objvCoursewareCase_BaseENS.VersionNo; //版本号
objvCoursewareCase_BaseENT.id_TeachSkill = objvCoursewareCase_BaseENS.id_TeachSkill; //教学技能流水号
objvCoursewareCase_BaseENT.TeachSkillID = objvCoursewareCase_BaseENS.TeachSkillID; //教学技能ID
objvCoursewareCase_BaseENT.SkillTypeName = objvCoursewareCase_BaseENS.SkillTypeName; //技能类型名称
objvCoursewareCase_BaseENT.TeachSkillName = objvCoursewareCase_BaseENS.TeachSkillName; //教学技能名称
objvCoursewareCase_BaseENT.TeachSkillTheory = objvCoursewareCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareCase_BaseENT.TeachSkillOperMethod = objvCoursewareCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareCase_BaseENT.id_SkillType = objvCoursewareCase_BaseENS.id_SkillType; //技能类型流水号
objvCoursewareCase_BaseENT.SkillTypeID = objvCoursewareCase_BaseENS.SkillTypeID; //技能类型ID
objvCoursewareCase_BaseENT.CaseLevelId = objvCoursewareCase_BaseENS.CaseLevelId; //课例等级Id
objvCoursewareCase_BaseENT.CaseLevelName = objvCoursewareCase_BaseENS.CaseLevelName; //案例等级名称
objvCoursewareCase_BaseENT.DocFile = objvCoursewareCase_BaseENS.DocFile; //生成的Word文件名
objvCoursewareCase_BaseENT.IsNeedGeneWord = objvCoursewareCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareCase_BaseENT.WordCreateDate = objvCoursewareCase_BaseENS.WordCreateDate; //Word生成日期
objvCoursewareCase_BaseENT.IsVisible = objvCoursewareCase_BaseENS.IsVisible; //是否显示
objvCoursewareCase_BaseENT.OwnerId = objvCoursewareCase_BaseENS.OwnerId; //拥有者Id
objvCoursewareCase_BaseENT.id_StudentInfo = objvCoursewareCase_BaseENS.id_StudentInfo; //学生流水号
objvCoursewareCase_BaseENT.StuName = objvCoursewareCase_BaseENS.StuName; //姓名
objvCoursewareCase_BaseENT.StuID = objvCoursewareCase_BaseENS.StuID; //学号
objvCoursewareCase_BaseENT.PoliticsName = objvCoursewareCase_BaseENS.PoliticsName; //政治面貌
objvCoursewareCase_BaseENT.SexDesc = objvCoursewareCase_BaseENS.SexDesc; //性别名称
objvCoursewareCase_BaseENT.EthnicName = objvCoursewareCase_BaseENS.EthnicName; //民族名称
objvCoursewareCase_BaseENT.UniZoneDesc = objvCoursewareCase_BaseENS.UniZoneDesc; //校区名称
objvCoursewareCase_BaseENT.StuTypeDesc = objvCoursewareCase_BaseENS.StuTypeDesc; //学生类别名称
objvCoursewareCase_BaseENT.id_XzCollege = objvCoursewareCase_BaseENS.id_XzCollege; //学院流水号
objvCoursewareCase_BaseENT.CollegeID = objvCoursewareCase_BaseENS.CollegeID; //学院ID
objvCoursewareCase_BaseENT.CollegeName = objvCoursewareCase_BaseENS.CollegeName; //学院名称
objvCoursewareCase_BaseENT.CollegeNameA = objvCoursewareCase_BaseENS.CollegeNameA; //学院名称简写
objvCoursewareCase_BaseENT.id_XzMajor = objvCoursewareCase_BaseENS.id_XzMajor; //专业流水号
objvCoursewareCase_BaseENT.MajorName = objvCoursewareCase_BaseENS.MajorName; //专业名称
objvCoursewareCase_BaseENT.id_GradeBase = objvCoursewareCase_BaseENS.id_GradeBase; //年级流水号
objvCoursewareCase_BaseENT.GradeBaseName = objvCoursewareCase_BaseENS.GradeBaseName; //年级名称
objvCoursewareCase_BaseENT.id_AdminCls = objvCoursewareCase_BaseENS.id_AdminCls; //行政班流水号
objvCoursewareCase_BaseENT.AdminClsId = objvCoursewareCase_BaseENS.AdminClsId; //行政班代号
objvCoursewareCase_BaseENT.AdminClsName = objvCoursewareCase_BaseENS.AdminClsName; //行政班名称
objvCoursewareCase_BaseENT.Birthday = objvCoursewareCase_BaseENS.Birthday; //出生日期
objvCoursewareCase_BaseENT.NativePlace = objvCoursewareCase_BaseENS.NativePlace; //籍贯
objvCoursewareCase_BaseENT.Duty = objvCoursewareCase_BaseENS.Duty; //职位
objvCoursewareCase_BaseENT.IDCardNo = objvCoursewareCase_BaseENS.IDCardNo; //身份证号
objvCoursewareCase_BaseENT.StuCardNo = objvCoursewareCase_BaseENS.StuCardNo; //学生证号
objvCoursewareCase_BaseENT.LiveAddress = objvCoursewareCase_BaseENS.LiveAddress; //居住地址
objvCoursewareCase_BaseENT.HomePhone = objvCoursewareCase_BaseENS.HomePhone; //住宅电话
objvCoursewareCase_BaseENT.EnrollmentDate = objvCoursewareCase_BaseENS.EnrollmentDate; //入校日期
objvCoursewareCase_BaseENT.PostCode = objvCoursewareCase_BaseENS.PostCode; //邮编
objvCoursewareCase_BaseENT.UserKindId = objvCoursewareCase_BaseENS.UserKindId; //用户类别Id
objvCoursewareCase_BaseENT.UserKindName = objvCoursewareCase_BaseENS.UserKindName; //用户类别名
objvCoursewareCase_BaseENT.UserTypeId = objvCoursewareCase_BaseENS.UserTypeId; //用户类型Id
objvCoursewareCase_BaseENT.IsDualVideo = objvCoursewareCase_BaseENS.IsDualVideo; //是否双视频
objvCoursewareCase_BaseENT.RecommendedDegreeId = objvCoursewareCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareCase_BaseENT.RecommendedDegreeName = objvCoursewareCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareCase_BaseENT.ftpFileType = objvCoursewareCase_BaseENS.ftpFileType; //ftp文件类型
objvCoursewareCase_BaseENT.VideoUrl = objvCoursewareCase_BaseENS.VideoUrl; //视频Url
objvCoursewareCase_BaseENT.VideoPath = objvCoursewareCase_BaseENS.VideoPath; //视频目录
objvCoursewareCase_BaseENT.ResErrMsg = objvCoursewareCase_BaseENS.ResErrMsg; //资源错误信息
objvCoursewareCase_BaseENT.Memo = objvCoursewareCase_BaseENS.Memo; //备注
objvCoursewareCase_BaseENT.OwnerName = objvCoursewareCase_BaseENS.OwnerName; //拥有者姓名
objvCoursewareCase_BaseENT.OwnerNameWithId = objvCoursewareCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareCase_BaseENT.BrowseCount4Case = objvCoursewareCase_BaseENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvCoursewareCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareCase_BaseEN.AttributeName)
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
//if (arrvCoursewareCase_BaseObjLst_Cache == null)
//{
//arrvCoursewareCase_BaseObjLst_Cache = await clsvCoursewareCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareCase_BaseEN._CurrTabName_S);
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
public static List<clsvCoursewareCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareCase_BaseEN._CurrTabName_S);
List<clsvCoursewareCase_BaseEN> arrvCoursewareCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareCase_Base.Id_CoursewareCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_CoursewareCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CoursewareCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvCoursewareCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareCase_Base.Id_CoursewareCase] = objInFor[convCoursewareCase_Base.Id_CoursewareCase];
objDR[convCoursewareCase_Base.CoursewareCaseID] = objInFor[convCoursewareCase_Base.CoursewareCaseID];
objDR[convCoursewareCase_Base.CoursewareCaseName] = objInFor[convCoursewareCase_Base.CoursewareCaseName];
objDR[convCoursewareCase_Base.CoursewareCaseTheme] = objInFor[convCoursewareCase_Base.CoursewareCaseTheme];
objDR[convCoursewareCase_Base.id_CoursewareCaseType] = objInFor[convCoursewareCase_Base.id_CoursewareCaseType];
objDR[convCoursewareCase_Base.CoursewareCaseTypeName] = objInFor[convCoursewareCase_Base.CoursewareCaseTypeName];
objDR[convCoursewareCase_Base.CoursewareCaseText] = objInFor[convCoursewareCase_Base.CoursewareCaseText];
objDR[convCoursewareCase_Base.CoursewareCaseDate] = objInFor[convCoursewareCase_Base.CoursewareCaseDate];
objDR[convCoursewareCase_Base.CoursewareCaseTime] = objInFor[convCoursewareCase_Base.CoursewareCaseTime];
objDR[convCoursewareCase_Base.CoursewareCaseDateIn] = objInFor[convCoursewareCase_Base.CoursewareCaseDateIn];
objDR[convCoursewareCase_Base.CoursewareCaseTimeIn] = objInFor[convCoursewareCase_Base.CoursewareCaseTimeIn];
objDR[convCoursewareCase_Base.id_StudyLevel] = objInFor[convCoursewareCase_Base.id_StudyLevel];
objDR[convCoursewareCase_Base.StudyLevelName] = objInFor[convCoursewareCase_Base.StudyLevelName];
objDR[convCoursewareCase_Base.id_TeachingPlan] = objInFor[convCoursewareCase_Base.id_TeachingPlan];
objDR[convCoursewareCase_Base.Id_CaseType] = objInFor[convCoursewareCase_Base.Id_CaseType];
objDR[convCoursewareCase_Base.id_Discipline] = objInFor[convCoursewareCase_Base.id_Discipline];
objDR[convCoursewareCase_Base.DisciplineID] = objInFor[convCoursewareCase_Base.DisciplineID];
objDR[convCoursewareCase_Base.DisciplineName] = objInFor[convCoursewareCase_Base.DisciplineName];
objDR[convCoursewareCase_Base.id_SenateGaugeVersion] = objInFor[convCoursewareCase_Base.id_SenateGaugeVersion];
objDR[convCoursewareCase_Base.senateGaugeVersionID] = objInFor[convCoursewareCase_Base.senateGaugeVersionID];
objDR[convCoursewareCase_Base.senateGaugeVersionName] = objInFor[convCoursewareCase_Base.senateGaugeVersionName];
objDR[convCoursewareCase_Base.senateGaugeVersionTtlScore] = objInFor[convCoursewareCase_Base.senateGaugeVersionTtlScore];
objDR[convCoursewareCase_Base.VersionNo] = objInFor[convCoursewareCase_Base.VersionNo];
objDR[convCoursewareCase_Base.id_TeachSkill] = objInFor[convCoursewareCase_Base.id_TeachSkill];
objDR[convCoursewareCase_Base.TeachSkillID] = objInFor[convCoursewareCase_Base.TeachSkillID];
objDR[convCoursewareCase_Base.SkillTypeName] = objInFor[convCoursewareCase_Base.SkillTypeName];
objDR[convCoursewareCase_Base.TeachSkillName] = objInFor[convCoursewareCase_Base.TeachSkillName];
objDR[convCoursewareCase_Base.TeachSkillTheory] = objInFor[convCoursewareCase_Base.TeachSkillTheory];
objDR[convCoursewareCase_Base.TeachSkillOperMethod] = objInFor[convCoursewareCase_Base.TeachSkillOperMethod];
objDR[convCoursewareCase_Base.id_SkillType] = objInFor[convCoursewareCase_Base.id_SkillType];
objDR[convCoursewareCase_Base.SkillTypeID] = objInFor[convCoursewareCase_Base.SkillTypeID];
objDR[convCoursewareCase_Base.CaseLevelId] = objInFor[convCoursewareCase_Base.CaseLevelId];
objDR[convCoursewareCase_Base.CaseLevelName] = objInFor[convCoursewareCase_Base.CaseLevelName];
objDR[convCoursewareCase_Base.DocFile] = objInFor[convCoursewareCase_Base.DocFile];
objDR[convCoursewareCase_Base.IsNeedGeneWord] = objInFor[convCoursewareCase_Base.IsNeedGeneWord];
objDR[convCoursewareCase_Base.WordCreateDate] = objInFor[convCoursewareCase_Base.WordCreateDate];
objDR[convCoursewareCase_Base.IsVisible] = objInFor[convCoursewareCase_Base.IsVisible];
objDR[convCoursewareCase_Base.OwnerId] = objInFor[convCoursewareCase_Base.OwnerId];
objDR[convCoursewareCase_Base.id_StudentInfo] = objInFor[convCoursewareCase_Base.id_StudentInfo];
objDR[convCoursewareCase_Base.StuName] = objInFor[convCoursewareCase_Base.StuName];
objDR[convCoursewareCase_Base.StuID] = objInFor[convCoursewareCase_Base.StuID];
objDR[convCoursewareCase_Base.PoliticsName] = objInFor[convCoursewareCase_Base.PoliticsName];
objDR[convCoursewareCase_Base.SexDesc] = objInFor[convCoursewareCase_Base.SexDesc];
objDR[convCoursewareCase_Base.EthnicName] = objInFor[convCoursewareCase_Base.EthnicName];
objDR[convCoursewareCase_Base.UniZoneDesc] = objInFor[convCoursewareCase_Base.UniZoneDesc];
objDR[convCoursewareCase_Base.StuTypeDesc] = objInFor[convCoursewareCase_Base.StuTypeDesc];
objDR[convCoursewareCase_Base.id_XzCollege] = objInFor[convCoursewareCase_Base.id_XzCollege];
objDR[convCoursewareCase_Base.CollegeID] = objInFor[convCoursewareCase_Base.CollegeID];
objDR[convCoursewareCase_Base.CollegeName] = objInFor[convCoursewareCase_Base.CollegeName];
objDR[convCoursewareCase_Base.CollegeNameA] = objInFor[convCoursewareCase_Base.CollegeNameA];
objDR[convCoursewareCase_Base.id_XzMajor] = objInFor[convCoursewareCase_Base.id_XzMajor];
objDR[convCoursewareCase_Base.MajorName] = objInFor[convCoursewareCase_Base.MajorName];
objDR[convCoursewareCase_Base.id_GradeBase] = objInFor[convCoursewareCase_Base.id_GradeBase];
objDR[convCoursewareCase_Base.GradeBaseName] = objInFor[convCoursewareCase_Base.GradeBaseName];
objDR[convCoursewareCase_Base.id_AdminCls] = objInFor[convCoursewareCase_Base.id_AdminCls];
objDR[convCoursewareCase_Base.AdminClsId] = objInFor[convCoursewareCase_Base.AdminClsId];
objDR[convCoursewareCase_Base.AdminClsName] = objInFor[convCoursewareCase_Base.AdminClsName];
objDR[convCoursewareCase_Base.Birthday] = objInFor[convCoursewareCase_Base.Birthday];
objDR[convCoursewareCase_Base.NativePlace] = objInFor[convCoursewareCase_Base.NativePlace];
objDR[convCoursewareCase_Base.Duty] = objInFor[convCoursewareCase_Base.Duty];
objDR[convCoursewareCase_Base.IDCardNo] = objInFor[convCoursewareCase_Base.IDCardNo];
objDR[convCoursewareCase_Base.StuCardNo] = objInFor[convCoursewareCase_Base.StuCardNo];
objDR[convCoursewareCase_Base.LiveAddress] = objInFor[convCoursewareCase_Base.LiveAddress];
objDR[convCoursewareCase_Base.HomePhone] = objInFor[convCoursewareCase_Base.HomePhone];
objDR[convCoursewareCase_Base.EnrollmentDate] = objInFor[convCoursewareCase_Base.EnrollmentDate];
objDR[convCoursewareCase_Base.PostCode] = objInFor[convCoursewareCase_Base.PostCode];
objDR[convCoursewareCase_Base.UserKindId] = objInFor[convCoursewareCase_Base.UserKindId];
objDR[convCoursewareCase_Base.UserKindName] = objInFor[convCoursewareCase_Base.UserKindName];
objDR[convCoursewareCase_Base.UserTypeId] = objInFor[convCoursewareCase_Base.UserTypeId];
objDR[convCoursewareCase_Base.IsDualVideo] = objInFor[convCoursewareCase_Base.IsDualVideo];
objDR[convCoursewareCase_Base.RecommendedDegreeId] = objInFor[convCoursewareCase_Base.RecommendedDegreeId];
objDR[convCoursewareCase_Base.RecommendedDegreeName] = objInFor[convCoursewareCase_Base.RecommendedDegreeName];
objDR[convCoursewareCase_Base.ftpFileType] = objInFor[convCoursewareCase_Base.ftpFileType];
objDR[convCoursewareCase_Base.VideoUrl] = objInFor[convCoursewareCase_Base.VideoUrl];
objDR[convCoursewareCase_Base.VideoPath] = objInFor[convCoursewareCase_Base.VideoPath];
objDR[convCoursewareCase_Base.ResErrMsg] = objInFor[convCoursewareCase_Base.ResErrMsg];
objDR[convCoursewareCase_Base.Memo] = objInFor[convCoursewareCase_Base.Memo];
objDR[convCoursewareCase_Base.OwnerName] = objInFor[convCoursewareCase_Base.OwnerName];
objDR[convCoursewareCase_Base.OwnerNameWithId] = objInFor[convCoursewareCase_Base.OwnerNameWithId];
objDR[convCoursewareCase_Base.BrowseCount4Case] = objInFor[convCoursewareCase_Base.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}