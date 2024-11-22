
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4TeaBL
 表名:vMicroteachCase4Tea(01120503)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvMicroteachCase4TeaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4TeaEN GetObj(this K_IdMicroteachCase_vMicroteachCase4Tea myKey)
{
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = clsvMicroteachCase4TeaBL.vMicroteachCase4TeaDA.GetObjByIdMicroteachCase(myKey.Value);
return objvMicroteachCase4TeaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdMicroteachCase(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase4Tea.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase4Tea.IdMicroteachCase);
}
objvMicroteachCase4TeaEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdMicroteachCase) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseTypeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, convMicroteachCase4Tea.MicroteachCaseTypeName);
}
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = strMicroteachCaseTypeName; //微格案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseTypeName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseTypeName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTypeName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCase4Tea.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase4Tea.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase4Tea.MicroteachCaseID);
}
objvMicroteachCase4TeaEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCase4Tea.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase4Tea.MicroteachCaseName);
}
objvMicroteachCase4TeaEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseTheme(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase4Tea.MicroteachCaseTheme);
}
objvMicroteachCase4TeaEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseTheme) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseDate(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase4Tea.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase4Tea.MicroteachCaseDate);
}
objvMicroteachCase4TeaEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseDate) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseTime(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase4Tea.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase4Tea.MicroteachCaseTime);
}
objvMicroteachCase4TeaEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseTime) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseDateIn(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase4Tea.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase4Tea.MicroteachCaseDateIn);
}
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroteachCaseDateIn) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdStudyLevel(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroteachCase4Tea.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroteachCase4Tea.IdStudyLevel);
}
objvMicroteachCase4TeaEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdStudyLevel) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetStudyLevelName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase4Tea.StudyLevelName);
}
objvMicroteachCase4TeaEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.StudyLevelName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdTeachingPlan(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroteachCase4Tea.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroteachCase4Tea.IdTeachingPlan);
}
objvMicroteachCase4TeaEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdTeachingPlan) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase4Tea.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase4Tea.MicroTeachCaseTimeIn);
}
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdMicroteachCaseType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdMicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCaseType, convMicroteachCase4Tea.IdMicroteachCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseType, 4, convMicroteachCase4Tea.IdMicroteachCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseType, 4, convMicroteachCase4Tea.IdMicroteachCaseType);
}
objvMicroteachCase4TeaEN.IdMicroteachCaseType = strIdMicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdMicroteachCaseType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdMicroteachCaseType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdMicroteachCaseType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdCaseType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, convMicroteachCase4Tea.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convMicroteachCase4Tea.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convMicroteachCase4Tea.IdCaseType);
}
objvMicroteachCase4TeaEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdCaseType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdCaseType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdCaseType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdDiscipline(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convMicroteachCase4Tea.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convMicroteachCase4Tea.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convMicroteachCase4Tea.IdDiscipline);
}
objvMicroteachCase4TeaEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdDiscipline) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdDiscipline, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdDiscipline] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetDisciplineID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase4Tea.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase4Tea.DisciplineID);
}
objvMicroteachCase4TeaEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.DisciplineID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.DisciplineID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.DisciplineID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetDisciplineName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase4Tea.DisciplineName);
}
objvMicroteachCase4TeaEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.DisciplineName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.DisciplineName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.DisciplineName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdSenateGaugeVersion(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convMicroteachCase4Tea.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convMicroteachCase4Tea.IdSenateGaugeVersion);
}
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdSenateGaugeVersion) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetsenateGaugeVersionID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase4Tea.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase4Tea.senateGaugeVersionID);
}
objvMicroteachCase4TeaEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.senateGaugeVersionID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetsenateGaugeVersionName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase4Tea.senateGaugeVersionName);
}
objvMicroteachCase4TeaEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.senateGaugeVersionName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.senateGaugeVersionTtlScore) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetVersionNo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, int? intVersionNo, string strComparisonOp="")
	{
objvMicroteachCase4TeaEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.VersionNo) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.VersionNo, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.VersionNo] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdTeachSkill(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convMicroteachCase4Tea.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convMicroteachCase4Tea.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convMicroteachCase4Tea.IdTeachSkill);
}
objvMicroteachCase4TeaEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdTeachSkill) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdTeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdTeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase4Tea.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase4Tea.TeachSkillID);
}
objvMicroteachCase4TeaEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeachSkillID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeachSkillID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetSkillTypeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase4Tea.SkillTypeName);
}
objvMicroteachCase4TeaEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.SkillTypeName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.SkillTypeName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.SkillTypeName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase4Tea.TeachSkillName);
}
objvMicroteachCase4TeaEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeachSkillName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeachSkillName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillTheory(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase4Tea.TeachSkillTheory);
}
objvMicroteachCase4TeaEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeachSkillTheory) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeachSkillTheory, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillTheory] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillOperMethod(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase4Tea.TeachSkillOperMethod);
}
objvMicroteachCase4TeaEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeachSkillOperMethod) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdSkillType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convMicroteachCase4Tea.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convMicroteachCase4Tea.IdSkillType);
}
objvMicroteachCase4TeaEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdSkillType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdSkillType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdSkillType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetSkillTypeID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase4Tea.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase4Tea.SkillTypeID);
}
objvMicroteachCase4TeaEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.SkillTypeID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.SkillTypeID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.SkillTypeID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCaseLevelId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase4Tea.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase4Tea.CaseLevelId);
}
objvMicroteachCase4TeaEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.CaseLevelId) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.CaseLevelId, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.CaseLevelId] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetDocFile(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMicroteachCase4Tea.DocFile);
}
objvMicroteachCase4TeaEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.DocFile) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.DocFile, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.DocFile] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIsNeedGeneWord(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvMicroteachCase4TeaEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IsNeedGeneWord) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IsNeedGeneWord, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IsNeedGeneWord] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetWordCreateDate(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMicroteachCase4Tea.WordCreateDate);
}
objvMicroteachCase4TeaEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.WordCreateDate) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.WordCreateDate, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.WordCreateDate] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIsVisible(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCase4TeaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IsVisible) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetmicroteachCaseText(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase4Tea.microteachCaseText);
}
objvMicroteachCase4TeaEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.microteachCaseText) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetOwnerId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroteachCase4Tea.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase4Tea.OwnerId);
}
objvMicroteachCase4TeaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.OwnerId) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetOwnerName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase4Tea.OwnerName);
}
objvMicroteachCase4TeaEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.OwnerName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.OwnerName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.OwnerName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeacherId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convMicroteachCase4Tea.TeacherId);
}
objvMicroteachCase4TeaEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeacherId) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeacherId, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeacherId] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeacherName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeacherName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convMicroteachCase4Tea.TeacherName);
}
objvMicroteachCase4TeaEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeacherName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeacherName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeacherName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIdXzCollege(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCase4Tea.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCase4Tea.IdXzCollege);
}
objvMicroteachCase4TeaEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IdXzCollege) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCollegeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase4Tea.CollegeName);
}
objvMicroteachCase4TeaEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.CollegeName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetEntryDate(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strEntryDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convMicroteachCase4Tea.EntryDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convMicroteachCase4Tea.EntryDate);
}
objvMicroteachCase4TeaEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.EntryDate) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.EntryDate, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.EntryDate] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCollegeId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convMicroteachCase4Tea.CollegeId);
}
objvMicroteachCase4TeaEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.CollegeId) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.CollegeId, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.CollegeId] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetEntryYear(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strEntryYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convMicroteachCase4Tea.EntryYear);
}
objvMicroteachCase4TeaEN.EntryYear = strEntryYear; //EntryYear
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.EntryYear) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.EntryYear, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.EntryYear] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetIsDualVideo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convMicroteachCase4Tea.IsDualVideo);
objvMicroteachCase4TeaEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.IsDualVideo) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.IsDualVideo, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.IsDualVideo] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetUserTypeId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase4Tea.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase4Tea.UserTypeId);
}
objvMicroteachCase4TeaEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.UserTypeId) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetRecommendedDegreeId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroteachCase4Tea.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase4Tea.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase4Tea.RecommendedDegreeId);
}
objvMicroteachCase4TeaEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.RecommendedDegreeId) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetRecommendedDegreeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase4Tea.RecommendedDegreeName);
}
objvMicroteachCase4TeaEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.RecommendedDegreeName) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMemo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase4Tea.Memo);
}
objvMicroteachCase4TeaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.Memo) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.Memo, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.Memo] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetBrowseCount4Case(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCase4TeaEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.BrowseCount4Case) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCollegeNameA(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase4Tea.CollegeNameA);
}
objvMicroteachCase4TeaEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.CollegeNameA) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetftpFileType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase4Tea.ftpFileType);
}
objvMicroteachCase4TeaEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.ftpFileType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase4TeaENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENS, clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENT)
{
try
{
objvMicroteachCase4TeaENT.IdMicroteachCase = objvMicroteachCase4TeaENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase4TeaENT.MicroteachCaseTypeName = objvMicroteachCase4TeaENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4TeaENT.MicroteachCaseID = objvMicroteachCase4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4TeaENT.MicroteachCaseName = objvMicroteachCase4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4TeaENT.MicroteachCaseTheme = objvMicroteachCase4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4TeaENT.MicroteachCaseDate = objvMicroteachCase4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4TeaENT.MicroteachCaseTime = objvMicroteachCase4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4TeaENT.MicroteachCaseDateIn = objvMicroteachCase4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4TeaENT.IdStudyLevel = objvMicroteachCase4TeaENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase4TeaENT.StudyLevelName = objvMicroteachCase4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase4TeaENT.IdTeachingPlan = objvMicroteachCase4TeaENS.IdTeachingPlan; //教案流水号
objvMicroteachCase4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4TeaENT.IdMicroteachCaseType = objvMicroteachCase4TeaENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4TeaENT.IdCaseType = objvMicroteachCase4TeaENS.IdCaseType; //案例类型流水号
objvMicroteachCase4TeaENT.IdDiscipline = objvMicroteachCase4TeaENS.IdDiscipline; //学科流水号
objvMicroteachCase4TeaENT.DisciplineID = objvMicroteachCase4TeaENS.DisciplineID; //学科ID
objvMicroteachCase4TeaENT.DisciplineName = objvMicroteachCase4TeaENS.DisciplineName; //学科名称
objvMicroteachCase4TeaENT.IdSenateGaugeVersion = objvMicroteachCase4TeaENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4TeaENT.senateGaugeVersionID = objvMicroteachCase4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4TeaENT.senateGaugeVersionName = objvMicroteachCase4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4TeaENT.VersionNo = objvMicroteachCase4TeaENS.VersionNo; //版本号
objvMicroteachCase4TeaENT.IdTeachSkill = objvMicroteachCase4TeaENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase4TeaENT.TeachSkillID = objvMicroteachCase4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase4TeaENT.SkillTypeName = objvMicroteachCase4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase4TeaENT.TeachSkillName = objvMicroteachCase4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase4TeaENT.TeachSkillTheory = objvMicroteachCase4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4TeaENT.TeachSkillOperMethod = objvMicroteachCase4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4TeaENT.IdSkillType = objvMicroteachCase4TeaENS.IdSkillType; //技能类型流水号
objvMicroteachCase4TeaENT.SkillTypeID = objvMicroteachCase4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase4TeaENT.CaseLevelId = objvMicroteachCase4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase4TeaENT.DocFile = objvMicroteachCase4TeaENS.DocFile; //生成的Word文件名
objvMicroteachCase4TeaENT.IsNeedGeneWord = objvMicroteachCase4TeaENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4TeaENT.WordCreateDate = objvMicroteachCase4TeaENS.WordCreateDate; //Word生成日期
objvMicroteachCase4TeaENT.IsVisible = objvMicroteachCase4TeaENS.IsVisible; //是否显示
objvMicroteachCase4TeaENT.microteachCaseText = objvMicroteachCase4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase4TeaENT.OwnerId = objvMicroteachCase4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase4TeaENT.OwnerName = objvMicroteachCase4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase4TeaENT.TeacherId = objvMicroteachCase4TeaENS.TeacherId; //教师工号
objvMicroteachCase4TeaENT.TeacherName = objvMicroteachCase4TeaENS.TeacherName; //教师姓名
objvMicroteachCase4TeaENT.IdXzCollege = objvMicroteachCase4TeaENS.IdXzCollege; //学院流水号
objvMicroteachCase4TeaENT.CollegeName = objvMicroteachCase4TeaENS.CollegeName; //学院名称
objvMicroteachCase4TeaENT.EntryDate = objvMicroteachCase4TeaENS.EntryDate; //进校日期
objvMicroteachCase4TeaENT.CollegeId = objvMicroteachCase4TeaENS.CollegeId; //学院ID
objvMicroteachCase4TeaENT.EntryYear = objvMicroteachCase4TeaENS.EntryYear; //EntryYear
objvMicroteachCase4TeaENT.IsDualVideo = objvMicroteachCase4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase4TeaENT.UserTypeId = objvMicroteachCase4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase4TeaENT.RecommendedDegreeId = objvMicroteachCase4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase4TeaENT.RecommendedDegreeName = objvMicroteachCase4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase4TeaENT.Memo = objvMicroteachCase4TeaENS.Memo; //备注
objvMicroteachCase4TeaENT.BrowseCount4Case = objvMicroteachCase4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase4TeaENT.CollegeNameA = objvMicroteachCase4TeaENS.CollegeNameA; //学院名称简写
objvMicroteachCase4TeaENT.ftpFileType = objvMicroteachCase4TeaENS.ftpFileType; //ftp文件类型
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
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase4TeaEN:objvMicroteachCase4TeaENT</returns>
 public static clsvMicroteachCase4TeaEN CopyTo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENS)
{
try
{
 clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENT = new clsvMicroteachCase4TeaEN()
{
IdMicroteachCase = objvMicroteachCase4TeaENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseTypeName = objvMicroteachCase4TeaENS.MicroteachCaseTypeName, //微格案例类型名称
MicroteachCaseID = objvMicroteachCase4TeaENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCase4TeaENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroteachCase4TeaENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroteachCase4TeaENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroteachCase4TeaENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroteachCase4TeaENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroteachCase4TeaENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroteachCase4TeaENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroteachCase4TeaENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroteachCase4TeaENS.MicroTeachCaseTimeIn, //案例入库时间
IdMicroteachCaseType = objvMicroteachCase4TeaENS.IdMicroteachCaseType, //微格案例类型流水号
IdCaseType = objvMicroteachCase4TeaENS.IdCaseType, //案例类型流水号
IdDiscipline = objvMicroteachCase4TeaENS.IdDiscipline, //学科流水号
DisciplineID = objvMicroteachCase4TeaENS.DisciplineID, //学科ID
DisciplineName = objvMicroteachCase4TeaENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvMicroteachCase4TeaENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvMicroteachCase4TeaENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCase4TeaENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroteachCase4TeaENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvMicroteachCase4TeaENS.VersionNo, //版本号
IdTeachSkill = objvMicroteachCase4TeaENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvMicroteachCase4TeaENS.TeachSkillID, //教学技能ID
SkillTypeName = objvMicroteachCase4TeaENS.SkillTypeName, //技能类型名称
TeachSkillName = objvMicroteachCase4TeaENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvMicroteachCase4TeaENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvMicroteachCase4TeaENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvMicroteachCase4TeaENS.IdSkillType, //技能类型流水号
SkillTypeID = objvMicroteachCase4TeaENS.SkillTypeID, //技能类型ID
CaseLevelId = objvMicroteachCase4TeaENS.CaseLevelId, //课例等级Id
DocFile = objvMicroteachCase4TeaENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvMicroteachCase4TeaENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvMicroteachCase4TeaENS.WordCreateDate, //Word生成日期
IsVisible = objvMicroteachCase4TeaENS.IsVisible, //是否显示
microteachCaseText = objvMicroteachCase4TeaENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroteachCase4TeaENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachCase4TeaENS.OwnerName, //拥有者姓名
TeacherId = objvMicroteachCase4TeaENS.TeacherId, //教师工号
TeacherName = objvMicroteachCase4TeaENS.TeacherName, //教师姓名
IdXzCollege = objvMicroteachCase4TeaENS.IdXzCollege, //学院流水号
CollegeName = objvMicroteachCase4TeaENS.CollegeName, //学院名称
EntryDate = objvMicroteachCase4TeaENS.EntryDate, //进校日期
CollegeId = objvMicroteachCase4TeaENS.CollegeId, //学院ID
EntryYear = objvMicroteachCase4TeaENS.EntryYear, //EntryYear
IsDualVideo = objvMicroteachCase4TeaENS.IsDualVideo, //是否双视频
UserTypeId = objvMicroteachCase4TeaENS.UserTypeId, //用户类型Id
RecommendedDegreeId = objvMicroteachCase4TeaENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvMicroteachCase4TeaENS.RecommendedDegreeName, //推荐度名称
Memo = objvMicroteachCase4TeaENS.Memo, //备注
BrowseCount4Case = objvMicroteachCase4TeaENS.BrowseCount4Case, //课例浏览次数
CollegeNameA = objvMicroteachCase4TeaENS.CollegeNameA, //学院名称简写
ftpFileType = objvMicroteachCase4TeaENS.ftpFileType, //ftp文件类型
};
 return objvMicroteachCase4TeaENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
 clsvMicroteachCase4TeaBL.vMicroteachCase4TeaDA.CheckProperty4Condition(objvMicroteachCase4TeaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdMicroteachCase, objvMicroteachCase4TeaCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseTypeName) == true)
{
string strComparisonOpMicroteachCaseTypeName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseTypeName, objvMicroteachCase4TeaCond.MicroteachCaseTypeName, strComparisonOpMicroteachCaseTypeName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseID, objvMicroteachCase4TeaCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseName, objvMicroteachCase4TeaCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseTheme, objvMicroteachCase4TeaCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseDate, objvMicroteachCase4TeaCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseTime, objvMicroteachCase4TeaCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseDateIn, objvMicroteachCase4TeaCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdStudyLevel, objvMicroteachCase4TeaCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.StudyLevelName, objvMicroteachCase4TeaCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdTeachingPlan, objvMicroteachCase4TeaCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroTeachCaseTimeIn, objvMicroteachCase4TeaCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdMicroteachCaseType) == true)
{
string strComparisonOpIdMicroteachCaseType = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdMicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdMicroteachCaseType, objvMicroteachCase4TeaCond.IdMicroteachCaseType, strComparisonOpIdMicroteachCaseType);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdCaseType, objvMicroteachCase4TeaCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdDiscipline, objvMicroteachCase4TeaCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.DisciplineID, objvMicroteachCase4TeaCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.DisciplineName, objvMicroteachCase4TeaCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdSenateGaugeVersion, objvMicroteachCase4TeaCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.senateGaugeVersionID, objvMicroteachCase4TeaCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.senateGaugeVersionName, objvMicroteachCase4TeaCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4Tea.senateGaugeVersionTtlScore, objvMicroteachCase4TeaCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.VersionNo) == true)
{
string strComparisonOpVersionNo = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4Tea.VersionNo, objvMicroteachCase4TeaCond.VersionNo, strComparisonOpVersionNo);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdTeachSkill, objvMicroteachCase4TeaCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillID, objvMicroteachCase4TeaCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.SkillTypeName, objvMicroteachCase4TeaCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillName, objvMicroteachCase4TeaCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillTheory, objvMicroteachCase4TeaCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillOperMethod, objvMicroteachCase4TeaCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdSkillType, objvMicroteachCase4TeaCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.SkillTypeID, objvMicroteachCase4TeaCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CaseLevelId, objvMicroteachCase4TeaCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.DocFile) == true)
{
string strComparisonOpDocFile = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.DocFile, objvMicroteachCase4TeaCond.DocFile, strComparisonOpDocFile);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IsNeedGeneWord) == true)
{
if (objvMicroteachCase4TeaCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4Tea.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4Tea.IsNeedGeneWord);
}
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.WordCreateDate, objvMicroteachCase4TeaCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IsVisible) == true)
{
if (objvMicroteachCase4TeaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4Tea.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4Tea.IsVisible);
}
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.microteachCaseText, objvMicroteachCase4TeaCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.OwnerId, objvMicroteachCase4TeaCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.OwnerName, objvMicroteachCase4TeaCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.TeacherId) == true)
{
string strComparisonOpTeacherId = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeacherId, objvMicroteachCase4TeaCond.TeacherId, strComparisonOpTeacherId);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.TeacherName) == true)
{
string strComparisonOpTeacherName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeacherName, objvMicroteachCase4TeaCond.TeacherName, strComparisonOpTeacherName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.IdXzCollege, objvMicroteachCase4TeaCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CollegeName, objvMicroteachCase4TeaCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.EntryDate) == true)
{
string strComparisonOpEntryDate = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.EntryDate, objvMicroteachCase4TeaCond.EntryDate, strComparisonOpEntryDate);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.CollegeId) == true)
{
string strComparisonOpCollegeId = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CollegeId, objvMicroteachCase4TeaCond.CollegeId, strComparisonOpCollegeId);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.EntryYear) == true)
{
string strComparisonOpEntryYear = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.EntryYear, objvMicroteachCase4TeaCond.EntryYear, strComparisonOpEntryYear);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.IsDualVideo) == true)
{
if (objvMicroteachCase4TeaCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4Tea.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4Tea.IsDualVideo);
}
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.UserTypeId, objvMicroteachCase4TeaCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.RecommendedDegreeId, objvMicroteachCase4TeaCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.RecommendedDegreeName, objvMicroteachCase4TeaCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.Memo, objvMicroteachCase4TeaCond.Memo, strComparisonOpMemo);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4Tea.BrowseCount4Case, objvMicroteachCase4TeaCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CollegeNameA, objvMicroteachCase4TeaCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvMicroteachCase4TeaCond.IsUpdated(convMicroteachCase4Tea.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCase4TeaCond.dicFldComparisonOp[convMicroteachCase4Tea.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.ftpFileType, objvMicroteachCase4TeaCond.ftpFileType, strComparisonOpftpFileType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase4Tea
{
public virtual bool UpdRelaTabDate(string strIdMicroteachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vMicroteachCase4Tea(vMicroteachCase4Tea)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase4TeaBL
{
public static RelatedActions_vMicroteachCase4Tea relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase4TeaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase4TeaDA vMicroteachCase4TeaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase4TeaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase4TeaBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase4TeaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase4TeaEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase4Tea(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase4TeaDA.GetDataTable_vMicroteachCase4Tea(strWhereCond);
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
objDT = vMicroteachCase4TeaDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase4TeaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase4TeaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase4TeaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase4TeaDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase4TeaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase4TeaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase4TeaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLstByIdMicroteachCaseLst(List<string> arrIdMicroteachCaseLst)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseLst, true);
 string strWhereCond = string.Format("IdMicroteachCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase4TeaEN> GetObjLstByIdMicroteachCaseLstCache(List<string> arrIdMicroteachCaseLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel =
arrvMicroteachCase4TeaObjLstCache
.Where(x => arrIdMicroteachCaseLst.Contains(x.IdMicroteachCase));
return arrvMicroteachCase4TeaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase4TeaEN> GetSubObjLstCache(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaCond)
{
List<clsvMicroteachCase4TeaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4TeaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase4Tea.AttributeName)
{
if (objvMicroteachCase4TeaCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase4TeaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4TeaCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase4TeaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase4TeaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4TeaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase4TeaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4TeaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4TeaCond[strFldName]));
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
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
List<clsvMicroteachCase4TeaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase4TeaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase4TeaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
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
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
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
public static List<clsvMicroteachCase4TeaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase4TeaEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase4TeaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase4Tea(ref clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
bool bolResult = vMicroteachCase4TeaDA.GetvMicroteachCase4Tea(ref objvMicroteachCase4TeaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4TeaEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
if (strIdMicroteachCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdMicroteachCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdMicroteachCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = vMicroteachCase4TeaDA.GetObjByIdMicroteachCase(strIdMicroteachCase);
return objvMicroteachCase4TeaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase4TeaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = vMicroteachCase4TeaDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase4TeaEN;
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
public static clsvMicroteachCase4TeaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = vMicroteachCase4TeaDA.GetObjByDataRow(objRow);
 return objvMicroteachCase4TeaEN;
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
public static clsvMicroteachCase4TeaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = vMicroteachCase4TeaDA.GetObjByDataRow(objRow);
 return objvMicroteachCase4TeaEN;
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
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <param name = "lstvMicroteachCase4TeaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase4TeaEN GetObjByIdMicroteachCaseFromList(string strIdMicroteachCase, List<clsvMicroteachCase4TeaEN> lstvMicroteachCase4TeaObjLst)
{
foreach (clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN in lstvMicroteachCase4TeaObjLst)
{
if (objvMicroteachCase4TeaEN.IdMicroteachCase == strIdMicroteachCase)
{
return objvMicroteachCase4TeaEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdMicroteachCase;
 try
 {
 strIdMicroteachCase = new clsvMicroteachCase4TeaDA().GetFirstID(strWhereCond);
 return strIdMicroteachCase;
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
 arrList = vMicroteachCase4TeaDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase4TeaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdMicroteachCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vMicroteachCase4TeaDA.IsExist(strIdMicroteachCase);
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
 bolIsExist = clsvMicroteachCase4TeaDA.IsExistTable();
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
 bolIsExist = vMicroteachCase4TeaDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase4TeaENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENS, clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENT)
{
try
{
objvMicroteachCase4TeaENT.IdMicroteachCase = objvMicroteachCase4TeaENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase4TeaENT.MicroteachCaseTypeName = objvMicroteachCase4TeaENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4TeaENT.MicroteachCaseID = objvMicroteachCase4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4TeaENT.MicroteachCaseName = objvMicroteachCase4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4TeaENT.MicroteachCaseTheme = objvMicroteachCase4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4TeaENT.MicroteachCaseDate = objvMicroteachCase4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4TeaENT.MicroteachCaseTime = objvMicroteachCase4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4TeaENT.MicroteachCaseDateIn = objvMicroteachCase4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4TeaENT.IdStudyLevel = objvMicroteachCase4TeaENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase4TeaENT.StudyLevelName = objvMicroteachCase4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase4TeaENT.IdTeachingPlan = objvMicroteachCase4TeaENS.IdTeachingPlan; //教案流水号
objvMicroteachCase4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4TeaENT.IdMicroteachCaseType = objvMicroteachCase4TeaENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4TeaENT.IdCaseType = objvMicroteachCase4TeaENS.IdCaseType; //案例类型流水号
objvMicroteachCase4TeaENT.IdDiscipline = objvMicroteachCase4TeaENS.IdDiscipline; //学科流水号
objvMicroteachCase4TeaENT.DisciplineID = objvMicroteachCase4TeaENS.DisciplineID; //学科ID
objvMicroteachCase4TeaENT.DisciplineName = objvMicroteachCase4TeaENS.DisciplineName; //学科名称
objvMicroteachCase4TeaENT.IdSenateGaugeVersion = objvMicroteachCase4TeaENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4TeaENT.senateGaugeVersionID = objvMicroteachCase4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4TeaENT.senateGaugeVersionName = objvMicroteachCase4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4TeaENT.VersionNo = objvMicroteachCase4TeaENS.VersionNo; //版本号
objvMicroteachCase4TeaENT.IdTeachSkill = objvMicroteachCase4TeaENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase4TeaENT.TeachSkillID = objvMicroteachCase4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase4TeaENT.SkillTypeName = objvMicroteachCase4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase4TeaENT.TeachSkillName = objvMicroteachCase4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase4TeaENT.TeachSkillTheory = objvMicroteachCase4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4TeaENT.TeachSkillOperMethod = objvMicroteachCase4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4TeaENT.IdSkillType = objvMicroteachCase4TeaENS.IdSkillType; //技能类型流水号
objvMicroteachCase4TeaENT.SkillTypeID = objvMicroteachCase4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase4TeaENT.CaseLevelId = objvMicroteachCase4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase4TeaENT.DocFile = objvMicroteachCase4TeaENS.DocFile; //生成的Word文件名
objvMicroteachCase4TeaENT.IsNeedGeneWord = objvMicroteachCase4TeaENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4TeaENT.WordCreateDate = objvMicroteachCase4TeaENS.WordCreateDate; //Word生成日期
objvMicroteachCase4TeaENT.IsVisible = objvMicroteachCase4TeaENS.IsVisible; //是否显示
objvMicroteachCase4TeaENT.microteachCaseText = objvMicroteachCase4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase4TeaENT.OwnerId = objvMicroteachCase4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase4TeaENT.OwnerName = objvMicroteachCase4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase4TeaENT.TeacherId = objvMicroteachCase4TeaENS.TeacherId; //教师工号
objvMicroteachCase4TeaENT.TeacherName = objvMicroteachCase4TeaENS.TeacherName; //教师姓名
objvMicroteachCase4TeaENT.IdXzCollege = objvMicroteachCase4TeaENS.IdXzCollege; //学院流水号
objvMicroteachCase4TeaENT.CollegeName = objvMicroteachCase4TeaENS.CollegeName; //学院名称
objvMicroteachCase4TeaENT.EntryDate = objvMicroteachCase4TeaENS.EntryDate; //进校日期
objvMicroteachCase4TeaENT.CollegeId = objvMicroteachCase4TeaENS.CollegeId; //学院ID
objvMicroteachCase4TeaENT.EntryYear = objvMicroteachCase4TeaENS.EntryYear; //EntryYear
objvMicroteachCase4TeaENT.IsDualVideo = objvMicroteachCase4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase4TeaENT.UserTypeId = objvMicroteachCase4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase4TeaENT.RecommendedDegreeId = objvMicroteachCase4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase4TeaENT.RecommendedDegreeName = objvMicroteachCase4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase4TeaENT.Memo = objvMicroteachCase4TeaENS.Memo; //备注
objvMicroteachCase4TeaENT.BrowseCount4Case = objvMicroteachCase4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase4TeaENT.CollegeNameA = objvMicroteachCase4TeaENS.CollegeNameA; //学院名称简写
objvMicroteachCase4TeaENT.ftpFileType = objvMicroteachCase4TeaENS.ftpFileType; //ftp文件类型
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
 /// <param name = "objvMicroteachCase4TeaEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
try
{
objvMicroteachCase4TeaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase4TeaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase4Tea.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objvMicroteachCase4TeaEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objvMicroteachCase4TeaEN.MicroteachCaseTypeName == "[null]" ? null :  objvMicroteachCase4TeaEN.MicroteachCaseTypeName; //微格案例类型名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseID = objvMicroteachCase4TeaEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseName = objvMicroteachCase4TeaEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objvMicroteachCase4TeaEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroteachCase4TeaEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseDate = objvMicroteachCase4TeaEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCase4TeaEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseTime = objvMicroteachCase4TeaEN.MicroteachCaseTime == "[null]" ? null :  objvMicroteachCase4TeaEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objvMicroteachCase4TeaEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroteachCase4TeaEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdStudyLevel = objvMicroteachCase4TeaEN.IdStudyLevel == "[null]" ? null :  objvMicroteachCase4TeaEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroteachCase4Tea.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.StudyLevelName = objvMicroteachCase4TeaEN.StudyLevelName == "[null]" ? null :  objvMicroteachCase4TeaEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdTeachingPlan = objvMicroteachCase4TeaEN.IdTeachingPlan == "[null]" ? null :  objvMicroteachCase4TeaEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdMicroteachCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objvMicroteachCase4TeaEN.IdMicroteachCaseType; //微格案例类型流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdCaseType = objvMicroteachCase4TeaEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdDiscipline = objvMicroteachCase4TeaEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.DisciplineID = objvMicroteachCase4TeaEN.DisciplineID == "[null]" ? null :  objvMicroteachCase4TeaEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convMicroteachCase4Tea.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.DisciplineName = objvMicroteachCase4TeaEN.DisciplineName == "[null]" ? null :  objvMicroteachCase4TeaEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objvMicroteachCase4TeaEN.IdSenateGaugeVersion == "[null]" ? null :  objvMicroteachCase4TeaEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.senateGaugeVersionID = objvMicroteachCase4TeaEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCase4TeaEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCase4Tea.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.senateGaugeVersionName = objvMicroteachCase4TeaEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCase4TeaEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroteachCase4Tea.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.VersionNo = objvMicroteachCase4TeaEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdTeachSkill = objvMicroteachCase4TeaEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.TeachSkillID = objvMicroteachCase4TeaEN.TeachSkillID == "[null]" ? null :  objvMicroteachCase4TeaEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convMicroteachCase4Tea.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.SkillTypeName = objvMicroteachCase4TeaEN.SkillTypeName == "[null]" ? null :  objvMicroteachCase4TeaEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.TeachSkillName = objvMicroteachCase4TeaEN.TeachSkillName == "[null]" ? null :  objvMicroteachCase4TeaEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.TeachSkillTheory = objvMicroteachCase4TeaEN.TeachSkillTheory == "[null]" ? null :  objvMicroteachCase4TeaEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convMicroteachCase4Tea.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objvMicroteachCase4TeaEN.TeachSkillOperMethod == "[null]" ? null :  objvMicroteachCase4TeaEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdSkillType = objvMicroteachCase4TeaEN.IdSkillType == "[null]" ? null :  objvMicroteachCase4TeaEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.SkillTypeID = objvMicroteachCase4TeaEN.SkillTypeID == "[null]" ? null :  objvMicroteachCase4TeaEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convMicroteachCase4Tea.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.CaseLevelId = objvMicroteachCase4TeaEN.CaseLevelId == "[null]" ? null :  objvMicroteachCase4TeaEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convMicroteachCase4Tea.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.DocFile = objvMicroteachCase4TeaEN.DocFile == "[null]" ? null :  objvMicroteachCase4TeaEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IsNeedGeneWord = objvMicroteachCase4TeaEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convMicroteachCase4Tea.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.WordCreateDate = objvMicroteachCase4TeaEN.WordCreateDate == "[null]" ? null :  objvMicroteachCase4TeaEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IsVisible = objvMicroteachCase4TeaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroteachCase4Tea.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.microteachCaseText = objvMicroteachCase4TeaEN.microteachCaseText == "[null]" ? null :  objvMicroteachCase4TeaEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroteachCase4Tea.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.OwnerId = objvMicroteachCase4TeaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCase4Tea.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.OwnerName = objvMicroteachCase4TeaEN.OwnerName == "[null]" ? null :  objvMicroteachCase4TeaEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachCase4Tea.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.TeacherId = objvMicroteachCase4TeaEN.TeacherId == "[null]" ? null :  objvMicroteachCase4TeaEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.TeacherName = objvMicroteachCase4TeaEN.TeacherName == "[null]" ? null :  objvMicroteachCase4TeaEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IdXzCollege = objvMicroteachCase4TeaEN.IdXzCollege == "[null]" ? null :  objvMicroteachCase4TeaEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCase4Tea.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.CollegeName = objvMicroteachCase4TeaEN.CollegeName == "[null]" ? null :  objvMicroteachCase4TeaEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.EntryDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.EntryDate = objvMicroteachCase4TeaEN.EntryDate == "[null]" ? null :  objvMicroteachCase4TeaEN.EntryDate; //进校日期
}
if (arrFldSet.Contains(convMicroteachCase4Tea.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.CollegeId = objvMicroteachCase4TeaEN.CollegeId == "[null]" ? null :  objvMicroteachCase4TeaEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convMicroteachCase4Tea.EntryYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.EntryYear = objvMicroteachCase4TeaEN.EntryYear == "[null]" ? null :  objvMicroteachCase4TeaEN.EntryYear; //EntryYear
}
if (arrFldSet.Contains(convMicroteachCase4Tea.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.IsDualVideo = objvMicroteachCase4TeaEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convMicroteachCase4Tea.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.UserTypeId = objvMicroteachCase4TeaEN.UserTypeId == "[null]" ? null :  objvMicroteachCase4TeaEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCase4Tea.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.RecommendedDegreeId = objvMicroteachCase4TeaEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convMicroteachCase4Tea.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.RecommendedDegreeName = objvMicroteachCase4TeaEN.RecommendedDegreeName == "[null]" ? null :  objvMicroteachCase4TeaEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convMicroteachCase4Tea.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.Memo = objvMicroteachCase4TeaEN.Memo == "[null]" ? null :  objvMicroteachCase4TeaEN.Memo; //备注
}
if (arrFldSet.Contains(convMicroteachCase4Tea.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.BrowseCount4Case = objvMicroteachCase4TeaEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachCase4Tea.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.CollegeNameA = objvMicroteachCase4TeaEN.CollegeNameA == "[null]" ? null :  objvMicroteachCase4TeaEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convMicroteachCase4Tea.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase4TeaEN.ftpFileType = objvMicroteachCase4TeaEN.ftpFileType == "[null]" ? null :  objvMicroteachCase4TeaEN.ftpFileType; //ftp文件类型
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
 /// <param name = "objvMicroteachCase4TeaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
try
{
if (objvMicroteachCase4TeaEN.MicroteachCaseTypeName == "[null]") objvMicroteachCase4TeaEN.MicroteachCaseTypeName = null; //微格案例类型名称
if (objvMicroteachCase4TeaEN.MicroteachCaseTheme == "[null]") objvMicroteachCase4TeaEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroteachCase4TeaEN.MicroteachCaseDate == "[null]") objvMicroteachCase4TeaEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCase4TeaEN.MicroteachCaseTime == "[null]") objvMicroteachCase4TeaEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroteachCase4TeaEN.MicroteachCaseDateIn == "[null]") objvMicroteachCase4TeaEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroteachCase4TeaEN.IdStudyLevel == "[null]") objvMicroteachCase4TeaEN.IdStudyLevel = null; //id_StudyLevel
if (objvMicroteachCase4TeaEN.StudyLevelName == "[null]") objvMicroteachCase4TeaEN.StudyLevelName = null; //学段名称
if (objvMicroteachCase4TeaEN.IdTeachingPlan == "[null]") objvMicroteachCase4TeaEN.IdTeachingPlan = null; //教案流水号
if (objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn == "[null]") objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroteachCase4TeaEN.DisciplineID == "[null]") objvMicroteachCase4TeaEN.DisciplineID = null; //学科ID
if (objvMicroteachCase4TeaEN.DisciplineName == "[null]") objvMicroteachCase4TeaEN.DisciplineName = null; //学科名称
if (objvMicroteachCase4TeaEN.IdSenateGaugeVersion == "[null]") objvMicroteachCase4TeaEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvMicroteachCase4TeaEN.senateGaugeVersionID == "[null]") objvMicroteachCase4TeaEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCase4TeaEN.senateGaugeVersionName == "[null]") objvMicroteachCase4TeaEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCase4TeaEN.TeachSkillID == "[null]") objvMicroteachCase4TeaEN.TeachSkillID = null; //教学技能ID
if (objvMicroteachCase4TeaEN.SkillTypeName == "[null]") objvMicroteachCase4TeaEN.SkillTypeName = null; //技能类型名称
if (objvMicroteachCase4TeaEN.TeachSkillName == "[null]") objvMicroteachCase4TeaEN.TeachSkillName = null; //教学技能名称
if (objvMicroteachCase4TeaEN.TeachSkillTheory == "[null]") objvMicroteachCase4TeaEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvMicroteachCase4TeaEN.TeachSkillOperMethod == "[null]") objvMicroteachCase4TeaEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvMicroteachCase4TeaEN.IdSkillType == "[null]") objvMicroteachCase4TeaEN.IdSkillType = null; //技能类型流水号
if (objvMicroteachCase4TeaEN.SkillTypeID == "[null]") objvMicroteachCase4TeaEN.SkillTypeID = null; //技能类型ID
if (objvMicroteachCase4TeaEN.CaseLevelId == "[null]") objvMicroteachCase4TeaEN.CaseLevelId = null; //课例等级Id
if (objvMicroteachCase4TeaEN.DocFile == "[null]") objvMicroteachCase4TeaEN.DocFile = null; //生成的Word文件名
if (objvMicroteachCase4TeaEN.WordCreateDate == "[null]") objvMicroteachCase4TeaEN.WordCreateDate = null; //Word生成日期
if (objvMicroteachCase4TeaEN.microteachCaseText == "[null]") objvMicroteachCase4TeaEN.microteachCaseText = null; //案例文本内容
if (objvMicroteachCase4TeaEN.OwnerName == "[null]") objvMicroteachCase4TeaEN.OwnerName = null; //拥有者姓名
if (objvMicroteachCase4TeaEN.TeacherId == "[null]") objvMicroteachCase4TeaEN.TeacherId = null; //教师工号
if (objvMicroteachCase4TeaEN.TeacherName == "[null]") objvMicroteachCase4TeaEN.TeacherName = null; //教师姓名
if (objvMicroteachCase4TeaEN.IdXzCollege == "[null]") objvMicroteachCase4TeaEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCase4TeaEN.CollegeName == "[null]") objvMicroteachCase4TeaEN.CollegeName = null; //学院名称
if (objvMicroteachCase4TeaEN.EntryDate == "[null]") objvMicroteachCase4TeaEN.EntryDate = null; //进校日期
if (objvMicroteachCase4TeaEN.CollegeId == "[null]") objvMicroteachCase4TeaEN.CollegeId = null; //学院ID
if (objvMicroteachCase4TeaEN.EntryYear == "[null]") objvMicroteachCase4TeaEN.EntryYear = null; //EntryYear
if (objvMicroteachCase4TeaEN.UserTypeId == "[null]") objvMicroteachCase4TeaEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCase4TeaEN.RecommendedDegreeName == "[null]") objvMicroteachCase4TeaEN.RecommendedDegreeName = null; //推荐度名称
if (objvMicroteachCase4TeaEN.Memo == "[null]") objvMicroteachCase4TeaEN.Memo = null; //备注
if (objvMicroteachCase4TeaEN.CollegeNameA == "[null]") objvMicroteachCase4TeaEN.CollegeNameA = null; //学院名称简写
if (objvMicroteachCase4TeaEN.ftpFileType == "[null]") objvMicroteachCase4TeaEN.ftpFileType = null; //ftp文件类型
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
public static void CheckProperty4Condition(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
 vMicroteachCase4TeaDA.CheckProperty4Condition(objvMicroteachCase4TeaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdMicroteachCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convMicroteachCase4Tea.IdMicroteachCase); 
List<clsvMicroteachCase4TeaEN> arrObjLst = clsvMicroteachCase4TeaBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN()
{
IdMicroteachCase = "0",
MicroteachCaseName = "选[vMicroteachCase4Tea]..."
};
arrObjLst.Insert(0, objvMicroteachCase4TeaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convMicroteachCase4Tea.IdMicroteachCase;
objComboBox.DisplayMember = convMicroteachCase4Tea.MicroteachCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdMicroteachCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vMicroteachCase4Tea]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convMicroteachCase4Tea.IdMicroteachCase); 
IEnumerable<clsvMicroteachCase4TeaEN> arrObjLst = clsvMicroteachCase4TeaBL.GetObjLst(strCondition);
objDDL.DataValueField = convMicroteachCase4Tea.IdMicroteachCase;
objDDL.DataTextField = convMicroteachCase4Tea.MicroteachCaseName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdMicroteachCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vMicroteachCase4Tea]...","0");
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst = GetAllvMicroteachCase4TeaObjLstCache(); 
objDDL.DataValueField = convMicroteachCase4Tea.IdMicroteachCase;
objDDL.DataTextField = convMicroteachCase4Tea.MicroteachCaseName;
objDDL.DataSource = arrvMicroteachCase4TeaObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeBL没有刷新缓存机制(clsRsStaffTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeBL没有刷新缓存机制(clsRsProfGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeBL没有刷新缓存机制(clsRsDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceBL没有刷新缓存机制(clsRsProvinceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionBL没有刷新缓存机制(clsRsReligionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifBL没有刷新缓存机制(clsRsQualifBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeBL没有刷新缓存机制(clsRsAdminGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCase");
//if (arrvMicroteachCase4TeaObjLstCache == null)
//{
//arrvMicroteachCase4TeaObjLstCache = vMicroteachCase4TeaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase4TeaEN GetObjByIdMicroteachCaseCache(string strIdMicroteachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel =
arrvMicroteachCase4TeaObjLstCache
.Where(x=> x.IdMicroteachCase == strIdMicroteachCase 
);
if (arrvMicroteachCase4TeaObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase4TeaEN obj = clsvMicroteachCase4TeaBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase4TeaObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroteachCaseNameByIdMicroteachCaseCache(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return "";
//获取缓存中的对象列表
clsvMicroteachCase4TeaEN objvMicroteachCase4Tea = GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase4Tea == null) return "";
return objvMicroteachCase4Tea.MicroteachCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdMicroteachCaseCache(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return "";
//获取缓存中的对象列表
clsvMicroteachCase4TeaEN objvMicroteachCase4Tea = GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase4Tea == null) return "";
return objvMicroteachCase4Tea.MicroteachCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetAllvMicroteachCase4TeaObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase4TeaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase4TeaObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdMicroteachCase)
{
if (strInFldName != convMicroteachCase4Tea.IdMicroteachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase4Tea.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase4Tea.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase4Tea = clsvMicroteachCase4TeaBL.GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase4Tea == null) return "";
return objvMicroteachCase4Tea[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase4TeaDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase4TeaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase4TeaDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase4TeaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaCond)
{
List<clsvMicroteachCase4TeaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase4TeaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase4Tea.AttributeName)
{
if (objvMicroteachCase4TeaCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase4TeaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4TeaCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase4TeaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase4TeaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase4TeaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase4TeaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4TeaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase4TeaCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase4TeaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase4TeaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase4TeaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}