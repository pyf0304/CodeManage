
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseSiteSenateWApi
 表名:vMicroteachCaseSiteSenate(01120457)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:17
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
public static class clsvMicroteachCaseSiteSenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_MicroteachCaseSiteSenate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, long lngid_MicroteachCaseSiteSenate, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.id_MicroteachCaseSiteSenate = lngid_MicroteachCaseSiteSenate; //微格现场评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFuncModuleId(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCaseSiteSenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCaseSiteSenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCaseSiteSenate.FuncModuleId);
objvMicroteachCaseSiteSenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FuncModuleId) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFuncModuleName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCaseSiteSenate.FuncModuleName);
objvMicroteachCaseSiteSenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FuncModuleName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_MicroteachCase(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroteachCaseSiteSenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCaseSiteSenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCaseSiteSenate.id_MicroteachCase);
objvMicroteachCaseSiteSenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_MicroteachCase) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCaseSiteSenate.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCaseSiteSenate.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCaseSiteSenate.MicroteachCaseID);
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCaseSiteSenate.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCaseSiteSenate.MicroteachCaseName);
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseTheme(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCaseSiteSenate.MicroteachCaseTheme);
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseTheme) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCaseSiteSenate.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCaseSiteSenate.MicroteachCaseDate);
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCaseSiteSenate.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCaseSiteSenate.MicroteachCaseTime);
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseDateIn(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseDateIn) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_StudyLevel(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convMicroteachCaseSiteSenate.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroteachCaseSiteSenate.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroteachCaseSiteSenate.id_StudyLevel);
objvMicroteachCaseSiteSenateEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_StudyLevel) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStudyLevelName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convMicroteachCaseSiteSenate.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCaseSiteSenate.StudyLevelName);
objvMicroteachCaseSiteSenateEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StudyLevelName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_TeachingPlan(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convMicroteachCaseSiteSenate.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroteachCaseSiteSenate.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroteachCaseSiteSenate.id_TeachingPlan);
objvMicroteachCaseSiteSenateEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_TeachingPlan) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroTeachCaseTimeIn(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIsVisible(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IsVisible) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetmicroteachCaseText(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCaseSiteSenate.microteachCaseText);
objvMicroteachCaseSiteSenateEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.microteachCaseText) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetOwnerId(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCaseSiteSenate.OwnerId);
objvMicroteachCaseSiteSenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.OwnerId) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convMicroteachCaseSiteSenate.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, convMicroteachCaseSiteSenate.StuName);
objvMicroteachCaseSiteSenateEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, convMicroteachCaseSiteSenate.StuID);
clsCheckSql.CheckFieldLen(strStuID, 20, convMicroteachCaseSiteSenate.StuID);
objvMicroteachCaseSiteSenateEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetPoliticsName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, convMicroteachCaseSiteSenate.PoliticsName);
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convMicroteachCaseSiteSenate.PoliticsName);
objvMicroteachCaseSiteSenateEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.PoliticsName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.PoliticsName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.PoliticsName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSexDesc(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convMicroteachCaseSiteSenate.SexDesc);
objvMicroteachCaseSiteSenateEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SexDesc) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SexDesc, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SexDesc] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetEthnicName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEthnicName, convMicroteachCaseSiteSenate.EthnicName);
clsCheckSql.CheckFieldLen(strEthnicName, 30, convMicroteachCaseSiteSenate.EthnicName);
objvMicroteachCaseSiteSenateEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.EthnicName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.EthnicName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.EthnicName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetUniZoneDesc(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneDesc, convMicroteachCaseSiteSenate.UniZoneDesc);
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convMicroteachCaseSiteSenate.UniZoneDesc);
objvMicroteachCaseSiteSenateEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.UniZoneDesc) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.UniZoneDesc, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.UniZoneDesc] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuTypeDesc(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTypeDesc, convMicroteachCaseSiteSenate.StuTypeDesc);
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convMicroteachCaseSiteSenate.StuTypeDesc);
objvMicroteachCaseSiteSenateEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuTypeDesc) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuTypeDesc, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuTypeDesc] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_XzCollege(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCaseSiteSenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCaseSiteSenate.id_XzCollege);
objvMicroteachCaseSiteSenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_XzCollege) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetCollegeName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convMicroteachCaseSiteSenate.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCaseSiteSenate.CollegeName);
objvMicroteachCaseSiteSenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.CollegeName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_XzMajor(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convMicroteachCaseSiteSenate.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convMicroteachCaseSiteSenate.id_XzMajor);
objvMicroteachCaseSiteSenateEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_XzMajor) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_XzMajor, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_XzMajor] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMajorName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convMicroteachCaseSiteSenate.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convMicroteachCaseSiteSenate.MajorName);
objvMicroteachCaseSiteSenateEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MajorName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MajorName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MajorName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_GradeBase(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_GradeBase, convMicroteachCaseSiteSenate.id_GradeBase);
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convMicroteachCaseSiteSenate.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convMicroteachCaseSiteSenate.id_GradeBase);
objvMicroteachCaseSiteSenateEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_GradeBase) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_GradeBase, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_GradeBase] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetGradeBaseName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMicroteachCaseSiteSenate.GradeBaseName);
objvMicroteachCaseSiteSenateEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.GradeBaseName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.GradeBaseName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.GradeBaseName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetBirthday(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convMicroteachCaseSiteSenate.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convMicroteachCaseSiteSenate.Birthday);
objvMicroteachCaseSiteSenateEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.Birthday) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.Birthday, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.Birthday] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetNativePlace(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convMicroteachCaseSiteSenate.NativePlace);
objvMicroteachCaseSiteSenateEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.NativePlace) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.NativePlace, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.NativePlace] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetDuty(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convMicroteachCaseSiteSenate.Duty);
objvMicroteachCaseSiteSenateEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.Duty) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.Duty, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.Duty] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIDCardNo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convMicroteachCaseSiteSenate.IDCardNo);
objvMicroteachCaseSiteSenateEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IDCardNo) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IDCardNo, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IDCardNo] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetStuCardNo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convMicroteachCaseSiteSenate.StuCardNo);
objvMicroteachCaseSiteSenateEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.StuCardNo) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.StuCardNo, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuCardNo] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetLiveAddress(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convMicroteachCaseSiteSenate.LiveAddress);
objvMicroteachCaseSiteSenateEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.LiveAddress) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.LiveAddress, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.LiveAddress] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetHomePhone(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convMicroteachCaseSiteSenate.HomePhone);
objvMicroteachCaseSiteSenateEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.HomePhone) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.HomePhone, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.HomePhone] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetEnrollmentDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convMicroteachCaseSiteSenate.EnrollmentDate);
objvMicroteachCaseSiteSenateEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.EnrollmentDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.EnrollmentDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.EnrollmentDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetPostCode(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convMicroteachCaseSiteSenate.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convMicroteachCaseSiteSenate.PostCode);
objvMicroteachCaseSiteSenateEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.PostCode) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.PostCode, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.PostCode] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetBrowseCount4Case(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.BrowseCount4Case) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_MicroteachCaseSiteSenateType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_MicroteachCaseSiteSenateType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCaseSiteSenateType, convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType);
clsCheckSql.CheckFieldLen(strid_MicroteachCaseSiteSenateType, 4, convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCaseSiteSenateType, 4, convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType);
objvMicroteachCaseSiteSenateEN.id_MicroteachCaseSiteSenateType = strid_MicroteachCaseSiteSenateType; //微格现场评价类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseSiteSenateTypeID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseSiteSenateTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseSiteSenateTypeID, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
clsCheckSql.CheckFieldLen(strMicroteachCaseSiteSenateTypeID, 4, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseSiteSenateTypeID, 4, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = strMicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMicroteachCaseSiteSenateTypeName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMicroteachCaseSiteSenateTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseSiteSenateTypeName, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
clsCheckSql.CheckFieldLen(strMicroteachCaseSiteSenateTypeName, 50, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = strMicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_Resource(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMicroteachCaseSiteSenate.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMicroteachCaseSiteSenate.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMicroteachCaseSiteSenate.id_Resource);
objvMicroteachCaseSiteSenateEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_Resource) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_Resource, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_Resource] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convMicroteachCaseSiteSenate.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCaseSiteSenate.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCaseSiteSenate.ResourceID);
objvMicroteachCaseSiteSenateEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCaseSiteSenate.ResourceName);
objvMicroteachCaseSiteSenateEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_FtpResource(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMicroteachCaseSiteSenate.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMicroteachCaseSiteSenate.id_FtpResource);
objvMicroteachCaseSiteSenateEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_FtpResource) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_FtpResource, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_FtpResource] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_File(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMicroteachCaseSiteSenate.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMicroteachCaseSiteSenate.id_File);
objvMicroteachCaseSiteSenateEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_File) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_File, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_File] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCaseSiteSenate.FileName);
objvMicroteachCaseSiteSenateEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCaseSiteSenate.FileType);
objvMicroteachCaseSiteSenateEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSaveDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCaseSiteSenate.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCaseSiteSenate.SaveDate);
objvMicroteachCaseSiteSenateEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SaveDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileSize(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCaseSiteSenate.FileSize);
objvMicroteachCaseSiteSenateEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileSize) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileSize, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileSize] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSaveTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCaseSiteSenate.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCaseSiteSenate.SaveTime);
objvMicroteachCaseSiteSenateEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SaveTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFtpResourceID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convMicroteachCaseSiteSenate.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCaseSiteSenate.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCaseSiteSenate.FtpResourceID);
objvMicroteachCaseSiteSenateEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FtpResourceID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileOriginalName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCaseSiteSenate.FileOriginalName);
objvMicroteachCaseSiteSenateEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileOriginalName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileDirName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCaseSiteSenate.FileDirName);
objvMicroteachCaseSiteSenateEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileDirName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileRename(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCaseSiteSenate.FileRename);
objvMicroteachCaseSiteSenateEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileRename) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileRename, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileRename] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileUpDate(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCaseSiteSenate.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCaseSiteSenate.FileUpDate);
objvMicroteachCaseSiteSenateEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileUpDate) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileUpTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCaseSiteSenate.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCaseSiteSenate.FileUpTime);
objvMicroteachCaseSiteSenateEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileUpTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSaveMode(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SaveMode) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN Setid_ResourceType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convMicroteachCaseSiteSenate.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMicroteachCaseSiteSenate.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMicroteachCaseSiteSenate.id_ResourceType);
objvMicroteachCaseSiteSenateEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.id_ResourceType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.id_ResourceType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_ResourceType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceTypeID(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convMicroteachCaseSiteSenate.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCaseSiteSenate.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCaseSiteSenate.ResourceTypeID);
objvMicroteachCaseSiteSenateEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceTypeID) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceTypeName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convMicroteachCaseSiteSenate.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCaseSiteSenate.ResourceTypeName);
objvMicroteachCaseSiteSenateEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceTypeName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetResourceOwner(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convMicroteachCaseSiteSenate.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCaseSiteSenate.ResourceOwner);
objvMicroteachCaseSiteSenateEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ResourceOwner) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetftpFileType(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCaseSiteSenate.ftpFileType);
objvMicroteachCaseSiteSenateEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ftpFileType) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetftpFileSize(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCaseSiteSenate.ftpFileSize);
objvMicroteachCaseSiteSenateEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ftpFileSize) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetftpResourceOwner(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCaseSiteSenate.ftpResourceOwner);
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.ftpResourceOwner) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileOriginName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCaseSiteSenate.FileOriginName);
objvMicroteachCaseSiteSenateEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileOriginName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetIsExistFile(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.IsExistFile) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileNewName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCaseSiteSenate.FileNewName);
objvMicroteachCaseSiteSenateEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileNewName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetFileOldName(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCaseSiteSenate.FileOldName);
objvMicroteachCaseSiteSenateEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.FileOldName) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateSenator(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateSenator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteSenateSenator, 50, convMicroteachCaseSiteSenate.SiteSenateSenator);
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = strSiteSenateSenator; //评议者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateSenator) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateSenator, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateSenator] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateTitle(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteSenateTitle, convMicroteachCaseSiteSenate.SiteSenateTitle);
clsCheckSql.CheckFieldLen(strSiteSenateTitle, 50, convMicroteachCaseSiteSenate.SiteSenateTitle);
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = strSiteSenateTitle; //评议名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateTitle) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateTitle, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTitle] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateContent(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteSenateContent, 2000, convMicroteachCaseSiteSenate.SiteSenateContent);
objvMicroteachCaseSiteSenateEN.SiteSenateContent = strSiteSenateContent; //现场评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateContent) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateContent, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateContent] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateData(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateData, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteSenateData, 8, convMicroteachCaseSiteSenate.SiteSenateData);
clsCheckSql.CheckFieldForeignKey(strSiteSenateData, 8, convMicroteachCaseSiteSenate.SiteSenateData);
objvMicroteachCaseSiteSenateEN.SiteSenateData = strSiteSenateData; //现场评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateData) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateData, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateData] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateTime(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strSiteSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteSenateTime, 6, convMicroteachCaseSiteSenate.SiteSenateTime);
clsCheckSql.CheckFieldForeignKey(strSiteSenateTime, 6, convMicroteachCaseSiteSenate.SiteSenateTime);
objvMicroteachCaseSiteSenateEN.SiteSenateTime = strSiteSenateTime; //现场评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateTime) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateTime, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTime] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetSiteSenateReadCount(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, int intSiteSenateReadCount, string strComparisonOp="")
	{
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = intSiteSenateReadCount; //现场评议阅读次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.SiteSenateReadCount) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.SiteSenateReadCount, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateReadCount] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseSiteSenateEN SetMemo(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCaseSiteSenate.Memo);
objvMicroteachCaseSiteSenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseSiteSenate.Memo) == false)
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(convMicroteachCaseSiteSenate.Memo, strComparisonOp);
}
else
{
objvMicroteachCaseSiteSenateEN.dicFldComparisonOp[convMicroteachCaseSiteSenate.Memo] = strComparisonOp;
}
}
return objvMicroteachCaseSiteSenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate) == true)
{
string strComparisonOp_id_MicroteachCaseSiteSenate = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate, objvMicroteachCaseSiteSenate_Cond.id_MicroteachCaseSiteSenate, strComparisonOp_id_MicroteachCaseSiteSenate);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FuncModuleId, objvMicroteachCaseSiteSenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FuncModuleName, objvMicroteachCaseSiteSenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_MicroteachCase, objvMicroteachCaseSiteSenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseID, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseName, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseTheme, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseDate, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseTime, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseDateIn, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_StudyLevel, objvMicroteachCaseSiteSenate_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StudyLevelName, objvMicroteachCaseSiteSenate_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_TeachingPlan, objvMicroteachCaseSiteSenate_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn, objvMicroteachCaseSiteSenate_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.IsVisible) == true)
{
if (objvMicroteachCaseSiteSenate_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseSiteSenate.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseSiteSenate.IsVisible);
}
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.microteachCaseText, objvMicroteachCaseSiteSenate_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.OwnerId, objvMicroteachCaseSiteSenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.StuName) == true)
{
string strComparisonOp_StuName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuName, objvMicroteachCaseSiteSenate_Cond.StuName, strComparisonOp_StuName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.StuID) == true)
{
string strComparisonOp_StuID = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuID, objvMicroteachCaseSiteSenate_Cond.StuID, strComparisonOp_StuID);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.PoliticsName, objvMicroteachCaseSiteSenate_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SexDesc, objvMicroteachCaseSiteSenate_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.EthnicName, objvMicroteachCaseSiteSenate_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.UniZoneDesc, objvMicroteachCaseSiteSenate_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuTypeDesc, objvMicroteachCaseSiteSenate_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_XzCollege, objvMicroteachCaseSiteSenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.CollegeName, objvMicroteachCaseSiteSenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_XzMajor, objvMicroteachCaseSiteSenate_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MajorName) == true)
{
string strComparisonOp_MajorName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MajorName, objvMicroteachCaseSiteSenate_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_GradeBase, objvMicroteachCaseSiteSenate_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.GradeBaseName, objvMicroteachCaseSiteSenate_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.Birthday) == true)
{
string strComparisonOp_Birthday = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.Birthday, objvMicroteachCaseSiteSenate_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.NativePlace, objvMicroteachCaseSiteSenate_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.Duty) == true)
{
string strComparisonOp_Duty = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.Duty, objvMicroteachCaseSiteSenate_Cond.Duty, strComparisonOp_Duty);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.IDCardNo, objvMicroteachCaseSiteSenate_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.StuCardNo, objvMicroteachCaseSiteSenate_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.LiveAddress, objvMicroteachCaseSiteSenate_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.HomePhone, objvMicroteachCaseSiteSenate_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.EnrollmentDate, objvMicroteachCaseSiteSenate_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.PostCode) == true)
{
string strComparisonOp_PostCode = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.PostCode, objvMicroteachCaseSiteSenate_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseSiteSenate.BrowseCount4Case, objvMicroteachCaseSiteSenate_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType) == true)
{
string strComparisonOp_id_MicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType, objvMicroteachCaseSiteSenate_Cond.id_MicroteachCaseSiteSenateType, strComparisonOp_id_MicroteachCaseSiteSenateType);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID) == true)
{
string strComparisonOp_MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseSiteSenateTypeID, strComparisonOp_MicroteachCaseSiteSenateTypeID);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName) == true)
{
string strComparisonOp_MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName, objvMicroteachCaseSiteSenate_Cond.MicroteachCaseSiteSenateTypeName, strComparisonOp_MicroteachCaseSiteSenateTypeName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_Resource, objvMicroteachCaseSiteSenate_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceID, objvMicroteachCaseSiteSenate_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceName, objvMicroteachCaseSiteSenate_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_FtpResource, objvMicroteachCaseSiteSenate_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_File) == true)
{
string strComparisonOp_id_File = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_File, objvMicroteachCaseSiteSenate_Cond.id_File, strComparisonOp_id_File);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileName) == true)
{
string strComparisonOp_FileName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileName, objvMicroteachCaseSiteSenate_Cond.FileName, strComparisonOp_FileName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileType) == true)
{
string strComparisonOp_FileType = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileType, objvMicroteachCaseSiteSenate_Cond.FileType, strComparisonOp_FileType);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SaveDate, objvMicroteachCaseSiteSenate_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileSize) == true)
{
string strComparisonOp_FileSize = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileSize, objvMicroteachCaseSiteSenate_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SaveTime, objvMicroteachCaseSiteSenate_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FtpResourceID, objvMicroteachCaseSiteSenate_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileOriginalName, objvMicroteachCaseSiteSenate_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileDirName, objvMicroteachCaseSiteSenate_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileRename) == true)
{
string strComparisonOp_FileRename = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileRename, objvMicroteachCaseSiteSenate_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileUpDate, objvMicroteachCaseSiteSenate_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileUpTime, objvMicroteachCaseSiteSenate_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SaveMode) == true)
{
if (objvMicroteachCaseSiteSenate_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseSiteSenate.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseSiteSenate.SaveMode);
}
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.id_ResourceType, objvMicroteachCaseSiteSenate_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceTypeID, objvMicroteachCaseSiteSenate_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceTypeName, objvMicroteachCaseSiteSenate_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ResourceOwner, objvMicroteachCaseSiteSenate_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ftpFileType, objvMicroteachCaseSiteSenate_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ftpFileSize, objvMicroteachCaseSiteSenate_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.ftpResourceOwner, objvMicroteachCaseSiteSenate_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileOriginName, objvMicroteachCaseSiteSenate_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.IsExistFile) == true)
{
if (objvMicroteachCaseSiteSenate_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseSiteSenate.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseSiteSenate.IsExistFile);
}
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileNewName, objvMicroteachCaseSiteSenate_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.FileOldName, objvMicroteachCaseSiteSenate_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateSenator) == true)
{
string strComparisonOp_SiteSenateSenator = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateSenator, objvMicroteachCaseSiteSenate_Cond.SiteSenateSenator, strComparisonOp_SiteSenateSenator);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateTitle) == true)
{
string strComparisonOp_SiteSenateTitle = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateTitle, objvMicroteachCaseSiteSenate_Cond.SiteSenateTitle, strComparisonOp_SiteSenateTitle);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateContent) == true)
{
string strComparisonOp_SiteSenateContent = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateContent, objvMicroteachCaseSiteSenate_Cond.SiteSenateContent, strComparisonOp_SiteSenateContent);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateData) == true)
{
string strComparisonOp_SiteSenateData = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateData];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateData, objvMicroteachCaseSiteSenate_Cond.SiteSenateData, strComparisonOp_SiteSenateData);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateTime) == true)
{
string strComparisonOp_SiteSenateTime = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.SiteSenateTime, objvMicroteachCaseSiteSenate_Cond.SiteSenateTime, strComparisonOp_SiteSenateTime);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.SiteSenateReadCount) == true)
{
string strComparisonOp_SiteSenateReadCount = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.SiteSenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseSiteSenate.SiteSenateReadCount, objvMicroteachCaseSiteSenate_Cond.SiteSenateReadCount, strComparisonOp_SiteSenateReadCount);
}
if (objvMicroteachCaseSiteSenate_Cond.IsUpdated(convMicroteachCaseSiteSenate.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCaseSiteSenate_Cond.dicFldComparisonOp[convMicroteachCaseSiteSenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseSiteSenate.Memo, objvMicroteachCaseSiteSenate_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v微格教学现场评议(vMicroteachCaseSiteSenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseSiteSenateWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCaseSiteSenateApi";

 public clsvMicroteachCaseSiteSenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObjByid_MicroteachCaseSiteSenate(long lngid_MicroteachCaseSiteSenate)
{
string strAction = "GetObjByid_MicroteachCaseSiteSenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCaseSiteSenate"] = lngid_MicroteachCaseSiteSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCaseSiteSenateEN = JsonConvert.DeserializeObject<clsvMicroteachCaseSiteSenateEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseSiteSenateEN;
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
 /// <param name = "lngid_MicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObjByid_MicroteachCaseSiteSenate_WA_Cache(long lngid_MicroteachCaseSiteSenate)
{
string strAction = "GetObjByid_MicroteachCaseSiteSenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCaseSiteSenate"] = lngid_MicroteachCaseSiteSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCaseSiteSenateEN = JsonConvert.DeserializeObject<clsvMicroteachCaseSiteSenateEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseSiteSenateEN;
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
public static clsvMicroteachCaseSiteSenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = null;
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
objvMicroteachCaseSiteSenateEN = JsonConvert.DeserializeObject<clsvMicroteachCaseSiteSenateEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseSiteSenateEN;
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
 /// <param name = "lngid_MicroteachCaseSiteSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseSiteSenateEN GetObjByid_MicroteachCaseSiteSenate_Cache(long lngid_MicroteachCaseSiteSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName_S);
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Sel =
from objvMicroteachCaseSiteSenateEN in arrvMicroteachCaseSiteSenateObjLst_Cache
where objvMicroteachCaseSiteSenateEN.id_MicroteachCaseSiteSenate == lngid_MicroteachCaseSiteSenate
select objvMicroteachCaseSiteSenateEN;
if (arrvMicroteachCaseSiteSenateObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseSiteSenateEN obj = clsvMicroteachCaseSiteSenateWApi.GetObjByid_MicroteachCaseSiteSenate(lngid_MicroteachCaseSiteSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCaseSiteSenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstById_MicroteachCaseSiteSenateLst(List<long> arrId_MicroteachCaseSiteSenate)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseSiteSenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCaseSiteSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachCaseSiteSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroteachCaseSiteSenateEN> GetObjLstById_MicroteachCaseSiteSenateLst_Cache(List<long> arrId_MicroteachCaseSiteSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName_S);
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Sel =
from objvMicroteachCaseSiteSenateEN in arrvMicroteachCaseSiteSenateObjLst_Cache
where arrId_MicroteachCaseSiteSenate.Contains(objvMicroteachCaseSiteSenateEN.id_MicroteachCaseSiteSenate)
select objvMicroteachCaseSiteSenateEN;
return arrvMicroteachCaseSiteSenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstById_MicroteachCaseSiteSenateLst_WA_Cache(List<long> arrId_MicroteachCaseSiteSenate)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseSiteSenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCaseSiteSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCaseSiteSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseSiteSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachCaseSiteSenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCaseSiteSenate"] = lngid_MicroteachCaseSiteSenate.ToString()
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
 /// <param name = "objvMicroteachCaseSiteSenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseSiteSenateENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENS, clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENT)
{
try
{
objvMicroteachCaseSiteSenateENT.id_MicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateENS.id_MicroteachCaseSiteSenate; //微格现场评议流水号
objvMicroteachCaseSiteSenateENT.FuncModuleId = objvMicroteachCaseSiteSenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseSiteSenateENT.FuncModuleName = objvMicroteachCaseSiteSenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseSiteSenateENT.id_MicroteachCase = objvMicroteachCaseSiteSenateENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseID = objvMicroteachCaseSiteSenateENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseName = objvMicroteachCaseSiteSenateENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseSiteSenateENT.MicroteachCaseTheme = objvMicroteachCaseSiteSenateENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCaseSiteSenateENT.MicroteachCaseDate = objvMicroteachCaseSiteSenateENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCaseSiteSenateENT.MicroteachCaseTime = objvMicroteachCaseSiteSenateENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCaseSiteSenateENT.MicroteachCaseDateIn = objvMicroteachCaseSiteSenateENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCaseSiteSenateENT.id_StudyLevel = objvMicroteachCaseSiteSenateENS.id_StudyLevel; //id_StudyLevel
objvMicroteachCaseSiteSenateENT.StudyLevelName = objvMicroteachCaseSiteSenateENS.StudyLevelName; //学段名称
objvMicroteachCaseSiteSenateENT.id_TeachingPlan = objvMicroteachCaseSiteSenateENS.id_TeachingPlan; //教案流水号
objvMicroteachCaseSiteSenateENT.MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCaseSiteSenateENT.IsVisible = objvMicroteachCaseSiteSenateENS.IsVisible; //是否显示
objvMicroteachCaseSiteSenateENT.microteachCaseText = objvMicroteachCaseSiteSenateENS.microteachCaseText; //案例文本内容
objvMicroteachCaseSiteSenateENT.OwnerId = objvMicroteachCaseSiteSenateENS.OwnerId; //拥有者Id
objvMicroteachCaseSiteSenateENT.StuName = objvMicroteachCaseSiteSenateENS.StuName; //姓名
objvMicroteachCaseSiteSenateENT.StuID = objvMicroteachCaseSiteSenateENS.StuID; //学号
objvMicroteachCaseSiteSenateENT.PoliticsName = objvMicroteachCaseSiteSenateENS.PoliticsName; //政治面貌
objvMicroteachCaseSiteSenateENT.SexDesc = objvMicroteachCaseSiteSenateENS.SexDesc; //性别名称
objvMicroteachCaseSiteSenateENT.EthnicName = objvMicroteachCaseSiteSenateENS.EthnicName; //民族名称
objvMicroteachCaseSiteSenateENT.UniZoneDesc = objvMicroteachCaseSiteSenateENS.UniZoneDesc; //校区名称
objvMicroteachCaseSiteSenateENT.StuTypeDesc = objvMicroteachCaseSiteSenateENS.StuTypeDesc; //学生类别名称
objvMicroteachCaseSiteSenateENT.id_XzCollege = objvMicroteachCaseSiteSenateENS.id_XzCollege; //学院流水号
objvMicroteachCaseSiteSenateENT.CollegeName = objvMicroteachCaseSiteSenateENS.CollegeName; //学院名称
objvMicroteachCaseSiteSenateENT.id_XzMajor = objvMicroteachCaseSiteSenateENS.id_XzMajor; //专业流水号
objvMicroteachCaseSiteSenateENT.MajorName = objvMicroteachCaseSiteSenateENS.MajorName; //专业名称
objvMicroteachCaseSiteSenateENT.id_GradeBase = objvMicroteachCaseSiteSenateENS.id_GradeBase; //年级流水号
objvMicroteachCaseSiteSenateENT.GradeBaseName = objvMicroteachCaseSiteSenateENS.GradeBaseName; //年级名称
objvMicroteachCaseSiteSenateENT.Birthday = objvMicroteachCaseSiteSenateENS.Birthday; //出生日期
objvMicroteachCaseSiteSenateENT.NativePlace = objvMicroteachCaseSiteSenateENS.NativePlace; //籍贯
objvMicroteachCaseSiteSenateENT.Duty = objvMicroteachCaseSiteSenateENS.Duty; //职位
objvMicroteachCaseSiteSenateENT.IDCardNo = objvMicroteachCaseSiteSenateENS.IDCardNo; //身份证号
objvMicroteachCaseSiteSenateENT.StuCardNo = objvMicroteachCaseSiteSenateENS.StuCardNo; //学生证号
objvMicroteachCaseSiteSenateENT.LiveAddress = objvMicroteachCaseSiteSenateENS.LiveAddress; //居住地址
objvMicroteachCaseSiteSenateENT.HomePhone = objvMicroteachCaseSiteSenateENS.HomePhone; //住宅电话
objvMicroteachCaseSiteSenateENT.EnrollmentDate = objvMicroteachCaseSiteSenateENS.EnrollmentDate; //入校日期
objvMicroteachCaseSiteSenateENT.PostCode = objvMicroteachCaseSiteSenateENS.PostCode; //邮编
objvMicroteachCaseSiteSenateENT.BrowseCount4Case = objvMicroteachCaseSiteSenateENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCaseSiteSenateENT.id_MicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateENS.id_MicroteachCaseSiteSenateType; //微格现场评价类型流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
objvMicroteachCaseSiteSenateENT.id_Resource = objvMicroteachCaseSiteSenateENS.id_Resource; //资源流水号
objvMicroteachCaseSiteSenateENT.ResourceID = objvMicroteachCaseSiteSenateENS.ResourceID; //资源ID
objvMicroteachCaseSiteSenateENT.ResourceName = objvMicroteachCaseSiteSenateENS.ResourceName; //资源名称
objvMicroteachCaseSiteSenateENT.id_FtpResource = objvMicroteachCaseSiteSenateENS.id_FtpResource; //FTP资源流水号
objvMicroteachCaseSiteSenateENT.id_File = objvMicroteachCaseSiteSenateENS.id_File; //文件流水号
objvMicroteachCaseSiteSenateENT.FileName = objvMicroteachCaseSiteSenateENS.FileName; //文件名称
objvMicroteachCaseSiteSenateENT.FileType = objvMicroteachCaseSiteSenateENS.FileType; //文件类型
objvMicroteachCaseSiteSenateENT.SaveDate = objvMicroteachCaseSiteSenateENS.SaveDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileSize = objvMicroteachCaseSiteSenateENS.FileSize; //文件大小
objvMicroteachCaseSiteSenateENT.SaveTime = objvMicroteachCaseSiteSenateENS.SaveTime; //创建时间
objvMicroteachCaseSiteSenateENT.FtpResourceID = objvMicroteachCaseSiteSenateENS.FtpResourceID; //FTP资源ID
objvMicroteachCaseSiteSenateENT.FileOriginalName = objvMicroteachCaseSiteSenateENS.FileOriginalName; //文件原名
objvMicroteachCaseSiteSenateENT.FileDirName = objvMicroteachCaseSiteSenateENS.FileDirName; //文件目录名
objvMicroteachCaseSiteSenateENT.FileRename = objvMicroteachCaseSiteSenateENS.FileRename; //文件新名
objvMicroteachCaseSiteSenateENT.FileUpDate = objvMicroteachCaseSiteSenateENS.FileUpDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileUpTime = objvMicroteachCaseSiteSenateENS.FileUpTime; //创建时间
objvMicroteachCaseSiteSenateENT.SaveMode = objvMicroteachCaseSiteSenateENS.SaveMode; //文件存放方式
objvMicroteachCaseSiteSenateENT.id_ResourceType = objvMicroteachCaseSiteSenateENS.id_ResourceType; //资源类型流水号
objvMicroteachCaseSiteSenateENT.ResourceTypeID = objvMicroteachCaseSiteSenateENS.ResourceTypeID; //资源类型ID
objvMicroteachCaseSiteSenateENT.ResourceTypeName = objvMicroteachCaseSiteSenateENS.ResourceTypeName; //资源类型名称
objvMicroteachCaseSiteSenateENT.ResourceOwner = objvMicroteachCaseSiteSenateENS.ResourceOwner; //上传者
objvMicroteachCaseSiteSenateENT.ftpFileType = objvMicroteachCaseSiteSenateENS.ftpFileType; //ftp文件类型
objvMicroteachCaseSiteSenateENT.ftpFileSize = objvMicroteachCaseSiteSenateENS.ftpFileSize; //ftp文件大小
objvMicroteachCaseSiteSenateENT.ftpResourceOwner = objvMicroteachCaseSiteSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCaseSiteSenateENT.FileOriginName = objvMicroteachCaseSiteSenateENS.FileOriginName; //原文件名
objvMicroteachCaseSiteSenateENT.IsExistFile = objvMicroteachCaseSiteSenateENS.IsExistFile; //是否存在文件
objvMicroteachCaseSiteSenateENT.FileNewName = objvMicroteachCaseSiteSenateENS.FileNewName; //新文件名
objvMicroteachCaseSiteSenateENT.FileOldName = objvMicroteachCaseSiteSenateENS.FileOldName; //旧文件名
objvMicroteachCaseSiteSenateENT.SiteSenateSenator = objvMicroteachCaseSiteSenateENS.SiteSenateSenator; //评议者
objvMicroteachCaseSiteSenateENT.SiteSenateTitle = objvMicroteachCaseSiteSenateENS.SiteSenateTitle; //评议名称
objvMicroteachCaseSiteSenateENT.SiteSenateContent = objvMicroteachCaseSiteSenateENS.SiteSenateContent; //现场评议内容
objvMicroteachCaseSiteSenateENT.SiteSenateData = objvMicroteachCaseSiteSenateENS.SiteSenateData; //现场评议日期
objvMicroteachCaseSiteSenateENT.SiteSenateTime = objvMicroteachCaseSiteSenateENS.SiteSenateTime; //现场评议时间
objvMicroteachCaseSiteSenateENT.SiteSenateReadCount = objvMicroteachCaseSiteSenateENS.SiteSenateReadCount; //现场评议阅读次数
objvMicroteachCaseSiteSenateENT.Memo = objvMicroteachCaseSiteSenateENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvMicroteachCaseSiteSenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCaseSiteSenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCaseSiteSenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCaseSiteSenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCaseSiteSenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCaseSiteSenateEN.AttributeName)
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
if (clsMicroteachCaseSiteSenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseSiteSenateWApi没有刷新缓存机制(clsMicroteachCaseSiteSenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseSiteSenateTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseSiteSenateTypeWApi没有刷新缓存机制(clsMicroteachCaseSiteSenateTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCaseSiteSenate");
//if (arrvMicroteachCaseSiteSenateObjLst_Cache == null)
//{
//arrvMicroteachCaseSiteSenateObjLst_Cache = await clsvMicroteachCaseSiteSenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName_S);
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
public static List<clsvMicroteachCaseSiteSenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseSiteSenateEN._CurrTabName_S);
List<clsvMicroteachCaseSiteSenateEN> arrvMicroteachCaseSiteSenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseSiteSenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCaseSiteSenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SiteSenateSenator, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SiteSenateTitle, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SiteSenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SiteSenateData, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SiteSenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.SiteSenateReadCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCaseSiteSenate.Memo, Type.GetType("System.String"));
foreach (clsvMicroteachCaseSiteSenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate] = objInFor[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenate];
objDR[convMicroteachCaseSiteSenate.FuncModuleId] = objInFor[convMicroteachCaseSiteSenate.FuncModuleId];
objDR[convMicroteachCaseSiteSenate.FuncModuleName] = objInFor[convMicroteachCaseSiteSenate.FuncModuleName];
objDR[convMicroteachCaseSiteSenate.id_MicroteachCase] = objInFor[convMicroteachCaseSiteSenate.id_MicroteachCase];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseID] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseID];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseName] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseName];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseTheme] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseTheme];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseDate] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseDate];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseTime] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseTime];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseDateIn];
objDR[convMicroteachCaseSiteSenate.id_StudyLevel] = objInFor[convMicroteachCaseSiteSenate.id_StudyLevel];
objDR[convMicroteachCaseSiteSenate.StudyLevelName] = objInFor[convMicroteachCaseSiteSenate.StudyLevelName];
objDR[convMicroteachCaseSiteSenate.id_TeachingPlan] = objInFor[convMicroteachCaseSiteSenate.id_TeachingPlan];
objDR[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] = objInFor[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn];
objDR[convMicroteachCaseSiteSenate.IsVisible] = objInFor[convMicroteachCaseSiteSenate.IsVisible];
objDR[convMicroteachCaseSiteSenate.microteachCaseText] = objInFor[convMicroteachCaseSiteSenate.microteachCaseText];
objDR[convMicroteachCaseSiteSenate.OwnerId] = objInFor[convMicroteachCaseSiteSenate.OwnerId];
objDR[convMicroteachCaseSiteSenate.StuName] = objInFor[convMicroteachCaseSiteSenate.StuName];
objDR[convMicroteachCaseSiteSenate.StuID] = objInFor[convMicroteachCaseSiteSenate.StuID];
objDR[convMicroteachCaseSiteSenate.PoliticsName] = objInFor[convMicroteachCaseSiteSenate.PoliticsName];
objDR[convMicroteachCaseSiteSenate.SexDesc] = objInFor[convMicroteachCaseSiteSenate.SexDesc];
objDR[convMicroteachCaseSiteSenate.EthnicName] = objInFor[convMicroteachCaseSiteSenate.EthnicName];
objDR[convMicroteachCaseSiteSenate.UniZoneDesc] = objInFor[convMicroteachCaseSiteSenate.UniZoneDesc];
objDR[convMicroteachCaseSiteSenate.StuTypeDesc] = objInFor[convMicroteachCaseSiteSenate.StuTypeDesc];
objDR[convMicroteachCaseSiteSenate.id_XzCollege] = objInFor[convMicroteachCaseSiteSenate.id_XzCollege];
objDR[convMicroteachCaseSiteSenate.CollegeName] = objInFor[convMicroteachCaseSiteSenate.CollegeName];
objDR[convMicroteachCaseSiteSenate.id_XzMajor] = objInFor[convMicroteachCaseSiteSenate.id_XzMajor];
objDR[convMicroteachCaseSiteSenate.MajorName] = objInFor[convMicroteachCaseSiteSenate.MajorName];
objDR[convMicroteachCaseSiteSenate.id_GradeBase] = objInFor[convMicroteachCaseSiteSenate.id_GradeBase];
objDR[convMicroteachCaseSiteSenate.GradeBaseName] = objInFor[convMicroteachCaseSiteSenate.GradeBaseName];
objDR[convMicroteachCaseSiteSenate.Birthday] = objInFor[convMicroteachCaseSiteSenate.Birthday];
objDR[convMicroteachCaseSiteSenate.NativePlace] = objInFor[convMicroteachCaseSiteSenate.NativePlace];
objDR[convMicroteachCaseSiteSenate.Duty] = objInFor[convMicroteachCaseSiteSenate.Duty];
objDR[convMicroteachCaseSiteSenate.IDCardNo] = objInFor[convMicroteachCaseSiteSenate.IDCardNo];
objDR[convMicroteachCaseSiteSenate.StuCardNo] = objInFor[convMicroteachCaseSiteSenate.StuCardNo];
objDR[convMicroteachCaseSiteSenate.LiveAddress] = objInFor[convMicroteachCaseSiteSenate.LiveAddress];
objDR[convMicroteachCaseSiteSenate.HomePhone] = objInFor[convMicroteachCaseSiteSenate.HomePhone];
objDR[convMicroteachCaseSiteSenate.EnrollmentDate] = objInFor[convMicroteachCaseSiteSenate.EnrollmentDate];
objDR[convMicroteachCaseSiteSenate.PostCode] = objInFor[convMicroteachCaseSiteSenate.PostCode];
objDR[convMicroteachCaseSiteSenate.BrowseCount4Case] = objInFor[convMicroteachCaseSiteSenate.BrowseCount4Case];
objDR[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType] = objInFor[convMicroteachCaseSiteSenate.id_MicroteachCaseSiteSenateType];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID];
objDR[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName] = objInFor[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName];
objDR[convMicroteachCaseSiteSenate.id_Resource] = objInFor[convMicroteachCaseSiteSenate.id_Resource];
objDR[convMicroteachCaseSiteSenate.ResourceID] = objInFor[convMicroteachCaseSiteSenate.ResourceID];
objDR[convMicroteachCaseSiteSenate.ResourceName] = objInFor[convMicroteachCaseSiteSenate.ResourceName];
objDR[convMicroteachCaseSiteSenate.id_FtpResource] = objInFor[convMicroteachCaseSiteSenate.id_FtpResource];
objDR[convMicroteachCaseSiteSenate.id_File] = objInFor[convMicroteachCaseSiteSenate.id_File];
objDR[convMicroteachCaseSiteSenate.FileName] = objInFor[convMicroteachCaseSiteSenate.FileName];
objDR[convMicroteachCaseSiteSenate.FileType] = objInFor[convMicroteachCaseSiteSenate.FileType];
objDR[convMicroteachCaseSiteSenate.SaveDate] = objInFor[convMicroteachCaseSiteSenate.SaveDate];
objDR[convMicroteachCaseSiteSenate.FileSize] = objInFor[convMicroteachCaseSiteSenate.FileSize];
objDR[convMicroteachCaseSiteSenate.SaveTime] = objInFor[convMicroteachCaseSiteSenate.SaveTime];
objDR[convMicroteachCaseSiteSenate.FtpResourceID] = objInFor[convMicroteachCaseSiteSenate.FtpResourceID];
objDR[convMicroteachCaseSiteSenate.FileOriginalName] = objInFor[convMicroteachCaseSiteSenate.FileOriginalName];
objDR[convMicroteachCaseSiteSenate.FileDirName] = objInFor[convMicroteachCaseSiteSenate.FileDirName];
objDR[convMicroteachCaseSiteSenate.FileRename] = objInFor[convMicroteachCaseSiteSenate.FileRename];
objDR[convMicroteachCaseSiteSenate.FileUpDate] = objInFor[convMicroteachCaseSiteSenate.FileUpDate];
objDR[convMicroteachCaseSiteSenate.FileUpTime] = objInFor[convMicroteachCaseSiteSenate.FileUpTime];
objDR[convMicroteachCaseSiteSenate.SaveMode] = objInFor[convMicroteachCaseSiteSenate.SaveMode];
objDR[convMicroteachCaseSiteSenate.id_ResourceType] = objInFor[convMicroteachCaseSiteSenate.id_ResourceType];
objDR[convMicroteachCaseSiteSenate.ResourceTypeID] = objInFor[convMicroteachCaseSiteSenate.ResourceTypeID];
objDR[convMicroteachCaseSiteSenate.ResourceTypeName] = objInFor[convMicroteachCaseSiteSenate.ResourceTypeName];
objDR[convMicroteachCaseSiteSenate.ResourceOwner] = objInFor[convMicroteachCaseSiteSenate.ResourceOwner];
objDR[convMicroteachCaseSiteSenate.ftpFileType] = objInFor[convMicroteachCaseSiteSenate.ftpFileType];
objDR[convMicroteachCaseSiteSenate.ftpFileSize] = objInFor[convMicroteachCaseSiteSenate.ftpFileSize];
objDR[convMicroteachCaseSiteSenate.ftpResourceOwner] = objInFor[convMicroteachCaseSiteSenate.ftpResourceOwner];
objDR[convMicroteachCaseSiteSenate.FileOriginName] = objInFor[convMicroteachCaseSiteSenate.FileOriginName];
objDR[convMicroteachCaseSiteSenate.IsExistFile] = objInFor[convMicroteachCaseSiteSenate.IsExistFile];
objDR[convMicroteachCaseSiteSenate.FileNewName] = objInFor[convMicroteachCaseSiteSenate.FileNewName];
objDR[convMicroteachCaseSiteSenate.FileOldName] = objInFor[convMicroteachCaseSiteSenate.FileOldName];
objDR[convMicroteachCaseSiteSenate.SiteSenateSenator] = objInFor[convMicroteachCaseSiteSenate.SiteSenateSenator];
objDR[convMicroteachCaseSiteSenate.SiteSenateTitle] = objInFor[convMicroteachCaseSiteSenate.SiteSenateTitle];
objDR[convMicroteachCaseSiteSenate.SiteSenateContent] = objInFor[convMicroteachCaseSiteSenate.SiteSenateContent];
objDR[convMicroteachCaseSiteSenate.SiteSenateData] = objInFor[convMicroteachCaseSiteSenate.SiteSenateData];
objDR[convMicroteachCaseSiteSenate.SiteSenateTime] = objInFor[convMicroteachCaseSiteSenate.SiteSenateTime];
objDR[convMicroteachCaseSiteSenate.SiteSenateReadCount] = objInFor[convMicroteachCaseSiteSenate.SiteSenateReadCount];
objDR[convMicroteachCaseSiteSenate.Memo] = objInFor[convMicroteachCaseSiteSenate.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}