
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_RelWApi
 表名:vMicroteachCase_Resource_Rel(01120370)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:31
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
public static class clsvMicroteachCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFuncModuleId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCase_Resource_Rel.FuncModuleId);
objvMicroteachCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FuncModuleId) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFuncModuleName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCase_Resource_Rel.FuncModuleName);
objvMicroteachCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FuncModuleName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_MicroteachCase(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel.id_MicroteachCase);
objvMicroteachCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_MicroteachCase) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel.MicroteachCaseID);
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroteachCaseID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase_Resource_Rel.MicroteachCaseName);
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroteachCaseName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseTheme(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel.MicroteachCaseTheme);
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroteachCaseTheme) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDate);
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroteachCaseDate) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseTime(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel.MicroteachCaseTime);
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroteachCaseTime) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseDateIn(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDateIn);
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroteachCaseDateIn) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_StudyLevel(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroteachCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroteachCase_Resource_Rel.id_StudyLevel);
objvMicroteachCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_StudyLevel) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStudyLevelName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase_Resource_Rel.StudyLevelName);
objvMicroteachCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.StudyLevelName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_TeachingPlan(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroteachCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroteachCase_Resource_Rel.id_TeachingPlan);
objvMicroteachCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_TeachingPlan) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn);
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetId_CaseType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convMicroteachCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convMicroteachCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convMicroteachCase_Resource_Rel.Id_CaseType);
objvMicroteachCase_Resource_RelEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.Id_CaseType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.Id_CaseType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Id_CaseType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_Discipline(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMicroteachCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMicroteachCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMicroteachCase_Resource_Rel.id_Discipline);
objvMicroteachCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_Discipline) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetDisciplineID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase_Resource_Rel.DisciplineID);
objvMicroteachCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.DisciplineID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetDisciplineName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase_Resource_Rel.DisciplineName);
objvMicroteachCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.DisciplineName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetsenateGaugeVersionID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel.senateGaugeVersionID);
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetsenateGaugeVersionName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase_Resource_Rel.senateGaugeVersionName);
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetVersionNo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.VersionNo) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_TeachSkill(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convMicroteachCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convMicroteachCase_Resource_Rel.id_TeachSkill);
objvMicroteachCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_TeachSkill) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase_Resource_Rel.TeachSkillID);
objvMicroteachCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.TeachSkillID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSkillTypeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase_Resource_Rel.SkillTypeName);
objvMicroteachCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.SkillTypeName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase_Resource_Rel.TeachSkillName);
objvMicroteachCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.TeachSkillName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillTheory(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase_Resource_Rel.TeachSkillTheory);
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.TeachSkillTheory) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillOperMethod(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel.TeachSkillOperMethod);
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_SkillType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convMicroteachCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convMicroteachCase_Resource_Rel.id_SkillType);
objvMicroteachCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_SkillType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSkillTypeID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase_Resource_Rel.SkillTypeID);
objvMicroteachCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.SkillTypeID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetCaseLevelId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase_Resource_Rel.CaseLevelId);
objvMicroteachCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.CaseLevelId) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetmicroteachCaseText(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase_Resource_Rel.microteachCaseText);
objvMicroteachCase_Resource_RelEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.microteachCaseText) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetOwnerId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase_Resource_Rel.OwnerId);
objvMicroteachCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.OwnerId) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convMicroteachCase_Resource_Rel.StuName);
objvMicroteachCase_Resource_RelEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.StuName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.StuName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convMicroteachCase_Resource_Rel.StuID);
objvMicroteachCase_Resource_RelEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.StuID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.StuID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetPoliticsName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convMicroteachCase_Resource_Rel.PoliticsName);
objvMicroteachCase_Resource_RelEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.PoliticsName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.PoliticsName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.PoliticsName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSexDesc(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convMicroteachCase_Resource_Rel.SexDesc);
objvMicroteachCase_Resource_RelEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.SexDesc) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.SexDesc, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SexDesc] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetEthnicName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convMicroteachCase_Resource_Rel.EthnicName);
objvMicroteachCase_Resource_RelEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.EthnicName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.EthnicName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.EthnicName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUniZoneDesc(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convMicroteachCase_Resource_Rel.UniZoneDesc);
objvMicroteachCase_Resource_RelEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.UniZoneDesc) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.UniZoneDesc, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UniZoneDesc] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuTypeDesc(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convMicroteachCase_Resource_Rel.StuTypeDesc);
objvMicroteachCase_Resource_RelEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.StuTypeDesc) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.StuTypeDesc, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuTypeDesc] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_XzCollege(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCase_Resource_Rel.id_XzCollege);
objvMicroteachCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_XzCollege) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetCollegeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase_Resource_Rel.CollegeName);
objvMicroteachCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.CollegeName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetCollegeNameA(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase_Resource_Rel.CollegeNameA);
objvMicroteachCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.CollegeNameA) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_XzMajor(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convMicroteachCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convMicroteachCase_Resource_Rel.id_XzMajor);
objvMicroteachCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_XzMajor) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMajorName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMicroteachCase_Resource_Rel.MajorName);
objvMicroteachCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.MajorName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_GradeBase(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convMicroteachCase_Resource_Rel.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convMicroteachCase_Resource_Rel.id_GradeBase);
objvMicroteachCase_Resource_RelEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_GradeBase) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_GradeBase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_GradeBase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetGradeBaseName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMicroteachCase_Resource_Rel.GradeBaseName);
objvMicroteachCase_Resource_RelEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.GradeBaseName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.GradeBaseName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.GradeBaseName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_AdminCls(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convMicroteachCase_Resource_Rel.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convMicroteachCase_Resource_Rel.id_AdminCls);
objvMicroteachCase_Resource_RelEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_AdminCls) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_AdminCls, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_AdminCls] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetAdminClsId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convMicroteachCase_Resource_Rel.AdminClsId);
objvMicroteachCase_Resource_RelEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.AdminClsId) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.AdminClsId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.AdminClsId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetAdminClsName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convMicroteachCase_Resource_Rel.AdminClsName);
objvMicroteachCase_Resource_RelEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.AdminClsName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.AdminClsName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.AdminClsName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetBirthday(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convMicroteachCase_Resource_Rel.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convMicroteachCase_Resource_Rel.Birthday);
objvMicroteachCase_Resource_RelEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.Birthday) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.Birthday, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Birthday] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetNativePlace(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convMicroteachCase_Resource_Rel.NativePlace);
objvMicroteachCase_Resource_RelEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.NativePlace) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.NativePlace, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.NativePlace] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetDuty(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convMicroteachCase_Resource_Rel.Duty);
objvMicroteachCase_Resource_RelEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.Duty) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.Duty, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Duty] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIDCardNo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convMicroteachCase_Resource_Rel.IDCardNo);
objvMicroteachCase_Resource_RelEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IDCardNo) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IDCardNo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IDCardNo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuCardNo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convMicroteachCase_Resource_Rel.StuCardNo);
objvMicroteachCase_Resource_RelEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.StuCardNo) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.StuCardNo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuCardNo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetLiveAddress(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convMicroteachCase_Resource_Rel.LiveAddress);
objvMicroteachCase_Resource_RelEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.LiveAddress) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.LiveAddress, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.LiveAddress] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetHomePhone(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convMicroteachCase_Resource_Rel.HomePhone);
objvMicroteachCase_Resource_RelEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.HomePhone) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.HomePhone, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.HomePhone] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetEnrollmentDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convMicroteachCase_Resource_Rel.EnrollmentDate);
objvMicroteachCase_Resource_RelEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.EnrollmentDate) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.EnrollmentDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.EnrollmentDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetPostCode(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convMicroteachCase_Resource_Rel.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convMicroteachCase_Resource_Rel.PostCode);
objvMicroteachCase_Resource_RelEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.PostCode) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.PostCode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.PostCode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIsDualVideo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IsDualVideo) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUserTypeId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase_Resource_Rel.UserTypeId);
objvMicroteachCase_Resource_RelEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.UserTypeId) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetRecommendedDegreeId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel.RecommendedDegreeId);
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetRecommendedDegreeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase_Resource_Rel.RecommendedDegreeName);
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetBrowseCount4Case(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.BrowseCount4Case) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_Resource(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMicroteachCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMicroteachCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMicroteachCase_Resource_Rel.id_Resource);
objvMicroteachCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_Resource) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel.ResourceID);
objvMicroteachCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ResourceID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel.ResourceName);
objvMicroteachCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ResourceName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSaveMode(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.SaveMode) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_FtpResource(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMicroteachCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMicroteachCase_Resource_Rel.id_FtpResource);
objvMicroteachCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_FtpResource) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFtpResourceID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel.FtpResourceID);
objvMicroteachCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FtpResourceID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileOriginalName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel.FileOriginalName);
objvMicroteachCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileOriginalName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileDirName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel.FileDirName);
objvMicroteachCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileDirName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileRename(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel.FileRename);
objvMicroteachCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileRename) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileUpDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel.FileUpDate);
objvMicroteachCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileUpDate) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileUpTime(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel.FileUpTime);
objvMicroteachCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileUpTime) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileSize(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel.FileSize);
objvMicroteachCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileSize) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel.FileType);
objvMicroteachCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceOwner(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel.ResourceOwner);
objvMicroteachCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ResourceOwner) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIsExistFile(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IsExistFile) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_File(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMicroteachCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMicroteachCase_Resource_Rel.id_File);
objvMicroteachCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_File) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel.FileName);
objvMicroteachCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSaveDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel.SaveDate);
objvMicroteachCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.SaveDate) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSaveTime(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel.SaveTime);
objvMicroteachCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.SaveTime) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileOriginName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel.FileOriginName);
objvMicroteachCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileOriginName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_ResourceType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMicroteachCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMicroteachCase_Resource_Rel.id_ResourceType);
objvMicroteachCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_ResourceType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceTypeID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel.ResourceTypeID);
objvMicroteachCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ResourceTypeID) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceTypeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel.ResourceTypeName);
objvMicroteachCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ResourceTypeName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileNewName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel.FileNewName);
objvMicroteachCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileNewName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileOldName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel.FileOldName);
objvMicroteachCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.FileOldName) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetftpFileType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel.ftpFileType);
objvMicroteachCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ftpFileType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetftpFileSize(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel.ftpFileSize);
objvMicroteachCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ftpFileSize) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetftpResourceOwner(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel.ftpResourceOwner);
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.ftpResourceOwner) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIsMain(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IsMain) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN Setid_UsingMode(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convMicroteachCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convMicroteachCase_Resource_Rel.id_UsingMode);
objvMicroteachCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.id_UsingMode) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIsVisible(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IsVisible) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIndexNO(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IndexNO) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetBrowseCount(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.BrowseCount) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUpdDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel.UpdDate);
objvMicroteachCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.UpdDate) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUpdUser(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel.UpdUser);
objvMicroteachCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.UpdUser) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMemo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel.Memo);
objvMicroteachCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.Memo) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvMicroteachCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FuncModuleId, objvMicroteachCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FuncModuleName, objvMicroteachCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_MicroteachCase, objvMicroteachCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseID, objvMicroteachCase_Resource_Rel_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseName, objvMicroteachCase_Resource_Rel_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseTheme, objvMicroteachCase_Resource_Rel_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseDate, objvMicroteachCase_Resource_Rel_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseTime, objvMicroteachCase_Resource_Rel_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseDateIn, objvMicroteachCase_Resource_Rel_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_StudyLevel, objvMicroteachCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StudyLevelName, objvMicroteachCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_TeachingPlan, objvMicroteachCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn, objvMicroteachCase_Resource_Rel_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Id_CaseType, objvMicroteachCase_Resource_Rel_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_Discipline, objvMicroteachCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.DisciplineID, objvMicroteachCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.DisciplineName, objvMicroteachCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.senateGaugeVersionID, objvMicroteachCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.senateGaugeVersionName, objvMicroteachCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore, objvMicroteachCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.VersionNo, objvMicroteachCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_TeachSkill, objvMicroteachCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillID, objvMicroteachCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SkillTypeName, objvMicroteachCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillName, objvMicroteachCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillTheory, objvMicroteachCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillOperMethod, objvMicroteachCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_SkillType, objvMicroteachCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SkillTypeID, objvMicroteachCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.CaseLevelId, objvMicroteachCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.microteachCaseText, objvMicroteachCase_Resource_Rel_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.OwnerId, objvMicroteachCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.StuName) == true)
{
string strComparisonOp_StuName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuName, objvMicroteachCase_Resource_Rel_Cond.StuName, strComparisonOp_StuName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.StuID) == true)
{
string strComparisonOp_StuID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuID, objvMicroteachCase_Resource_Rel_Cond.StuID, strComparisonOp_StuID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.PoliticsName, objvMicroteachCase_Resource_Rel_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SexDesc, objvMicroteachCase_Resource_Rel_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.EthnicName, objvMicroteachCase_Resource_Rel_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UniZoneDesc, objvMicroteachCase_Resource_Rel_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuTypeDesc, objvMicroteachCase_Resource_Rel_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_XzCollege, objvMicroteachCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.CollegeName, objvMicroteachCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.CollegeNameA, objvMicroteachCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_XzMajor, objvMicroteachCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MajorName, objvMicroteachCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_GradeBase, objvMicroteachCase_Resource_Rel_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.GradeBaseName, objvMicroteachCase_Resource_Rel_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_AdminCls, objvMicroteachCase_Resource_Rel_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.AdminClsId, objvMicroteachCase_Resource_Rel_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.AdminClsName, objvMicroteachCase_Resource_Rel_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.Birthday) == true)
{
string strComparisonOp_Birthday = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Birthday, objvMicroteachCase_Resource_Rel_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.NativePlace, objvMicroteachCase_Resource_Rel_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.Duty) == true)
{
string strComparisonOp_Duty = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Duty, objvMicroteachCase_Resource_Rel_Cond.Duty, strComparisonOp_Duty);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IDCardNo, objvMicroteachCase_Resource_Rel_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuCardNo, objvMicroteachCase_Resource_Rel_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.LiveAddress, objvMicroteachCase_Resource_Rel_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.HomePhone, objvMicroteachCase_Resource_Rel_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.EnrollmentDate, objvMicroteachCase_Resource_Rel_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.PostCode) == true)
{
string strComparisonOp_PostCode = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.PostCode, objvMicroteachCase_Resource_Rel_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.IsDualVideo) == true)
{
if (objvMicroteachCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsDualVideo);
}
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UserTypeId, objvMicroteachCase_Resource_Rel_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.RecommendedDegreeId, objvMicroteachCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.RecommendedDegreeName, objvMicroteachCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.BrowseCount4Case, objvMicroteachCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_Resource, objvMicroteachCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceID, objvMicroteachCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceName, objvMicroteachCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_FtpResource, objvMicroteachCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FtpResourceID, objvMicroteachCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileOriginalName, objvMicroteachCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileDirName, objvMicroteachCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileRename, objvMicroteachCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileUpDate, objvMicroteachCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileUpTime, objvMicroteachCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileSize, objvMicroteachCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileType, objvMicroteachCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceOwner, objvMicroteachCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_File, objvMicroteachCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileName, objvMicroteachCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SaveDate, objvMicroteachCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SaveTime, objvMicroteachCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileOriginName, objvMicroteachCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_ResourceType, objvMicroteachCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceTypeID, objvMicroteachCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceTypeName, objvMicroteachCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileNewName, objvMicroteachCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileOldName, objvMicroteachCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ftpFileType, objvMicroteachCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ftpFileSize, objvMicroteachCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ftpResourceOwner, objvMicroteachCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.id_UsingMode, objvMicroteachCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.IsVisible) == true)
{
if (objvMicroteachCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsVisible);
}
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.IndexNO, objvMicroteachCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.BrowseCount, objvMicroteachCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UpdDate, objvMicroteachCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UpdUser, objvMicroteachCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroteachCase_Resource_Rel_Cond.IsUpdated(convMicroteachCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCase_Resource_Rel_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Memo, objvMicroteachCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v微格案例与资源关系(vMicroteachCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase_Resource_RelApi";

 public clsvMicroteachCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = null;
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
objvMicroteachCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_RelEN;
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
public static clsvMicroteachCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = null;
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
objvMicroteachCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_RelEN;
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
public static clsvMicroteachCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = null;
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
objvMicroteachCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_RelEN;
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
public static clsvMicroteachCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Sel =
from objvMicroteachCase_Resource_RelEN in arrvMicroteachCase_Resource_RelObjLst_Cache
where objvMicroteachCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvMicroteachCase_Resource_RelEN;
if (arrvMicroteachCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_RelEN obj = clsvMicroteachCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMicroteachCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Sel =
from objvMicroteachCase_Resource_RelEN in arrvMicroteachCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvMicroteachCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvMicroteachCase_Resource_RelEN;
return arrvMicroteachCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMicroteachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENS, clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENT)
{
try
{
objvMicroteachCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvMicroteachCase_Resource_RelENT.FuncModuleId = objvMicroteachCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelENT.FuncModuleName = objvMicroteachCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_RelENT.id_MicroteachCase = objvMicroteachCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelENT.MicroteachCaseID = objvMicroteachCase_Resource_RelENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_RelENT.MicroteachCaseName = objvMicroteachCase_Resource_RelENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_RelENT.MicroteachCaseTheme = objvMicroteachCase_Resource_RelENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_RelENT.MicroteachCaseDate = objvMicroteachCase_Resource_RelENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_RelENT.MicroteachCaseTime = objvMicroteachCase_Resource_RelENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_RelENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_RelENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_RelENT.id_StudyLevel = objvMicroteachCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_RelENT.StudyLevelName = objvMicroteachCase_Resource_RelENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_RelENT.id_TeachingPlan = objvMicroteachCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvMicroteachCase_Resource_RelENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_RelENT.Id_CaseType = objvMicroteachCase_Resource_RelENS.Id_CaseType; //案例类型流水号
objvMicroteachCase_Resource_RelENT.id_Discipline = objvMicroteachCase_Resource_RelENS.id_Discipline; //学科流水号
objvMicroteachCase_Resource_RelENT.DisciplineID = objvMicroteachCase_Resource_RelENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_RelENT.DisciplineName = objvMicroteachCase_Resource_RelENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionID = objvMicroteachCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_RelENT.senateGaugeVersionName = objvMicroteachCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_RelENT.VersionNo = objvMicroteachCase_Resource_RelENS.VersionNo; //版本号
objvMicroteachCase_Resource_RelENT.id_TeachSkill = objvMicroteachCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvMicroteachCase_Resource_RelENT.TeachSkillID = objvMicroteachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_RelENT.SkillTypeName = objvMicroteachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_RelENT.TeachSkillName = objvMicroteachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_RelENT.TeachSkillTheory = objvMicroteachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_RelENT.TeachSkillOperMethod = objvMicroteachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_RelENT.id_SkillType = objvMicroteachCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvMicroteachCase_Resource_RelENT.SkillTypeID = objvMicroteachCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_RelENT.CaseLevelId = objvMicroteachCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_RelENT.microteachCaseText = objvMicroteachCase_Resource_RelENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_RelENT.OwnerId = objvMicroteachCase_Resource_RelENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_RelENT.StuName = objvMicroteachCase_Resource_RelENS.StuName; //姓名
objvMicroteachCase_Resource_RelENT.StuID = objvMicroteachCase_Resource_RelENS.StuID; //学号
objvMicroteachCase_Resource_RelENT.PoliticsName = objvMicroteachCase_Resource_RelENS.PoliticsName; //政治面貌
objvMicroteachCase_Resource_RelENT.SexDesc = objvMicroteachCase_Resource_RelENS.SexDesc; //性别名称
objvMicroteachCase_Resource_RelENT.EthnicName = objvMicroteachCase_Resource_RelENS.EthnicName; //民族名称
objvMicroteachCase_Resource_RelENT.UniZoneDesc = objvMicroteachCase_Resource_RelENS.UniZoneDesc; //校区名称
objvMicroteachCase_Resource_RelENT.StuTypeDesc = objvMicroteachCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvMicroteachCase_Resource_RelENT.id_XzCollege = objvMicroteachCase_Resource_RelENS.id_XzCollege; //学院流水号
objvMicroteachCase_Resource_RelENT.CollegeName = objvMicroteachCase_Resource_RelENS.CollegeName; //学院名称
objvMicroteachCase_Resource_RelENT.CollegeNameA = objvMicroteachCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvMicroteachCase_Resource_RelENT.id_XzMajor = objvMicroteachCase_Resource_RelENS.id_XzMajor; //专业流水号
objvMicroteachCase_Resource_RelENT.MajorName = objvMicroteachCase_Resource_RelENS.MajorName; //专业名称
objvMicroteachCase_Resource_RelENT.id_GradeBase = objvMicroteachCase_Resource_RelENS.id_GradeBase; //年级流水号
objvMicroteachCase_Resource_RelENT.GradeBaseName = objvMicroteachCase_Resource_RelENS.GradeBaseName; //年级名称
objvMicroteachCase_Resource_RelENT.id_AdminCls = objvMicroteachCase_Resource_RelENS.id_AdminCls; //行政班流水号
objvMicroteachCase_Resource_RelENT.AdminClsId = objvMicroteachCase_Resource_RelENS.AdminClsId; //行政班代号
objvMicroteachCase_Resource_RelENT.AdminClsName = objvMicroteachCase_Resource_RelENS.AdminClsName; //行政班名称
objvMicroteachCase_Resource_RelENT.Birthday = objvMicroteachCase_Resource_RelENS.Birthday; //出生日期
objvMicroteachCase_Resource_RelENT.NativePlace = objvMicroteachCase_Resource_RelENS.NativePlace; //籍贯
objvMicroteachCase_Resource_RelENT.Duty = objvMicroteachCase_Resource_RelENS.Duty; //职位
objvMicroteachCase_Resource_RelENT.IDCardNo = objvMicroteachCase_Resource_RelENS.IDCardNo; //身份证号
objvMicroteachCase_Resource_RelENT.StuCardNo = objvMicroteachCase_Resource_RelENS.StuCardNo; //学生证号
objvMicroteachCase_Resource_RelENT.LiveAddress = objvMicroteachCase_Resource_RelENS.LiveAddress; //居住地址
objvMicroteachCase_Resource_RelENT.HomePhone = objvMicroteachCase_Resource_RelENS.HomePhone; //住宅电话
objvMicroteachCase_Resource_RelENT.EnrollmentDate = objvMicroteachCase_Resource_RelENS.EnrollmentDate; //入校日期
objvMicroteachCase_Resource_RelENT.PostCode = objvMicroteachCase_Resource_RelENS.PostCode; //邮编
objvMicroteachCase_Resource_RelENT.IsDualVideo = objvMicroteachCase_Resource_RelENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_RelENT.UserTypeId = objvMicroteachCase_Resource_RelENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_RelENT.RecommendedDegreeId = objvMicroteachCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_RelENT.RecommendedDegreeName = objvMicroteachCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_RelENT.BrowseCount4Case = objvMicroteachCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_RelENT.id_Resource = objvMicroteachCase_Resource_RelENS.id_Resource; //资源流水号
objvMicroteachCase_Resource_RelENT.ResourceID = objvMicroteachCase_Resource_RelENS.ResourceID; //资源ID
objvMicroteachCase_Resource_RelENT.ResourceName = objvMicroteachCase_Resource_RelENS.ResourceName; //资源名称
objvMicroteachCase_Resource_RelENT.SaveMode = objvMicroteachCase_Resource_RelENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_RelENT.id_FtpResource = objvMicroteachCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvMicroteachCase_Resource_RelENT.FtpResourceID = objvMicroteachCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_RelENT.FileOriginalName = objvMicroteachCase_Resource_RelENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_RelENT.FileDirName = objvMicroteachCase_Resource_RelENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_RelENT.FileRename = objvMicroteachCase_Resource_RelENS.FileRename; //文件新名
objvMicroteachCase_Resource_RelENT.FileUpDate = objvMicroteachCase_Resource_RelENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_RelENT.FileUpTime = objvMicroteachCase_Resource_RelENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_RelENT.FileSize = objvMicroteachCase_Resource_RelENS.FileSize; //文件大小
objvMicroteachCase_Resource_RelENT.FileType = objvMicroteachCase_Resource_RelENS.FileType; //文件类型
objvMicroteachCase_Resource_RelENT.ResourceOwner = objvMicroteachCase_Resource_RelENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_RelENT.IsExistFile = objvMicroteachCase_Resource_RelENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_RelENT.id_File = objvMicroteachCase_Resource_RelENS.id_File; //文件流水号
objvMicroteachCase_Resource_RelENT.FileName = objvMicroteachCase_Resource_RelENS.FileName; //文件名称
objvMicroteachCase_Resource_RelENT.SaveDate = objvMicroteachCase_Resource_RelENS.SaveDate; //创建日期
objvMicroteachCase_Resource_RelENT.SaveTime = objvMicroteachCase_Resource_RelENS.SaveTime; //创建时间
objvMicroteachCase_Resource_RelENT.FileOriginName = objvMicroteachCase_Resource_RelENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_RelENT.id_ResourceType = objvMicroteachCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvMicroteachCase_Resource_RelENT.ResourceTypeID = objvMicroteachCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_RelENT.ResourceTypeName = objvMicroteachCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_RelENT.FileNewName = objvMicroteachCase_Resource_RelENS.FileNewName; //新文件名
objvMicroteachCase_Resource_RelENT.FileOldName = objvMicroteachCase_Resource_RelENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_RelENT.ftpFileType = objvMicroteachCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_RelENT.ftpFileSize = objvMicroteachCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_RelENT.ftpResourceOwner = objvMicroteachCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_RelENT.IsMain = objvMicroteachCase_Resource_RelENS.IsMain; //是否主资源
objvMicroteachCase_Resource_RelENT.id_UsingMode = objvMicroteachCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_RelENT.IsVisible = objvMicroteachCase_Resource_RelENS.IsVisible; //是否显示
objvMicroteachCase_Resource_RelENT.IndexNO = objvMicroteachCase_Resource_RelENS.IndexNO; //序号
objvMicroteachCase_Resource_RelENT.BrowseCount = objvMicroteachCase_Resource_RelENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_RelENT.UpdDate = objvMicroteachCase_Resource_RelENS.UpdDate; //修改日期
objvMicroteachCase_Resource_RelENT.UpdUser = objvMicroteachCase_Resource_RelENS.UpdUser; //修改人
objvMicroteachCase_Resource_RelENT.Memo = objvMicroteachCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvMicroteachCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase_Resource_RelEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvMicroteachCase_Resource_RelObjLst_Cache == null)
//{
//arrvMicroteachCase_Resource_RelObjLst_Cache = await clsvMicroteachCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvMicroteachCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convMicroteachCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convMicroteachCase_Resource_Rel.FuncModuleId] = objInFor[convMicroteachCase_Resource_Rel.FuncModuleId];
objDR[convMicroteachCase_Resource_Rel.FuncModuleName] = objInFor[convMicroteachCase_Resource_Rel.FuncModuleName];
objDR[convMicroteachCase_Resource_Rel.id_MicroteachCase] = objInFor[convMicroteachCase_Resource_Rel.id_MicroteachCase];
objDR[convMicroteachCase_Resource_Rel.MicroteachCaseID] = objInFor[convMicroteachCase_Resource_Rel.MicroteachCaseID];
objDR[convMicroteachCase_Resource_Rel.MicroteachCaseName] = objInFor[convMicroteachCase_Resource_Rel.MicroteachCaseName];
objDR[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] = objInFor[convMicroteachCase_Resource_Rel.MicroteachCaseTheme];
objDR[convMicroteachCase_Resource_Rel.MicroteachCaseDate] = objInFor[convMicroteachCase_Resource_Rel.MicroteachCaseDate];
objDR[convMicroteachCase_Resource_Rel.MicroteachCaseTime] = objInFor[convMicroteachCase_Resource_Rel.MicroteachCaseTime];
objDR[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] = objInFor[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn];
objDR[convMicroteachCase_Resource_Rel.id_StudyLevel] = objInFor[convMicroteachCase_Resource_Rel.id_StudyLevel];
objDR[convMicroteachCase_Resource_Rel.StudyLevelName] = objInFor[convMicroteachCase_Resource_Rel.StudyLevelName];
objDR[convMicroteachCase_Resource_Rel.id_TeachingPlan] = objInFor[convMicroteachCase_Resource_Rel.id_TeachingPlan];
objDR[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] = objInFor[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn];
objDR[convMicroteachCase_Resource_Rel.Id_CaseType] = objInFor[convMicroteachCase_Resource_Rel.Id_CaseType];
objDR[convMicroteachCase_Resource_Rel.id_Discipline] = objInFor[convMicroteachCase_Resource_Rel.id_Discipline];
objDR[convMicroteachCase_Resource_Rel.DisciplineID] = objInFor[convMicroteachCase_Resource_Rel.DisciplineID];
objDR[convMicroteachCase_Resource_Rel.DisciplineName] = objInFor[convMicroteachCase_Resource_Rel.DisciplineName];
objDR[convMicroteachCase_Resource_Rel.senateGaugeVersionID] = objInFor[convMicroteachCase_Resource_Rel.senateGaugeVersionID];
objDR[convMicroteachCase_Resource_Rel.senateGaugeVersionName] = objInFor[convMicroteachCase_Resource_Rel.senateGaugeVersionName];
objDR[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convMicroteachCase_Resource_Rel.VersionNo] = objInFor[convMicroteachCase_Resource_Rel.VersionNo];
objDR[convMicroteachCase_Resource_Rel.id_TeachSkill] = objInFor[convMicroteachCase_Resource_Rel.id_TeachSkill];
objDR[convMicroteachCase_Resource_Rel.TeachSkillID] = objInFor[convMicroteachCase_Resource_Rel.TeachSkillID];
objDR[convMicroteachCase_Resource_Rel.SkillTypeName] = objInFor[convMicroteachCase_Resource_Rel.SkillTypeName];
objDR[convMicroteachCase_Resource_Rel.TeachSkillName] = objInFor[convMicroteachCase_Resource_Rel.TeachSkillName];
objDR[convMicroteachCase_Resource_Rel.TeachSkillTheory] = objInFor[convMicroteachCase_Resource_Rel.TeachSkillTheory];
objDR[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convMicroteachCase_Resource_Rel.TeachSkillOperMethod];
objDR[convMicroteachCase_Resource_Rel.id_SkillType] = objInFor[convMicroteachCase_Resource_Rel.id_SkillType];
objDR[convMicroteachCase_Resource_Rel.SkillTypeID] = objInFor[convMicroteachCase_Resource_Rel.SkillTypeID];
objDR[convMicroteachCase_Resource_Rel.CaseLevelId] = objInFor[convMicroteachCase_Resource_Rel.CaseLevelId];
objDR[convMicroteachCase_Resource_Rel.microteachCaseText] = objInFor[convMicroteachCase_Resource_Rel.microteachCaseText];
objDR[convMicroteachCase_Resource_Rel.OwnerId] = objInFor[convMicroteachCase_Resource_Rel.OwnerId];
objDR[convMicroteachCase_Resource_Rel.StuName] = objInFor[convMicroteachCase_Resource_Rel.StuName];
objDR[convMicroteachCase_Resource_Rel.StuID] = objInFor[convMicroteachCase_Resource_Rel.StuID];
objDR[convMicroteachCase_Resource_Rel.PoliticsName] = objInFor[convMicroteachCase_Resource_Rel.PoliticsName];
objDR[convMicroteachCase_Resource_Rel.SexDesc] = objInFor[convMicroteachCase_Resource_Rel.SexDesc];
objDR[convMicroteachCase_Resource_Rel.EthnicName] = objInFor[convMicroteachCase_Resource_Rel.EthnicName];
objDR[convMicroteachCase_Resource_Rel.UniZoneDesc] = objInFor[convMicroteachCase_Resource_Rel.UniZoneDesc];
objDR[convMicroteachCase_Resource_Rel.StuTypeDesc] = objInFor[convMicroteachCase_Resource_Rel.StuTypeDesc];
objDR[convMicroteachCase_Resource_Rel.id_XzCollege] = objInFor[convMicroteachCase_Resource_Rel.id_XzCollege];
objDR[convMicroteachCase_Resource_Rel.CollegeName] = objInFor[convMicroteachCase_Resource_Rel.CollegeName];
objDR[convMicroteachCase_Resource_Rel.CollegeNameA] = objInFor[convMicroteachCase_Resource_Rel.CollegeNameA];
objDR[convMicroteachCase_Resource_Rel.id_XzMajor] = objInFor[convMicroteachCase_Resource_Rel.id_XzMajor];
objDR[convMicroteachCase_Resource_Rel.MajorName] = objInFor[convMicroteachCase_Resource_Rel.MajorName];
objDR[convMicroteachCase_Resource_Rel.id_GradeBase] = objInFor[convMicroteachCase_Resource_Rel.id_GradeBase];
objDR[convMicroteachCase_Resource_Rel.GradeBaseName] = objInFor[convMicroteachCase_Resource_Rel.GradeBaseName];
objDR[convMicroteachCase_Resource_Rel.id_AdminCls] = objInFor[convMicroteachCase_Resource_Rel.id_AdminCls];
objDR[convMicroteachCase_Resource_Rel.AdminClsId] = objInFor[convMicroteachCase_Resource_Rel.AdminClsId];
objDR[convMicroteachCase_Resource_Rel.AdminClsName] = objInFor[convMicroteachCase_Resource_Rel.AdminClsName];
objDR[convMicroteachCase_Resource_Rel.Birthday] = objInFor[convMicroteachCase_Resource_Rel.Birthday];
objDR[convMicroteachCase_Resource_Rel.NativePlace] = objInFor[convMicroteachCase_Resource_Rel.NativePlace];
objDR[convMicroteachCase_Resource_Rel.Duty] = objInFor[convMicroteachCase_Resource_Rel.Duty];
objDR[convMicroteachCase_Resource_Rel.IDCardNo] = objInFor[convMicroteachCase_Resource_Rel.IDCardNo];
objDR[convMicroteachCase_Resource_Rel.StuCardNo] = objInFor[convMicroteachCase_Resource_Rel.StuCardNo];
objDR[convMicroteachCase_Resource_Rel.LiveAddress] = objInFor[convMicroteachCase_Resource_Rel.LiveAddress];
objDR[convMicroteachCase_Resource_Rel.HomePhone] = objInFor[convMicroteachCase_Resource_Rel.HomePhone];
objDR[convMicroteachCase_Resource_Rel.EnrollmentDate] = objInFor[convMicroteachCase_Resource_Rel.EnrollmentDate];
objDR[convMicroteachCase_Resource_Rel.PostCode] = objInFor[convMicroteachCase_Resource_Rel.PostCode];
objDR[convMicroteachCase_Resource_Rel.IsDualVideo] = objInFor[convMicroteachCase_Resource_Rel.IsDualVideo];
objDR[convMicroteachCase_Resource_Rel.UserTypeId] = objInFor[convMicroteachCase_Resource_Rel.UserTypeId];
objDR[convMicroteachCase_Resource_Rel.RecommendedDegreeId] = objInFor[convMicroteachCase_Resource_Rel.RecommendedDegreeId];
objDR[convMicroteachCase_Resource_Rel.RecommendedDegreeName] = objInFor[convMicroteachCase_Resource_Rel.RecommendedDegreeName];
objDR[convMicroteachCase_Resource_Rel.BrowseCount4Case] = objInFor[convMicroteachCase_Resource_Rel.BrowseCount4Case];
objDR[convMicroteachCase_Resource_Rel.id_Resource] = objInFor[convMicroteachCase_Resource_Rel.id_Resource];
objDR[convMicroteachCase_Resource_Rel.ResourceID] = objInFor[convMicroteachCase_Resource_Rel.ResourceID];
objDR[convMicroteachCase_Resource_Rel.ResourceName] = objInFor[convMicroteachCase_Resource_Rel.ResourceName];
objDR[convMicroteachCase_Resource_Rel.SaveMode] = objInFor[convMicroteachCase_Resource_Rel.SaveMode];
objDR[convMicroteachCase_Resource_Rel.id_FtpResource] = objInFor[convMicroteachCase_Resource_Rel.id_FtpResource];
objDR[convMicroteachCase_Resource_Rel.FtpResourceID] = objInFor[convMicroteachCase_Resource_Rel.FtpResourceID];
objDR[convMicroteachCase_Resource_Rel.FileOriginalName] = objInFor[convMicroteachCase_Resource_Rel.FileOriginalName];
objDR[convMicroteachCase_Resource_Rel.FileDirName] = objInFor[convMicroteachCase_Resource_Rel.FileDirName];
objDR[convMicroteachCase_Resource_Rel.FileRename] = objInFor[convMicroteachCase_Resource_Rel.FileRename];
objDR[convMicroteachCase_Resource_Rel.FileUpDate] = objInFor[convMicroteachCase_Resource_Rel.FileUpDate];
objDR[convMicroteachCase_Resource_Rel.FileUpTime] = objInFor[convMicroteachCase_Resource_Rel.FileUpTime];
objDR[convMicroteachCase_Resource_Rel.FileSize] = objInFor[convMicroteachCase_Resource_Rel.FileSize];
objDR[convMicroteachCase_Resource_Rel.FileType] = objInFor[convMicroteachCase_Resource_Rel.FileType];
objDR[convMicroteachCase_Resource_Rel.ResourceOwner] = objInFor[convMicroteachCase_Resource_Rel.ResourceOwner];
objDR[convMicroteachCase_Resource_Rel.IsExistFile] = objInFor[convMicroteachCase_Resource_Rel.IsExistFile];
objDR[convMicroteachCase_Resource_Rel.id_File] = objInFor[convMicroteachCase_Resource_Rel.id_File];
objDR[convMicroteachCase_Resource_Rel.FileName] = objInFor[convMicroteachCase_Resource_Rel.FileName];
objDR[convMicroteachCase_Resource_Rel.SaveDate] = objInFor[convMicroteachCase_Resource_Rel.SaveDate];
objDR[convMicroteachCase_Resource_Rel.SaveTime] = objInFor[convMicroteachCase_Resource_Rel.SaveTime];
objDR[convMicroteachCase_Resource_Rel.FileOriginName] = objInFor[convMicroteachCase_Resource_Rel.FileOriginName];
objDR[convMicroteachCase_Resource_Rel.id_ResourceType] = objInFor[convMicroteachCase_Resource_Rel.id_ResourceType];
objDR[convMicroteachCase_Resource_Rel.ResourceTypeID] = objInFor[convMicroteachCase_Resource_Rel.ResourceTypeID];
objDR[convMicroteachCase_Resource_Rel.ResourceTypeName] = objInFor[convMicroteachCase_Resource_Rel.ResourceTypeName];
objDR[convMicroteachCase_Resource_Rel.FileNewName] = objInFor[convMicroteachCase_Resource_Rel.FileNewName];
objDR[convMicroteachCase_Resource_Rel.FileOldName] = objInFor[convMicroteachCase_Resource_Rel.FileOldName];
objDR[convMicroteachCase_Resource_Rel.ftpFileType] = objInFor[convMicroteachCase_Resource_Rel.ftpFileType];
objDR[convMicroteachCase_Resource_Rel.ftpFileSize] = objInFor[convMicroteachCase_Resource_Rel.ftpFileSize];
objDR[convMicroteachCase_Resource_Rel.ftpResourceOwner] = objInFor[convMicroteachCase_Resource_Rel.ftpResourceOwner];
objDR[convMicroteachCase_Resource_Rel.IsMain] = objInFor[convMicroteachCase_Resource_Rel.IsMain];
objDR[convMicroteachCase_Resource_Rel.id_UsingMode] = objInFor[convMicroteachCase_Resource_Rel.id_UsingMode];
objDR[convMicroteachCase_Resource_Rel.IsVisible] = objInFor[convMicroteachCase_Resource_Rel.IsVisible];
objDR[convMicroteachCase_Resource_Rel.IndexNO] = objInFor[convMicroteachCase_Resource_Rel.IndexNO];
objDR[convMicroteachCase_Resource_Rel.BrowseCount] = objInFor[convMicroteachCase_Resource_Rel.BrowseCount];
objDR[convMicroteachCase_Resource_Rel.UpdDate] = objInFor[convMicroteachCase_Resource_Rel.UpdDate];
objDR[convMicroteachCase_Resource_Rel.UpdUser] = objInFor[convMicroteachCase_Resource_Rel.UpdUser];
objDR[convMicroteachCase_Resource_Rel.Memo] = objInFor[convMicroteachCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}