
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseWApi
 表名:vMicroTeachCase(01120324)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:57
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
public static class clsvMicroTeachCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_MicroteachCase(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroTeachCase.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroTeachCase.id_MicroteachCase);
objvMicroTeachCaseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_MicroteachCase) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroTeachCase.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroTeachCase.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroTeachCase.MicroteachCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroTeachCase.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroTeachCase.MicroteachCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseTheme(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroTeachCase.MicroteachCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseDate(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroTeachCase.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroTeachCase.MicroteachCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseTime(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroTeachCase.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroTeachCase.MicroteachCaseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseDateIn(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroTeachCase.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroTeachCase.MicroteachCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_StudyLevel(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convMicroTeachCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroTeachCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroTeachCase.id_StudyLevel);
objvMicroTeachCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_StudyLevel) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStudyLevelName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convMicroTeachCase.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroTeachCase.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_TeachingPlan(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convMicroTeachCase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroTeachCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroTeachCase.id_TeachingPlan);
objvMicroTeachCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_TeachingPlan) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroTeachCaseTimeIn(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroTeachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroTeachCase.MicroTeachCaseTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_MicroteachCaseType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_MicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCaseType, convMicroTeachCase.id_MicroteachCaseType);
clsCheckSql.CheckFieldLen(strid_MicroteachCaseType, 4, convMicroTeachCase.id_MicroteachCaseType);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCaseType, 4, convMicroTeachCase.id_MicroteachCaseType);
objvMicroTeachCaseEN.id_MicroteachCaseType = strid_MicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_MicroteachCaseType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_MicroteachCaseType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_MicroteachCaseType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMicroteachCaseTypeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, convMicroTeachCase.MicroteachCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetId_CaseType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convMicroTeachCase.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convMicroTeachCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convMicroTeachCase.Id_CaseType);
objvMicroTeachCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.Id_CaseType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.Id_CaseType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.Id_CaseType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_Discipline(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMicroTeachCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMicroTeachCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMicroTeachCase.id_Discipline);
objvMicroTeachCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_Discipline) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_Discipline, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_Discipline] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDisciplineID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroTeachCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroTeachCase.DisciplineID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDisciplineName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroTeachCase.DisciplineName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_SenateGaugeVersion(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convMicroTeachCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMicroTeachCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMicroTeachCase.id_SenateGaugeVersion);
objvMicroTeachCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_SenateGaugeVersion) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetsenateGaugeVersionID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convMicroTeachCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroTeachCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroTeachCase.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetsenateGaugeVersionName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroTeachCase.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetVersionNo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_TeachSkill(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convMicroTeachCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convMicroTeachCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convMicroTeachCase.id_TeachSkill);
objvMicroTeachCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_TeachSkill) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_TeachSkill, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_TeachSkill] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroTeachCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroTeachCase.TeachSkillID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetSkillTypeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroTeachCase.SkillTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroTeachCase.TeachSkillName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillTheory(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroTeachCase.TeachSkillTheory);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetTeachSkillOperMethod(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroTeachCase.TeachSkillOperMethod);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_SkillType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convMicroTeachCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convMicroTeachCase.id_SkillType);
objvMicroTeachCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_SkillType) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_SkillType, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_SkillType] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetSkillTypeID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroTeachCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroTeachCase.SkillTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCaseLevelId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroTeachCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroTeachCase.CaseLevelId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCaseLevelName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convMicroTeachCase.CaseLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDocFile(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMicroTeachCase.DocFile);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetWordCreateDate(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMicroTeachCase.WordCreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetmicroteachCaseText(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroTeachCase.microteachCaseText);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetOwnerId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroTeachCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroTeachCase.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_StudentInfo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convMicroTeachCase.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convMicroTeachCase.id_StudentInfo);
objvMicroTeachCaseEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_StudentInfo) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_StudentInfo, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_StudentInfo] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convMicroTeachCase.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, convMicroTeachCase.StuName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convMicroTeachCase.StuID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetPoliticsName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convMicroTeachCase.PoliticsName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetSexDesc(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convMicroTeachCase.SexDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetEthnicName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convMicroTeachCase.EthnicName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUniZoneDesc(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convMicroTeachCase.UniZoneDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuTypeDesc(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convMicroTeachCase.StuTypeDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_XzCollege(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroTeachCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroTeachCase.id_XzCollege);
objvMicroTeachCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_XzCollege) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_XzCollege, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_XzCollege] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCollegeID(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroTeachCase.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCollegeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convMicroTeachCase.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroTeachCase.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetCollegeNameA(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroTeachCase.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_XzMajor(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convMicroTeachCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convMicroTeachCase.id_XzMajor);
objvMicroTeachCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_XzMajor) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_XzMajor, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_XzMajor] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMajorName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convMicroTeachCase.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convMicroTeachCase.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_GradeBase(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_GradeBase, convMicroTeachCase.id_GradeBase);
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convMicroTeachCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convMicroTeachCase.id_GradeBase);
objvMicroTeachCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_GradeBase) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_GradeBase, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_GradeBase] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetGradeBaseName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMicroTeachCase.GradeBaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN Setid_AdminCls(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convMicroTeachCase.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convMicroTeachCase.id_AdminCls);
objvMicroTeachCaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseEN.dicFldComparisonOp.ContainsKey(convMicroTeachCase.id_AdminCls) == false)
{
objvMicroTeachCaseEN.dicFldComparisonOp.Add(convMicroTeachCase.id_AdminCls, strComparisonOp);
}
else
{
objvMicroTeachCaseEN.dicFldComparisonOp[convMicroTeachCase.id_AdminCls] = strComparisonOp;
}
}
return objvMicroTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetAdminClsId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convMicroTeachCase.AdminClsId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetAdminClsName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convMicroTeachCase.AdminClsName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetBirthday(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convMicroTeachCase.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convMicroTeachCase.Birthday);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetNativePlace(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convMicroTeachCase.NativePlace);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetDuty(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convMicroTeachCase.Duty);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIDCardNo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convMicroTeachCase.IDCardNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetStuCardNo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convMicroTeachCase.StuCardNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetLiveAddress(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convMicroTeachCase.LiveAddress);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetHomePhone(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convMicroTeachCase.HomePhone);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetEnrollmentDate(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convMicroTeachCase.EnrollmentDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetPostCode(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convMicroTeachCase.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convMicroTeachCase.PostCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserKindId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convMicroTeachCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroTeachCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroTeachCase.UserKindId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserKindName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroTeachCase.UserKindName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserTypeId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroTeachCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroTeachCase.UserTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetUserTypeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroTeachCase.UserTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetRecommendedDegreeId(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroTeachCase.RecommendedDegreeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetRecommendedDegreeName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroTeachCase.RecommendedDegreeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetftpFileType(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroTeachCase.ftpFileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetVideoUrl(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convMicroTeachCase.VideoUrl);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetVideoPath(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convMicroTeachCase.VideoPath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetResErrMsg(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convMicroTeachCase.ResErrMsg);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetMemo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroTeachCase.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetIsHaveVideo(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convMicroTeachCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convMicroTeachCase.IsHaveVideo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetOwnerName(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroTeachCase.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseEN SetBrowseCount4Case(this clsvMicroTeachCaseEN objvMicroTeachCaseEN, int intBrowseCount4Case, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroTeachCaseEN objvMicroTeachCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_MicroteachCase, objvMicroTeachCase_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseID, objvMicroTeachCase_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseName, objvMicroTeachCase_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseTheme, objvMicroTeachCase_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseDate, objvMicroTeachCase_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseTime, objvMicroTeachCase_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseDateIn, objvMicroTeachCase_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_StudyLevel, objvMicroTeachCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StudyLevelName, objvMicroTeachCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_TeachingPlan, objvMicroTeachCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroTeachCaseTimeIn, objvMicroTeachCase_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_MicroteachCaseType) == true)
{
string strComparisonOp_id_MicroteachCaseType = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_MicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_MicroteachCaseType, objvMicroTeachCase_Cond.id_MicroteachCaseType, strComparisonOp_id_MicroteachCaseType);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MicroteachCaseTypeName) == true)
{
string strComparisonOp_MicroteachCaseTypeName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MicroteachCaseTypeName, objvMicroTeachCase_Cond.MicroteachCaseTypeName, strComparisonOp_MicroteachCaseTypeName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Id_CaseType, objvMicroTeachCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_Discipline, objvMicroTeachCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.DisciplineID, objvMicroTeachCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.DisciplineName, objvMicroTeachCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_SenateGaugeVersion, objvMicroTeachCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.senateGaugeVersionID, objvMicroTeachCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.senateGaugeVersionName, objvMicroTeachCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCase.senateGaugeVersionTtlScore, objvMicroTeachCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCase.VersionNo, objvMicroTeachCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_TeachSkill, objvMicroTeachCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillID, objvMicroTeachCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.SkillTypeName, objvMicroTeachCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillName, objvMicroTeachCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillTheory, objvMicroTeachCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.TeachSkillOperMethod, objvMicroTeachCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_SkillType, objvMicroTeachCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.SkillTypeID, objvMicroTeachCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CaseLevelId, objvMicroTeachCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CaseLevelName, objvMicroTeachCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.DocFile, objvMicroTeachCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.IsNeedGeneWord) == true)
{
if (objvMicroTeachCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCase.IsNeedGeneWord);
}
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.WordCreateDate, objvMicroTeachCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.IsVisible) == true)
{
if (objvMicroTeachCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCase.IsVisible);
}
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.microteachCaseText, objvMicroTeachCase_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.OwnerId, objvMicroTeachCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_StudentInfo, objvMicroTeachCase_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.StuName) == true)
{
string strComparisonOp_StuName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuName, objvMicroTeachCase_Cond.StuName, strComparisonOp_StuName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.StuID) == true)
{
string strComparisonOp_StuID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuID, objvMicroTeachCase_Cond.StuID, strComparisonOp_StuID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.PoliticsName, objvMicroTeachCase_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.SexDesc, objvMicroTeachCase_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.EthnicName, objvMicroTeachCase_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UniZoneDesc, objvMicroTeachCase_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuTypeDesc, objvMicroTeachCase_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_XzCollege, objvMicroTeachCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CollegeID, objvMicroTeachCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CollegeName, objvMicroTeachCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.CollegeNameA, objvMicroTeachCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_XzMajor, objvMicroTeachCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.MajorName, objvMicroTeachCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_GradeBase, objvMicroTeachCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.GradeBaseName, objvMicroTeachCase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.id_AdminCls, objvMicroTeachCase_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.AdminClsId, objvMicroTeachCase_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.AdminClsName, objvMicroTeachCase_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.Birthday) == true)
{
string strComparisonOp_Birthday = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Birthday, objvMicroTeachCase_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.NativePlace, objvMicroTeachCase_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.Duty) == true)
{
string strComparisonOp_Duty = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Duty, objvMicroTeachCase_Cond.Duty, strComparisonOp_Duty);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IDCardNo, objvMicroTeachCase_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.StuCardNo, objvMicroTeachCase_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.LiveAddress, objvMicroTeachCase_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.HomePhone, objvMicroTeachCase_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.EnrollmentDate, objvMicroTeachCase_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.PostCode) == true)
{
string strComparisonOp_PostCode = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.PostCode, objvMicroTeachCase_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.IsDualVideo) == true)
{
if (objvMicroTeachCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCase.IsDualVideo);
}
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserKindId, objvMicroTeachCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserKindName, objvMicroTeachCase_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserTypeId, objvMicroTeachCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.UserTypeName, objvMicroTeachCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.RecommendedDegreeId, objvMicroTeachCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.RecommendedDegreeName, objvMicroTeachCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.ftpFileType, objvMicroTeachCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.VideoUrl, objvMicroTeachCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.VideoPath, objvMicroTeachCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.ResErrMsg, objvMicroTeachCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.Memo) == true)
{
string strComparisonOp_Memo = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.Memo, objvMicroTeachCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.IsHaveVideo, objvMicroTeachCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCase.OwnerName, objvMicroTeachCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroTeachCase_Cond.IsUpdated(convMicroTeachCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroTeachCase_Cond.dicFldComparisonOp[convMicroTeachCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCase.BrowseCount4Case, objvMicroTeachCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v微格教学案例(vMicroTeachCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroTeachCaseWApi
{
private static readonly string mstrApiControllerName = "vMicroTeachCaseApi";

 public clsvMicroTeachCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseEN GetObjByid_MicroteachCase(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroTeachCaseEN objvMicroTeachCaseEN = null;
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
objvMicroTeachCaseEN = JsonConvert.DeserializeObject<clsvMicroTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroTeachCaseEN;
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
public static clsvMicroTeachCaseEN GetObjByid_MicroteachCase_WA_Cache(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroTeachCaseEN objvMicroTeachCaseEN = null;
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
objvMicroTeachCaseEN = JsonConvert.DeserializeObject<clsvMicroTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroTeachCaseEN;
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
public static clsvMicroTeachCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroTeachCaseEN objvMicroTeachCaseEN = null;
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
objvMicroTeachCaseEN = JsonConvert.DeserializeObject<clsvMicroTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroTeachCaseEN;
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
public static clsvMicroTeachCaseEN GetObjByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName_S);
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Sel =
from objvMicroTeachCaseEN in arrvMicroTeachCaseObjLst_Cache
where objvMicroTeachCaseEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroTeachCaseEN;
if (arrvMicroTeachCaseObjLst_Sel.Count() == 0)
{
   clsvMicroTeachCaseEN obj = clsvMicroTeachCaseWApi.GetObjByid_MicroteachCase(strid_MicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroTeachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseEN> GetObjLstById_MicroteachCaseLst(List<string> arrId_MicroteachCase)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMicroTeachCaseEN> GetObjLstById_MicroteachCaseLst_Cache(List<string> arrId_MicroteachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName_S);
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Sel =
from objvMicroTeachCaseEN in arrvMicroTeachCaseObjLst_Cache
where arrId_MicroteachCase.Contains(objvMicroTeachCaseEN.id_MicroteachCase)
select objvMicroTeachCaseEN;
return arrvMicroTeachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseEN> GetObjLstById_MicroteachCaseLst_WA_Cache(List<string> arrId_MicroteachCase)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMicroTeachCaseENS">源对象</param>
 /// <param name = "objvMicroTeachCaseENT">目标对象</param>
 public static void CopyTo(clsvMicroTeachCaseEN objvMicroTeachCaseENS, clsvMicroTeachCaseEN objvMicroTeachCaseENT)
{
try
{
objvMicroTeachCaseENT.id_MicroteachCase = objvMicroTeachCaseENS.id_MicroteachCase; //微格教学案例流水号
objvMicroTeachCaseENT.MicroteachCaseID = objvMicroTeachCaseENS.MicroteachCaseID; //微格教学案例ID
objvMicroTeachCaseENT.MicroteachCaseName = objvMicroTeachCaseENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseENT.MicroteachCaseTheme = objvMicroTeachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroTeachCaseENT.MicroteachCaseDate = objvMicroTeachCaseENS.MicroteachCaseDate; //微格教学日期
objvMicroTeachCaseENT.MicroteachCaseTime = objvMicroTeachCaseENS.MicroteachCaseTime; //微格教学时间
objvMicroTeachCaseENT.MicroteachCaseDateIn = objvMicroTeachCaseENS.MicroteachCaseDateIn; //案例入库日期
objvMicroTeachCaseENT.id_StudyLevel = objvMicroTeachCaseENS.id_StudyLevel; //id_StudyLevel
objvMicroTeachCaseENT.StudyLevelName = objvMicroTeachCaseENS.StudyLevelName; //学段名称
objvMicroTeachCaseENT.id_TeachingPlan = objvMicroTeachCaseENS.id_TeachingPlan; //教案流水号
objvMicroTeachCaseENT.MicroTeachCaseTimeIn = objvMicroTeachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroTeachCaseENT.id_MicroteachCaseType = objvMicroTeachCaseENS.id_MicroteachCaseType; //微格案例类型流水号
objvMicroTeachCaseENT.MicroteachCaseTypeName = objvMicroTeachCaseENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroTeachCaseENT.Id_CaseType = objvMicroTeachCaseENS.Id_CaseType; //案例类型流水号
objvMicroTeachCaseENT.id_Discipline = objvMicroTeachCaseENS.id_Discipline; //学科流水号
objvMicroTeachCaseENT.DisciplineID = objvMicroTeachCaseENS.DisciplineID; //学科ID
objvMicroTeachCaseENT.DisciplineName = objvMicroTeachCaseENS.DisciplineName; //学科名称
objvMicroTeachCaseENT.id_SenateGaugeVersion = objvMicroTeachCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMicroTeachCaseENT.senateGaugeVersionID = objvMicroTeachCaseENS.senateGaugeVersionID; //评价量表版本ID
objvMicroTeachCaseENT.senateGaugeVersionName = objvMicroTeachCaseENS.senateGaugeVersionName; //评价量表版本名称
objvMicroTeachCaseENT.senateGaugeVersionTtlScore = objvMicroTeachCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroTeachCaseENT.VersionNo = objvMicroTeachCaseENS.VersionNo; //版本号
objvMicroTeachCaseENT.id_TeachSkill = objvMicroTeachCaseENS.id_TeachSkill; //教学技能流水号
objvMicroTeachCaseENT.TeachSkillID = objvMicroTeachCaseENS.TeachSkillID; //教学技能ID
objvMicroTeachCaseENT.SkillTypeName = objvMicroTeachCaseENS.SkillTypeName; //技能类型名称
objvMicroTeachCaseENT.TeachSkillName = objvMicroTeachCaseENS.TeachSkillName; //教学技能名称
objvMicroTeachCaseENT.TeachSkillTheory = objvMicroTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvMicroTeachCaseENT.TeachSkillOperMethod = objvMicroTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroTeachCaseENT.id_SkillType = objvMicroTeachCaseENS.id_SkillType; //技能类型流水号
objvMicroTeachCaseENT.SkillTypeID = objvMicroTeachCaseENS.SkillTypeID; //技能类型ID
objvMicroTeachCaseENT.CaseLevelId = objvMicroTeachCaseENS.CaseLevelId; //课例等级Id
objvMicroTeachCaseENT.CaseLevelName = objvMicroTeachCaseENS.CaseLevelName; //案例等级名称
objvMicroTeachCaseENT.DocFile = objvMicroTeachCaseENS.DocFile; //生成的Word文件名
objvMicroTeachCaseENT.IsNeedGeneWord = objvMicroTeachCaseENS.IsNeedGeneWord; //是否需要生成Word
objvMicroTeachCaseENT.WordCreateDate = objvMicroTeachCaseENS.WordCreateDate; //Word生成日期
objvMicroTeachCaseENT.IsVisible = objvMicroTeachCaseENS.IsVisible; //是否显示
objvMicroTeachCaseENT.microteachCaseText = objvMicroTeachCaseENS.microteachCaseText; //案例文本内容
objvMicroTeachCaseENT.OwnerId = objvMicroTeachCaseENS.OwnerId; //拥有者Id
objvMicroTeachCaseENT.id_StudentInfo = objvMicroTeachCaseENS.id_StudentInfo; //学生流水号
objvMicroTeachCaseENT.StuName = objvMicroTeachCaseENS.StuName; //姓名
objvMicroTeachCaseENT.StuID = objvMicroTeachCaseENS.StuID; //学号
objvMicroTeachCaseENT.PoliticsName = objvMicroTeachCaseENS.PoliticsName; //政治面貌
objvMicroTeachCaseENT.SexDesc = objvMicroTeachCaseENS.SexDesc; //性别名称
objvMicroTeachCaseENT.EthnicName = objvMicroTeachCaseENS.EthnicName; //民族名称
objvMicroTeachCaseENT.UniZoneDesc = objvMicroTeachCaseENS.UniZoneDesc; //校区名称
objvMicroTeachCaseENT.StuTypeDesc = objvMicroTeachCaseENS.StuTypeDesc; //学生类别名称
objvMicroTeachCaseENT.id_XzCollege = objvMicroTeachCaseENS.id_XzCollege; //学院流水号
objvMicroTeachCaseENT.CollegeID = objvMicroTeachCaseENS.CollegeID; //学院ID
objvMicroTeachCaseENT.CollegeName = objvMicroTeachCaseENS.CollegeName; //学院名称
objvMicroTeachCaseENT.CollegeNameA = objvMicroTeachCaseENS.CollegeNameA; //学院名称简写
objvMicroTeachCaseENT.id_XzMajor = objvMicroTeachCaseENS.id_XzMajor; //专业流水号
objvMicroTeachCaseENT.MajorName = objvMicroTeachCaseENS.MajorName; //专业名称
objvMicroTeachCaseENT.id_GradeBase = objvMicroTeachCaseENS.id_GradeBase; //年级流水号
objvMicroTeachCaseENT.GradeBaseName = objvMicroTeachCaseENS.GradeBaseName; //年级名称
objvMicroTeachCaseENT.id_AdminCls = objvMicroTeachCaseENS.id_AdminCls; //行政班流水号
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
public static DataTable ToDataTable(List<clsvMicroTeachCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroTeachCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroTeachCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroTeachCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroTeachCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroTeachCaseEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase");
//if (arrvMicroTeachCaseObjLst_Cache == null)
//{
//arrvMicroTeachCaseObjLst_Cache = await clsvMicroTeachCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName_S);
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
public static List<clsvMicroTeachCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroTeachCaseEN._CurrTabName_S);
List<clsvMicroTeachCaseEN> arrvMicroTeachCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroTeachCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroTeachCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroTeachCase.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_MicroteachCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MicroteachCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroTeachCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroTeachCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroTeachCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroTeachCase.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroTeachCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.IsHaveVideo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCase.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvMicroTeachCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroTeachCase.id_MicroteachCase] = objInFor[convMicroTeachCase.id_MicroteachCase];
objDR[convMicroTeachCase.MicroteachCaseID] = objInFor[convMicroTeachCase.MicroteachCaseID];
objDR[convMicroTeachCase.MicroteachCaseName] = objInFor[convMicroTeachCase.MicroteachCaseName];
objDR[convMicroTeachCase.MicroteachCaseTheme] = objInFor[convMicroTeachCase.MicroteachCaseTheme];
objDR[convMicroTeachCase.MicroteachCaseDate] = objInFor[convMicroTeachCase.MicroteachCaseDate];
objDR[convMicroTeachCase.MicroteachCaseTime] = objInFor[convMicroTeachCase.MicroteachCaseTime];
objDR[convMicroTeachCase.MicroteachCaseDateIn] = objInFor[convMicroTeachCase.MicroteachCaseDateIn];
objDR[convMicroTeachCase.id_StudyLevel] = objInFor[convMicroTeachCase.id_StudyLevel];
objDR[convMicroTeachCase.StudyLevelName] = objInFor[convMicroTeachCase.StudyLevelName];
objDR[convMicroTeachCase.id_TeachingPlan] = objInFor[convMicroTeachCase.id_TeachingPlan];
objDR[convMicroTeachCase.MicroTeachCaseTimeIn] = objInFor[convMicroTeachCase.MicroTeachCaseTimeIn];
objDR[convMicroTeachCase.id_MicroteachCaseType] = objInFor[convMicroTeachCase.id_MicroteachCaseType];
objDR[convMicroTeachCase.MicroteachCaseTypeName] = objInFor[convMicroTeachCase.MicroteachCaseTypeName];
objDR[convMicroTeachCase.Id_CaseType] = objInFor[convMicroTeachCase.Id_CaseType];
objDR[convMicroTeachCase.id_Discipline] = objInFor[convMicroTeachCase.id_Discipline];
objDR[convMicroTeachCase.DisciplineID] = objInFor[convMicroTeachCase.DisciplineID];
objDR[convMicroTeachCase.DisciplineName] = objInFor[convMicroTeachCase.DisciplineName];
objDR[convMicroTeachCase.id_SenateGaugeVersion] = objInFor[convMicroTeachCase.id_SenateGaugeVersion];
objDR[convMicroTeachCase.senateGaugeVersionID] = objInFor[convMicroTeachCase.senateGaugeVersionID];
objDR[convMicroTeachCase.senateGaugeVersionName] = objInFor[convMicroTeachCase.senateGaugeVersionName];
objDR[convMicroTeachCase.senateGaugeVersionTtlScore] = objInFor[convMicroTeachCase.senateGaugeVersionTtlScore];
objDR[convMicroTeachCase.VersionNo] = objInFor[convMicroTeachCase.VersionNo];
objDR[convMicroTeachCase.id_TeachSkill] = objInFor[convMicroTeachCase.id_TeachSkill];
objDR[convMicroTeachCase.TeachSkillID] = objInFor[convMicroTeachCase.TeachSkillID];
objDR[convMicroTeachCase.SkillTypeName] = objInFor[convMicroTeachCase.SkillTypeName];
objDR[convMicroTeachCase.TeachSkillName] = objInFor[convMicroTeachCase.TeachSkillName];
objDR[convMicroTeachCase.TeachSkillTheory] = objInFor[convMicroTeachCase.TeachSkillTheory];
objDR[convMicroTeachCase.TeachSkillOperMethod] = objInFor[convMicroTeachCase.TeachSkillOperMethod];
objDR[convMicroTeachCase.id_SkillType] = objInFor[convMicroTeachCase.id_SkillType];
objDR[convMicroTeachCase.SkillTypeID] = objInFor[convMicroTeachCase.SkillTypeID];
objDR[convMicroTeachCase.CaseLevelId] = objInFor[convMicroTeachCase.CaseLevelId];
objDR[convMicroTeachCase.CaseLevelName] = objInFor[convMicroTeachCase.CaseLevelName];
objDR[convMicroTeachCase.DocFile] = objInFor[convMicroTeachCase.DocFile];
objDR[convMicroTeachCase.IsNeedGeneWord] = objInFor[convMicroTeachCase.IsNeedGeneWord];
objDR[convMicroTeachCase.WordCreateDate] = objInFor[convMicroTeachCase.WordCreateDate];
objDR[convMicroTeachCase.IsVisible] = objInFor[convMicroTeachCase.IsVisible];
objDR[convMicroTeachCase.microteachCaseText] = objInFor[convMicroTeachCase.microteachCaseText];
objDR[convMicroTeachCase.OwnerId] = objInFor[convMicroTeachCase.OwnerId];
objDR[convMicroTeachCase.id_StudentInfo] = objInFor[convMicroTeachCase.id_StudentInfo];
objDR[convMicroTeachCase.StuName] = objInFor[convMicroTeachCase.StuName];
objDR[convMicroTeachCase.StuID] = objInFor[convMicroTeachCase.StuID];
objDR[convMicroTeachCase.PoliticsName] = objInFor[convMicroTeachCase.PoliticsName];
objDR[convMicroTeachCase.SexDesc] = objInFor[convMicroTeachCase.SexDesc];
objDR[convMicroTeachCase.EthnicName] = objInFor[convMicroTeachCase.EthnicName];
objDR[convMicroTeachCase.UniZoneDesc] = objInFor[convMicroTeachCase.UniZoneDesc];
objDR[convMicroTeachCase.StuTypeDesc] = objInFor[convMicroTeachCase.StuTypeDesc];
objDR[convMicroTeachCase.id_XzCollege] = objInFor[convMicroTeachCase.id_XzCollege];
objDR[convMicroTeachCase.CollegeID] = objInFor[convMicroTeachCase.CollegeID];
objDR[convMicroTeachCase.CollegeName] = objInFor[convMicroTeachCase.CollegeName];
objDR[convMicroTeachCase.CollegeNameA] = objInFor[convMicroTeachCase.CollegeNameA];
objDR[convMicroTeachCase.id_XzMajor] = objInFor[convMicroTeachCase.id_XzMajor];
objDR[convMicroTeachCase.MajorName] = objInFor[convMicroTeachCase.MajorName];
objDR[convMicroTeachCase.id_GradeBase] = objInFor[convMicroTeachCase.id_GradeBase];
objDR[convMicroTeachCase.GradeBaseName] = objInFor[convMicroTeachCase.GradeBaseName];
objDR[convMicroTeachCase.id_AdminCls] = objInFor[convMicroTeachCase.id_AdminCls];
objDR[convMicroTeachCase.AdminClsId] = objInFor[convMicroTeachCase.AdminClsId];
objDR[convMicroTeachCase.AdminClsName] = objInFor[convMicroTeachCase.AdminClsName];
objDR[convMicroTeachCase.Birthday] = objInFor[convMicroTeachCase.Birthday];
objDR[convMicroTeachCase.NativePlace] = objInFor[convMicroTeachCase.NativePlace];
objDR[convMicroTeachCase.Duty] = objInFor[convMicroTeachCase.Duty];
objDR[convMicroTeachCase.IDCardNo] = objInFor[convMicroTeachCase.IDCardNo];
objDR[convMicroTeachCase.StuCardNo] = objInFor[convMicroTeachCase.StuCardNo];
objDR[convMicroTeachCase.LiveAddress] = objInFor[convMicroTeachCase.LiveAddress];
objDR[convMicroTeachCase.HomePhone] = objInFor[convMicroTeachCase.HomePhone];
objDR[convMicroTeachCase.EnrollmentDate] = objInFor[convMicroTeachCase.EnrollmentDate];
objDR[convMicroTeachCase.PostCode] = objInFor[convMicroTeachCase.PostCode];
objDR[convMicroTeachCase.IsDualVideo] = objInFor[convMicroTeachCase.IsDualVideo];
objDR[convMicroTeachCase.UserKindId] = objInFor[convMicroTeachCase.UserKindId];
objDR[convMicroTeachCase.UserKindName] = objInFor[convMicroTeachCase.UserKindName];
objDR[convMicroTeachCase.UserTypeId] = objInFor[convMicroTeachCase.UserTypeId];
objDR[convMicroTeachCase.UserTypeName] = objInFor[convMicroTeachCase.UserTypeName];
objDR[convMicroTeachCase.RecommendedDegreeId] = objInFor[convMicroTeachCase.RecommendedDegreeId];
objDR[convMicroTeachCase.RecommendedDegreeName] = objInFor[convMicroTeachCase.RecommendedDegreeName];
objDR[convMicroTeachCase.ftpFileType] = objInFor[convMicroTeachCase.ftpFileType];
objDR[convMicroTeachCase.VideoUrl] = objInFor[convMicroTeachCase.VideoUrl];
objDR[convMicroTeachCase.VideoPath] = objInFor[convMicroTeachCase.VideoPath];
objDR[convMicroTeachCase.ResErrMsg] = objInFor[convMicroTeachCase.ResErrMsg];
objDR[convMicroTeachCase.Memo] = objInFor[convMicroTeachCase.Memo];
objDR[convMicroTeachCase.IsHaveVideo] = objInFor[convMicroTeachCase.IsHaveVideo];
objDR[convMicroTeachCase.OwnerName] = objInFor[convMicroTeachCase.OwnerName];
objDR[convMicroTeachCase.BrowseCount4Case] = objInFor[convMicroTeachCase.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}