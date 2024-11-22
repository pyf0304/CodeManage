
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4AllBL
 表名:vMicroteachCase_Resource_Rel4All(01120429)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:34
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
public static class  clsvMicroteachCase_Resource_Rel4AllBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObj(this K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4All myKey)
{
clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = clsvMicroteachCase_Resource_Rel4AllBL.vMicroteachCase_Resource_Rel4AllDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvMicroteachCase_Resource_Rel4AllEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdMicroteachCaseResourceRel(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdMicroteachCase(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
}
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdMicroteachCase) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseTheme(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseTime(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroteachCaseDateIn(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdStudyLevel(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroteachCase_Resource_Rel4All.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroteachCase_Resource_Rel4All.IdStudyLevel);
}
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdStudyLevel) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetStudyLevelName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase_Resource_Rel4All.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdTeachingPlan(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
}
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdTeachingPlan) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdCaseType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convMicroteachCase_Resource_Rel4All.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convMicroteachCase_Resource_Rel4All.IdCaseType);
}
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdCaseType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdCaseType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdCaseType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdDiscipline(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convMicroteachCase_Resource_Rel4All.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convMicroteachCase_Resource_Rel4All.IdDiscipline);
}
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdDiscipline) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdDiscipline, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdDiscipline] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetDisciplineID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase_Resource_Rel4All.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase_Resource_Rel4All.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetDisciplineName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase_Resource_Rel4All.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetsenateGaugeVersionID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetsenateGaugeVersionName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetVersionNo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdTeachSkill(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convMicroteachCase_Resource_Rel4All.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convMicroteachCase_Resource_Rel4All.IdTeachSkill);
}
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdTeachSkill) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdTeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdTeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4All.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4All.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSkillTypeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase_Resource_Rel4All.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase_Resource_Rel4All.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillTheory(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetTeachSkillOperMethod(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdSkillType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convMicroteachCase_Resource_Rel4All.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convMicroteachCase_Resource_Rel4All.IdSkillType);
}
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdSkillType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdSkillType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdSkillType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSkillTypeID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4All.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4All.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCaseLevelId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4All.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4All.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCaseLevelName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convMicroteachCase_Resource_Rel4All.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetmicroteachCaseText(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase_Resource_Rel4All.microteachCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetOwnerId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase_Resource_Rel4All.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetOwnerName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase_Resource_Rel4All.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCollegeID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCase_Resource_Rel4All.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetCollegeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase_Resource_Rel4All.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetOwnerNameWithId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdXzCollege(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCase_Resource_Rel4All.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCase_Resource_Rel4All.IdXzCollege);
}
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdXzCollege) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserKindId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserKindId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCase_Resource_Rel4All.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCase_Resource_Rel4All.UserKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserKindName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCase_Resource_Rel4All.UserKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserTypeId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase_Resource_Rel4All.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase_Resource_Rel4All.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUserTypeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCase_Resource_Rel4All.UserTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetRecommendedDegreeId(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetRecommendedDegreeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetBrowseCount4Case(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdResource(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convMicroteachCase_Resource_Rel4All.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convMicroteachCase_Resource_Rel4All.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convMicroteachCase_Resource_Rel4All.IdResource);
}
objvMicroteachCase_Resource_Rel4AllEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdResource) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel4All.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel4All.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel4All.ResourceName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdFtpResource(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convMicroteachCase_Resource_Rel4All.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convMicroteachCase_Resource_Rel4All.IdFtpResource);
}
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdFtpResource) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdFtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdFtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdFile(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convMicroteachCase_Resource_Rel4All.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convMicroteachCase_Resource_Rel4All.IdFile);
}
objvMicroteachCase_Resource_Rel4AllEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdFile) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel4All.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel4All.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSaveDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel4All.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel4All.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileSize(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel4All.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetSaveTime(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel4All.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel4All.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFtpResourceID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4All.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4All.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileOriginalName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel4All.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileDirName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel4All.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileRename(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel4All.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileUpDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel4All.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel4All.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileUpTime(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel4All.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel4All.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdResourceType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convMicroteachCase_Resource_Rel4All.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convMicroteachCase_Resource_Rel4All.IdResourceType);
}
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdResourceType) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceTypeID(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4All.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4All.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceTypeName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel4All.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetResourceOwner(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel4All.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetftpFileType(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel4All.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetftpFileSize(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel4All.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetftpResourceOwner(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileOriginName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel4All.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileNewName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel4All.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetFileOldName(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel4All.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIdUsingMode(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convMicroteachCase_Resource_Rel4All.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convMicroteachCase_Resource_Rel4All.IdUsingMode);
}
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4All.IdUsingMode) == false)
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4All.IdUsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4AllEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdUsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4AllEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetIndexNO(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int? intIndexNO, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetBrowseCount(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUpdDate(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel4All.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetUpdUser(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel4All.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN SetMemo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel4All.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENS, clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENT)
{
try
{
objvMicroteachCase_Resource_Rel4AllENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4AllENT.IdStudyLevel = objvMicroteachCase_Resource_Rel4AllENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllENT.StudyLevelName = objvMicroteachCase_Resource_Rel4AllENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4AllENT.IdTeachingPlan = objvMicroteachCase_Resource_Rel4AllENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4AllENT.IdCaseType = objvMicroteachCase_Resource_Rel4AllENS.IdCaseType; //案例类型流水号
objvMicroteachCase_Resource_Rel4AllENT.IdDiscipline = objvMicroteachCase_Resource_Rel4AllENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_Rel4AllENT.DisciplineID = objvMicroteachCase_Resource_Rel4AllENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4AllENT.DisciplineName = objvMicroteachCase_Resource_Rel4AllENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllENT.VersionNo = objvMicroteachCase_Resource_Rel4AllENS.VersionNo; //版本号
objvMicroteachCase_Resource_Rel4AllENT.IdTeachSkill = objvMicroteachCase_Resource_Rel4AllENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillID = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeName = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillName = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllENT.IdSkillType = objvMicroteachCase_Resource_Rel4AllENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeID = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelId = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelName = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase_Resource_Rel4AllENT.microteachCaseText = objvMicroteachCase_Resource_Rel4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4AllENT.OwnerId = objvMicroteachCase_Resource_Rel4AllENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4AllENT.OwnerName = objvMicroteachCase_Resource_Rel4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4AllENT.CollegeID = objvMicroteachCase_Resource_Rel4AllENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4AllENT.CollegeName = objvMicroteachCase_Resource_Rel4AllENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4AllENT.OwnerNameWithId = objvMicroteachCase_Resource_Rel4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllENT.IdXzCollege = objvMicroteachCase_Resource_Rel4AllENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4AllENT.IsDualVideo = objvMicroteachCase_Resource_Rel4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4AllENT.UserKindId = objvMicroteachCase_Resource_Rel4AllENS.UserKindId; //用户类别Id
objvMicroteachCase_Resource_Rel4AllENT.UserKindName = objvMicroteachCase_Resource_Rel4AllENS.UserKindName; //用户类别名
objvMicroteachCase_Resource_Rel4AllENT.UserTypeId = objvMicroteachCase_Resource_Rel4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4AllENT.UserTypeName = objvMicroteachCase_Resource_Rel4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4AllENT.IdResource = objvMicroteachCase_Resource_Rel4AllENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel4AllENT.ResourceID = objvMicroteachCase_Resource_Rel4AllENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4AllENT.ResourceName = objvMicroteachCase_Resource_Rel4AllENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4AllENT.IdFtpResource = objvMicroteachCase_Resource_Rel4AllENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllENT.IdFile = objvMicroteachCase_Resource_Rel4AllENS.IdFile; //文件流水号
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
objvMicroteachCase_Resource_Rel4AllENT.IdResourceType = objvMicroteachCase_Resource_Rel4AllENS.IdResourceType; //资源类型流水号
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
objvMicroteachCase_Resource_Rel4AllENT.IdUsingMode = objvMicroteachCase_Resource_Rel4AllENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllENT.IsVisible = objvMicroteachCase_Resource_Rel4AllENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4AllENT.IndexNO = objvMicroteachCase_Resource_Rel4AllENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4AllENT.UpdDate = objvMicroteachCase_Resource_Rel4AllENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4AllENT.UpdUser = objvMicroteachCase_Resource_Rel4AllENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4AllENT.Memo = objvMicroteachCase_Resource_Rel4AllENS.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase_Resource_Rel4AllEN:objvMicroteachCase_Resource_Rel4AllENT</returns>
 public static clsvMicroteachCase_Resource_Rel4AllEN CopyTo(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENS)
{
try
{
 clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENT = new clsvMicroteachCase_Resource_Rel4AllEN()
{
IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
IdMicroteachCase = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroteachCase_Resource_Rel4AllENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroteachCase_Resource_Rel4AllENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroteachCase_Resource_Rel4AllENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllENS.MicroTeachCaseTimeIn, //案例入库时间
IdCaseType = objvMicroteachCase_Resource_Rel4AllENS.IdCaseType, //案例类型流水号
IdDiscipline = objvMicroteachCase_Resource_Rel4AllENS.IdDiscipline, //学科流水号
DisciplineID = objvMicroteachCase_Resource_Rel4AllENS.DisciplineID, //学科ID
DisciplineName = objvMicroteachCase_Resource_Rel4AllENS.DisciplineName, //学科名称
senateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvMicroteachCase_Resource_Rel4AllENS.VersionNo, //版本号
IdTeachSkill = objvMicroteachCase_Resource_Rel4AllENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillID, //教学技能ID
SkillTypeName = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeName, //技能类型名称
TeachSkillName = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvMicroteachCase_Resource_Rel4AllENS.IdSkillType, //技能类型流水号
SkillTypeID = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeID, //技能类型ID
CaseLevelId = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelId, //课例等级Id
CaseLevelName = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelName, //案例等级名称
microteachCaseText = objvMicroteachCase_Resource_Rel4AllENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroteachCase_Resource_Rel4AllENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachCase_Resource_Rel4AllENS.OwnerName, //拥有者姓名
CollegeID = objvMicroteachCase_Resource_Rel4AllENS.CollegeID, //学院ID
CollegeName = objvMicroteachCase_Resource_Rel4AllENS.CollegeName, //学院名称
OwnerNameWithId = objvMicroteachCase_Resource_Rel4AllENS.OwnerNameWithId, //拥有者名称附Id
IdXzCollege = objvMicroteachCase_Resource_Rel4AllENS.IdXzCollege, //学院流水号
IsDualVideo = objvMicroteachCase_Resource_Rel4AllENS.IsDualVideo, //是否双视频
UserKindId = objvMicroteachCase_Resource_Rel4AllENS.UserKindId, //用户类别Id
UserKindName = objvMicroteachCase_Resource_Rel4AllENS.UserKindName, //用户类别名
UserTypeId = objvMicroteachCase_Resource_Rel4AllENS.UserTypeId, //用户类型Id
UserTypeName = objvMicroteachCase_Resource_Rel4AllENS.UserTypeName, //用户类型名称
RecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeName, //推荐度名称
BrowseCount4Case = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount4Case, //课例浏览次数
IdResource = objvMicroteachCase_Resource_Rel4AllENS.IdResource, //资源流水号
ResourceID = objvMicroteachCase_Resource_Rel4AllENS.ResourceID, //资源ID
ResourceName = objvMicroteachCase_Resource_Rel4AllENS.ResourceName, //资源名称
IdFtpResource = objvMicroteachCase_Resource_Rel4AllENS.IdFtpResource, //FTP资源流水号
IdFile = objvMicroteachCase_Resource_Rel4AllENS.IdFile, //文件流水号
FileName = objvMicroteachCase_Resource_Rel4AllENS.FileName, //文件名称
FileType = objvMicroteachCase_Resource_Rel4AllENS.FileType, //文件类型
SaveDate = objvMicroteachCase_Resource_Rel4AllENS.SaveDate, //创建日期
FileSize = objvMicroteachCase_Resource_Rel4AllENS.FileSize, //文件大小
SaveTime = objvMicroteachCase_Resource_Rel4AllENS.SaveTime, //创建时间
FtpResourceID = objvMicroteachCase_Resource_Rel4AllENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvMicroteachCase_Resource_Rel4AllENS.FileOriginalName, //文件原名
FileDirName = objvMicroteachCase_Resource_Rel4AllENS.FileDirName, //文件目录名
FileRename = objvMicroteachCase_Resource_Rel4AllENS.FileRename, //文件新名
FileUpDate = objvMicroteachCase_Resource_Rel4AllENS.FileUpDate, //创建日期
FileUpTime = objvMicroteachCase_Resource_Rel4AllENS.FileUpTime, //创建时间
SaveMode = objvMicroteachCase_Resource_Rel4AllENS.SaveMode, //文件存放方式
IdResourceType = objvMicroteachCase_Resource_Rel4AllENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvMicroteachCase_Resource_Rel4AllENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvMicroteachCase_Resource_Rel4AllENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvMicroteachCase_Resource_Rel4AllENS.ResourceOwner, //上传者
ftpFileType = objvMicroteachCase_Resource_Rel4AllENS.ftpFileType, //ftp文件类型
ftpFileSize = objvMicroteachCase_Resource_Rel4AllENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvMicroteachCase_Resource_Rel4AllENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvMicroteachCase_Resource_Rel4AllENS.FileOriginName, //原文件名
IsExistFile = objvMicroteachCase_Resource_Rel4AllENS.IsExistFile, //是否存在文件
FileNewName = objvMicroteachCase_Resource_Rel4AllENS.FileNewName, //新文件名
FileOldName = objvMicroteachCase_Resource_Rel4AllENS.FileOldName, //旧文件名
IsMain = objvMicroteachCase_Resource_Rel4AllENS.IsMain, //是否主资源
IdUsingMode = objvMicroteachCase_Resource_Rel4AllENS.IdUsingMode, //资源使用模式流水号
IsVisible = objvMicroteachCase_Resource_Rel4AllENS.IsVisible, //是否显示
IndexNO = objvMicroteachCase_Resource_Rel4AllENS.IndexNO, //序号
BrowseCount = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount, //浏览次数
UpdDate = objvMicroteachCase_Resource_Rel4AllENS.UpdDate, //修改日期
UpdUser = objvMicroteachCase_Resource_Rel4AllENS.UpdUser, //修改人
Memo = objvMicroteachCase_Resource_Rel4AllENS.Memo, //备注
};
 return objvMicroteachCase_Resource_Rel4AllENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
 clsvMicroteachCase_Resource_Rel4AllBL.vMicroteachCase_Resource_Rel4AllDA.CheckProperty4Condition(objvMicroteachCase_Resource_Rel4AllEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel, objvMicroteachCase_Resource_Rel4AllCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdMicroteachCase, objvMicroteachCase_Resource_Rel4AllCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseID, objvMicroteachCase_Resource_Rel4AllCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseName, objvMicroteachCase_Resource_Rel4AllCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme, objvMicroteachCase_Resource_Rel4AllCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseDate, objvMicroteachCase_Resource_Rel4AllCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseTime, objvMicroteachCase_Resource_Rel4AllCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn, objvMicroteachCase_Resource_Rel4AllCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdStudyLevel, objvMicroteachCase_Resource_Rel4AllCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.StudyLevelName, objvMicroteachCase_Resource_Rel4AllCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdTeachingPlan, objvMicroteachCase_Resource_Rel4AllCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn, objvMicroteachCase_Resource_Rel4AllCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdCaseType, objvMicroteachCase_Resource_Rel4AllCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdDiscipline, objvMicroteachCase_Resource_Rel4AllCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.DisciplineID, objvMicroteachCase_Resource_Rel4AllCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.DisciplineName, objvMicroteachCase_Resource_Rel4AllCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.senateGaugeVersionID, objvMicroteachCase_Resource_Rel4AllCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.senateGaugeVersionName, objvMicroteachCase_Resource_Rel4AllCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore, objvMicroteachCase_Resource_Rel4AllCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.VersionNo) == true)
{
string strComparisonOpVersionNo = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.VersionNo, objvMicroteachCase_Resource_Rel4AllCond.VersionNo, strComparisonOpVersionNo);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdTeachSkill, objvMicroteachCase_Resource_Rel4AllCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillID, objvMicroteachCase_Resource_Rel4AllCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SkillTypeName, objvMicroteachCase_Resource_Rel4AllCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillName, objvMicroteachCase_Resource_Rel4AllCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillTheory, objvMicroteachCase_Resource_Rel4AllCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod, objvMicroteachCase_Resource_Rel4AllCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdSkillType, objvMicroteachCase_Resource_Rel4AllCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SkillTypeID, objvMicroteachCase_Resource_Rel4AllCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CaseLevelId, objvMicroteachCase_Resource_Rel4AllCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CaseLevelName, objvMicroteachCase_Resource_Rel4AllCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.microteachCaseText, objvMicroteachCase_Resource_Rel4AllCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.OwnerId, objvMicroteachCase_Resource_Rel4AllCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.OwnerName, objvMicroteachCase_Resource_Rel4AllCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.CollegeID) == true)
{
string strComparisonOpCollegeID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CollegeID, objvMicroteachCase_Resource_Rel4AllCond.CollegeID, strComparisonOpCollegeID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.CollegeName, objvMicroteachCase_Resource_Rel4AllCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.OwnerNameWithId, objvMicroteachCase_Resource_Rel4AllCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdXzCollege, objvMicroteachCase_Resource_Rel4AllCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsDualVideo) == true)
{
if (objvMicroteachCase_Resource_Rel4AllCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsDualVideo);
}
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserKindId) == true)
{
string strComparisonOpUserKindId = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserKindId, objvMicroteachCase_Resource_Rel4AllCond.UserKindId, strComparisonOpUserKindId);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserKindName) == true)
{
string strComparisonOpUserKindName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserKindName, objvMicroteachCase_Resource_Rel4AllCond.UserKindName, strComparisonOpUserKindName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserTypeId, objvMicroteachCase_Resource_Rel4AllCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UserTypeName, objvMicroteachCase_Resource_Rel4AllCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.RecommendedDegreeId, objvMicroteachCase_Resource_Rel4AllCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.RecommendedDegreeName, objvMicroteachCase_Resource_Rel4AllCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.BrowseCount4Case, objvMicroteachCase_Resource_Rel4AllCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdResource) == true)
{
string strComparisonOpIdResource = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdResource, objvMicroteachCase_Resource_Rel4AllCond.IdResource, strComparisonOpIdResource);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceID) == true)
{
string strComparisonOpResourceID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceID, objvMicroteachCase_Resource_Rel4AllCond.ResourceID, strComparisonOpResourceID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceName) == true)
{
string strComparisonOpResourceName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceName, objvMicroteachCase_Resource_Rel4AllCond.ResourceName, strComparisonOpResourceName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdFtpResource, objvMicroteachCase_Resource_Rel4AllCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdFile) == true)
{
string strComparisonOpIdFile = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdFile, objvMicroteachCase_Resource_Rel4AllCond.IdFile, strComparisonOpIdFile);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileName) == true)
{
string strComparisonOpFileName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileName, objvMicroteachCase_Resource_Rel4AllCond.FileName, strComparisonOpFileName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileType) == true)
{
string strComparisonOpFileType = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileType, objvMicroteachCase_Resource_Rel4AllCond.FileType, strComparisonOpFileType);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.SaveDate) == true)
{
string strComparisonOpSaveDate = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SaveDate, objvMicroteachCase_Resource_Rel4AllCond.SaveDate, strComparisonOpSaveDate);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileSize) == true)
{
string strComparisonOpFileSize = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileSize, objvMicroteachCase_Resource_Rel4AllCond.FileSize, strComparisonOpFileSize);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.SaveTime) == true)
{
string strComparisonOpSaveTime = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.SaveTime, objvMicroteachCase_Resource_Rel4AllCond.SaveTime, strComparisonOpSaveTime);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FtpResourceID, objvMicroteachCase_Resource_Rel4AllCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileOriginalName, objvMicroteachCase_Resource_Rel4AllCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileDirName) == true)
{
string strComparisonOpFileDirName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileDirName, objvMicroteachCase_Resource_Rel4AllCond.FileDirName, strComparisonOpFileDirName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileRename) == true)
{
string strComparisonOpFileRename = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileRename, objvMicroteachCase_Resource_Rel4AllCond.FileRename, strComparisonOpFileRename);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileUpDate, objvMicroteachCase_Resource_Rel4AllCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileUpTime, objvMicroteachCase_Resource_Rel4AllCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel4AllCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdResourceType, objvMicroteachCase_Resource_Rel4AllCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceTypeID, objvMicroteachCase_Resource_Rel4AllCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceTypeName, objvMicroteachCase_Resource_Rel4AllCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ResourceOwner, objvMicroteachCase_Resource_Rel4AllCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ftpFileType, objvMicroteachCase_Resource_Rel4AllCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ftpFileSize, objvMicroteachCase_Resource_Rel4AllCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.ftpResourceOwner, objvMicroteachCase_Resource_Rel4AllCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileOriginName, objvMicroteachCase_Resource_Rel4AllCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel4AllCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileNewName) == true)
{
string strComparisonOpFileNewName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileNewName, objvMicroteachCase_Resource_Rel4AllCond.FileNewName, strComparisonOpFileNewName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.FileOldName) == true)
{
string strComparisonOpFileOldName = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.FileOldName, objvMicroteachCase_Resource_Rel4AllCond.FileOldName, strComparisonOpFileOldName);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel4AllCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.IdUsingMode, objvMicroteachCase_Resource_Rel4AllCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IsVisible) == true)
{
if (objvMicroteachCase_Resource_Rel4AllCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4All.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4All.IsVisible);
}
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.IndexNO) == true)
{
string strComparisonOpIndexNO = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.IndexNO, objvMicroteachCase_Resource_Rel4AllCond.IndexNO, strComparisonOpIndexNO);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4All.BrowseCount, objvMicroteachCase_Resource_Rel4AllCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UpdDate, objvMicroteachCase_Resource_Rel4AllCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.UpdUser, objvMicroteachCase_Resource_Rel4AllCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(convMicroteachCase_Resource_Rel4All.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4All.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4All.Memo, objvMicroteachCase_Resource_Rel4AllCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase_Resource_Rel4All
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel4All(vMicroteachCase_Resource_Rel4All)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_Rel4AllBL
{
public static RelatedActions_vMicroteachCase_Resource_Rel4All relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase_Resource_Rel4AllDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase_Resource_Rel4AllDA vMicroteachCase_Resource_Rel4AllDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase_Resource_Rel4AllDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase_Resource_Rel4AllBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel4AllEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel4AllEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase_Resource_Rel4All(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable_vMicroteachCase_Resource_Rel4All(strWhereCond);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase_Resource_Rel4AllDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
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
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Sel =
arrvMicroteachCase_Resource_Rel4AllObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvMicroteachCase_Resource_Rel4AllObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel4AllEN> GetSubObjLstCache(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllCond)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4AllEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel4All.AttributeName)
{
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4AllCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4AllCond[strFldName]));
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
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
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
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
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
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
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase_Resource_Rel4All(ref clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
bool bolResult = vMicroteachCase_Resource_Rel4AllDA.GetvMicroteachCase_Resource_Rel4All(ref objvMicroteachCase_Resource_Rel4AllEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = vMicroteachCase_Resource_Rel4AllDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvMicroteachCase_Resource_Rel4AllEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = vMicroteachCase_Resource_Rel4AllDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase_Resource_Rel4AllEN;
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
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = vMicroteachCase_Resource_Rel4AllDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_Rel4AllEN;
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
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = vMicroteachCase_Resource_Rel4AllDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_Rel4AllEN;
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
 /// <param name = "lstvMicroteachCase_Resource_Rel4AllObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvMicroteachCase_Resource_Rel4AllEN> lstvMicroteachCase_Resource_Rel4AllObjLst)
{
foreach (clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN in lstvMicroteachCase_Resource_Rel4AllObjLst)
{
if (objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvMicroteachCase_Resource_Rel4AllEN;
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
 lngIdMicroteachCaseResourceRel = new clsvMicroteachCase_Resource_Rel4AllDA().GetFirstID(strWhereCond);
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
 arrList = vMicroteachCase_Resource_Rel4AllDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_Rel4AllDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_Rel4AllDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvMicroteachCase_Resource_Rel4AllDA.IsExistTable();
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
 bolIsExist = vMicroteachCase_Resource_Rel4AllDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENS, clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENT)
{
try
{
objvMicroteachCase_Resource_Rel4AllENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4AllENT.IdStudyLevel = objvMicroteachCase_Resource_Rel4AllENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllENT.StudyLevelName = objvMicroteachCase_Resource_Rel4AllENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4AllENT.IdTeachingPlan = objvMicroteachCase_Resource_Rel4AllENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4AllENT.IdCaseType = objvMicroteachCase_Resource_Rel4AllENS.IdCaseType; //案例类型流水号
objvMicroteachCase_Resource_Rel4AllENT.IdDiscipline = objvMicroteachCase_Resource_Rel4AllENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_Rel4AllENT.DisciplineID = objvMicroteachCase_Resource_Rel4AllENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4AllENT.DisciplineName = objvMicroteachCase_Resource_Rel4AllENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllENT.VersionNo = objvMicroteachCase_Resource_Rel4AllENS.VersionNo; //版本号
objvMicroteachCase_Resource_Rel4AllENT.IdTeachSkill = objvMicroteachCase_Resource_Rel4AllENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillID = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeName = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillName = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllENT.IdSkillType = objvMicroteachCase_Resource_Rel4AllENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeID = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelId = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelName = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase_Resource_Rel4AllENT.microteachCaseText = objvMicroteachCase_Resource_Rel4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4AllENT.OwnerId = objvMicroteachCase_Resource_Rel4AllENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4AllENT.OwnerName = objvMicroteachCase_Resource_Rel4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4AllENT.CollegeID = objvMicroteachCase_Resource_Rel4AllENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4AllENT.CollegeName = objvMicroteachCase_Resource_Rel4AllENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4AllENT.OwnerNameWithId = objvMicroteachCase_Resource_Rel4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllENT.IdXzCollege = objvMicroteachCase_Resource_Rel4AllENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4AllENT.IsDualVideo = objvMicroteachCase_Resource_Rel4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4AllENT.UserKindId = objvMicroteachCase_Resource_Rel4AllENS.UserKindId; //用户类别Id
objvMicroteachCase_Resource_Rel4AllENT.UserKindName = objvMicroteachCase_Resource_Rel4AllENS.UserKindName; //用户类别名
objvMicroteachCase_Resource_Rel4AllENT.UserTypeId = objvMicroteachCase_Resource_Rel4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4AllENT.UserTypeName = objvMicroteachCase_Resource_Rel4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4AllENT.IdResource = objvMicroteachCase_Resource_Rel4AllENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel4AllENT.ResourceID = objvMicroteachCase_Resource_Rel4AllENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4AllENT.ResourceName = objvMicroteachCase_Resource_Rel4AllENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4AllENT.IdFtpResource = objvMicroteachCase_Resource_Rel4AllENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllENT.IdFile = objvMicroteachCase_Resource_Rel4AllENS.IdFile; //文件流水号
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
objvMicroteachCase_Resource_Rel4AllENT.IdResourceType = objvMicroteachCase_Resource_Rel4AllENS.IdResourceType; //资源类型流水号
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
objvMicroteachCase_Resource_Rel4AllENT.IdUsingMode = objvMicroteachCase_Resource_Rel4AllENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllENT.IsVisible = objvMicroteachCase_Resource_Rel4AllENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4AllENT.IndexNO = objvMicroteachCase_Resource_Rel4AllENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4AllENT.UpdDate = objvMicroteachCase_Resource_Rel4AllENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4AllENT.UpdUser = objvMicroteachCase_Resource_Rel4AllENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4AllENT.Memo = objvMicroteachCase_Resource_Rel4AllENS.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
try
{
objvMicroteachCase_Resource_Rel4AllEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase_Resource_Rel4AllEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objvMicroteachCase_Resource_Rel4AllEN.IdCaseType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objvMicroteachCase_Resource_Rel4AllEN.DisciplineID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objvMicroteachCase_Resource_Rel4AllEN.DisciplineName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objvMicroteachCase_Resource_Rel4AllEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objvMicroteachCase_Resource_Rel4AllEN.IdSkillType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objvMicroteachCase_Resource_Rel4AllEN.OwnerId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objvMicroteachCase_Resource_Rel4AllEN.OwnerName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objvMicroteachCase_Resource_Rel4AllEN.CollegeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objvMicroteachCase_Resource_Rel4AllEN.CollegeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objvMicroteachCase_Resource_Rel4AllEN.UserKindId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objvMicroteachCase_Resource_Rel4AllEN.UserKindName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objvMicroteachCase_Resource_Rel4AllEN.UserTypeId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objvMicroteachCase_Resource_Rel4AllEN.UserTypeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objvMicroteachCase_Resource_Rel4AllEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objvMicroteachCase_Resource_Rel4AllEN.ResourceID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objvMicroteachCase_Resource_Rel4AllEN.ResourceName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objvMicroteachCase_Resource_Rel4AllEN.IdFile == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileName = objvMicroteachCase_Resource_Rel4AllEN.FileName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileName; //文件名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileType = objvMicroteachCase_Resource_Rel4AllEN.FileType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileType; //文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objvMicroteachCase_Resource_Rel4AllEN.SaveDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objvMicroteachCase_Resource_Rel4AllEN.FileSize == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objvMicroteachCase_Resource_Rel4AllEN.SaveTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objvMicroteachCase_Resource_Rel4AllEN.FileDirName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objvMicroteachCase_Resource_Rel4AllEN.FileRename == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objvMicroteachCase_Resource_Rel4AllEN.FileUpDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objvMicroteachCase_Resource_Rel4AllEN.FileUpTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = objvMicroteachCase_Resource_Rel4AllEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objvMicroteachCase_Resource_Rel4AllEN.IdResourceType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objvMicroteachCase_Resource_Rel4AllEN.ftpFileType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objvMicroteachCase_Resource_Rel4AllEN.FileOriginName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = objvMicroteachCase_Resource_Rel4AllEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objvMicroteachCase_Resource_Rel4AllEN.FileNewName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objvMicroteachCase_Resource_Rel4AllEN.FileOldName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IsMain = objvMicroteachCase_Resource_Rel4AllEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = objvMicroteachCase_Resource_Rel4AllEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objvMicroteachCase_Resource_Rel4AllEN.IndexNO; //序号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objvMicroteachCase_Resource_Rel4AllEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objvMicroteachCase_Resource_Rel4AllEN.UpdDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objvMicroteachCase_Resource_Rel4AllEN.UpdUser == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4All.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4AllEN.Memo = objvMicroteachCase_Resource_Rel4AllEN.Memo == "[null]" ? null :  objvMicroteachCase_Resource_Rel4AllEN.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
try
{
if (objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = null; //微格教学案例ID
if (objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = null; //微格教学案例名称
if (objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = null; //id_StudyLevel
if (objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = null; //学段名称
if (objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = null; //教案流水号
if (objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn == "[null]") objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroteachCase_Resource_Rel4AllEN.IdCaseType == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = null; //案例类型流水号
if (objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = null; //学科流水号
if (objvMicroteachCase_Resource_Rel4AllEN.DisciplineID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = null; //学科ID
if (objvMicroteachCase_Resource_Rel4AllEN.DisciplineName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = null; //学科名称
if (objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = null; //教学技能流水号
if (objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = null; //教学技能ID
if (objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = null; //技能类型名称
if (objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = null; //教学技能名称
if (objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory == "[null]") objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod == "[null]") objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvMicroteachCase_Resource_Rel4AllEN.IdSkillType == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = null; //技能类型流水号
if (objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = null; //技能类型ID
if (objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId == "[null]") objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = null; //课例等级Id
if (objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = null; //案例等级名称
if (objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText == "[null]") objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = null; //案例文本内容
if (objvMicroteachCase_Resource_Rel4AllEN.OwnerId == "[null]") objvMicroteachCase_Resource_Rel4AllEN.OwnerId = null; //拥有者Id
if (objvMicroteachCase_Resource_Rel4AllEN.OwnerName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.OwnerName = null; //拥有者姓名
if (objvMicroteachCase_Resource_Rel4AllEN.CollegeID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.CollegeID = null; //学院ID
if (objvMicroteachCase_Resource_Rel4AllEN.CollegeName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.CollegeName = null; //学院名称
if (objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId == "[null]") objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCase_Resource_Rel4AllEN.UserKindId == "[null]") objvMicroteachCase_Resource_Rel4AllEN.UserKindId = null; //用户类别Id
if (objvMicroteachCase_Resource_Rel4AllEN.UserKindName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.UserKindName = null; //用户类别名
if (objvMicroteachCase_Resource_Rel4AllEN.UserTypeId == "[null]") objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCase_Resource_Rel4AllEN.UserTypeName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = null; //用户类型名称
if (objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId == "[null]") objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = null; //推荐度Id
if (objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = null; //推荐度名称
if (objvMicroteachCase_Resource_Rel4AllEN.ResourceID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ResourceID = null; //资源ID
if (objvMicroteachCase_Resource_Rel4AllEN.ResourceName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ResourceName = null; //资源名称
if (objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = null; //FTP资源流水号
if (objvMicroteachCase_Resource_Rel4AllEN.IdFile == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdFile = null; //文件流水号
if (objvMicroteachCase_Resource_Rel4AllEN.FileName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileName = null; //文件名称
if (objvMicroteachCase_Resource_Rel4AllEN.FileType == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileType = null; //文件类型
if (objvMicroteachCase_Resource_Rel4AllEN.SaveDate == "[null]") objvMicroteachCase_Resource_Rel4AllEN.SaveDate = null; //创建日期
if (objvMicroteachCase_Resource_Rel4AllEN.FileSize == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileSize = null; //文件大小
if (objvMicroteachCase_Resource_Rel4AllEN.SaveTime == "[null]") objvMicroteachCase_Resource_Rel4AllEN.SaveTime = null; //创建时间
if (objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = null; //FTP资源ID
if (objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = null; //文件原名
if (objvMicroteachCase_Resource_Rel4AllEN.FileDirName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileDirName = null; //文件目录名
if (objvMicroteachCase_Resource_Rel4AllEN.FileRename == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileRename = null; //文件新名
if (objvMicroteachCase_Resource_Rel4AllEN.FileUpDate == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = null; //创建日期
if (objvMicroteachCase_Resource_Rel4AllEN.FileUpTime == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = null; //创建时间
if (objvMicroteachCase_Resource_Rel4AllEN.IdResourceType == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = null; //资源类型流水号
if (objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = null; //资源类型ID
if (objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = null; //资源类型名称
if (objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = null; //上传者
if (objvMicroteachCase_Resource_Rel4AllEN.ftpFileType == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = null; //ftp文件类型
if (objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = null; //ftp文件大小
if (objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner == "[null]") objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvMicroteachCase_Resource_Rel4AllEN.FileOriginName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = null; //原文件名
if (objvMicroteachCase_Resource_Rel4AllEN.FileNewName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileNewName = null; //新文件名
if (objvMicroteachCase_Resource_Rel4AllEN.FileOldName == "[null]") objvMicroteachCase_Resource_Rel4AllEN.FileOldName = null; //旧文件名
if (objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode == "[null]") objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = null; //资源使用模式流水号
if (objvMicroteachCase_Resource_Rel4AllEN.UpdDate == "[null]") objvMicroteachCase_Resource_Rel4AllEN.UpdDate = null; //修改日期
if (objvMicroteachCase_Resource_Rel4AllEN.UpdUser == "[null]") objvMicroteachCase_Resource_Rel4AllEN.UpdUser = null; //修改人
if (objvMicroteachCase_Resource_Rel4AllEN.Memo == "[null]") objvMicroteachCase_Resource_Rel4AllEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
 vMicroteachCase_Resource_Rel4AllDA.CheckProperty4Condition(objvMicroteachCase_Resource_Rel4AllEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvMicroteachCase_Resource_Rel4AllObjLstCache == null)
//{
//arrvMicroteachCase_Resource_Rel4AllObjLstCache = vMicroteachCase_Resource_Rel4AllDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel4AllEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLst_Sel =
arrvMicroteachCase_Resource_Rel4AllObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvMicroteachCase_Resource_Rel4AllObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_Rel4AllEN obj = clsvMicroteachCase_Resource_Rel4AllBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase_Resource_Rel4AllObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetAllvMicroteachCase_Resource_Rel4AllObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase_Resource_Rel4AllObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel4AllEN> arrvMicroteachCase_Resource_Rel4AllObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_Rel4AllObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName);
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
if (strInFldName != convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase_Resource_Rel4All.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase_Resource_Rel4All.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase_Resource_Rel4All = clsvMicroteachCase_Resource_Rel4AllBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvMicroteachCase_Resource_Rel4All == null) return "";
return objvMicroteachCase_Resource_Rel4All[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase_Resource_Rel4AllDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase_Resource_Rel4AllDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase_Resource_Rel4AllDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase_Resource_Rel4AllDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllCond)
{
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4AllEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel4All.AttributeName)
{
if (objvMicroteachCase_Resource_Rel4AllCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_Rel4AllCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_Rel4AllCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4AllCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4AllCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase_Resource_Rel4AllDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_Rel4AllDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_Rel4AllDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}