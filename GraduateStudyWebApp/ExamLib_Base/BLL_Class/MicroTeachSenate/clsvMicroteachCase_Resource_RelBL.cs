
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_RelBL
 表名:vMicroteachCase_Resource_Rel(01120370)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsvMicroteachCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelEN GetObj(this K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel myKey)
{
clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = clsvMicroteachCase_Resource_RelBL.vMicroteachCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvMicroteachCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdMicroteachCaseResourceRel(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFuncModuleId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCase_Resource_Rel.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCase_Resource_Rel.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCase_Resource_Rel.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFuncModuleName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCase_Resource_Rel.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdMicroteachCase(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel.IdMicroteachCase);
}
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdMicroteachCase) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel.MicroteachCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase_Resource_Rel.MicroteachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseTheme(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel.MicroteachCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseTime(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel.MicroteachCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroteachCaseDateIn(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel.MicroteachCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdStudyLevel(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroteachCase_Resource_Rel.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroteachCase_Resource_Rel.IdStudyLevel);
}
objvMicroteachCase_Resource_RelEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdStudyLevel) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStudyLevelName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase_Resource_Rel.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdTeachingPlan(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroteachCase_Resource_Rel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroteachCase_Resource_Rel.IdTeachingPlan);
}
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdTeachingPlan) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdCaseType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, convMicroteachCase_Resource_Rel.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convMicroteachCase_Resource_Rel.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convMicroteachCase_Resource_Rel.IdCaseType);
}
objvMicroteachCase_Resource_RelEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdCaseType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdCaseType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdCaseType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdDiscipline(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convMicroteachCase_Resource_Rel.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convMicroteachCase_Resource_Rel.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convMicroteachCase_Resource_Rel.IdDiscipline);
}
objvMicroteachCase_Resource_RelEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdDiscipline) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdDiscipline, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdDiscipline] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetDisciplineID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase_Resource_Rel.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase_Resource_Rel.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetDisciplineName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase_Resource_Rel.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetsenateGaugeVersionID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetsenateGaugeVersionName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase_Resource_Rel.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetVersionNo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdTeachSkill(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convMicroteachCase_Resource_Rel.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convMicroteachCase_Resource_Rel.IdTeachSkill);
}
objvMicroteachCase_Resource_RelEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdTeachSkill) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdTeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdTeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase_Resource_Rel.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase_Resource_Rel.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSkillTypeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase_Resource_Rel.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase_Resource_Rel.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillTheory(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase_Resource_Rel.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetTeachSkillOperMethod(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdSkillType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convMicroteachCase_Resource_Rel.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convMicroteachCase_Resource_Rel.IdSkillType);
}
objvMicroteachCase_Resource_RelEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdSkillType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdSkillType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdSkillType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSkillTypeID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase_Resource_Rel.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase_Resource_Rel.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetCaseLevelId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase_Resource_Rel.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase_Resource_Rel.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetmicroteachCaseText(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase_Resource_Rel.microteachCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetOwnerId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase_Resource_Rel.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convMicroteachCase_Resource_Rel.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convMicroteachCase_Resource_Rel.StuID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetPoliticsName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strPoliticsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convMicroteachCase_Resource_Rel.PoliticsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSexDesc(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convMicroteachCase_Resource_Rel.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetEthnicName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convMicroteachCase_Resource_Rel.EthnicName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUniZoneDesc(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convMicroteachCase_Resource_Rel.UniZoneDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuTypeDesc(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convMicroteachCase_Resource_Rel.StuTypeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdXzCollege(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCase_Resource_Rel.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCase_Resource_Rel.IdXzCollege);
}
objvMicroteachCase_Resource_RelEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdXzCollege) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetCollegeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase_Resource_Rel.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetCollegeNameA(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase_Resource_Rel.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdXzMajor(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convMicroteachCase_Resource_Rel.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convMicroteachCase_Resource_Rel.IdXzMajor);
}
objvMicroteachCase_Resource_RelEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdXzMajor) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdXzMajor, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdXzMajor] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMajorName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMicroteachCase_Resource_Rel.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdGradeBase(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convMicroteachCase_Resource_Rel.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convMicroteachCase_Resource_Rel.IdGradeBase);
}
objvMicroteachCase_Resource_RelEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdGradeBase) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdGradeBase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdGradeBase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetGradeBaseName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMicroteachCase_Resource_Rel.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdAdminCls(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convMicroteachCase_Resource_Rel.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convMicroteachCase_Resource_Rel.IdAdminCls);
}
objvMicroteachCase_Resource_RelEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdAdminCls) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdAdminCls, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdAdminCls] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetAdminClsId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convMicroteachCase_Resource_Rel.AdminClsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetAdminClsName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convMicroteachCase_Resource_Rel.AdminClsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetBirthday(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convMicroteachCase_Resource_Rel.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convMicroteachCase_Resource_Rel.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetNativePlace(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convMicroteachCase_Resource_Rel.NativePlace);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetDuty(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convMicroteachCase_Resource_Rel.Duty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIDCardNo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIDCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convMicroteachCase_Resource_Rel.IDCardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetStuCardNo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convMicroteachCase_Resource_Rel.StuCardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetLiveAddress(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convMicroteachCase_Resource_Rel.LiveAddress);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetHomePhone(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convMicroteachCase_Resource_Rel.HomePhone);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetEnrollmentDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convMicroteachCase_Resource_Rel.EnrollmentDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetPostCode(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convMicroteachCase_Resource_Rel.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convMicroteachCase_Resource_Rel.PostCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUserTypeId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase_Resource_Rel.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase_Resource_Rel.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetRecommendedDegreeId(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetRecommendedDegreeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase_Resource_Rel.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetBrowseCount4Case(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdResource(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convMicroteachCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convMicroteachCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convMicroteachCase_Resource_Rel.IdResource);
}
objvMicroteachCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdResource) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel.ResourceName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdFtpResource(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convMicroteachCase_Resource_Rel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convMicroteachCase_Resource_Rel.IdFtpResource);
}
objvMicroteachCase_Resource_RelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdFtpResource) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdFtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdFtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFtpResourceID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileOriginalName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileDirName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileRename(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileUpDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileUpTime(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileSize(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceOwner(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdFile(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convMicroteachCase_Resource_Rel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convMicroteachCase_Resource_Rel.IdFile);
}
objvMicroteachCase_Resource_RelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdFile) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSaveDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetSaveTime(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileOriginName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdResourceType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convMicroteachCase_Resource_Rel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convMicroteachCase_Resource_Rel.IdResourceType);
}
objvMicroteachCase_Resource_RelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdResourceType) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceTypeID(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetResourceTypeName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileNewName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetFileOldName(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetftpFileType(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetftpFileSize(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetftpResourceOwner(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIdUsingMode(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convMicroteachCase_Resource_Rel.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convMicroteachCase_Resource_Rel.IdUsingMode);
}
objvMicroteachCase_Resource_RelEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel.IdUsingMode) == false)
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel.IdUsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdUsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetIndexNO(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetBrowseCount(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUpdDate(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetUpdUser(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelEN SetMemo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENS, clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENT)
{
try
{
objvMicroteachCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_RelENT.FuncModuleId = objvMicroteachCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelENT.FuncModuleName = objvMicroteachCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_RelENT.IdMicroteachCase = objvMicroteachCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelENT.MicroteachCaseID = objvMicroteachCase_Resource_RelENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_RelENT.MicroteachCaseName = objvMicroteachCase_Resource_RelENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_RelENT.MicroteachCaseTheme = objvMicroteachCase_Resource_RelENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_RelENT.MicroteachCaseDate = objvMicroteachCase_Resource_RelENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_RelENT.MicroteachCaseTime = objvMicroteachCase_Resource_RelENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_RelENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_RelENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_RelENT.IdStudyLevel = objvMicroteachCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_RelENT.StudyLevelName = objvMicroteachCase_Resource_RelENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_RelENT.IdTeachingPlan = objvMicroteachCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_RelENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_RelENT.IdCaseType = objvMicroteachCase_Resource_RelENS.IdCaseType; //案例类型流水号
objvMicroteachCase_Resource_RelENT.IdDiscipline = objvMicroteachCase_Resource_RelENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_RelENT.DisciplineID = objvMicroteachCase_Resource_RelENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_RelENT.DisciplineName = objvMicroteachCase_Resource_RelENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionID = objvMicroteachCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_RelENT.senateGaugeVersionName = objvMicroteachCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_RelENT.VersionNo = objvMicroteachCase_Resource_RelENS.VersionNo; //版本号
objvMicroteachCase_Resource_RelENT.IdTeachSkill = objvMicroteachCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_RelENT.TeachSkillID = objvMicroteachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_RelENT.SkillTypeName = objvMicroteachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_RelENT.TeachSkillName = objvMicroteachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_RelENT.TeachSkillTheory = objvMicroteachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_RelENT.TeachSkillOperMethod = objvMicroteachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_RelENT.IdSkillType = objvMicroteachCase_Resource_RelENS.IdSkillType; //技能类型流水号
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
objvMicroteachCase_Resource_RelENT.IdXzCollege = objvMicroteachCase_Resource_RelENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_RelENT.CollegeName = objvMicroteachCase_Resource_RelENS.CollegeName; //学院名称
objvMicroteachCase_Resource_RelENT.CollegeNameA = objvMicroteachCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvMicroteachCase_Resource_RelENT.IdXzMajor = objvMicroteachCase_Resource_RelENS.IdXzMajor; //专业流水号
objvMicroteachCase_Resource_RelENT.MajorName = objvMicroteachCase_Resource_RelENS.MajorName; //专业名称
objvMicroteachCase_Resource_RelENT.IdGradeBase = objvMicroteachCase_Resource_RelENS.IdGradeBase; //年级流水号
objvMicroteachCase_Resource_RelENT.GradeBaseName = objvMicroteachCase_Resource_RelENS.GradeBaseName; //年级名称
objvMicroteachCase_Resource_RelENT.IdAdminCls = objvMicroteachCase_Resource_RelENS.IdAdminCls; //行政班流水号
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
objvMicroteachCase_Resource_RelENT.IdResource = objvMicroteachCase_Resource_RelENS.IdResource; //资源流水号
objvMicroteachCase_Resource_RelENT.ResourceID = objvMicroteachCase_Resource_RelENS.ResourceID; //资源ID
objvMicroteachCase_Resource_RelENT.ResourceName = objvMicroteachCase_Resource_RelENS.ResourceName; //资源名称
objvMicroteachCase_Resource_RelENT.SaveMode = objvMicroteachCase_Resource_RelENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_RelENT.IdFtpResource = objvMicroteachCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
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
objvMicroteachCase_Resource_RelENT.IdFile = objvMicroteachCase_Resource_RelENS.IdFile; //文件流水号
objvMicroteachCase_Resource_RelENT.FileName = objvMicroteachCase_Resource_RelENS.FileName; //文件名称
objvMicroteachCase_Resource_RelENT.SaveDate = objvMicroteachCase_Resource_RelENS.SaveDate; //创建日期
objvMicroteachCase_Resource_RelENT.SaveTime = objvMicroteachCase_Resource_RelENS.SaveTime; //创建时间
objvMicroteachCase_Resource_RelENT.FileOriginName = objvMicroteachCase_Resource_RelENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_RelENT.IdResourceType = objvMicroteachCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_RelENT.ResourceTypeID = objvMicroteachCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_RelENT.ResourceTypeName = objvMicroteachCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_RelENT.FileNewName = objvMicroteachCase_Resource_RelENS.FileNewName; //新文件名
objvMicroteachCase_Resource_RelENT.FileOldName = objvMicroteachCase_Resource_RelENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_RelENT.ftpFileType = objvMicroteachCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_RelENT.ftpFileSize = objvMicroteachCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_RelENT.ftpResourceOwner = objvMicroteachCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_RelENT.IsMain = objvMicroteachCase_Resource_RelENS.IsMain; //是否主资源
objvMicroteachCase_Resource_RelENT.IdUsingMode = objvMicroteachCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_RelENT.IsVisible = objvMicroteachCase_Resource_RelENS.IsVisible; //是否显示
objvMicroteachCase_Resource_RelENT.IndexNO = objvMicroteachCase_Resource_RelENS.IndexNO; //序号
objvMicroteachCase_Resource_RelENT.BrowseCount = objvMicroteachCase_Resource_RelENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_RelENT.UpdDate = objvMicroteachCase_Resource_RelENS.UpdDate; //修改日期
objvMicroteachCase_Resource_RelENT.UpdUser = objvMicroteachCase_Resource_RelENS.UpdUser; //修改人
objvMicroteachCase_Resource_RelENT.Memo = objvMicroteachCase_Resource_RelENS.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase_Resource_RelEN:objvMicroteachCase_Resource_RelENT</returns>
 public static clsvMicroteachCase_Resource_RelEN CopyTo(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENS)
{
try
{
 clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENT = new clsvMicroteachCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objvMicroteachCase_Resource_RelENS.FuncModuleId, //功能模块Id
FuncModuleName = objvMicroteachCase_Resource_RelENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvMicroteachCase_Resource_RelENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroteachCase_Resource_RelENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCase_Resource_RelENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroteachCase_Resource_RelENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroteachCase_Resource_RelENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroteachCase_Resource_RelENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroteachCase_Resource_RelENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroteachCase_Resource_RelENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroteachCase_Resource_RelENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroteachCase_Resource_RelENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelENS.MicroTeachCaseTimeIn, //案例入库时间
IdCaseType = objvMicroteachCase_Resource_RelENS.IdCaseType, //案例类型流水号
IdDiscipline = objvMicroteachCase_Resource_RelENS.IdDiscipline, //学科流水号
DisciplineID = objvMicroteachCase_Resource_RelENS.DisciplineID, //学科ID
DisciplineName = objvMicroteachCase_Resource_RelENS.DisciplineName, //学科名称
senateGaugeVersionID = objvMicroteachCase_Resource_RelENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCase_Resource_RelENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvMicroteachCase_Resource_RelENS.VersionNo, //版本号
IdTeachSkill = objvMicroteachCase_Resource_RelENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvMicroteachCase_Resource_RelENS.TeachSkillID, //教学技能ID
SkillTypeName = objvMicroteachCase_Resource_RelENS.SkillTypeName, //技能类型名称
TeachSkillName = objvMicroteachCase_Resource_RelENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvMicroteachCase_Resource_RelENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvMicroteachCase_Resource_RelENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvMicroteachCase_Resource_RelENS.IdSkillType, //技能类型流水号
SkillTypeID = objvMicroteachCase_Resource_RelENS.SkillTypeID, //技能类型ID
CaseLevelId = objvMicroteachCase_Resource_RelENS.CaseLevelId, //课例等级Id
microteachCaseText = objvMicroteachCase_Resource_RelENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroteachCase_Resource_RelENS.OwnerId, //拥有者Id
StuName = objvMicroteachCase_Resource_RelENS.StuName, //姓名
StuID = objvMicroteachCase_Resource_RelENS.StuID, //学号
PoliticsName = objvMicroteachCase_Resource_RelENS.PoliticsName, //政治面貌
SexDesc = objvMicroteachCase_Resource_RelENS.SexDesc, //性别名称
EthnicName = objvMicroteachCase_Resource_RelENS.EthnicName, //民族名称
UniZoneDesc = objvMicroteachCase_Resource_RelENS.UniZoneDesc, //校区名称
StuTypeDesc = objvMicroteachCase_Resource_RelENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvMicroteachCase_Resource_RelENS.IdXzCollege, //学院流水号
CollegeName = objvMicroteachCase_Resource_RelENS.CollegeName, //学院名称
CollegeNameA = objvMicroteachCase_Resource_RelENS.CollegeNameA, //学院名称简写
IdXzMajor = objvMicroteachCase_Resource_RelENS.IdXzMajor, //专业流水号
MajorName = objvMicroteachCase_Resource_RelENS.MajorName, //专业名称
IdGradeBase = objvMicroteachCase_Resource_RelENS.IdGradeBase, //年级流水号
GradeBaseName = objvMicroteachCase_Resource_RelENS.GradeBaseName, //年级名称
IdAdminCls = objvMicroteachCase_Resource_RelENS.IdAdminCls, //行政班流水号
AdminClsId = objvMicroteachCase_Resource_RelENS.AdminClsId, //行政班代号
AdminClsName = objvMicroteachCase_Resource_RelENS.AdminClsName, //行政班名称
Birthday = objvMicroteachCase_Resource_RelENS.Birthday, //出生日期
NativePlace = objvMicroteachCase_Resource_RelENS.NativePlace, //籍贯
Duty = objvMicroteachCase_Resource_RelENS.Duty, //职位
IDCardNo = objvMicroteachCase_Resource_RelENS.IDCardNo, //身份证号
StuCardNo = objvMicroteachCase_Resource_RelENS.StuCardNo, //学生证号
LiveAddress = objvMicroteachCase_Resource_RelENS.LiveAddress, //居住地址
HomePhone = objvMicroteachCase_Resource_RelENS.HomePhone, //住宅电话
EnrollmentDate = objvMicroteachCase_Resource_RelENS.EnrollmentDate, //入校日期
PostCode = objvMicroteachCase_Resource_RelENS.PostCode, //邮编
IsDualVideo = objvMicroteachCase_Resource_RelENS.IsDualVideo, //是否双视频
UserTypeId = objvMicroteachCase_Resource_RelENS.UserTypeId, //用户类型Id
RecommendedDegreeId = objvMicroteachCase_Resource_RelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvMicroteachCase_Resource_RelENS.RecommendedDegreeName, //推荐度名称
BrowseCount4Case = objvMicroteachCase_Resource_RelENS.BrowseCount4Case, //课例浏览次数
IdResource = objvMicroteachCase_Resource_RelENS.IdResource, //资源流水号
ResourceID = objvMicroteachCase_Resource_RelENS.ResourceID, //资源ID
ResourceName = objvMicroteachCase_Resource_RelENS.ResourceName, //资源名称
SaveMode = objvMicroteachCase_Resource_RelENS.SaveMode, //文件存放方式
IdFtpResource = objvMicroteachCase_Resource_RelENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvMicroteachCase_Resource_RelENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvMicroteachCase_Resource_RelENS.FileOriginalName, //文件原名
FileDirName = objvMicroteachCase_Resource_RelENS.FileDirName, //文件目录名
FileRename = objvMicroteachCase_Resource_RelENS.FileRename, //文件新名
FileUpDate = objvMicroteachCase_Resource_RelENS.FileUpDate, //创建日期
FileUpTime = objvMicroteachCase_Resource_RelENS.FileUpTime, //创建时间
FileSize = objvMicroteachCase_Resource_RelENS.FileSize, //文件大小
FileType = objvMicroteachCase_Resource_RelENS.FileType, //文件类型
ResourceOwner = objvMicroteachCase_Resource_RelENS.ResourceOwner, //上传者
IsExistFile = objvMicroteachCase_Resource_RelENS.IsExistFile, //是否存在文件
IdFile = objvMicroteachCase_Resource_RelENS.IdFile, //文件流水号
FileName = objvMicroteachCase_Resource_RelENS.FileName, //文件名称
SaveDate = objvMicroteachCase_Resource_RelENS.SaveDate, //创建日期
SaveTime = objvMicroteachCase_Resource_RelENS.SaveTime, //创建时间
FileOriginName = objvMicroteachCase_Resource_RelENS.FileOriginName, //原文件名
IdResourceType = objvMicroteachCase_Resource_RelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvMicroteachCase_Resource_RelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvMicroteachCase_Resource_RelENS.ResourceTypeName, //资源类型名称
FileNewName = objvMicroteachCase_Resource_RelENS.FileNewName, //新文件名
FileOldName = objvMicroteachCase_Resource_RelENS.FileOldName, //旧文件名
ftpFileType = objvMicroteachCase_Resource_RelENS.ftpFileType, //ftp文件类型
ftpFileSize = objvMicroteachCase_Resource_RelENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvMicroteachCase_Resource_RelENS.ftpResourceOwner, //Ftp资源拥有者
IsMain = objvMicroteachCase_Resource_RelENS.IsMain, //是否主资源
IdUsingMode = objvMicroteachCase_Resource_RelENS.IdUsingMode, //资源使用模式流水号
IsVisible = objvMicroteachCase_Resource_RelENS.IsVisible, //是否显示
IndexNO = objvMicroteachCase_Resource_RelENS.IndexNO, //序号
BrowseCount = objvMicroteachCase_Resource_RelENS.BrowseCount, //浏览次数
UpdDate = objvMicroteachCase_Resource_RelENS.UpdDate, //修改日期
UpdUser = objvMicroteachCase_Resource_RelENS.UpdUser, //修改人
Memo = objvMicroteachCase_Resource_RelENS.Memo, //备注
};
 return objvMicroteachCase_Resource_RelENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
 clsvMicroteachCase_Resource_RelBL.vMicroteachCase_Resource_RelDA.CheckProperty4Condition(objvMicroteachCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, objvMicroteachCase_Resource_RelCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FuncModuleId, objvMicroteachCase_Resource_RelCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FuncModuleName, objvMicroteachCase_Resource_RelCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdMicroteachCase, objvMicroteachCase_Resource_RelCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseID, objvMicroteachCase_Resource_RelCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseName, objvMicroteachCase_Resource_RelCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseTheme, objvMicroteachCase_Resource_RelCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseDate, objvMicroteachCase_Resource_RelCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseTime, objvMicroteachCase_Resource_RelCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroteachCaseDateIn, objvMicroteachCase_Resource_RelCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdStudyLevel, objvMicroteachCase_Resource_RelCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StudyLevelName, objvMicroteachCase_Resource_RelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdTeachingPlan, objvMicroteachCase_Resource_RelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn, objvMicroteachCase_Resource_RelCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdCaseType, objvMicroteachCase_Resource_RelCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdDiscipline, objvMicroteachCase_Resource_RelCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.DisciplineID, objvMicroteachCase_Resource_RelCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.DisciplineName, objvMicroteachCase_Resource_RelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.senateGaugeVersionID, objvMicroteachCase_Resource_RelCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.senateGaugeVersionName, objvMicroteachCase_Resource_RelCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore, objvMicroteachCase_Resource_RelCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOpVersionNo = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.VersionNo, objvMicroteachCase_Resource_RelCond.VersionNo, strComparisonOpVersionNo);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdTeachSkill, objvMicroteachCase_Resource_RelCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillID, objvMicroteachCase_Resource_RelCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SkillTypeName, objvMicroteachCase_Resource_RelCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillName, objvMicroteachCase_Resource_RelCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillTheory, objvMicroteachCase_Resource_RelCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.TeachSkillOperMethod, objvMicroteachCase_Resource_RelCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdSkillType, objvMicroteachCase_Resource_RelCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SkillTypeID, objvMicroteachCase_Resource_RelCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.CaseLevelId, objvMicroteachCase_Resource_RelCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.microteachCaseText, objvMicroteachCase_Resource_RelCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.OwnerId, objvMicroteachCase_Resource_RelCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.StuName) == true)
{
string strComparisonOpStuName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuName, objvMicroteachCase_Resource_RelCond.StuName, strComparisonOpStuName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.StuID) == true)
{
string strComparisonOpStuID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuID, objvMicroteachCase_Resource_RelCond.StuID, strComparisonOpStuID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.PoliticsName, objvMicroteachCase_Resource_RelCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.SexDesc) == true)
{
string strComparisonOpSexDesc = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SexDesc, objvMicroteachCase_Resource_RelCond.SexDesc, strComparisonOpSexDesc);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.EthnicName) == true)
{
string strComparisonOpEthnicName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.EthnicName, objvMicroteachCase_Resource_RelCond.EthnicName, strComparisonOpEthnicName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UniZoneDesc, objvMicroteachCase_Resource_RelCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuTypeDesc, objvMicroteachCase_Resource_RelCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdXzCollege, objvMicroteachCase_Resource_RelCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.CollegeName, objvMicroteachCase_Resource_RelCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.CollegeNameA, objvMicroteachCase_Resource_RelCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdXzMajor, objvMicroteachCase_Resource_RelCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.MajorName) == true)
{
string strComparisonOpMajorName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.MajorName, objvMicroteachCase_Resource_RelCond.MajorName, strComparisonOpMajorName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdGradeBase, objvMicroteachCase_Resource_RelCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.GradeBaseName, objvMicroteachCase_Resource_RelCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdAdminCls, objvMicroteachCase_Resource_RelCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.AdminClsId, objvMicroteachCase_Resource_RelCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.AdminClsName, objvMicroteachCase_Resource_RelCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.Birthday) == true)
{
string strComparisonOpBirthday = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Birthday, objvMicroteachCase_Resource_RelCond.Birthday, strComparisonOpBirthday);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.NativePlace) == true)
{
string strComparisonOpNativePlace = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.NativePlace, objvMicroteachCase_Resource_RelCond.NativePlace, strComparisonOpNativePlace);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.Duty) == true)
{
string strComparisonOpDuty = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Duty, objvMicroteachCase_Resource_RelCond.Duty, strComparisonOpDuty);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IDCardNo) == true)
{
string strComparisonOpIDCardNo = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IDCardNo, objvMicroteachCase_Resource_RelCond.IDCardNo, strComparisonOpIDCardNo);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.StuCardNo, objvMicroteachCase_Resource_RelCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.LiveAddress, objvMicroteachCase_Resource_RelCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.HomePhone) == true)
{
string strComparisonOpHomePhone = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.HomePhone, objvMicroteachCase_Resource_RelCond.HomePhone, strComparisonOpHomePhone);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.EnrollmentDate, objvMicroteachCase_Resource_RelCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.PostCode) == true)
{
string strComparisonOpPostCode = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.PostCode, objvMicroteachCase_Resource_RelCond.PostCode, strComparisonOpPostCode);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IsDualVideo) == true)
{
if (objvMicroteachCase_Resource_RelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsDualVideo);
}
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UserTypeId, objvMicroteachCase_Resource_RelCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.RecommendedDegreeId, objvMicroteachCase_Resource_RelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.RecommendedDegreeName, objvMicroteachCase_Resource_RelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.BrowseCount4Case, objvMicroteachCase_Resource_RelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdResource, objvMicroteachCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOpResourceID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceID, objvMicroteachCase_Resource_RelCond.ResourceID, strComparisonOpResourceID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOpResourceName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceName, objvMicroteachCase_Resource_RelCond.ResourceName, strComparisonOpResourceName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.SaveMode) == true)
{
if (objvMicroteachCase_Resource_RelCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.SaveMode);
}
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdFtpResource, objvMicroteachCase_Resource_RelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FtpResourceID, objvMicroteachCase_Resource_RelCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileOriginalName, objvMicroteachCase_Resource_RelCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOpFileDirName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileDirName, objvMicroteachCase_Resource_RelCond.FileDirName, strComparisonOpFileDirName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileRename) == true)
{
string strComparisonOpFileRename = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileRename, objvMicroteachCase_Resource_RelCond.FileRename, strComparisonOpFileRename);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileUpDate, objvMicroteachCase_Resource_RelCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileUpTime, objvMicroteachCase_Resource_RelCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileSize) == true)
{
string strComparisonOpFileSize = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileSize, objvMicroteachCase_Resource_RelCond.FileSize, strComparisonOpFileSize);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileType) == true)
{
string strComparisonOpFileType = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileType, objvMicroteachCase_Resource_RelCond.FileType, strComparisonOpFileType);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceOwner, objvMicroteachCase_Resource_RelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_RelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsExistFile);
}
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdFile) == true)
{
string strComparisonOpIdFile = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdFile, objvMicroteachCase_Resource_RelCond.IdFile, strComparisonOpIdFile);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileName) == true)
{
string strComparisonOpFileName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileName, objvMicroteachCase_Resource_RelCond.FileName, strComparisonOpFileName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOpSaveDate = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SaveDate, objvMicroteachCase_Resource_RelCond.SaveDate, strComparisonOpSaveDate);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.SaveTime, objvMicroteachCase_Resource_RelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileOriginName, objvMicroteachCase_Resource_RelCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdResourceType, objvMicroteachCase_Resource_RelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceTypeID, objvMicroteachCase_Resource_RelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ResourceTypeName, objvMicroteachCase_Resource_RelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileNewName, objvMicroteachCase_Resource_RelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.FileOldName, objvMicroteachCase_Resource_RelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ftpFileType, objvMicroteachCase_Resource_RelCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ftpFileSize, objvMicroteachCase_Resource_RelCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.ftpResourceOwner, objvMicroteachCase_Resource_RelCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IsMain) == true)
{
if (objvMicroteachCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsMain);
}
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.IdUsingMode, objvMicroteachCase_Resource_RelCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IsVisible) == true)
{
if (objvMicroteachCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel.IsVisible);
}
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.IndexNO, objvMicroteachCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel.BrowseCount, objvMicroteachCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UpdDate, objvMicroteachCase_Resource_RelCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.UpdUser, objvMicroteachCase_Resource_RelCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroteachCase_Resource_RelCond.IsUpdated(convMicroteachCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel.Memo, objvMicroteachCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格案例与资源关系(vMicroteachCase_Resource_Rel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_RelBL
{
public static RelatedActions_vMicroteachCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase_Resource_RelDA vMicroteachCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase_Resource_RelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase_Resource_RelDA.GetDataTable_vMicroteachCase_Resource_Rel(strWhereCond);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseResourceRelLst);
 string strWhereCond = string.Format("IdMicroteachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName);
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Sel =
arrvMicroteachCase_Resource_RelObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvMicroteachCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase_Resource_RelEN> GetSubObjLstCache(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelCond)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel.AttributeName)
{
if (objvMicroteachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelCond[strFldName]));
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
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
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
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
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
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
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = new clsvMicroteachCase_Resource_RelEN();
try
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_RelEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_RelEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_RelEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_RelEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_RelEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_RelEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_RelEN.VersionNo = objRow[convMicroteachCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_RelEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_RelEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_RelEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_RelEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_RelEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_RelEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_RelEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_RelEN.OwnerId = objRow[convMicroteachCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_RelEN.StuName = objRow[convMicroteachCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMicroteachCase_Resource_RelEN.StuID = objRow[convMicroteachCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMicroteachCase_Resource_RelEN.PoliticsName = objRow[convMicroteachCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCase_Resource_RelEN.SexDesc = objRow[convMicroteachCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCase_Resource_RelEN.EthnicName = objRow[convMicroteachCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objRow[convMicroteachCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objRow[convMicroteachCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCase_Resource_RelEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_RelEN.CollegeName = objRow[convMicroteachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_RelEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase_Resource_RelEN.IdXzMajor = objRow[convMicroteachCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCase_Resource_RelEN.MajorName = objRow[convMicroteachCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvMicroteachCase_Resource_RelEN.IdGradeBase = objRow[convMicroteachCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCase_Resource_RelEN.GradeBaseName = objRow[convMicroteachCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCase_Resource_RelEN.IdAdminCls = objRow[convMicroteachCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroteachCase_Resource_RelEN.AdminClsId = objRow[convMicroteachCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvMicroteachCase_Resource_RelEN.AdminClsName = objRow[convMicroteachCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvMicroteachCase_Resource_RelEN.Birthday = objRow[convMicroteachCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvMicroteachCase_Resource_RelEN.NativePlace = objRow[convMicroteachCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCase_Resource_RelEN.Duty = objRow[convMicroteachCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvMicroteachCase_Resource_RelEN.IDCardNo = objRow[convMicroteachCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCase_Resource_RelEN.StuCardNo = objRow[convMicroteachCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCase_Resource_RelEN.LiveAddress = objRow[convMicroteachCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCase_Resource_RelEN.HomePhone = objRow[convMicroteachCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objRow[convMicroteachCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCase_Resource_RelEN.PostCode = objRow[convMicroteachCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvMicroteachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_RelEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_RelEN.IdResource = objRow[convMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_RelEN.ResourceID = objRow[convMicroteachCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_RelEN.ResourceName = objRow[convMicroteachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_RelEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_RelEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_RelEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_RelEN.FileDirName = objRow[convMicroteachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_RelEN.FileRename = objRow[convMicroteachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_RelEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileSize = objRow[convMicroteachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_RelEN.FileType = objRow[convMicroteachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_RelEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_RelEN.IdFile = objRow[convMicroteachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_RelEN.FileName = objRow[convMicroteachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_RelEN.SaveDate = objRow[convMicroteachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_RelEN.SaveTime = objRow[convMicroteachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_RelEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_RelEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_RelEN.FileNewName = objRow[convMicroteachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_RelEN.FileOldName = objRow[convMicroteachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_RelEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_RelEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_RelEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_RelEN.IndexNO = objRow[convMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_RelEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_RelEN.UpdDate = objRow[convMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_RelEN.UpdUser = objRow[convMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_RelEN.Memo = objRow[convMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase_Resource_Rel(ref clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
bool bolResult = vMicroteachCase_Resource_RelDA.GetvMicroteachCase_Resource_Rel(ref objvMicroteachCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = vMicroteachCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvMicroteachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = vMicroteachCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase_Resource_RelEN;
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
public static clsvMicroteachCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = vMicroteachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_RelEN;
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
public static clsvMicroteachCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN = vMicroteachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_RelEN;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvMicroteachCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvMicroteachCase_Resource_RelEN> lstvMicroteachCase_Resource_RelObjLst)
{
foreach (clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN in lstvMicroteachCase_Resource_RelObjLst)
{
if (objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvMicroteachCase_Resource_RelEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdMicroteachCaseResourceRel;
 try
 {
 lngIdMicroteachCaseResourceRel = new clsvMicroteachCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseResourceRel;
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
 arrList = vMicroteachCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vMicroteachCase_Resource_RelDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvMicroteachCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = vMicroteachCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENS, clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelENT)
{
try
{
objvMicroteachCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_RelENT.FuncModuleId = objvMicroteachCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelENT.FuncModuleName = objvMicroteachCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_RelENT.IdMicroteachCase = objvMicroteachCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelENT.MicroteachCaseID = objvMicroteachCase_Resource_RelENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_RelENT.MicroteachCaseName = objvMicroteachCase_Resource_RelENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_RelENT.MicroteachCaseTheme = objvMicroteachCase_Resource_RelENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_RelENT.MicroteachCaseDate = objvMicroteachCase_Resource_RelENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_RelENT.MicroteachCaseTime = objvMicroteachCase_Resource_RelENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_RelENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_RelENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_RelENT.IdStudyLevel = objvMicroteachCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_RelENT.StudyLevelName = objvMicroteachCase_Resource_RelENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_RelENT.IdTeachingPlan = objvMicroteachCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_RelENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_RelENT.IdCaseType = objvMicroteachCase_Resource_RelENS.IdCaseType; //案例类型流水号
objvMicroteachCase_Resource_RelENT.IdDiscipline = objvMicroteachCase_Resource_RelENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_RelENT.DisciplineID = objvMicroteachCase_Resource_RelENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_RelENT.DisciplineName = objvMicroteachCase_Resource_RelENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionID = objvMicroteachCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_RelENT.senateGaugeVersionName = objvMicroteachCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_RelENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_RelENT.VersionNo = objvMicroteachCase_Resource_RelENS.VersionNo; //版本号
objvMicroteachCase_Resource_RelENT.IdTeachSkill = objvMicroteachCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_RelENT.TeachSkillID = objvMicroteachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_RelENT.SkillTypeName = objvMicroteachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_RelENT.TeachSkillName = objvMicroteachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_RelENT.TeachSkillTheory = objvMicroteachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_RelENT.TeachSkillOperMethod = objvMicroteachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_RelENT.IdSkillType = objvMicroteachCase_Resource_RelENS.IdSkillType; //技能类型流水号
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
objvMicroteachCase_Resource_RelENT.IdXzCollege = objvMicroteachCase_Resource_RelENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_RelENT.CollegeName = objvMicroteachCase_Resource_RelENS.CollegeName; //学院名称
objvMicroteachCase_Resource_RelENT.CollegeNameA = objvMicroteachCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvMicroteachCase_Resource_RelENT.IdXzMajor = objvMicroteachCase_Resource_RelENS.IdXzMajor; //专业流水号
objvMicroteachCase_Resource_RelENT.MajorName = objvMicroteachCase_Resource_RelENS.MajorName; //专业名称
objvMicroteachCase_Resource_RelENT.IdGradeBase = objvMicroteachCase_Resource_RelENS.IdGradeBase; //年级流水号
objvMicroteachCase_Resource_RelENT.GradeBaseName = objvMicroteachCase_Resource_RelENS.GradeBaseName; //年级名称
objvMicroteachCase_Resource_RelENT.IdAdminCls = objvMicroteachCase_Resource_RelENS.IdAdminCls; //行政班流水号
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
objvMicroteachCase_Resource_RelENT.IdResource = objvMicroteachCase_Resource_RelENS.IdResource; //资源流水号
objvMicroteachCase_Resource_RelENT.ResourceID = objvMicroteachCase_Resource_RelENS.ResourceID; //资源ID
objvMicroteachCase_Resource_RelENT.ResourceName = objvMicroteachCase_Resource_RelENS.ResourceName; //资源名称
objvMicroteachCase_Resource_RelENT.SaveMode = objvMicroteachCase_Resource_RelENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_RelENT.IdFtpResource = objvMicroteachCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
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
objvMicroteachCase_Resource_RelENT.IdFile = objvMicroteachCase_Resource_RelENS.IdFile; //文件流水号
objvMicroteachCase_Resource_RelENT.FileName = objvMicroteachCase_Resource_RelENS.FileName; //文件名称
objvMicroteachCase_Resource_RelENT.SaveDate = objvMicroteachCase_Resource_RelENS.SaveDate; //创建日期
objvMicroteachCase_Resource_RelENT.SaveTime = objvMicroteachCase_Resource_RelENS.SaveTime; //创建时间
objvMicroteachCase_Resource_RelENT.FileOriginName = objvMicroteachCase_Resource_RelENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_RelENT.IdResourceType = objvMicroteachCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_RelENT.ResourceTypeID = objvMicroteachCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_RelENT.ResourceTypeName = objvMicroteachCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_RelENT.FileNewName = objvMicroteachCase_Resource_RelENS.FileNewName; //新文件名
objvMicroteachCase_Resource_RelENT.FileOldName = objvMicroteachCase_Resource_RelENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_RelENT.ftpFileType = objvMicroteachCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_RelENT.ftpFileSize = objvMicroteachCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_RelENT.ftpResourceOwner = objvMicroteachCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_RelENT.IsMain = objvMicroteachCase_Resource_RelENS.IsMain; //是否主资源
objvMicroteachCase_Resource_RelENT.IdUsingMode = objvMicroteachCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_RelENT.IsVisible = objvMicroteachCase_Resource_RelENS.IsVisible; //是否显示
objvMicroteachCase_Resource_RelENT.IndexNO = objvMicroteachCase_Resource_RelENS.IndexNO; //序号
objvMicroteachCase_Resource_RelENT.BrowseCount = objvMicroteachCase_Resource_RelENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_RelENT.UpdDate = objvMicroteachCase_Resource_RelENS.UpdDate; //修改日期
objvMicroteachCase_Resource_RelENT.UpdUser = objvMicroteachCase_Resource_RelENS.UpdUser; //修改人
objvMicroteachCase_Resource_RelENT.Memo = objvMicroteachCase_Resource_RelENS.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
try
{
objvMicroteachCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FuncModuleId = objvMicroteachCase_Resource_RelEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FuncModuleName = objvMicroteachCase_Resource_RelEN.FuncModuleName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdMicroteachCase = objvMicroteachCase_Resource_RelEN.IdMicroteachCase == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroteachCaseID = objvMicroteachCase_Resource_RelEN.MicroteachCaseID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroteachCaseName = objvMicroteachCase_Resource_RelEN.MicroteachCaseName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = objvMicroteachCase_Resource_RelEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = objvMicroteachCase_Resource_RelEN.MicroteachCaseTime == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdStudyLevel = objvMicroteachCase_Resource_RelEN.IdStudyLevel == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.StudyLevelName = objvMicroteachCase_Resource_RelEN.StudyLevelName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdTeachingPlan = objvMicroteachCase_Resource_RelEN.IdTeachingPlan == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdCaseType = objvMicroteachCase_Resource_RelEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdDiscipline = objvMicroteachCase_Resource_RelEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.DisciplineID = objvMicroteachCase_Resource_RelEN.DisciplineID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.DisciplineName = objvMicroteachCase_Resource_RelEN.DisciplineName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = objvMicroteachCase_Resource_RelEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = objvMicroteachCase_Resource_RelEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_RelEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.VersionNo = objvMicroteachCase_Resource_RelEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdTeachSkill = objvMicroteachCase_Resource_RelEN.IdTeachSkill == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.TeachSkillID = objvMicroteachCase_Resource_RelEN.TeachSkillID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.SkillTypeName = objvMicroteachCase_Resource_RelEN.SkillTypeName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.TeachSkillName = objvMicroteachCase_Resource_RelEN.TeachSkillName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.TeachSkillTheory = objvMicroteachCase_Resource_RelEN.TeachSkillTheory == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdSkillType = objvMicroteachCase_Resource_RelEN.IdSkillType == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.SkillTypeID = objvMicroteachCase_Resource_RelEN.SkillTypeID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.CaseLevelId = objvMicroteachCase_Resource_RelEN.CaseLevelId == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.microteachCaseText = objvMicroteachCase_Resource_RelEN.microteachCaseText == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.OwnerId = objvMicroteachCase_Resource_RelEN.OwnerId == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.StuName = objvMicroteachCase_Resource_RelEN.StuName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.StuName; //姓名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.StuID = objvMicroteachCase_Resource_RelEN.StuID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.StuID; //学号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.PoliticsName = objvMicroteachCase_Resource_RelEN.PoliticsName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.SexDesc = objvMicroteachCase_Resource_RelEN.SexDesc == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.EthnicName = objvMicroteachCase_Resource_RelEN.EthnicName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.UniZoneDesc = objvMicroteachCase_Resource_RelEN.UniZoneDesc == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.StuTypeDesc = objvMicroteachCase_Resource_RelEN.StuTypeDesc == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdXzCollege = objvMicroteachCase_Resource_RelEN.IdXzCollege == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.CollegeName = objvMicroteachCase_Resource_RelEN.CollegeName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.CollegeNameA = objvMicroteachCase_Resource_RelEN.CollegeNameA == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdXzMajor = objvMicroteachCase_Resource_RelEN.IdXzMajor == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.MajorName = objvMicroteachCase_Resource_RelEN.MajorName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdGradeBase = objvMicroteachCase_Resource_RelEN.IdGradeBase == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.GradeBaseName = objvMicroteachCase_Resource_RelEN.GradeBaseName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdAdminCls = objvMicroteachCase_Resource_RelEN.IdAdminCls == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.AdminClsId = objvMicroteachCase_Resource_RelEN.AdminClsId == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.AdminClsName = objvMicroteachCase_Resource_RelEN.AdminClsName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.Birthday = objvMicroteachCase_Resource_RelEN.Birthday == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.NativePlace = objvMicroteachCase_Resource_RelEN.NativePlace == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.Duty = objvMicroteachCase_Resource_RelEN.Duty == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.Duty; //职位
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IDCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IDCardNo = objvMicroteachCase_Resource_RelEN.IDCardNo == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IDCardNo; //身份证号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.StuCardNo = objvMicroteachCase_Resource_RelEN.StuCardNo == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.LiveAddress = objvMicroteachCase_Resource_RelEN.LiveAddress == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.HomePhone = objvMicroteachCase_Resource_RelEN.HomePhone == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.EnrollmentDate = objvMicroteachCase_Resource_RelEN.EnrollmentDate == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.PostCode = objvMicroteachCase_Resource_RelEN.PostCode == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.PostCode; //邮编
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IsDualVideo = objvMicroteachCase_Resource_RelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.UserTypeId = objvMicroteachCase_Resource_RelEN.UserTypeId == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = objvMicroteachCase_Resource_RelEN.RecommendedDegreeId == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = objvMicroteachCase_Resource_RelEN.RecommendedDegreeName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.BrowseCount4Case = objvMicroteachCase_Resource_RelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdResource = objvMicroteachCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ResourceID = objvMicroteachCase_Resource_RelEN.ResourceID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ResourceName = objvMicroteachCase_Resource_RelEN.ResourceName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.SaveMode = objvMicroteachCase_Resource_RelEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdFtpResource = objvMicroteachCase_Resource_RelEN.IdFtpResource == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FtpResourceID = objvMicroteachCase_Resource_RelEN.FtpResourceID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileOriginalName = objvMicroteachCase_Resource_RelEN.FileOriginalName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileDirName = objvMicroteachCase_Resource_RelEN.FileDirName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileRename = objvMicroteachCase_Resource_RelEN.FileRename == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileUpDate = objvMicroteachCase_Resource_RelEN.FileUpDate == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileUpTime = objvMicroteachCase_Resource_RelEN.FileUpTime == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileSize = objvMicroteachCase_Resource_RelEN.FileSize == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileType = objvMicroteachCase_Resource_RelEN.FileType == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileType; //文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ResourceOwner = objvMicroteachCase_Resource_RelEN.ResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IsExistFile = objvMicroteachCase_Resource_RelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdFile = objvMicroteachCase_Resource_RelEN.IdFile == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileName = objvMicroteachCase_Resource_RelEN.FileName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileName; //文件名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.SaveDate = objvMicroteachCase_Resource_RelEN.SaveDate == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.SaveTime = objvMicroteachCase_Resource_RelEN.SaveTime == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileOriginName = objvMicroteachCase_Resource_RelEN.FileOriginName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdResourceType = objvMicroteachCase_Resource_RelEN.IdResourceType == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ResourceTypeID = objvMicroteachCase_Resource_RelEN.ResourceTypeID == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ResourceTypeName = objvMicroteachCase_Resource_RelEN.ResourceTypeName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileNewName = objvMicroteachCase_Resource_RelEN.FileNewName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.FileOldName = objvMicroteachCase_Resource_RelEN.FileOldName == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ftpFileType = objvMicroteachCase_Resource_RelEN.ftpFileType == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ftpFileSize = objvMicroteachCase_Resource_RelEN.ftpFileSize == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.ftpResourceOwner = objvMicroteachCase_Resource_RelEN.ftpResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IsMain = objvMicroteachCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IdUsingMode = objvMicroteachCase_Resource_RelEN.IdUsingMode == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IsVisible = objvMicroteachCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.IndexNO = objvMicroteachCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.BrowseCount = objvMicroteachCase_Resource_RelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.UpdDate = objvMicroteachCase_Resource_RelEN.UpdDate == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.UpdUser = objvMicroteachCase_Resource_RelEN.UpdUser == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelEN.Memo = objvMicroteachCase_Resource_RelEN.Memo == "[null]" ? null :  objvMicroteachCase_Resource_RelEN.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
try
{
if (objvMicroteachCase_Resource_RelEN.FuncModuleName == "[null]") objvMicroteachCase_Resource_RelEN.FuncModuleName = null; //功能模块名称
if (objvMicroteachCase_Resource_RelEN.IdMicroteachCase == "[null]") objvMicroteachCase_Resource_RelEN.IdMicroteachCase = null; //微格教学案例流水号
if (objvMicroteachCase_Resource_RelEN.MicroteachCaseID == "[null]") objvMicroteachCase_Resource_RelEN.MicroteachCaseID = null; //微格教学案例ID
if (objvMicroteachCase_Resource_RelEN.MicroteachCaseName == "[null]") objvMicroteachCase_Resource_RelEN.MicroteachCaseName = null; //微格教学案例名称
if (objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme == "[null]") objvMicroteachCase_Resource_RelEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroteachCase_Resource_RelEN.MicroteachCaseDate == "[null]") objvMicroteachCase_Resource_RelEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCase_Resource_RelEN.MicroteachCaseTime == "[null]") objvMicroteachCase_Resource_RelEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn == "[null]") objvMicroteachCase_Resource_RelEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroteachCase_Resource_RelEN.IdStudyLevel == "[null]") objvMicroteachCase_Resource_RelEN.IdStudyLevel = null; //id_StudyLevel
if (objvMicroteachCase_Resource_RelEN.StudyLevelName == "[null]") objvMicroteachCase_Resource_RelEN.StudyLevelName = null; //学段名称
if (objvMicroteachCase_Resource_RelEN.IdTeachingPlan == "[null]") objvMicroteachCase_Resource_RelEN.IdTeachingPlan = null; //教案流水号
if (objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn == "[null]") objvMicroteachCase_Resource_RelEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroteachCase_Resource_RelEN.DisciplineID == "[null]") objvMicroteachCase_Resource_RelEN.DisciplineID = null; //学科ID
if (objvMicroteachCase_Resource_RelEN.DisciplineName == "[null]") objvMicroteachCase_Resource_RelEN.DisciplineName = null; //学科名称
if (objvMicroteachCase_Resource_RelEN.senateGaugeVersionID == "[null]") objvMicroteachCase_Resource_RelEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCase_Resource_RelEN.senateGaugeVersionName == "[null]") objvMicroteachCase_Resource_RelEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCase_Resource_RelEN.IdTeachSkill == "[null]") objvMicroteachCase_Resource_RelEN.IdTeachSkill = null; //教学技能流水号
if (objvMicroteachCase_Resource_RelEN.TeachSkillID == "[null]") objvMicroteachCase_Resource_RelEN.TeachSkillID = null; //教学技能ID
if (objvMicroteachCase_Resource_RelEN.SkillTypeName == "[null]") objvMicroteachCase_Resource_RelEN.SkillTypeName = null; //技能类型名称
if (objvMicroteachCase_Resource_RelEN.TeachSkillName == "[null]") objvMicroteachCase_Resource_RelEN.TeachSkillName = null; //教学技能名称
if (objvMicroteachCase_Resource_RelEN.TeachSkillTheory == "[null]") objvMicroteachCase_Resource_RelEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod == "[null]") objvMicroteachCase_Resource_RelEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvMicroteachCase_Resource_RelEN.IdSkillType == "[null]") objvMicroteachCase_Resource_RelEN.IdSkillType = null; //技能类型流水号
if (objvMicroteachCase_Resource_RelEN.SkillTypeID == "[null]") objvMicroteachCase_Resource_RelEN.SkillTypeID = null; //技能类型ID
if (objvMicroteachCase_Resource_RelEN.CaseLevelId == "[null]") objvMicroteachCase_Resource_RelEN.CaseLevelId = null; //课例等级Id
if (objvMicroteachCase_Resource_RelEN.microteachCaseText == "[null]") objvMicroteachCase_Resource_RelEN.microteachCaseText = null; //案例文本内容
if (objvMicroteachCase_Resource_RelEN.OwnerId == "[null]") objvMicroteachCase_Resource_RelEN.OwnerId = null; //拥有者Id
if (objvMicroteachCase_Resource_RelEN.StuName == "[null]") objvMicroteachCase_Resource_RelEN.StuName = null; //姓名
if (objvMicroteachCase_Resource_RelEN.StuID == "[null]") objvMicroteachCase_Resource_RelEN.StuID = null; //学号
if (objvMicroteachCase_Resource_RelEN.PoliticsName == "[null]") objvMicroteachCase_Resource_RelEN.PoliticsName = null; //政治面貌
if (objvMicroteachCase_Resource_RelEN.SexDesc == "[null]") objvMicroteachCase_Resource_RelEN.SexDesc = null; //性别名称
if (objvMicroteachCase_Resource_RelEN.EthnicName == "[null]") objvMicroteachCase_Resource_RelEN.EthnicName = null; //民族名称
if (objvMicroteachCase_Resource_RelEN.UniZoneDesc == "[null]") objvMicroteachCase_Resource_RelEN.UniZoneDesc = null; //校区名称
if (objvMicroteachCase_Resource_RelEN.StuTypeDesc == "[null]") objvMicroteachCase_Resource_RelEN.StuTypeDesc = null; //学生类别名称
if (objvMicroteachCase_Resource_RelEN.IdXzCollege == "[null]") objvMicroteachCase_Resource_RelEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCase_Resource_RelEN.CollegeName == "[null]") objvMicroteachCase_Resource_RelEN.CollegeName = null; //学院名称
if (objvMicroteachCase_Resource_RelEN.CollegeNameA == "[null]") objvMicroteachCase_Resource_RelEN.CollegeNameA = null; //学院名称简写
if (objvMicroteachCase_Resource_RelEN.IdXzMajor == "[null]") objvMicroteachCase_Resource_RelEN.IdXzMajor = null; //专业流水号
if (objvMicroteachCase_Resource_RelEN.MajorName == "[null]") objvMicroteachCase_Resource_RelEN.MajorName = null; //专业名称
if (objvMicroteachCase_Resource_RelEN.IdGradeBase == "[null]") objvMicroteachCase_Resource_RelEN.IdGradeBase = null; //年级流水号
if (objvMicroteachCase_Resource_RelEN.GradeBaseName == "[null]") objvMicroteachCase_Resource_RelEN.GradeBaseName = null; //年级名称
if (objvMicroteachCase_Resource_RelEN.IdAdminCls == "[null]") objvMicroteachCase_Resource_RelEN.IdAdminCls = null; //行政班流水号
if (objvMicroteachCase_Resource_RelEN.AdminClsId == "[null]") objvMicroteachCase_Resource_RelEN.AdminClsId = null; //行政班代号
if (objvMicroteachCase_Resource_RelEN.AdminClsName == "[null]") objvMicroteachCase_Resource_RelEN.AdminClsName = null; //行政班名称
if (objvMicroteachCase_Resource_RelEN.Birthday == "[null]") objvMicroteachCase_Resource_RelEN.Birthday = null; //出生日期
if (objvMicroteachCase_Resource_RelEN.NativePlace == "[null]") objvMicroteachCase_Resource_RelEN.NativePlace = null; //籍贯
if (objvMicroteachCase_Resource_RelEN.Duty == "[null]") objvMicroteachCase_Resource_RelEN.Duty = null; //职位
if (objvMicroteachCase_Resource_RelEN.IDCardNo == "[null]") objvMicroteachCase_Resource_RelEN.IDCardNo = null; //身份证号
if (objvMicroteachCase_Resource_RelEN.StuCardNo == "[null]") objvMicroteachCase_Resource_RelEN.StuCardNo = null; //学生证号
if (objvMicroteachCase_Resource_RelEN.LiveAddress == "[null]") objvMicroteachCase_Resource_RelEN.LiveAddress = null; //居住地址
if (objvMicroteachCase_Resource_RelEN.HomePhone == "[null]") objvMicroteachCase_Resource_RelEN.HomePhone = null; //住宅电话
if (objvMicroteachCase_Resource_RelEN.EnrollmentDate == "[null]") objvMicroteachCase_Resource_RelEN.EnrollmentDate = null; //入校日期
if (objvMicroteachCase_Resource_RelEN.PostCode == "[null]") objvMicroteachCase_Resource_RelEN.PostCode = null; //邮编
if (objvMicroteachCase_Resource_RelEN.UserTypeId == "[null]") objvMicroteachCase_Resource_RelEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCase_Resource_RelEN.RecommendedDegreeId == "[null]") objvMicroteachCase_Resource_RelEN.RecommendedDegreeId = null; //推荐度Id
if (objvMicroteachCase_Resource_RelEN.RecommendedDegreeName == "[null]") objvMicroteachCase_Resource_RelEN.RecommendedDegreeName = null; //推荐度名称
if (objvMicroteachCase_Resource_RelEN.ResourceID == "[null]") objvMicroteachCase_Resource_RelEN.ResourceID = null; //资源ID
if (objvMicroteachCase_Resource_RelEN.ResourceName == "[null]") objvMicroteachCase_Resource_RelEN.ResourceName = null; //资源名称
if (objvMicroteachCase_Resource_RelEN.IdFtpResource == "[null]") objvMicroteachCase_Resource_RelEN.IdFtpResource = null; //FTP资源流水号
if (objvMicroteachCase_Resource_RelEN.FtpResourceID == "[null]") objvMicroteachCase_Resource_RelEN.FtpResourceID = null; //FTP资源ID
if (objvMicroteachCase_Resource_RelEN.FileOriginalName == "[null]") objvMicroteachCase_Resource_RelEN.FileOriginalName = null; //文件原名
if (objvMicroteachCase_Resource_RelEN.FileDirName == "[null]") objvMicroteachCase_Resource_RelEN.FileDirName = null; //文件目录名
if (objvMicroteachCase_Resource_RelEN.FileRename == "[null]") objvMicroteachCase_Resource_RelEN.FileRename = null; //文件新名
if (objvMicroteachCase_Resource_RelEN.FileUpDate == "[null]") objvMicroteachCase_Resource_RelEN.FileUpDate = null; //创建日期
if (objvMicroteachCase_Resource_RelEN.FileUpTime == "[null]") objvMicroteachCase_Resource_RelEN.FileUpTime = null; //创建时间
if (objvMicroteachCase_Resource_RelEN.FileSize == "[null]") objvMicroteachCase_Resource_RelEN.FileSize = null; //文件大小
if (objvMicroteachCase_Resource_RelEN.FileType == "[null]") objvMicroteachCase_Resource_RelEN.FileType = null; //文件类型
if (objvMicroteachCase_Resource_RelEN.ResourceOwner == "[null]") objvMicroteachCase_Resource_RelEN.ResourceOwner = null; //上传者
if (objvMicroteachCase_Resource_RelEN.IdFile == "[null]") objvMicroteachCase_Resource_RelEN.IdFile = null; //文件流水号
if (objvMicroteachCase_Resource_RelEN.FileName == "[null]") objvMicroteachCase_Resource_RelEN.FileName = null; //文件名称
if (objvMicroteachCase_Resource_RelEN.SaveDate == "[null]") objvMicroteachCase_Resource_RelEN.SaveDate = null; //创建日期
if (objvMicroteachCase_Resource_RelEN.SaveTime == "[null]") objvMicroteachCase_Resource_RelEN.SaveTime = null; //创建时间
if (objvMicroteachCase_Resource_RelEN.FileOriginName == "[null]") objvMicroteachCase_Resource_RelEN.FileOriginName = null; //原文件名
if (objvMicroteachCase_Resource_RelEN.IdResourceType == "[null]") objvMicroteachCase_Resource_RelEN.IdResourceType = null; //资源类型流水号
if (objvMicroteachCase_Resource_RelEN.ResourceTypeID == "[null]") objvMicroteachCase_Resource_RelEN.ResourceTypeID = null; //资源类型ID
if (objvMicroteachCase_Resource_RelEN.ResourceTypeName == "[null]") objvMicroteachCase_Resource_RelEN.ResourceTypeName = null; //资源类型名称
if (objvMicroteachCase_Resource_RelEN.FileNewName == "[null]") objvMicroteachCase_Resource_RelEN.FileNewName = null; //新文件名
if (objvMicroteachCase_Resource_RelEN.FileOldName == "[null]") objvMicroteachCase_Resource_RelEN.FileOldName = null; //旧文件名
if (objvMicroteachCase_Resource_RelEN.ftpFileType == "[null]") objvMicroteachCase_Resource_RelEN.ftpFileType = null; //ftp文件类型
if (objvMicroteachCase_Resource_RelEN.ftpFileSize == "[null]") objvMicroteachCase_Resource_RelEN.ftpFileSize = null; //ftp文件大小
if (objvMicroteachCase_Resource_RelEN.ftpResourceOwner == "[null]") objvMicroteachCase_Resource_RelEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvMicroteachCase_Resource_RelEN.IdUsingMode == "[null]") objvMicroteachCase_Resource_RelEN.IdUsingMode = null; //资源使用模式流水号
if (objvMicroteachCase_Resource_RelEN.UpdDate == "[null]") objvMicroteachCase_Resource_RelEN.UpdDate = null; //修改日期
if (objvMicroteachCase_Resource_RelEN.UpdUser == "[null]") objvMicroteachCase_Resource_RelEN.UpdUser = null; //修改人
if (objvMicroteachCase_Resource_RelEN.Memo == "[null]") objvMicroteachCase_Resource_RelEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelEN)
{
 vMicroteachCase_Resource_RelDA.CheckProperty4Condition(objvMicroteachCase_Resource_RelEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelBL没有刷新缓存机制(clsMicroteachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseBL没有刷新缓存机制(clsMicroteachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeBL没有刷新缓存机制(clsMicroteachCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvMicroteachCase_Resource_RelObjLstCache == null)
//{
//arrvMicroteachCase_Resource_RelObjLstCache = vMicroteachCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName);
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLst_Sel =
arrvMicroteachCase_Resource_RelObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvMicroteachCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_RelEN obj = clsvMicroteachCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetAllvMicroteachCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName);
List<clsvMicroteachCase_Resource_RelEN> arrvMicroteachCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelEN._CurrTabName);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseResourceRel)
{
if (strInFldName != convMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase_Resource_Rel = clsvMicroteachCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvMicroteachCase_Resource_Rel == null) return "";
return objvMicroteachCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase_Resource_RelEN objvMicroteachCase_Resource_RelCond)
{
List<clsvMicroteachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel.AttributeName)
{
if (objvMicroteachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}