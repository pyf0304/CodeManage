
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4AllWApi
 表名:vMicroteachCase_Resource_Rel4All(01120429)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:35
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsvMicroteachCase_Resource_Rel4AllWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_MicroteachCase_Resource_Rel(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_MicroteachCase(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroteachCase_Resource_Rel4All.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel4All.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel4All.id_MicroteachCase);
objvMicroteachCase_Resource_Rel4AllEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_MicroteachCase) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroteachCaseID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroteachCaseName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseTheme(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseTime(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseDateIn(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_StudyLevel(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroteachCase_Resource_Rel4All.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroteachCase_Resource_Rel4All.id_StudyLevel);
objvMicroteachCase_Resource_Rel4AllEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_StudyLevel) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetStudyLevelName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase_Resource_Rel4All.StudyLevelName);
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.StudyLevelName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_TeachingPlan(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroteachCase_Resource_Rel4All.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroteachCase_Resource_Rel4All.id_TeachingPlan);
objvMicroteachCase_Resource_Rel4AllEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_TeachingPlan) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetId_CaseType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convMicroteachCase_Resource_Rel4All.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convMicroteachCase_Resource_Rel4All.Id_CaseType);
objvMicroteachCase_Resource_Rel4AllEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.Id_CaseType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.Id_CaseType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.Id_CaseType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_Discipline(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMicroteachCase_Resource_Rel4All.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMicroteachCase_Resource_Rel4All.id_Discipline);
objvMicroteachCase_Resource_Rel4AllEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_Discipline) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_Discipline, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_Discipline] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetDisciplineID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase_Resource_Rel4All.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase_Resource_Rel4All.DisciplineID);
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.DisciplineID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.DisciplineID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.DisciplineID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetDisciplineName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase_Resource_Rel4All.DisciplineName);
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.DisciplineName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.DisciplineName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.DisciplineName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetsenateGaugeVersionID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetsenateGaugeVersionName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetVersionNo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int intVersionNo, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.VersionNo) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.VersionNo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.VersionNo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_TeachSkill(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convMicroteachCase_Resource_Rel4All.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convMicroteachCase_Resource_Rel4All.id_TeachSkill);
objvMicroteachCase_Resource_Rel4AllEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_TeachSkill) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_TeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_TeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4All.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4All.TeachSkillID);
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.TeachSkillID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.TeachSkillID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSkillTypeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase_Resource_Rel4All.SkillTypeName);
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.SkillTypeName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.SkillTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SkillTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase_Resource_Rel4All.TeachSkillName);
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.TeachSkillName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.TeachSkillName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillTheory(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.TeachSkillTheory) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.TeachSkillTheory, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillOperMethod(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_SkillType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convMicroteachCase_Resource_Rel4All.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convMicroteachCase_Resource_Rel4All.id_SkillType);
objvMicroteachCase_Resource_Rel4AllEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_SkillType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_SkillType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_SkillType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSkillTypeID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4All.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4All.SkillTypeID);
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.SkillTypeID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.SkillTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SkillTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCaseLevelId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4All.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4All.CaseLevelId);
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.CaseLevelId) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.CaseLevelId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CaseLevelId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCaseLevelName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convMicroteachCase_Resource_Rel4All.CaseLevelName);
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.CaseLevelName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.CaseLevelName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CaseLevelName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetmicroteachCaseText(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase_Resource_Rel4All.microteachCaseText);
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.microteachCaseText) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetOwnerId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase_Resource_Rel4All.OwnerId);
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.OwnerId) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetOwnerName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase_Resource_Rel4All.OwnerName);
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.OwnerName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.OwnerName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCollegeID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCase_Resource_Rel4All.CollegeID);
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.CollegeID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.CollegeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CollegeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCollegeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase_Resource_Rel4All.CollegeName);
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.CollegeName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetOwnerNameWithId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.OwnerNameWithId) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.OwnerNameWithId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_XzCollege(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCase_Resource_Rel4All.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCase_Resource_Rel4All.id_XzCollege);
objvMicroteachCase_Resource_Rel4AllEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_XzCollege) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIsDualVideo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IsDualVideo) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IsDualVideo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IsDualVideo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserKindId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCase_Resource_Rel4All.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCase_Resource_Rel4All.UserKindId);
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.UserKindId) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.UserKindId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserKindId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserKindName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCase_Resource_Rel4All.UserKindName);
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.UserKindName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.UserKindName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserKindName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserTypeId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase_Resource_Rel4All.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase_Resource_Rel4All.UserTypeId);
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.UserTypeId) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserTypeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCase_Resource_Rel4All.UserTypeName);
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.UserTypeName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.UserTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetRecommendedDegreeId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetRecommendedDegreeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetBrowseCount4Case(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.BrowseCount4Case) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_Resource(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMicroteachCase_Resource_Rel4All.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMicroteachCase_Resource_Rel4All.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMicroteachCase_Resource_Rel4All.id_Resource);
objvMicroteachCase_Resource_Rel4AllEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_Resource) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_Resource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_Resource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel4All.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel4All.ResourceID);
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ResourceID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel4All.ResourceName);
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ResourceName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_FtpResource(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMicroteachCase_Resource_Rel4All.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMicroteachCase_Resource_Rel4All.id_FtpResource);
objvMicroteachCase_Resource_Rel4AllEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_FtpResource) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_FtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_FtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_File(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMicroteachCase_Resource_Rel4All.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMicroteachCase_Resource_Rel4All.id_File);
objvMicroteachCase_Resource_Rel4AllEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_File) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_File, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_File] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel4All.FileName);
objvMicroteachCase_Resource_Rel4AllEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel4All.FileType);
objvMicroteachCase_Resource_Rel4AllEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSaveDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel4All.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel4All.SaveDate);
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.SaveDate) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileSize(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel4All.FileSize);
objvMicroteachCase_Resource_Rel4AllEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileSize) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSaveTime(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel4All.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel4All.SaveTime);
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.SaveTime) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFtpResourceID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4All.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4All.FtpResourceID);
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FtpResourceID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileOriginalName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel4All.FileOriginalName);
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileOriginalName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileDirName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel4All.FileDirName);
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileDirName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileRename(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel4All.FileRename);
objvMicroteachCase_Resource_Rel4AllEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileRename) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileRename, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileRename] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileUpDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel4All.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel4All.FileUpDate);
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileUpDate) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileUpTime(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel4All.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel4All.FileUpTime);
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileUpTime) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSaveMode(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.SaveMode) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_ResourceType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMicroteachCase_Resource_Rel4All.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMicroteachCase_Resource_Rel4All.id_ResourceType);
objvMicroteachCase_Resource_Rel4AllEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_ResourceType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_ResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_ResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceTypeID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4All.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4All.ResourceTypeID);
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ResourceTypeID) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceTypeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel4All.ResourceTypeName);
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ResourceTypeName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceOwner(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel4All.ResourceOwner);
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetftpFileType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel4All.ftpFileType);
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ftpFileType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetftpFileSize(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel4All.ftpFileSize);
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ftpFileSize) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetftpResourceOwner(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.ftpResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileOriginName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel4All.FileOriginName);
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileOriginName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIsExistFile(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IsExistFile) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileNewName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel4All.FileNewName);
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileNewName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileOldName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel4All.FileOldName);
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.FileOldName) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIsMain(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, bool bolIsMain, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IsMain) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IsMain, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IsMain] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN Setid_UsingMode(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convMicroteachCase_Resource_Rel4All.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convMicroteachCase_Resource_Rel4All.id_UsingMode);
objvMicroteachCase_Resource_Rel4AllEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.id_UsingMode) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.id_UsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_UsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIsVisible(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IsVisible) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIndexNO(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int intIndexNO, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IndexNO) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IndexNO, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IndexNO] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetBrowseCount(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int intBrowseCount, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.BrowseCount) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUpdDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel4All.UpdDate);
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.UpdDate) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.UpdDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UpdDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUpdUser(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel4All.UpdUser);
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.UpdUser) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMemo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel4All.Memo);
objvMicroteachCase_Resource_Rel4AllEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.Memo) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.Memo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.Memo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4All_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel, objvMicroteachCase_Resource_Rel4All_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_MicroteachCase, objvMicroteachCase_Resource_Rel4All_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseID, objvMicroteachCase_Resource_Rel4All_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseName, objvMicroteachCase_Resource_Rel4All_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme, objvMicroteachCase_Resource_Rel4All_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseDate, objvMicroteachCase_Resource_Rel4All_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseTime, objvMicroteachCase_Resource_Rel4All_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn, objvMicroteachCase_Resource_Rel4All_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_StudyLevel, objvMicroteachCase_Resource_Rel4All_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.StudyLevelName, objvMicroteachCase_Resource_Rel4All_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_TeachingPlan, objvMicroteachCase_Resource_Rel4All_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn, objvMicroteachCase_Resource_Rel4All_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.Id_CaseType, objvMicroteachCase_Resource_Rel4All_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_Discipline, objvMicroteachCase_Resource_Rel4All_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.DisciplineID, objvMicroteachCase_Resource_Rel4All_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.DisciplineName, objvMicroteachCase_Resource_Rel4All_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.senateGaugeVersionID, objvMicroteachCase_Resource_Rel4All_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.senateGaugeVersionName, objvMicroteachCase_Resource_Rel4All_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore, objvMicroteachCase_Resource_Rel4All_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.VersionNo, objvMicroteachCase_Resource_Rel4All_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_TeachSkill, objvMicroteachCase_Resource_Rel4All_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillID, objvMicroteachCase_Resource_Rel4All_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SkillTypeName, objvMicroteachCase_Resource_Rel4All_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillName, objvMicroteachCase_Resource_Rel4All_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillTheory, objvMicroteachCase_Resource_Rel4All_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod, objvMicroteachCase_Resource_Rel4All_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_SkillType, objvMicroteachCase_Resource_Rel4All_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SkillTypeID, objvMicroteachCase_Resource_Rel4All_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CaseLevelId, objvMicroteachCase_Resource_Rel4All_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CaseLevelName, objvMicroteachCase_Resource_Rel4All_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.microteachCaseText, objvMicroteachCase_Resource_Rel4All_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.OwnerId, objvMicroteachCase_Resource_Rel4All_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.OwnerName, objvMicroteachCase_Resource_Rel4All_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CollegeID, objvMicroteachCase_Resource_Rel4All_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CollegeName, objvMicroteachCase_Resource_Rel4All_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.OwnerNameWithId, objvMicroteachCase_Resource_Rel4All_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_XzCollege, objvMicroteachCase_Resource_Rel4All_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsDualVideo) == true)
{
if (objvMicroteachCase_Resource_Rel4All_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsDualVideo);
}
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserKindId, objvMicroteachCase_Resource_Rel4All_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserKindName, objvMicroteachCase_Resource_Rel4All_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserTypeId, objvMicroteachCase_Resource_Rel4All_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserTypeName, objvMicroteachCase_Resource_Rel4All_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.RecommendedDegreeId, objvMicroteachCase_Resource_Rel4All_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.RecommendedDegreeName, objvMicroteachCase_Resource_Rel4All_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.BrowseCount4Case, objvMicroteachCase_Resource_Rel4All_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_Resource, objvMicroteachCase_Resource_Rel4All_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceID, objvMicroteachCase_Resource_Rel4All_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceName, objvMicroteachCase_Resource_Rel4All_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_FtpResource, objvMicroteachCase_Resource_Rel4All_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_File) == true)
{
string strComparisonOp_id_File = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_File, objvMicroteachCase_Resource_Rel4All_Cond.id_File, strComparisonOp_id_File);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileName) == true)
{
string strComparisonOp_FileName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileName, objvMicroteachCase_Resource_Rel4All_Cond.FileName, strComparisonOp_FileName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileType) == true)
{
string strComparisonOp_FileType = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileType, objvMicroteachCase_Resource_Rel4All_Cond.FileType, strComparisonOp_FileType);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SaveDate, objvMicroteachCase_Resource_Rel4All_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileSize) == true)
{
string strComparisonOp_FileSize = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileSize, objvMicroteachCase_Resource_Rel4All_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SaveTime, objvMicroteachCase_Resource_Rel4All_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FtpResourceID, objvMicroteachCase_Resource_Rel4All_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileOriginalName, objvMicroteachCase_Resource_Rel4All_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileDirName, objvMicroteachCase_Resource_Rel4All_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileRename) == true)
{
string strComparisonOp_FileRename = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileRename, objvMicroteachCase_Resource_Rel4All_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileUpDate, objvMicroteachCase_Resource_Rel4All_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileUpTime, objvMicroteachCase_Resource_Rel4All_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel4All_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_ResourceType, objvMicroteachCase_Resource_Rel4All_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceTypeID, objvMicroteachCase_Resource_Rel4All_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceTypeName, objvMicroteachCase_Resource_Rel4All_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceOwner, objvMicroteachCase_Resource_Rel4All_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ftpFileType, objvMicroteachCase_Resource_Rel4All_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ftpFileSize, objvMicroteachCase_Resource_Rel4All_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ftpResourceOwner, objvMicroteachCase_Resource_Rel4All_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileOriginName, objvMicroteachCase_Resource_Rel4All_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel4All_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileNewName, objvMicroteachCase_Resource_Rel4All_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileOldName, objvMicroteachCase_Resource_Rel4All_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel4All_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.id_UsingMode, objvMicroteachCase_Resource_Rel4All_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsVisible) == true)
{
if (objvMicroteachCase_Resource_Rel4All_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsVisible);
}
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.IndexNO, objvMicroteachCase_Resource_Rel4All_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.BrowseCount, objvMicroteachCase_Resource_Rel4All_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UpdDate, objvMicroteachCase_Resource_Rel4All_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UpdUser, objvMicroteachCase_Resource_Rel4All_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroteachCase_Resource_Rel4All_Cond.IsUpdated(convMicroteachCase_Resource_Rel4All.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCase_Resource_Rel4All_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.Memo, objvMicroteachCase_Resource_Rel4All_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel4All(vMicroteachCase_Resource_Rel4All)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_Rel4AllWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase_Resource_Rel4AllApi";

 public clsvMicroteachCase_Resource_Rel4AllWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase_Resource_Rel4AllEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel4AllEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel4AllEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase_Resource_Rel4AllEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel4AllEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel4AllEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = null;
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
objvMicroteachCase_Resource_Rel4AllEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel4AllEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel4AllEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Sel =
from objvMicroteachCase_Resource_Rel4AllEN in arrvMicroteachCase_Resource_Rel4AllObjLst_Cache
where objvMicroteachCase_Resource_Rel4AllEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvMicroteachCase_Resource_Rel4AllEN;
if (arrvMicroteachCase_Resource_Rel4AllObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_Rel4AllEN obj = clsvMicroteachCase_Resource_Rel4AllWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase_Resource_Rel4AllObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Sel =
from objvMicroteachCase_Resource_Rel4AllEN in arrvMicroteachCase_Resource_Rel4AllObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvMicroteachCase_Resource_Rel4AllEN.id_MicroteachCase_Resource_Rel)
select objvMicroteachCase_Resource_Rel4AllEN;
return arrvMicroteachCase_Resource_Rel4AllObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
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
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENS, clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENT)
{
try
{
objvMicroteachCase_Resource_Rel4AllENT.id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel4AllENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllENT.id_MicroteachCase = objvMicroteachCase_Resource_Rel4AllENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4AllENT.id_StudyLevel = objvMicroteachCase_Resource_Rel4AllENS.id_StudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllENT.StudyLevelName = objvMicroteachCase_Resource_Rel4AllENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4AllENT.id_TeachingPlan = objvMicroteachCase_Resource_Rel4AllENS.id_TeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4AllENT.Id_CaseType = objvMicroteachCase_Resource_Rel4AllENS.Id_CaseType; //案例类型流水号
objvMicroteachCase_Resource_Rel4AllENT.id_Discipline = objvMicroteachCase_Resource_Rel4AllENS.id_Discipline; //学科流水号
objvMicroteachCase_Resource_Rel4AllENT.DisciplineID = objvMicroteachCase_Resource_Rel4AllENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4AllENT.DisciplineName = objvMicroteachCase_Resource_Rel4AllENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllENT.VersionNo = objvMicroteachCase_Resource_Rel4AllENS.VersionNo; //版本号
objvMicroteachCase_Resource_Rel4AllENT.id_TeachSkill = objvMicroteachCase_Resource_Rel4AllENS.id_TeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillID = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeName = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillName = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllENT.id_SkillType = objvMicroteachCase_Resource_Rel4AllENS.id_SkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeID = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelId = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelName = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase_Resource_Rel4AllENT.microteachCaseText = objvMicroteachCase_Resource_Rel4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4AllENT.OwnerId = objvMicroteachCase_Resource_Rel4AllENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4AllENT.OwnerName = objvMicroteachCase_Resource_Rel4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4AllENT.CollegeID = objvMicroteachCase_Resource_Rel4AllENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4AllENT.CollegeName = objvMicroteachCase_Resource_Rel4AllENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4AllENT.OwnerNameWithId = objvMicroteachCase_Resource_Rel4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllENT.id_XzCollege = objvMicroteachCase_Resource_Rel4AllENS.id_XzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4AllENT.IsDualVideo = objvMicroteachCase_Resource_Rel4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4AllENT.UserKindId = objvMicroteachCase_Resource_Rel4AllENS.UserKindId; //用户类别Id
objvMicroteachCase_Resource_Rel4AllENT.UserKindName = objvMicroteachCase_Resource_Rel4AllENS.UserKindName; //用户类别名
objvMicroteachCase_Resource_Rel4AllENT.UserTypeId = objvMicroteachCase_Resource_Rel4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4AllENT.UserTypeName = objvMicroteachCase_Resource_Rel4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4AllENT.id_Resource = objvMicroteachCase_Resource_Rel4AllENS.id_Resource; //资源流水号
objvMicroteachCase_Resource_Rel4AllENT.ResourceID = objvMicroteachCase_Resource_Rel4AllENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4AllENT.ResourceName = objvMicroteachCase_Resource_Rel4AllENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4AllENT.id_FtpResource = objvMicroteachCase_Resource_Rel4AllENS.id_FtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllENT.id_File = objvMicroteachCase_Resource_Rel4AllENS.id_File; //文件流水号
objvMicroteachCase_Resource_Rel4AllENT.FileName = objvMicroteachCase_Resource_Rel4AllENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel4AllENT.FileType = objvMicroteachCase_Resource_Rel4AllENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel4AllENT.SaveDate = objvMicroteachCase_Resource_Rel4AllENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel4AllENT.FileSize = objvMicroteachCase_Resource_Rel4AllENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel4AllENT.SaveTime = objvMicroteachCase_Resource_Rel4AllENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel4AllENT.FtpResourceID = objvMicroteachCase_Resource_Rel4AllENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel4AllENT.FileOriginalName = objvMicroteachCase_Resource_Rel4AllENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel4AllENT.FileDirName = objvMicroteachCase_Resource_Rel4AllENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel4AllENT.FileRename = objvMicroteachCase_Resource_Rel4AllENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel4AllENT.FileUpDate = objvMicroteachCase_Resource_Rel4AllENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel4AllENT.FileUpTime = objvMicroteachCase_Resource_Rel4AllENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel4AllENT.SaveMode = objvMicroteachCase_Resource_Rel4AllENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel4AllENT.id_ResourceType = objvMicroteachCase_Resource_Rel4AllENS.id_ResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel4AllENT.ResourceTypeID = objvMicroteachCase_Resource_Rel4AllENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel4AllENT.ResourceTypeName = objvMicroteachCase_Resource_Rel4AllENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel4AllENT.ResourceOwner = objvMicroteachCase_Resource_Rel4AllENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel4AllENT.ftpFileType = objvMicroteachCase_Resource_Rel4AllENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel4AllENT.ftpFileSize = objvMicroteachCase_Resource_Rel4AllENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel4AllENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel4AllENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllENT.FileOriginName = objvMicroteachCase_Resource_Rel4AllENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel4AllENT.IsExistFile = objvMicroteachCase_Resource_Rel4AllENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel4AllENT.FileNewName = objvMicroteachCase_Resource_Rel4AllENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel4AllENT.FileOldName = objvMicroteachCase_Resource_Rel4AllENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel4AllENT.IsMain = objvMicroteachCase_Resource_Rel4AllENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel4AllENT.id_UsingMode = objvMicroteachCase_Resource_Rel4AllENS.id_UsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllENT.IsVisible = objvMicroteachCase_Resource_Rel4AllENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4AllENT.IndexNO = objvMicroteachCase_Resource_Rel4AllENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4AllENT.UpdDate = objvMicroteachCase_Resource_Rel4AllENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4AllENT.UpdUser = objvMicroteachCase_Resource_Rel4AllENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4AllENT.Memo = objvMicroteachCase_Resource_Rel4AllENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvMicroteachCase_Resource_Rel4AllEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase_Resource_Rel4AllEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase_Resource_Rel4AllEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase_Resource_Rel4AllEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase_Resource_Rel4AllEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase_Resource_Rel4AllEN.AttributeName)
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
if (clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelWApi没有刷新缓存机制(clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsMicroteachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseWApi没有刷新缓存机制(clsMicroteachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeWApi没有刷新缓存机制(clsMicroteachCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvMicroteachCase_Resource_Rel4AllObjLst_Cache == null)
//{
//arrvMicroteachCase_Resource_Rel4AllObjLst_Cache = await clsvMicroteachCase_Resource_Rel4AllWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName_S);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_Rel4AllObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4All.Memo, Type.GetType("System.String"));
foreach (clsvMicroteachCase_Resource_Rel4AllEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel] = objInFor[convMicroteachCase_Resource_Rel4All.id_MicroteachCase_Resource_Rel];
objDR[convMicroteachCase_Resource_Rel4All.id_MicroteachCase] = objInFor[convMicroteachCase_Resource_Rel4All.id_MicroteachCase];
objDR[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] = objInFor[convMicroteachCase_Resource_Rel4All.MicroteachCaseID];
objDR[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] = objInFor[convMicroteachCase_Resource_Rel4All.MicroteachCaseName];
objDR[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] = objInFor[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme];
objDR[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] = objInFor[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate];
objDR[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] = objInFor[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime];
objDR[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] = objInFor[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn];
objDR[convMicroteachCase_Resource_Rel4All.id_StudyLevel] = objInFor[convMicroteachCase_Resource_Rel4All.id_StudyLevel];
objDR[convMicroteachCase_Resource_Rel4All.StudyLevelName] = objInFor[convMicroteachCase_Resource_Rel4All.StudyLevelName];
objDR[convMicroteachCase_Resource_Rel4All.id_TeachingPlan] = objInFor[convMicroteachCase_Resource_Rel4All.id_TeachingPlan];
objDR[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] = objInFor[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn];
objDR[convMicroteachCase_Resource_Rel4All.Id_CaseType] = objInFor[convMicroteachCase_Resource_Rel4All.Id_CaseType];
objDR[convMicroteachCase_Resource_Rel4All.id_Discipline] = objInFor[convMicroteachCase_Resource_Rel4All.id_Discipline];
objDR[convMicroteachCase_Resource_Rel4All.DisciplineID] = objInFor[convMicroteachCase_Resource_Rel4All.DisciplineID];
objDR[convMicroteachCase_Resource_Rel4All.DisciplineName] = objInFor[convMicroteachCase_Resource_Rel4All.DisciplineName];
objDR[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] = objInFor[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID];
objDR[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] = objInFor[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName];
objDR[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] = objInFor[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore];
objDR[convMicroteachCase_Resource_Rel4All.VersionNo] = objInFor[convMicroteachCase_Resource_Rel4All.VersionNo];
objDR[convMicroteachCase_Resource_Rel4All.id_TeachSkill] = objInFor[convMicroteachCase_Resource_Rel4All.id_TeachSkill];
objDR[convMicroteachCase_Resource_Rel4All.TeachSkillID] = objInFor[convMicroteachCase_Resource_Rel4All.TeachSkillID];
objDR[convMicroteachCase_Resource_Rel4All.SkillTypeName] = objInFor[convMicroteachCase_Resource_Rel4All.SkillTypeName];
objDR[convMicroteachCase_Resource_Rel4All.TeachSkillName] = objInFor[convMicroteachCase_Resource_Rel4All.TeachSkillName];
objDR[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] = objInFor[convMicroteachCase_Resource_Rel4All.TeachSkillTheory];
objDR[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] = objInFor[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod];
objDR[convMicroteachCase_Resource_Rel4All.id_SkillType] = objInFor[convMicroteachCase_Resource_Rel4All.id_SkillType];
objDR[convMicroteachCase_Resource_Rel4All.SkillTypeID] = objInFor[convMicroteachCase_Resource_Rel4All.SkillTypeID];
objDR[convMicroteachCase_Resource_Rel4All.CaseLevelId] = objInFor[convMicroteachCase_Resource_Rel4All.CaseLevelId];
objDR[convMicroteachCase_Resource_Rel4All.CaseLevelName] = objInFor[convMicroteachCase_Resource_Rel4All.CaseLevelName];
objDR[convMicroteachCase_Resource_Rel4All.microteachCaseText] = objInFor[convMicroteachCase_Resource_Rel4All.microteachCaseText];
objDR[convMicroteachCase_Resource_Rel4All.OwnerId] = objInFor[convMicroteachCase_Resource_Rel4All.OwnerId];
objDR[convMicroteachCase_Resource_Rel4All.OwnerName] = objInFor[convMicroteachCase_Resource_Rel4All.OwnerName];
objDR[convMicroteachCase_Resource_Rel4All.CollegeID] = objInFor[convMicroteachCase_Resource_Rel4All.CollegeID];
objDR[convMicroteachCase_Resource_Rel4All.CollegeName] = objInFor[convMicroteachCase_Resource_Rel4All.CollegeName];
objDR[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] = objInFor[convMicroteachCase_Resource_Rel4All.OwnerNameWithId];
objDR[convMicroteachCase_Resource_Rel4All.id_XzCollege] = objInFor[convMicroteachCase_Resource_Rel4All.id_XzCollege];
objDR[convMicroteachCase_Resource_Rel4All.IsDualVideo] = objInFor[convMicroteachCase_Resource_Rel4All.IsDualVideo];
objDR[convMicroteachCase_Resource_Rel4All.UserKindId] = objInFor[convMicroteachCase_Resource_Rel4All.UserKindId];
objDR[convMicroteachCase_Resource_Rel4All.UserKindName] = objInFor[convMicroteachCase_Resource_Rel4All.UserKindName];
objDR[convMicroteachCase_Resource_Rel4All.UserTypeId] = objInFor[convMicroteachCase_Resource_Rel4All.UserTypeId];
objDR[convMicroteachCase_Resource_Rel4All.UserTypeName] = objInFor[convMicroteachCase_Resource_Rel4All.UserTypeName];
objDR[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] = objInFor[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId];
objDR[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] = objInFor[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName];
objDR[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] = objInFor[convMicroteachCase_Resource_Rel4All.BrowseCount4Case];
objDR[convMicroteachCase_Resource_Rel4All.id_Resource] = objInFor[convMicroteachCase_Resource_Rel4All.id_Resource];
objDR[convMicroteachCase_Resource_Rel4All.ResourceID] = objInFor[convMicroteachCase_Resource_Rel4All.ResourceID];
objDR[convMicroteachCase_Resource_Rel4All.ResourceName] = objInFor[convMicroteachCase_Resource_Rel4All.ResourceName];
objDR[convMicroteachCase_Resource_Rel4All.id_FtpResource] = objInFor[convMicroteachCase_Resource_Rel4All.id_FtpResource];
objDR[convMicroteachCase_Resource_Rel4All.id_File] = objInFor[convMicroteachCase_Resource_Rel4All.id_File];
objDR[convMicroteachCase_Resource_Rel4All.FileName] = objInFor[convMicroteachCase_Resource_Rel4All.FileName];
objDR[convMicroteachCase_Resource_Rel4All.FileType] = objInFor[convMicroteachCase_Resource_Rel4All.FileType];
objDR[convMicroteachCase_Resource_Rel4All.SaveDate] = objInFor[convMicroteachCase_Resource_Rel4All.SaveDate];
objDR[convMicroteachCase_Resource_Rel4All.FileSize] = objInFor[convMicroteachCase_Resource_Rel4All.FileSize];
objDR[convMicroteachCase_Resource_Rel4All.SaveTime] = objInFor[convMicroteachCase_Resource_Rel4All.SaveTime];
objDR[convMicroteachCase_Resource_Rel4All.FtpResourceID] = objInFor[convMicroteachCase_Resource_Rel4All.FtpResourceID];
objDR[convMicroteachCase_Resource_Rel4All.FileOriginalName] = objInFor[convMicroteachCase_Resource_Rel4All.FileOriginalName];
objDR[convMicroteachCase_Resource_Rel4All.FileDirName] = objInFor[convMicroteachCase_Resource_Rel4All.FileDirName];
objDR[convMicroteachCase_Resource_Rel4All.FileRename] = objInFor[convMicroteachCase_Resource_Rel4All.FileRename];
objDR[convMicroteachCase_Resource_Rel4All.FileUpDate] = objInFor[convMicroteachCase_Resource_Rel4All.FileUpDate];
objDR[convMicroteachCase_Resource_Rel4All.FileUpTime] = objInFor[convMicroteachCase_Resource_Rel4All.FileUpTime];
objDR[convMicroteachCase_Resource_Rel4All.SaveMode] = objInFor[convMicroteachCase_Resource_Rel4All.SaveMode];
objDR[convMicroteachCase_Resource_Rel4All.id_ResourceType] = objInFor[convMicroteachCase_Resource_Rel4All.id_ResourceType];
objDR[convMicroteachCase_Resource_Rel4All.ResourceTypeID] = objInFor[convMicroteachCase_Resource_Rel4All.ResourceTypeID];
objDR[convMicroteachCase_Resource_Rel4All.ResourceTypeName] = objInFor[convMicroteachCase_Resource_Rel4All.ResourceTypeName];
objDR[convMicroteachCase_Resource_Rel4All.ResourceOwner] = objInFor[convMicroteachCase_Resource_Rel4All.ResourceOwner];
objDR[convMicroteachCase_Resource_Rel4All.ftpFileType] = objInFor[convMicroteachCase_Resource_Rel4All.ftpFileType];
objDR[convMicroteachCase_Resource_Rel4All.ftpFileSize] = objInFor[convMicroteachCase_Resource_Rel4All.ftpFileSize];
objDR[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] = objInFor[convMicroteachCase_Resource_Rel4All.ftpResourceOwner];
objDR[convMicroteachCase_Resource_Rel4All.FileOriginName] = objInFor[convMicroteachCase_Resource_Rel4All.FileOriginName];
objDR[convMicroteachCase_Resource_Rel4All.IsExistFile] = objInFor[convMicroteachCase_Resource_Rel4All.IsExistFile];
objDR[convMicroteachCase_Resource_Rel4All.FileNewName] = objInFor[convMicroteachCase_Resource_Rel4All.FileNewName];
objDR[convMicroteachCase_Resource_Rel4All.FileOldName] = objInFor[convMicroteachCase_Resource_Rel4All.FileOldName];
objDR[convMicroteachCase_Resource_Rel4All.IsMain] = objInFor[convMicroteachCase_Resource_Rel4All.IsMain];
objDR[convMicroteachCase_Resource_Rel4All.id_UsingMode] = objInFor[convMicroteachCase_Resource_Rel4All.id_UsingMode];
objDR[convMicroteachCase_Resource_Rel4All.IsVisible] = objInFor[convMicroteachCase_Resource_Rel4All.IsVisible];
objDR[convMicroteachCase_Resource_Rel4All.IndexNO] = objInFor[convMicroteachCase_Resource_Rel4All.IndexNO];
objDR[convMicroteachCase_Resource_Rel4All.BrowseCount] = objInFor[convMicroteachCase_Resource_Rel4All.BrowseCount];
objDR[convMicroteachCase_Resource_Rel4All.UpdDate] = objInFor[convMicroteachCase_Resource_Rel4All.UpdDate];
objDR[convMicroteachCase_Resource_Rel4All.UpdUser] = objInFor[convMicroteachCase_Resource_Rel4All.UpdUser];
objDR[convMicroteachCase_Resource_Rel4All.Memo] = objInFor[convMicroteachCase_Resource_Rel4All.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}