
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4TeaBL
 表名:vMicroteachCase_Resource_Rel4Tea(01120428)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:38
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
public static class  clsvMicroteachCase_Resource_Rel4TeaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObj(this K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4Tea myKey)
{
clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = clsvMicroteachCase_Resource_Rel4TeaBL.vMicroteachCase_Resource_Rel4TeaDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvMicroteachCase_Resource_Rel4TeaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdMicroteachCaseResourceRel(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdMicroteachCase(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseTheme(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseTime(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseDateIn(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdStudyLevel(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetStudyLevelName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
}
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.StudyLevelName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.StudyLevelName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdTeachingPlan(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
}
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdDiscipline(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdDiscipline) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdDiscipline, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdDiscipline] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetDisciplineID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase_Resource_Rel4Tea.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase_Resource_Rel4Tea.DisciplineID);
}
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.DisciplineID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.DisciplineID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.DisciplineID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetDisciplineName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase_Resource_Rel4Tea.DisciplineName);
}
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.DisciplineName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.DisciplineName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.DisciplineName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetsenateGaugeVersionID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
}
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetsenateGaugeVersionName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
}
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdTeachSkill(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
}
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.TeachSkillID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSkillTypeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
}
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.SkillTypeName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.SkillTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
}
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.TeachSkillName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillTheory(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
}
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillOperMethod(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
}
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdSkillType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convMicroteachCase_Resource_Rel4Tea.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convMicroteachCase_Resource_Rel4Tea.IdSkillType);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdSkillType) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdSkillType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdSkillType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSkillTypeID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
}
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.SkillTypeID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.SkillTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCaseLevelId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
}
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.CaseLevelId) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.CaseLevelId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetmicroteachCaseText(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
}
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.microteachCaseText) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.microteachCaseText, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetOwnerId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroteachCase_Resource_Rel4Tea.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase_Resource_Rel4Tea.OwnerId);
}
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.OwnerId) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetOwnerName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase_Resource_Rel4Tea.OwnerName);
}
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.OwnerName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.OwnerName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.OwnerName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeacherID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeacherID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convMicroteachCase_Resource_Rel4Tea.TeacherID);
}
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.TeacherID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.TeacherID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeacherID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeacherName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeacherName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convMicroteachCase_Resource_Rel4Tea.TeacherName);
}
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.TeacherName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.TeacherName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeacherName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdXzCollege(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdXzCollege) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCollegeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase_Resource_Rel4Tea.CollegeName);
}
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.CollegeName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetEntryDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strEntryDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convMicroteachCase_Resource_Rel4Tea.EntryDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convMicroteachCase_Resource_Rel4Tea.EntryDate);
}
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.EntryDate) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.EntryDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.EntryDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCollegeID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCase_Resource_Rel4Tea.CollegeID);
}
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.CollegeID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.CollegeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetEntryYear(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strEntryYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convMicroteachCase_Resource_Rel4Tea.EntryYear);
}
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = strEntryYear; //EntryYear
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.EntryYear) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.EntryYear, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.EntryYear] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIsDualVideo(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IsDualVideo) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IsDualVideo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IsDualVideo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetUserTypeId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase_Resource_Rel4Tea.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase_Resource_Rel4Tea.UserTypeId);
}
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.UserTypeId) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetRecommendedDegreeId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
}
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetRecommendedDegreeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
}
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetBrowseCount4Case(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdResource(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convMicroteachCase_Resource_Rel4Tea.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convMicroteachCase_Resource_Rel4Tea.IdResource);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdResource) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel4Tea.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel4Tea.ResourceID);
}
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ResourceID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel4Tea.ResourceName);
}
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ResourceName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdFtpResource(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdFtpResource) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdFtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdFile(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convMicroteachCase_Resource_Rel4Tea.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convMicroteachCase_Resource_Rel4Tea.IdFile);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdFile) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel4Tea.FileName);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel4Tea.FileType);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileType) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSaveDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel4Tea.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel4Tea.SaveDate);
}
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.SaveDate) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileSize(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel4Tea.FileSize);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileSize) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSaveTime(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel4Tea.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel4Tea.SaveTime);
}
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.SaveTime) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFtpResourceID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
}
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FtpResourceID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileOriginalName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileOriginalName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileDirName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel4Tea.FileDirName);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileDirName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileRename(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel4Tea.FileRename);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileRename) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileRename, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileRename] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileUpDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel4Tea.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel4Tea.FileUpDate);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileUpDate) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileUpTime(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel4Tea.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel4Tea.FileUpTime);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileUpTime) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSaveMode(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.SaveMode) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdResourceType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convMicroteachCase_Resource_Rel4Tea.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convMicroteachCase_Resource_Rel4Tea.IdResourceType);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdResourceType) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceTypeID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
}
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceTypeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
}
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceOwner(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
}
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetftpFileType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel4Tea.ftpFileType);
}
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ftpFileType) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetftpFileSize(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
}
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ftpFileSize) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetftpResourceOwner(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
}
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileOriginName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel4Tea.FileOriginName);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileOriginName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIsExistFile(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IsExistFile) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileNewName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel4Tea.FileNewName);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileNewName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileOldName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel4Tea.FileOldName);
}
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.FileOldName) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIsMain(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, bool bolIsMain, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IsMain) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IsMain, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IsMain] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIdUsingMode(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
}
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IdUsingMode) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IdUsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIsVisible(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IsVisible) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IsVisible, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IsVisible] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIndexNO(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, int? intIndexNO, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.IndexNO) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.IndexNO, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IndexNO] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetBrowseCount(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, int? intBrowseCount, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.BrowseCount) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetUpdDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel4Tea.UpdDate);
}
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.UpdDate) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.UpdDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UpdDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetUpdUser(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel4Tea.UpdUser);
}
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.UpdUser) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMemo(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel4Tea.Memo);
}
objvMicroteachCase_Resource_Rel4TeaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.Memo) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.Memo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.Memo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCollegeNameA(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
}
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.CollegeNameA) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENS, clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENT)
{
try
{
objvMicroteachCase_Resource_Rel4TeaENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4TeaENT.IdStudyLevel = objvMicroteachCase_Resource_Rel4TeaENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaENT.StudyLevelName = objvMicroteachCase_Resource_Rel4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4TeaENT.IdTeachingPlan = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4TeaENT.IdDiscipline = objvMicroteachCase_Resource_Rel4TeaENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineID = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineName = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaENT.IdTeachSkill = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillID = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeName = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillName = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaENT.IdSkillType = objvMicroteachCase_Resource_Rel4TeaENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeID = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4TeaENT.CaseLevelId = objvMicroteachCase_Resource_Rel4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4TeaENT.microteachCaseText = objvMicroteachCase_Resource_Rel4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4TeaENT.OwnerId = objvMicroteachCase_Resource_Rel4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4TeaENT.OwnerName = objvMicroteachCase_Resource_Rel4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaENT.TeacherID = objvMicroteachCase_Resource_Rel4TeaENS.TeacherID; //教师工号
objvMicroteachCase_Resource_Rel4TeaENT.TeacherName = objvMicroteachCase_Resource_Rel4TeaENS.TeacherName; //教师姓名
objvMicroteachCase_Resource_Rel4TeaENT.IdXzCollege = objvMicroteachCase_Resource_Rel4TeaENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4TeaENT.CollegeName = objvMicroteachCase_Resource_Rel4TeaENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4TeaENT.EntryDate = objvMicroteachCase_Resource_Rel4TeaENS.EntryDate; //进校日期
objvMicroteachCase_Resource_Rel4TeaENT.CollegeID = objvMicroteachCase_Resource_Rel4TeaENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4TeaENT.EntryYear = objvMicroteachCase_Resource_Rel4TeaENS.EntryYear; //EntryYear
objvMicroteachCase_Resource_Rel4TeaENT.IsDualVideo = objvMicroteachCase_Resource_Rel4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4TeaENT.UserTypeId = objvMicroteachCase_Resource_Rel4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.IdResource = objvMicroteachCase_Resource_Rel4TeaENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4TeaENT.IdFtpResource = objvMicroteachCase_Resource_Rel4TeaENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.IdFile = objvMicroteachCase_Resource_Rel4TeaENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel4TeaENT.FileName = objvMicroteachCase_Resource_Rel4TeaENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel4TeaENT.FileType = objvMicroteachCase_Resource_Rel4TeaENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel4TeaENT.SaveDate = objvMicroteachCase_Resource_Rel4TeaENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel4TeaENT.FileSize = objvMicroteachCase_Resource_Rel4TeaENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel4TeaENT.SaveTime = objvMicroteachCase_Resource_Rel4TeaENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel4TeaENT.FtpResourceID = objvMicroteachCase_Resource_Rel4TeaENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaENT.FileOriginalName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel4TeaENT.FileDirName = objvMicroteachCase_Resource_Rel4TeaENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel4TeaENT.FileRename = objvMicroteachCase_Resource_Rel4TeaENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel4TeaENT.FileUpDate = objvMicroteachCase_Resource_Rel4TeaENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel4TeaENT.FileUpTime = objvMicroteachCase_Resource_Rel4TeaENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel4TeaENT.SaveMode = objvMicroteachCase_Resource_Rel4TeaENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel4TeaENT.IdResourceType = objvMicroteachCase_Resource_Rel4TeaENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceTypeID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceTypeName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel4TeaENT.ResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel4TeaENT.ftpFileType = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaENT.ftpFileSize = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaENT.FileOriginName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel4TeaENT.IsExistFile = objvMicroteachCase_Resource_Rel4TeaENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel4TeaENT.FileNewName = objvMicroteachCase_Resource_Rel4TeaENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel4TeaENT.FileOldName = objvMicroteachCase_Resource_Rel4TeaENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel4TeaENT.IsMain = objvMicroteachCase_Resource_Rel4TeaENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel4TeaENT.IdUsingMode = objvMicroteachCase_Resource_Rel4TeaENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaENT.IsVisible = objvMicroteachCase_Resource_Rel4TeaENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4TeaENT.IndexNO = objvMicroteachCase_Resource_Rel4TeaENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.UpdDate = objvMicroteachCase_Resource_Rel4TeaENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4TeaENT.UpdUser = objvMicroteachCase_Resource_Rel4TeaENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4TeaENT.Memo = objvMicroteachCase_Resource_Rel4TeaENS.Memo; //备注
objvMicroteachCase_Resource_Rel4TeaENT.CollegeNameA = objvMicroteachCase_Resource_Rel4TeaENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase_Resource_Rel4TeaEN:objvMicroteachCase_Resource_Rel4TeaENT</returns>
 public static clsvMicroteachCase_Resource_Rel4TeaEN CopyTo(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENS)
{
try
{
 clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENT = new clsvMicroteachCase_Resource_Rel4TeaEN()
{
IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
IdMicroteachCase = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objvMicroteachCase_Resource_Rel4TeaENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvMicroteachCase_Resource_Rel4TeaENS.StudyLevelName, //学段名称
IdTeachingPlan = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroTeachCaseTimeIn, //案例入库时间
IdDiscipline = objvMicroteachCase_Resource_Rel4TeaENS.IdDiscipline, //学科流水号
DisciplineID = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineID, //学科ID
DisciplineName = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineName, //学科名称
senateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionTtlScore, //评价量表版本总分
IdTeachSkill = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillID, //教学技能ID
SkillTypeName = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeName, //技能类型名称
TeachSkillName = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvMicroteachCase_Resource_Rel4TeaENS.IdSkillType, //技能类型流水号
SkillTypeID = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeID, //技能类型ID
CaseLevelId = objvMicroteachCase_Resource_Rel4TeaENS.CaseLevelId, //课例等级Id
microteachCaseText = objvMicroteachCase_Resource_Rel4TeaENS.microteachCaseText, //案例文本内容
OwnerId = objvMicroteachCase_Resource_Rel4TeaENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachCase_Resource_Rel4TeaENS.OwnerName, //拥有者姓名
TeacherID = objvMicroteachCase_Resource_Rel4TeaENS.TeacherID, //教师工号
TeacherName = objvMicroteachCase_Resource_Rel4TeaENS.TeacherName, //教师姓名
IdXzCollege = objvMicroteachCase_Resource_Rel4TeaENS.IdXzCollege, //学院流水号
CollegeName = objvMicroteachCase_Resource_Rel4TeaENS.CollegeName, //学院名称
EntryDate = objvMicroteachCase_Resource_Rel4TeaENS.EntryDate, //进校日期
CollegeID = objvMicroteachCase_Resource_Rel4TeaENS.CollegeID, //学院ID
EntryYear = objvMicroteachCase_Resource_Rel4TeaENS.EntryYear, //EntryYear
IsDualVideo = objvMicroteachCase_Resource_Rel4TeaENS.IsDualVideo, //是否双视频
UserTypeId = objvMicroteachCase_Resource_Rel4TeaENS.UserTypeId, //用户类型Id
RecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeName, //推荐度名称
BrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount4Case, //课例浏览次数
IdResource = objvMicroteachCase_Resource_Rel4TeaENS.IdResource, //资源流水号
ResourceID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceID, //资源ID
ResourceName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceName, //资源名称
IdFtpResource = objvMicroteachCase_Resource_Rel4TeaENS.IdFtpResource, //FTP资源流水号
IdFile = objvMicroteachCase_Resource_Rel4TeaENS.IdFile, //文件流水号
FileName = objvMicroteachCase_Resource_Rel4TeaENS.FileName, //文件名称
FileType = objvMicroteachCase_Resource_Rel4TeaENS.FileType, //文件类型
SaveDate = objvMicroteachCase_Resource_Rel4TeaENS.SaveDate, //创建日期
FileSize = objvMicroteachCase_Resource_Rel4TeaENS.FileSize, //文件大小
SaveTime = objvMicroteachCase_Resource_Rel4TeaENS.SaveTime, //创建时间
FtpResourceID = objvMicroteachCase_Resource_Rel4TeaENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginalName, //文件原名
FileDirName = objvMicroteachCase_Resource_Rel4TeaENS.FileDirName, //文件目录名
FileRename = objvMicroteachCase_Resource_Rel4TeaENS.FileRename, //文件新名
FileUpDate = objvMicroteachCase_Resource_Rel4TeaENS.FileUpDate, //创建日期
FileUpTime = objvMicroteachCase_Resource_Rel4TeaENS.FileUpTime, //创建时间
SaveMode = objvMicroteachCase_Resource_Rel4TeaENS.SaveMode, //文件存放方式
IdResourceType = objvMicroteachCase_Resource_Rel4TeaENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ResourceOwner, //上传者
ftpFileType = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileType, //ftp文件类型
ftpFileSize = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginName, //原文件名
IsExistFile = objvMicroteachCase_Resource_Rel4TeaENS.IsExistFile, //是否存在文件
FileNewName = objvMicroteachCase_Resource_Rel4TeaENS.FileNewName, //新文件名
FileOldName = objvMicroteachCase_Resource_Rel4TeaENS.FileOldName, //旧文件名
IsMain = objvMicroteachCase_Resource_Rel4TeaENS.IsMain, //是否主资源
IdUsingMode = objvMicroteachCase_Resource_Rel4TeaENS.IdUsingMode, //资源使用模式流水号
IsVisible = objvMicroteachCase_Resource_Rel4TeaENS.IsVisible, //是否显示
IndexNO = objvMicroteachCase_Resource_Rel4TeaENS.IndexNO, //序号
BrowseCount = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount, //浏览次数
UpdDate = objvMicroteachCase_Resource_Rel4TeaENS.UpdDate, //修改日期
UpdUser = objvMicroteachCase_Resource_Rel4TeaENS.UpdUser, //修改人
Memo = objvMicroteachCase_Resource_Rel4TeaENS.Memo, //备注
CollegeNameA = objvMicroteachCase_Resource_Rel4TeaENS.CollegeNameA, //学院名称简写
};
 return objvMicroteachCase_Resource_Rel4TeaENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
 clsvMicroteachCase_Resource_Rel4TeaBL.vMicroteachCase_Resource_Rel4TeaDA.CheckProperty4Condition(objvMicroteachCase_Resource_Rel4TeaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel, objvMicroteachCase_Resource_Rel4TeaCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase, objvMicroteachCase_Resource_Rel4TeaCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID, objvMicroteachCase_Resource_Rel4TeaCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName, objvMicroteachCase_Resource_Rel4TeaCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme, objvMicroteachCase_Resource_Rel4TeaCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate, objvMicroteachCase_Resource_Rel4TeaCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime, objvMicroteachCase_Resource_Rel4TeaCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn, objvMicroteachCase_Resource_Rel4TeaCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdStudyLevel, objvMicroteachCase_Resource_Rel4TeaCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.StudyLevelName, objvMicroteachCase_Resource_Rel4TeaCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan, objvMicroteachCase_Resource_Rel4TeaCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn, objvMicroteachCase_Resource_Rel4TeaCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdDiscipline, objvMicroteachCase_Resource_Rel4TeaCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.DisciplineID, objvMicroteachCase_Resource_Rel4TeaCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.DisciplineName, objvMicroteachCase_Resource_Rel4TeaCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID, objvMicroteachCase_Resource_Rel4TeaCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName, objvMicroteachCase_Resource_Rel4TeaCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore, objvMicroteachCase_Resource_Rel4TeaCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdTeachSkill, objvMicroteachCase_Resource_Rel4TeaCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillID, objvMicroteachCase_Resource_Rel4TeaCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SkillTypeName, objvMicroteachCase_Resource_Rel4TeaCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillName, objvMicroteachCase_Resource_Rel4TeaCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory, objvMicroteachCase_Resource_Rel4TeaCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod, objvMicroteachCase_Resource_Rel4TeaCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdSkillType, objvMicroteachCase_Resource_Rel4TeaCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SkillTypeID, objvMicroteachCase_Resource_Rel4TeaCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CaseLevelId, objvMicroteachCase_Resource_Rel4TeaCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.microteachCaseText, objvMicroteachCase_Resource_Rel4TeaCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.OwnerId, objvMicroteachCase_Resource_Rel4TeaCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.OwnerName, objvMicroteachCase_Resource_Rel4TeaCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeacherID) == true)
{
string strComparisonOpTeacherID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeacherID, objvMicroteachCase_Resource_Rel4TeaCond.TeacherID, strComparisonOpTeacherID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeacherName) == true)
{
string strComparisonOpTeacherName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeacherName, objvMicroteachCase_Resource_Rel4TeaCond.TeacherName, strComparisonOpTeacherName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdXzCollege, objvMicroteachCase_Resource_Rel4TeaCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CollegeName, objvMicroteachCase_Resource_Rel4TeaCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.EntryDate) == true)
{
string strComparisonOpEntryDate = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.EntryDate, objvMicroteachCase_Resource_Rel4TeaCond.EntryDate, strComparisonOpEntryDate);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CollegeID) == true)
{
string strComparisonOpCollegeID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CollegeID, objvMicroteachCase_Resource_Rel4TeaCond.CollegeID, strComparisonOpCollegeID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.EntryYear) == true)
{
string strComparisonOpEntryYear = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.EntryYear, objvMicroteachCase_Resource_Rel4TeaCond.EntryYear, strComparisonOpEntryYear);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsDualVideo) == true)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
}
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.UserTypeId, objvMicroteachCase_Resource_Rel4TeaCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId, objvMicroteachCase_Resource_Rel4TeaCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName, objvMicroteachCase_Resource_Rel4TeaCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case, objvMicroteachCase_Resource_Rel4TeaCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdResource) == true)
{
string strComparisonOpIdResource = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdResource, objvMicroteachCase_Resource_Rel4TeaCond.IdResource, strComparisonOpIdResource);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceID) == true)
{
string strComparisonOpResourceID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceID, objvMicroteachCase_Resource_Rel4TeaCond.ResourceID, strComparisonOpResourceID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceName) == true)
{
string strComparisonOpResourceName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceName, objvMicroteachCase_Resource_Rel4TeaCond.ResourceName, strComparisonOpResourceName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdFtpResource, objvMicroteachCase_Resource_Rel4TeaCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdFile) == true)
{
string strComparisonOpIdFile = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdFile, objvMicroteachCase_Resource_Rel4TeaCond.IdFile, strComparisonOpIdFile);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileName) == true)
{
string strComparisonOpFileName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileName, objvMicroteachCase_Resource_Rel4TeaCond.FileName, strComparisonOpFileName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileType) == true)
{
string strComparisonOpFileType = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileType, objvMicroteachCase_Resource_Rel4TeaCond.FileType, strComparisonOpFileType);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SaveDate) == true)
{
string strComparisonOpSaveDate = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SaveDate, objvMicroteachCase_Resource_Rel4TeaCond.SaveDate, strComparisonOpSaveDate);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileSize) == true)
{
string strComparisonOpFileSize = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileSize, objvMicroteachCase_Resource_Rel4TeaCond.FileSize, strComparisonOpFileSize);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SaveTime) == true)
{
string strComparisonOpSaveTime = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SaveTime, objvMicroteachCase_Resource_Rel4TeaCond.SaveTime, strComparisonOpSaveTime);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FtpResourceID, objvMicroteachCase_Resource_Rel4TeaCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileOriginalName, objvMicroteachCase_Resource_Rel4TeaCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileDirName) == true)
{
string strComparisonOpFileDirName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileDirName, objvMicroteachCase_Resource_Rel4TeaCond.FileDirName, strComparisonOpFileDirName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileRename) == true)
{
string strComparisonOpFileRename = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileRename, objvMicroteachCase_Resource_Rel4TeaCond.FileRename, strComparisonOpFileRename);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileUpDate, objvMicroteachCase_Resource_Rel4TeaCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileUpTime, objvMicroteachCase_Resource_Rel4TeaCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdResourceType, objvMicroteachCase_Resource_Rel4TeaCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceTypeID, objvMicroteachCase_Resource_Rel4TeaCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceTypeName, objvMicroteachCase_Resource_Rel4TeaCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceOwner, objvMicroteachCase_Resource_Rel4TeaCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ftpFileType, objvMicroteachCase_Resource_Rel4TeaCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ftpFileSize, objvMicroteachCase_Resource_Rel4TeaCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner, objvMicroteachCase_Resource_Rel4TeaCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileOriginName, objvMicroteachCase_Resource_Rel4TeaCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileNewName) == true)
{
string strComparisonOpFileNewName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileNewName, objvMicroteachCase_Resource_Rel4TeaCond.FileNewName, strComparisonOpFileNewName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileOldName) == true)
{
string strComparisonOpFileOldName = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileOldName, objvMicroteachCase_Resource_Rel4TeaCond.FileOldName, strComparisonOpFileOldName);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.IdUsingMode, objvMicroteachCase_Resource_Rel4TeaCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsVisible) == true)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsVisible);
}
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IndexNO) == true)
{
string strComparisonOpIndexNO = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.IndexNO, objvMicroteachCase_Resource_Rel4TeaCond.IndexNO, strComparisonOpIndexNO);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.BrowseCount, objvMicroteachCase_Resource_Rel4TeaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.UpdDate, objvMicroteachCase_Resource_Rel4TeaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.UpdUser, objvMicroteachCase_Resource_Rel4TeaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.Memo, objvMicroteachCase_Resource_Rel4TeaCond.Memo, strComparisonOpMemo);
}
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CollegeNameA, objvMicroteachCase_Resource_Rel4TeaCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase_Resource_Rel4Tea
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格资源关系4Tea(vMicroteachCase_Resource_Rel4Tea)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_Rel4TeaBL
{
public static RelatedActions_vMicroteachCase_Resource_Rel4Tea relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase_Resource_Rel4TeaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase_Resource_Rel4TeaDA vMicroteachCase_Resource_Rel4TeaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase_Resource_Rel4TeaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase_Resource_Rel4TeaBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel4TeaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel4TeaEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase_Resource_Rel4Tea(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable_vMicroteachCase_Resource_Rel4Tea(strWhereCond);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase_Resource_Rel4TeaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
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
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel =
arrvMicroteachCase_Resource_Rel4TeaObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel4TeaEN> GetSubObjLstCache(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaCond)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel4Tea.AttributeName)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4TeaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4TeaCond[strFldName]));
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
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
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
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
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase_Resource_Rel4Tea(ref clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
bool bolResult = vMicroteachCase_Resource_Rel4TeaDA.GetvMicroteachCase_Resource_Rel4Tea(ref objvMicroteachCase_Resource_Rel4TeaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = vMicroteachCase_Resource_Rel4TeaDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvMicroteachCase_Resource_Rel4TeaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = vMicroteachCase_Resource_Rel4TeaDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase_Resource_Rel4TeaEN;
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
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = vMicroteachCase_Resource_Rel4TeaDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_Rel4TeaEN;
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
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = vMicroteachCase_Resource_Rel4TeaDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_Rel4TeaEN;
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
 /// <param name = "lstvMicroteachCase_Resource_Rel4TeaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvMicroteachCase_Resource_Rel4TeaEN> lstvMicroteachCase_Resource_Rel4TeaObjLst)
{
foreach (clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN in lstvMicroteachCase_Resource_Rel4TeaObjLst)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvMicroteachCase_Resource_Rel4TeaEN;
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
 lngIdMicroteachCaseResourceRel = new clsvMicroteachCase_Resource_Rel4TeaDA().GetFirstID(strWhereCond);
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
 arrList = vMicroteachCase_Resource_Rel4TeaDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_Rel4TeaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_Rel4TeaDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvMicroteachCase_Resource_Rel4TeaDA.IsExistTable();
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
 bolIsExist = vMicroteachCase_Resource_Rel4TeaDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENS, clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENT)
{
try
{
objvMicroteachCase_Resource_Rel4TeaENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4TeaENT.IdStudyLevel = objvMicroteachCase_Resource_Rel4TeaENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaENT.StudyLevelName = objvMicroteachCase_Resource_Rel4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4TeaENT.IdTeachingPlan = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4TeaENT.IdDiscipline = objvMicroteachCase_Resource_Rel4TeaENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineID = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineName = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaENT.IdTeachSkill = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillID = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeName = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillName = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaENT.IdSkillType = objvMicroteachCase_Resource_Rel4TeaENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeID = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4TeaENT.CaseLevelId = objvMicroteachCase_Resource_Rel4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4TeaENT.microteachCaseText = objvMicroteachCase_Resource_Rel4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4TeaENT.OwnerId = objvMicroteachCase_Resource_Rel4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4TeaENT.OwnerName = objvMicroteachCase_Resource_Rel4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaENT.TeacherID = objvMicroteachCase_Resource_Rel4TeaENS.TeacherID; //教师工号
objvMicroteachCase_Resource_Rel4TeaENT.TeacherName = objvMicroteachCase_Resource_Rel4TeaENS.TeacherName; //教师姓名
objvMicroteachCase_Resource_Rel4TeaENT.IdXzCollege = objvMicroteachCase_Resource_Rel4TeaENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4TeaENT.CollegeName = objvMicroteachCase_Resource_Rel4TeaENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4TeaENT.EntryDate = objvMicroteachCase_Resource_Rel4TeaENS.EntryDate; //进校日期
objvMicroteachCase_Resource_Rel4TeaENT.CollegeID = objvMicroteachCase_Resource_Rel4TeaENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4TeaENT.EntryYear = objvMicroteachCase_Resource_Rel4TeaENS.EntryYear; //EntryYear
objvMicroteachCase_Resource_Rel4TeaENT.IsDualVideo = objvMicroteachCase_Resource_Rel4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4TeaENT.UserTypeId = objvMicroteachCase_Resource_Rel4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.IdResource = objvMicroteachCase_Resource_Rel4TeaENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4TeaENT.IdFtpResource = objvMicroteachCase_Resource_Rel4TeaENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.IdFile = objvMicroteachCase_Resource_Rel4TeaENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel4TeaENT.FileName = objvMicroteachCase_Resource_Rel4TeaENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel4TeaENT.FileType = objvMicroteachCase_Resource_Rel4TeaENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel4TeaENT.SaveDate = objvMicroteachCase_Resource_Rel4TeaENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel4TeaENT.FileSize = objvMicroteachCase_Resource_Rel4TeaENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel4TeaENT.SaveTime = objvMicroteachCase_Resource_Rel4TeaENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel4TeaENT.FtpResourceID = objvMicroteachCase_Resource_Rel4TeaENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaENT.FileOriginalName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel4TeaENT.FileDirName = objvMicroteachCase_Resource_Rel4TeaENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel4TeaENT.FileRename = objvMicroteachCase_Resource_Rel4TeaENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel4TeaENT.FileUpDate = objvMicroteachCase_Resource_Rel4TeaENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel4TeaENT.FileUpTime = objvMicroteachCase_Resource_Rel4TeaENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel4TeaENT.SaveMode = objvMicroteachCase_Resource_Rel4TeaENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel4TeaENT.IdResourceType = objvMicroteachCase_Resource_Rel4TeaENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceTypeID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceTypeName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel4TeaENT.ResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel4TeaENT.ftpFileType = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaENT.ftpFileSize = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaENT.FileOriginName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel4TeaENT.IsExistFile = objvMicroteachCase_Resource_Rel4TeaENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel4TeaENT.FileNewName = objvMicroteachCase_Resource_Rel4TeaENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel4TeaENT.FileOldName = objvMicroteachCase_Resource_Rel4TeaENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel4TeaENT.IsMain = objvMicroteachCase_Resource_Rel4TeaENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel4TeaENT.IdUsingMode = objvMicroteachCase_Resource_Rel4TeaENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaENT.IsVisible = objvMicroteachCase_Resource_Rel4TeaENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4TeaENT.IndexNO = objvMicroteachCase_Resource_Rel4TeaENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.UpdDate = objvMicroteachCase_Resource_Rel4TeaENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4TeaENT.UpdUser = objvMicroteachCase_Resource_Rel4TeaENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4TeaENT.Memo = objvMicroteachCase_Resource_Rel4TeaENS.Memo; //备注
objvMicroteachCase_Resource_Rel4TeaENT.CollegeNameA = objvMicroteachCase_Resource_Rel4TeaENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
try
{
objvMicroteachCase_Resource_Rel4TeaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase_Resource_Rel4TeaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objvMicroteachCase_Resource_Rel4TeaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objvMicroteachCase_Resource_Rel4TeaEN.OwnerName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.TeacherID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objvMicroteachCase_Resource_Rel4TeaEN.TeacherID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.TeacherID; //教师工号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objvMicroteachCase_Resource_Rel4TeaEN.TeacherName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objvMicroteachCase_Resource_Rel4TeaEN.CollegeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.EntryDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objvMicroteachCase_Resource_Rel4TeaEN.EntryDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.EntryDate; //进校日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objvMicroteachCase_Resource_Rel4TeaEN.CollegeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.EntryYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objvMicroteachCase_Resource_Rel4TeaEN.EntryYear == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.EntryYear; //EntryYear
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objvMicroteachCase_Resource_Rel4TeaEN.IdResource == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objvMicroteachCase_Resource_Rel4TeaEN.ResourceID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objvMicroteachCase_Resource_Rel4TeaEN.ResourceName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objvMicroteachCase_Resource_Rel4TeaEN.IdFile == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objvMicroteachCase_Resource_Rel4TeaEN.FileName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileName; //文件名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objvMicroteachCase_Resource_Rel4TeaEN.FileType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileType; //文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objvMicroteachCase_Resource_Rel4TeaEN.SaveDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objvMicroteachCase_Resource_Rel4TeaEN.FileSize == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objvMicroteachCase_Resource_Rel4TeaEN.SaveTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objvMicroteachCase_Resource_Rel4TeaEN.FileDirName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objvMicroteachCase_Resource_Rel4TeaEN.FileRename == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = objvMicroteachCase_Resource_Rel4TeaEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objvMicroteachCase_Resource_Rel4TeaEN.FileNewName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objvMicroteachCase_Resource_Rel4TeaEN.FileOldName == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = objvMicroteachCase_Resource_Rel4TeaEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = objvMicroteachCase_Resource_Rel4TeaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objvMicroteachCase_Resource_Rel4TeaEN.IndexNO; //序号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objvMicroteachCase_Resource_Rel4TeaEN.UpdDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objvMicroteachCase_Resource_Rel4TeaEN.UpdUser == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objvMicroteachCase_Resource_Rel4TeaEN.Memo == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.Memo; //备注
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel4Tea.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA == "[null]" ? null :  objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
try
{
if (objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = null; //微格教学案例流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = null; //微格教学时间
if (objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = null; //案例入库日期
if (objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = null; //id_StudyLevel
if (objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = null; //学段名称
if (objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = null; //教案流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = null; //学科ID
if (objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = null; //学科名称
if (objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = null; //教学技能ID
if (objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = null; //技能类型名称
if (objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = null; //教学技能名称
if (objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = null; //技能类型流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = null; //技能类型ID
if (objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = null; //课例等级Id
if (objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = null; //案例文本内容
if (objvMicroteachCase_Resource_Rel4TeaEN.OwnerName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = null; //拥有者姓名
if (objvMicroteachCase_Resource_Rel4TeaEN.TeacherID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = null; //教师工号
if (objvMicroteachCase_Resource_Rel4TeaEN.TeacherName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = null; //教师姓名
if (objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.CollegeName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = null; //学院名称
if (objvMicroteachCase_Resource_Rel4TeaEN.EntryDate == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = null; //进校日期
if (objvMicroteachCase_Resource_Rel4TeaEN.CollegeID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = null; //学院ID
if (objvMicroteachCase_Resource_Rel4TeaEN.EntryYear == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = null; //EntryYear
if (objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = null; //推荐度名称
if (objvMicroteachCase_Resource_Rel4TeaEN.IdResource == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdResource = null; //资源流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.ResourceID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = null; //资源ID
if (objvMicroteachCase_Resource_Rel4TeaEN.ResourceName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = null; //资源名称
if (objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = null; //FTP资源流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.IdFile == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdFile = null; //文件流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.FileName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileName = null; //文件名称
if (objvMicroteachCase_Resource_Rel4TeaEN.FileType == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileType = null; //文件类型
if (objvMicroteachCase_Resource_Rel4TeaEN.SaveDate == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = null; //创建日期
if (objvMicroteachCase_Resource_Rel4TeaEN.FileSize == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileSize = null; //文件大小
if (objvMicroteachCase_Resource_Rel4TeaEN.SaveTime == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = null; //创建时间
if (objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = null; //FTP资源ID
if (objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = null; //文件原名
if (objvMicroteachCase_Resource_Rel4TeaEN.FileDirName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = null; //文件目录名
if (objvMicroteachCase_Resource_Rel4TeaEN.FileRename == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileRename = null; //文件新名
if (objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = null; //创建日期
if (objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = null; //创建时间
if (objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = null; //资源类型流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = null; //资源类型ID
if (objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = null; //资源类型名称
if (objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = null; //上传者
if (objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = null; //ftp文件类型
if (objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = null; //ftp文件大小
if (objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = null; //原文件名
if (objvMicroteachCase_Resource_Rel4TeaEN.FileNewName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = null; //新文件名
if (objvMicroteachCase_Resource_Rel4TeaEN.FileOldName == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = null; //旧文件名
if (objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = null; //资源使用模式流水号
if (objvMicroteachCase_Resource_Rel4TeaEN.UpdDate == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = null; //修改日期
if (objvMicroteachCase_Resource_Rel4TeaEN.UpdUser == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = null; //修改人
if (objvMicroteachCase_Resource_Rel4TeaEN.Memo == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.Memo = null; //备注
if (objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA == "[null]") objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
 vMicroteachCase_Resource_Rel4TeaDA.CheckProperty4Condition(objvMicroteachCase_Resource_Rel4TeaEN);
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
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvMicroteachCase_Resource_Rel4TeaObjLstCache == null)
//{
//arrvMicroteachCase_Resource_Rel4TeaObjLstCache = vMicroteachCase_Resource_Rel4TeaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel =
arrvMicroteachCase_Resource_Rel4TeaObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_Rel4TeaEN obj = clsvMicroteachCase_Resource_Rel4TeaBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetAllvMicroteachCase_Resource_Rel4TeaObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase_Resource_Rel4TeaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_Rel4TeaObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName);
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
if (strInFldName != convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase_Resource_Rel4Tea.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase_Resource_Rel4Tea.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase_Resource_Rel4Tea = clsvMicroteachCase_Resource_Rel4TeaBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvMicroteachCase_Resource_Rel4Tea == null) return "";
return objvMicroteachCase_Resource_Rel4Tea[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase_Resource_Rel4TeaDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase_Resource_Rel4TeaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase_Resource_Rel4TeaDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase_Resource_Rel4TeaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaCond)
{
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel4Tea.AttributeName)
{
if (objvMicroteachCase_Resource_Rel4TeaCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_Rel4TeaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_Rel4TeaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4TeaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel4TeaCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase_Resource_Rel4TeaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_Rel4TeaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_Rel4TeaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}