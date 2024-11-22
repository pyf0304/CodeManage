
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4AllWApi
 表名:vMicroteachCase4All(01120327)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:43
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
public static class clsvMicroteachCase4AllWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_MicroteachCase(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase4All.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase4All.id_MicroteachCase);
objvMicroteachCase4AllEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_MicroteachCase) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseTypeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, convMicroteachCase4All.MicroteachCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCase4All.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase4All.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase4All.MicroteachCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCase4All.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase4All.MicroteachCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseTheme(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase4All.MicroteachCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseDate(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase4All.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase4All.MicroteachCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseTime(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase4All.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase4All.MicroteachCaseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroteachCaseDateIn(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase4All.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase4All.MicroteachCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_StudyLevel(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroteachCase4All.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroteachCase4All.id_StudyLevel);
objvMicroteachCase4AllEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_StudyLevel) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetStudyLevelName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase4All.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_TeachingPlan(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroteachCase4All.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroteachCase4All.id_TeachingPlan);
objvMicroteachCase4AllEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_TeachingPlan) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase4All.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase4All.MicroTeachCaseTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_MicroteachCaseType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_MicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCaseType, convMicroteachCase4All.id_MicroteachCaseType);
clsCheckSql.CheckFieldLen(strid_MicroteachCaseType, 4, convMicroteachCase4All.id_MicroteachCaseType);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCaseType, 4, convMicroteachCase4All.id_MicroteachCaseType);
objvMicroteachCase4AllEN.id_MicroteachCaseType = strid_MicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_MicroteachCaseType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_MicroteachCaseType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_MicroteachCaseType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetId_CaseType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convMicroteachCase4All.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convMicroteachCase4All.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convMicroteachCase4All.Id_CaseType);
objvMicroteachCase4AllEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.Id_CaseType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.Id_CaseType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.Id_CaseType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_Discipline(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMicroteachCase4All.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMicroteachCase4All.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMicroteachCase4All.id_Discipline);
objvMicroteachCase4AllEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_Discipline) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_Discipline, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_Discipline] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetDisciplineID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase4All.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase4All.DisciplineID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetDisciplineName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase4All.DisciplineName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_SenateGaugeVersion(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMicroteachCase4All.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMicroteachCase4All.id_SenateGaugeVersion);
objvMicroteachCase4AllEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_SenateGaugeVersion) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetsenateGaugeVersionID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase4All.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase4All.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetsenateGaugeVersionName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase4All.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetVersionNo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_TeachSkill(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convMicroteachCase4All.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convMicroteachCase4All.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convMicroteachCase4All.id_TeachSkill);
objvMicroteachCase4AllEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_TeachSkill) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_TeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_TeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase4All.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase4All.TeachSkillID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetSkillTypeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase4All.SkillTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase4All.TeachSkillName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillTheory(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase4All.TeachSkillTheory);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetTeachSkillOperMethod(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase4All.TeachSkillOperMethod);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_SkillType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convMicroteachCase4All.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convMicroteachCase4All.id_SkillType);
objvMicroteachCase4AllEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_SkillType) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_SkillType, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_SkillType] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetSkillTypeID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase4All.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase4All.SkillTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCaseLevelId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase4All.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase4All.CaseLevelId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCaseLevelName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convMicroteachCase4All.CaseLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetDocFile(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMicroteachCase4All.DocFile);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetWordCreateDate(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMicroteachCase4All.WordCreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetmicroteachCaseText(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase4All.microteachCaseText);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetOwnerId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroteachCase4All.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase4All.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetOwnerName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase4All.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCollegeID(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCase4All.CollegeID);
objvMicroteachCase4AllEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.CollegeID) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.CollegeID, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.CollegeID] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCollegeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase4All.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetOwnerNameWithId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCase4All.OwnerNameWithId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN Setid_XzCollege(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCase4All.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCase4All.id_XzCollege);
objvMicroteachCase4AllEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4All.id_XzCollege) == false)
{
objvMicroteachCase4AllEN.dicFldComparisonOp.Add(convMicroteachCase4All.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCase4AllEN.dicFldComparisonOp[convMicroteachCase4All.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCase4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserKindId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convMicroteachCase4All.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCase4All.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCase4All.UserKindId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserKindName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCase4All.UserKindName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserTypeId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase4All.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase4All.UserTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetUserTypeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCase4All.UserTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetRecommendedDegreeId(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroteachCase4All.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase4All.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase4All.RecommendedDegreeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetRecommendedDegreeName(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase4All.RecommendedDegreeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetMemo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase4All.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetBrowseCount4Case(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, int intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetIsHaveVideo(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convMicroteachCase4All.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convMicroteachCase4All.IsHaveVideo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetCollegeNameA(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase4All.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4AllEN SetftpFileType(this clsvMicroteachCase4AllEN objvMicroteachCase4AllEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase4All.ftpFileType);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase4AllEN objvMicroteachCase4All_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_MicroteachCase, objvMicroteachCase4All_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseTypeName) == true)
{
string strComparisonOp_MicroteachCaseTypeName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseTypeName, objvMicroteachCase4All_Cond.MicroteachCaseTypeName, strComparisonOp_MicroteachCaseTypeName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseID, objvMicroteachCase4All_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseName, objvMicroteachCase4All_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseTheme, objvMicroteachCase4All_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseDate, objvMicroteachCase4All_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseTime, objvMicroteachCase4All_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroteachCaseDateIn, objvMicroteachCase4All_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_StudyLevel, objvMicroteachCase4All_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.StudyLevelName, objvMicroteachCase4All_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_TeachingPlan, objvMicroteachCase4All_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.MicroTeachCaseTimeIn, objvMicroteachCase4All_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_MicroteachCaseType) == true)
{
string strComparisonOp_id_MicroteachCaseType = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_MicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_MicroteachCaseType, objvMicroteachCase4All_Cond.id_MicroteachCaseType, strComparisonOp_id_MicroteachCaseType);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.Id_CaseType, objvMicroteachCase4All_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_Discipline, objvMicroteachCase4All_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.DisciplineID, objvMicroteachCase4All_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.DisciplineName, objvMicroteachCase4All_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_SenateGaugeVersion, objvMicroteachCase4All_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.senateGaugeVersionID, objvMicroteachCase4All_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.senateGaugeVersionName, objvMicroteachCase4All_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4All.senateGaugeVersionTtlScore, objvMicroteachCase4All_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4All.VersionNo, objvMicroteachCase4All_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_TeachSkill, objvMicroteachCase4All_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillID, objvMicroteachCase4All_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.SkillTypeName, objvMicroteachCase4All_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillName, objvMicroteachCase4All_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillTheory, objvMicroteachCase4All_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.TeachSkillOperMethod, objvMicroteachCase4All_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_SkillType, objvMicroteachCase4All_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.SkillTypeID, objvMicroteachCase4All_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CaseLevelId, objvMicroteachCase4All_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CaseLevelName, objvMicroteachCase4All_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.DocFile) == true)
{
string strComparisonOp_DocFile = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.DocFile, objvMicroteachCase4All_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.IsNeedGeneWord) == true)
{
if (objvMicroteachCase4All_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4All.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4All.IsNeedGeneWord);
}
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.WordCreateDate, objvMicroteachCase4All_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.IsVisible) == true)
{
if (objvMicroteachCase4All_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4All.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4All.IsVisible);
}
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.microteachCaseText, objvMicroteachCase4All_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.OwnerId, objvMicroteachCase4All_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.OwnerName, objvMicroteachCase4All_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CollegeID, objvMicroteachCase4All_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CollegeName, objvMicroteachCase4All_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.OwnerNameWithId, objvMicroteachCase4All_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.id_XzCollege, objvMicroteachCase4All_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.IsDualVideo) == true)
{
if (objvMicroteachCase4All_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4All.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4All.IsDualVideo);
}
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserKindId, objvMicroteachCase4All_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserKindName, objvMicroteachCase4All_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserTypeId, objvMicroteachCase4All_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.UserTypeName, objvMicroteachCase4All_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.RecommendedDegreeId, objvMicroteachCase4All_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.RecommendedDegreeName, objvMicroteachCase4All_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.Memo, objvMicroteachCase4All_Cond.Memo, strComparisonOp_Memo);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4All.BrowseCount4Case, objvMicroteachCase4All_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.IsHaveVideo, objvMicroteachCase4All_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.CollegeNameA, objvMicroteachCase4All_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvMicroteachCase4All_Cond.IsUpdated(convMicroteachCase4All.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCase4All_Cond.dicFldComparisonOp[convMicroteachCase4All.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4All.ftpFileType, objvMicroteachCase4All_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v微格教学案例_All(vMicroteachCase4All)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase4AllWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase4AllApi";

 public clsvMicroteachCase4AllWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_MicroteachCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v微格教学案例_All]...","0");
List<clsvMicroteachCase4AllEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_MicroteachCase";
objDDL.DataTextField="MicroteachCaseName";
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
public static void BindCbo_id_MicroteachCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convMicroteachCase4All.id_MicroteachCase); 
List<clsvMicroteachCase4AllEN> arrObjLst = clsvMicroteachCase4AllWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN()
{
id_MicroteachCase = "0",
MicroteachCaseName = "选[v微格教学案例_All]..."
};
arrObjLst.Insert(0, objvMicroteachCase4AllEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convMicroteachCase4All.id_MicroteachCase;
objComboBox.DisplayMember = convMicroteachCase4All.MicroteachCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4AllEN GetObjByid_MicroteachCase(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase4AllEN = JsonConvert.DeserializeObject<clsvMicroteachCase4AllEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase4AllEN;
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
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4AllEN GetObjByid_MicroteachCase_WA_Cache(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCase4AllEN = JsonConvert.DeserializeObject<clsvMicroteachCase4AllEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase4AllEN;
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
public static clsvMicroteachCase4AllEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = null;
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
objvMicroteachCase4AllEN = JsonConvert.DeserializeObject<clsvMicroteachCase4AllEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase4AllEN;
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
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase4AllEN GetObjByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName_S);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel =
from objvMicroteachCase4AllEN in arrvMicroteachCase4AllObjLst_Cache
where objvMicroteachCase4AllEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase4AllEN;
if (arrvMicroteachCase4AllObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase4AllEN obj = clsvMicroteachCase4AllWApi.GetObjByid_MicroteachCase(strid_MicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase4AllObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroteachCaseNameByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName_S);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel1 =
from objvMicroteachCase4AllEN in arrvMicroteachCase4AllObjLst_Cache
where objvMicroteachCase4AllEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase4AllEN;
List <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel = new List<clsvMicroteachCase4AllEN>();
foreach (clsvMicroteachCase4AllEN obj in arrvMicroteachCase4AllObjLst_Sel1)
{
arrvMicroteachCase4AllObjLst_Sel.Add(obj);
}
if (arrvMicroteachCase4AllObjLst_Sel.Count > 0)
{
return arrvMicroteachCase4AllObjLst_Sel[0].MicroteachCaseName;
}
string strErrMsgForGetObjById = string.Format("在vMicroteachCase4All对象缓存列表中,找不到记录[id_MicroteachCase = {0}](函数:{1})", strid_MicroteachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvMicroteachCase4AllBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName_S);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel1 =
from objvMicroteachCase4AllEN in arrvMicroteachCase4AllObjLst_Cache
where objvMicroteachCase4AllEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase4AllEN;
List <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel = new List<clsvMicroteachCase4AllEN>();
foreach (clsvMicroteachCase4AllEN obj in arrvMicroteachCase4AllObjLst_Sel1)
{
arrvMicroteachCase4AllObjLst_Sel.Add(obj);
}
if (arrvMicroteachCase4AllObjLst_Sel.Count > 0)
{
return arrvMicroteachCase4AllObjLst_Sel[0].MicroteachCaseName;
}
string strErrMsgForGetObjById = string.Format("在vMicroteachCase4All对象缓存列表中,找不到记录的相关名称[id_MicroteachCase = {0}](函数:{1})", strid_MicroteachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvMicroteachCase4AllBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4AllEN> GetObjLstById_MicroteachCaseLst(List<string> arrId_MicroteachCase)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroteachCase4AllEN> GetObjLstById_MicroteachCaseLst_Cache(List<string> arrId_MicroteachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName_S);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Sel =
from objvMicroteachCase4AllEN in arrvMicroteachCase4AllObjLst_Cache
where arrId_MicroteachCase.Contains(objvMicroteachCase4AllEN.id_MicroteachCase)
select objvMicroteachCase4AllEN;
return arrvMicroteachCase4AllObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4AllEN> GetObjLstById_MicroteachCaseLst_WA_Cache(List<string> arrId_MicroteachCase)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4AllEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4AllEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase4AllEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4AllEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_MicroteachCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
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
 /// <param name = "objvMicroteachCase4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase4AllENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase4AllEN objvMicroteachCase4AllENS, clsvMicroteachCase4AllEN objvMicroteachCase4AllENT)
{
try
{
objvMicroteachCase4AllENT.id_MicroteachCase = objvMicroteachCase4AllENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase4AllENT.MicroteachCaseTypeName = objvMicroteachCase4AllENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4AllENT.MicroteachCaseID = objvMicroteachCase4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4AllENT.MicroteachCaseName = objvMicroteachCase4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4AllENT.MicroteachCaseTheme = objvMicroteachCase4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4AllENT.MicroteachCaseDate = objvMicroteachCase4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4AllENT.MicroteachCaseTime = objvMicroteachCase4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4AllENT.MicroteachCaseDateIn = objvMicroteachCase4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4AllENT.id_StudyLevel = objvMicroteachCase4AllENS.id_StudyLevel; //id_StudyLevel
objvMicroteachCase4AllENT.StudyLevelName = objvMicroteachCase4AllENS.StudyLevelName; //学段名称
objvMicroteachCase4AllENT.id_TeachingPlan = objvMicroteachCase4AllENS.id_TeachingPlan; //教案流水号
objvMicroteachCase4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4AllENT.id_MicroteachCaseType = objvMicroteachCase4AllENS.id_MicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4AllENT.Id_CaseType = objvMicroteachCase4AllENS.Id_CaseType; //案例类型流水号
objvMicroteachCase4AllENT.id_Discipline = objvMicroteachCase4AllENS.id_Discipline; //学科流水号
objvMicroteachCase4AllENT.DisciplineID = objvMicroteachCase4AllENS.DisciplineID; //学科ID
objvMicroteachCase4AllENT.DisciplineName = objvMicroteachCase4AllENS.DisciplineName; //学科名称
objvMicroteachCase4AllENT.id_SenateGaugeVersion = objvMicroteachCase4AllENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4AllENT.senateGaugeVersionID = objvMicroteachCase4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4AllENT.senateGaugeVersionName = objvMicroteachCase4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4AllENT.VersionNo = objvMicroteachCase4AllENS.VersionNo; //版本号
objvMicroteachCase4AllENT.id_TeachSkill = objvMicroteachCase4AllENS.id_TeachSkill; //教学技能流水号
objvMicroteachCase4AllENT.TeachSkillID = objvMicroteachCase4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase4AllENT.SkillTypeName = objvMicroteachCase4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase4AllENT.TeachSkillName = objvMicroteachCase4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase4AllENT.TeachSkillTheory = objvMicroteachCase4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4AllENT.TeachSkillOperMethod = objvMicroteachCase4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4AllENT.id_SkillType = objvMicroteachCase4AllENS.id_SkillType; //技能类型流水号
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
objvMicroteachCase4AllENT.CollegeID = objvMicroteachCase4AllENS.CollegeID; //学院ID
objvMicroteachCase4AllENT.CollegeName = objvMicroteachCase4AllENS.CollegeName; //学院名称
objvMicroteachCase4AllENT.OwnerNameWithId = objvMicroteachCase4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase4AllENT.id_XzCollege = objvMicroteachCase4AllENS.id_XzCollege; //学院流水号
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
public static DataTable ToDataTable(List<clsvMicroteachCase4AllEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase4AllEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase4AllEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase4AllEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase4AllEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase4AllEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase");
//if (arrvMicroteachCase4AllObjLst_Cache == null)
//{
//arrvMicroteachCase4AllObjLst_Cache = await clsvMicroteachCase4AllWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName_S);
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
public static List<clsvMicroteachCase4AllEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase4AllEN._CurrTabName_S);
List<clsvMicroteachCase4AllEN> arrvMicroteachCase4AllObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase4AllObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase4AllEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase4All.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_MicroteachCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCase4All.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase4All.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase4All.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase4All.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase4All.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase4All.IsHaveVideo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4All.ftpFileType, Type.GetType("System.String"));
foreach (clsvMicroteachCase4AllEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase4All.id_MicroteachCase] = objInFor[convMicroteachCase4All.id_MicroteachCase];
objDR[convMicroteachCase4All.MicroteachCaseTypeName] = objInFor[convMicroteachCase4All.MicroteachCaseTypeName];
objDR[convMicroteachCase4All.MicroteachCaseID] = objInFor[convMicroteachCase4All.MicroteachCaseID];
objDR[convMicroteachCase4All.MicroteachCaseName] = objInFor[convMicroteachCase4All.MicroteachCaseName];
objDR[convMicroteachCase4All.MicroteachCaseTheme] = objInFor[convMicroteachCase4All.MicroteachCaseTheme];
objDR[convMicroteachCase4All.MicroteachCaseDate] = objInFor[convMicroteachCase4All.MicroteachCaseDate];
objDR[convMicroteachCase4All.MicroteachCaseTime] = objInFor[convMicroteachCase4All.MicroteachCaseTime];
objDR[convMicroteachCase4All.MicroteachCaseDateIn] = objInFor[convMicroteachCase4All.MicroteachCaseDateIn];
objDR[convMicroteachCase4All.id_StudyLevel] = objInFor[convMicroteachCase4All.id_StudyLevel];
objDR[convMicroteachCase4All.StudyLevelName] = objInFor[convMicroteachCase4All.StudyLevelName];
objDR[convMicroteachCase4All.id_TeachingPlan] = objInFor[convMicroteachCase4All.id_TeachingPlan];
objDR[convMicroteachCase4All.MicroTeachCaseTimeIn] = objInFor[convMicroteachCase4All.MicroTeachCaseTimeIn];
objDR[convMicroteachCase4All.id_MicroteachCaseType] = objInFor[convMicroteachCase4All.id_MicroteachCaseType];
objDR[convMicroteachCase4All.Id_CaseType] = objInFor[convMicroteachCase4All.Id_CaseType];
objDR[convMicroteachCase4All.id_Discipline] = objInFor[convMicroteachCase4All.id_Discipline];
objDR[convMicroteachCase4All.DisciplineID] = objInFor[convMicroteachCase4All.DisciplineID];
objDR[convMicroteachCase4All.DisciplineName] = objInFor[convMicroteachCase4All.DisciplineName];
objDR[convMicroteachCase4All.id_SenateGaugeVersion] = objInFor[convMicroteachCase4All.id_SenateGaugeVersion];
objDR[convMicroteachCase4All.senateGaugeVersionID] = objInFor[convMicroteachCase4All.senateGaugeVersionID];
objDR[convMicroteachCase4All.senateGaugeVersionName] = objInFor[convMicroteachCase4All.senateGaugeVersionName];
objDR[convMicroteachCase4All.senateGaugeVersionTtlScore] = objInFor[convMicroteachCase4All.senateGaugeVersionTtlScore];
objDR[convMicroteachCase4All.VersionNo] = objInFor[convMicroteachCase4All.VersionNo];
objDR[convMicroteachCase4All.id_TeachSkill] = objInFor[convMicroteachCase4All.id_TeachSkill];
objDR[convMicroteachCase4All.TeachSkillID] = objInFor[convMicroteachCase4All.TeachSkillID];
objDR[convMicroteachCase4All.SkillTypeName] = objInFor[convMicroteachCase4All.SkillTypeName];
objDR[convMicroteachCase4All.TeachSkillName] = objInFor[convMicroteachCase4All.TeachSkillName];
objDR[convMicroteachCase4All.TeachSkillTheory] = objInFor[convMicroteachCase4All.TeachSkillTheory];
objDR[convMicroteachCase4All.TeachSkillOperMethod] = objInFor[convMicroteachCase4All.TeachSkillOperMethod];
objDR[convMicroteachCase4All.id_SkillType] = objInFor[convMicroteachCase4All.id_SkillType];
objDR[convMicroteachCase4All.SkillTypeID] = objInFor[convMicroteachCase4All.SkillTypeID];
objDR[convMicroteachCase4All.CaseLevelId] = objInFor[convMicroteachCase4All.CaseLevelId];
objDR[convMicroteachCase4All.CaseLevelName] = objInFor[convMicroteachCase4All.CaseLevelName];
objDR[convMicroteachCase4All.DocFile] = objInFor[convMicroteachCase4All.DocFile];
objDR[convMicroteachCase4All.IsNeedGeneWord] = objInFor[convMicroteachCase4All.IsNeedGeneWord];
objDR[convMicroteachCase4All.WordCreateDate] = objInFor[convMicroteachCase4All.WordCreateDate];
objDR[convMicroteachCase4All.IsVisible] = objInFor[convMicroteachCase4All.IsVisible];
objDR[convMicroteachCase4All.microteachCaseText] = objInFor[convMicroteachCase4All.microteachCaseText];
objDR[convMicroteachCase4All.OwnerId] = objInFor[convMicroteachCase4All.OwnerId];
objDR[convMicroteachCase4All.OwnerName] = objInFor[convMicroteachCase4All.OwnerName];
objDR[convMicroteachCase4All.CollegeID] = objInFor[convMicroteachCase4All.CollegeID];
objDR[convMicroteachCase4All.CollegeName] = objInFor[convMicroteachCase4All.CollegeName];
objDR[convMicroteachCase4All.OwnerNameWithId] = objInFor[convMicroteachCase4All.OwnerNameWithId];
objDR[convMicroteachCase4All.id_XzCollege] = objInFor[convMicroteachCase4All.id_XzCollege];
objDR[convMicroteachCase4All.IsDualVideo] = objInFor[convMicroteachCase4All.IsDualVideo];
objDR[convMicroteachCase4All.UserKindId] = objInFor[convMicroteachCase4All.UserKindId];
objDR[convMicroteachCase4All.UserKindName] = objInFor[convMicroteachCase4All.UserKindName];
objDR[convMicroteachCase4All.UserTypeId] = objInFor[convMicroteachCase4All.UserTypeId];
objDR[convMicroteachCase4All.UserTypeName] = objInFor[convMicroteachCase4All.UserTypeName];
objDR[convMicroteachCase4All.RecommendedDegreeId] = objInFor[convMicroteachCase4All.RecommendedDegreeId];
objDR[convMicroteachCase4All.RecommendedDegreeName] = objInFor[convMicroteachCase4All.RecommendedDegreeName];
objDR[convMicroteachCase4All.Memo] = objInFor[convMicroteachCase4All.Memo];
objDR[convMicroteachCase4All.BrowseCount4Case] = objInFor[convMicroteachCase4All.BrowseCount4Case];
objDR[convMicroteachCase4All.IsHaveVideo] = objInFor[convMicroteachCase4All.IsHaveVideo];
objDR[convMicroteachCase4All.CollegeNameA] = objInFor[convMicroteachCase4All.CollegeNameA];
objDR[convMicroteachCase4All.ftpFileType] = objInFor[convMicroteachCase4All.ftpFileType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}