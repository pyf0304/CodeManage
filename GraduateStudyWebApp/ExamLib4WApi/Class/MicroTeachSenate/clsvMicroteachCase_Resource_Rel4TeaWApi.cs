
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4TeaWApi
 表名:vMicroteachCase_Resource_Rel4Tea(01120428)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:23
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
public static class clsvMicroteachCase_Resource_Rel4TeaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_MicroteachCase_Resource_Rel(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel4TeaEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_MicroteachCase(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase);
objvMicroteachCase_Resource_Rel4TeaEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseTheme(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseTime(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroteachCaseDateIn(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_StudyLevel(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroteachCase_Resource_Rel4Tea.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroteachCase_Resource_Rel4Tea.id_StudyLevel);
objvMicroteachCase_Resource_Rel4TeaEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_StudyLevel) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetStudyLevelName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_TeachingPlan(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan);
objvMicroteachCase_Resource_Rel4TeaEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_Discipline(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMicroteachCase_Resource_Rel4Tea.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMicroteachCase_Resource_Rel4Tea.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMicroteachCase_Resource_Rel4Tea.id_Discipline);
objvMicroteachCase_Resource_Rel4TeaEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_Discipline) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_Discipline, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_Discipline] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetDisciplineID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase_Resource_Rel4Tea.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase_Resource_Rel4Tea.DisciplineID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetDisciplineName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase_Resource_Rel4Tea.DisciplineName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetsenateGaugeVersionID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetsenateGaugeVersionName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_TeachSkill(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convMicroteachCase_Resource_Rel4Tea.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convMicroteachCase_Resource_Rel4Tea.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convMicroteachCase_Resource_Rel4Tea.id_TeachSkill);
objvMicroteachCase_Resource_Rel4TeaEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_TeachSkill) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_TeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_TeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSkillTypeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillTheory(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeachSkillOperMethod(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_SkillType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convMicroteachCase_Resource_Rel4Tea.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convMicroteachCase_Resource_Rel4Tea.id_SkillType);
objvMicroteachCase_Resource_Rel4TeaEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_SkillType) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_SkillType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_SkillType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSkillTypeID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCaseLevelId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetmicroteachCaseText(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetOwnerId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroteachCase_Resource_Rel4Tea.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase_Resource_Rel4Tea.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetOwnerName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase_Resource_Rel4Tea.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeacherID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convMicroteachCase_Resource_Rel4Tea.TeacherID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetTeacherName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convMicroteachCase_Resource_Rel4Tea.TeacherName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_XzCollege(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCase_Resource_Rel4Tea.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCase_Resource_Rel4Tea.id_XzCollege);
objvMicroteachCase_Resource_Rel4TeaEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_XzCollege) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCollegeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase_Resource_Rel4Tea.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetEntryDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convMicroteachCase_Resource_Rel4Tea.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convMicroteachCase_Resource_Rel4Tea.EntryDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCollegeID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCase_Resource_Rel4Tea.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetEntryYear(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strEntryYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convMicroteachCase_Resource_Rel4Tea.EntryYear);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetUserTypeId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase_Resource_Rel4Tea.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase_Resource_Rel4Tea.UserTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetRecommendedDegreeId(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetRecommendedDegreeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetBrowseCount4Case(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, int intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_Resource(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMicroteachCase_Resource_Rel4Tea.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMicroteachCase_Resource_Rel4Tea.id_Resource);
objvMicroteachCase_Resource_Rel4TeaEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_Resource) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_Resource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_Resource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel4Tea.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel4Tea.ResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel4Tea.ResourceName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_FtpResource(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMicroteachCase_Resource_Rel4Tea.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMicroteachCase_Resource_Rel4Tea.id_FtpResource);
objvMicroteachCase_Resource_Rel4TeaEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_FtpResource) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_FtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_FtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_File(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMicroteachCase_Resource_Rel4Tea.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMicroteachCase_Resource_Rel4Tea.id_File);
objvMicroteachCase_Resource_Rel4TeaEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_File) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_File, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_File] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel4Tea.FileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel4Tea.FileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSaveDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel4Tea.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel4Tea.SaveDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileSize(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel4Tea.FileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetSaveTime(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel4Tea.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel4Tea.SaveTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFtpResourceID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileOriginalName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileDirName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel4Tea.FileDirName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileRename(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel4Tea.FileRename);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileUpDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel4Tea.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel4Tea.FileUpDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileUpTime(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel4Tea.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel4Tea.FileUpTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_ResourceType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMicroteachCase_Resource_Rel4Tea.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMicroteachCase_Resource_Rel4Tea.id_ResourceType);
objvMicroteachCase_Resource_Rel4TeaEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_ResourceType) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_ResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_ResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceTypeID(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceTypeName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetResourceOwner(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetftpFileType(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel4Tea.ftpFileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetftpFileSize(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetftpResourceOwner(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileOriginName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel4Tea.FileOriginName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileNewName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel4Tea.FileNewName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetFileOldName(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel4Tea.FileOldName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN Setid_UsingMode(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convMicroteachCase_Resource_Rel4Tea.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convMicroteachCase_Resource_Rel4Tea.id_UsingMode);
objvMicroteachCase_Resource_Rel4TeaEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel4Tea.id_UsingMode) == false)
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel4Tea.id_UsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel4TeaEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_UsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetIndexNO(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, int intIndexNO, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetBrowseCount(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetUpdDate(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel4Tea.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetUpdUser(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel4Tea.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetMemo(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel4Tea.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN SetCollegeNameA(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4Tea_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel, objvMicroteachCase_Resource_Rel4Tea_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase, objvMicroteachCase_Resource_Rel4Tea_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_StudyLevel, objvMicroteachCase_Resource_Rel4Tea_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.StudyLevelName, objvMicroteachCase_Resource_Rel4Tea_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan, objvMicroteachCase_Resource_Rel4Tea_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn, objvMicroteachCase_Resource_Rel4Tea_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_Discipline, objvMicroteachCase_Resource_Rel4Tea_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.DisciplineID, objvMicroteachCase_Resource_Rel4Tea_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.DisciplineName, objvMicroteachCase_Resource_Rel4Tea_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID, objvMicroteachCase_Resource_Rel4Tea_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName, objvMicroteachCase_Resource_Rel4Tea_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore, objvMicroteachCase_Resource_Rel4Tea_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_TeachSkill, objvMicroteachCase_Resource_Rel4Tea_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillID, objvMicroteachCase_Resource_Rel4Tea_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SkillTypeName, objvMicroteachCase_Resource_Rel4Tea_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillName, objvMicroteachCase_Resource_Rel4Tea_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory, objvMicroteachCase_Resource_Rel4Tea_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod, objvMicroteachCase_Resource_Rel4Tea_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_SkillType, objvMicroteachCase_Resource_Rel4Tea_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SkillTypeID, objvMicroteachCase_Resource_Rel4Tea_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CaseLevelId, objvMicroteachCase_Resource_Rel4Tea_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.microteachCaseText, objvMicroteachCase_Resource_Rel4Tea_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.OwnerId, objvMicroteachCase_Resource_Rel4Tea_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.OwnerName, objvMicroteachCase_Resource_Rel4Tea_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeacherID, objvMicroteachCase_Resource_Rel4Tea_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.TeacherName, objvMicroteachCase_Resource_Rel4Tea_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_XzCollege, objvMicroteachCase_Resource_Rel4Tea_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CollegeName, objvMicroteachCase_Resource_Rel4Tea_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.EntryDate) == true)
{
string strComparisonOp_EntryDate = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.EntryDate, objvMicroteachCase_Resource_Rel4Tea_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CollegeID, objvMicroteachCase_Resource_Rel4Tea_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.EntryYear) == true)
{
string strComparisonOp_EntryYear = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.EntryYear, objvMicroteachCase_Resource_Rel4Tea_Cond.EntryYear, strComparisonOp_EntryYear);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsDualVideo) == true)
{
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
}
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.UserTypeId, objvMicroteachCase_Resource_Rel4Tea_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId, objvMicroteachCase_Resource_Rel4Tea_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName, objvMicroteachCase_Resource_Rel4Tea_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case, objvMicroteachCase_Resource_Rel4Tea_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_Resource, objvMicroteachCase_Resource_Rel4Tea_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceID, objvMicroteachCase_Resource_Rel4Tea_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceName, objvMicroteachCase_Resource_Rel4Tea_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_FtpResource, objvMicroteachCase_Resource_Rel4Tea_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_File) == true)
{
string strComparisonOp_id_File = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_File, objvMicroteachCase_Resource_Rel4Tea_Cond.id_File, strComparisonOp_id_File);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileName) == true)
{
string strComparisonOp_FileName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileName, objvMicroteachCase_Resource_Rel4Tea_Cond.FileName, strComparisonOp_FileName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileType) == true)
{
string strComparisonOp_FileType = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileType, objvMicroteachCase_Resource_Rel4Tea_Cond.FileType, strComparisonOp_FileType);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SaveDate, objvMicroteachCase_Resource_Rel4Tea_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileSize) == true)
{
string strComparisonOp_FileSize = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileSize, objvMicroteachCase_Resource_Rel4Tea_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.SaveTime, objvMicroteachCase_Resource_Rel4Tea_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FtpResourceID, objvMicroteachCase_Resource_Rel4Tea_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileOriginalName, objvMicroteachCase_Resource_Rel4Tea_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileDirName, objvMicroteachCase_Resource_Rel4Tea_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileRename) == true)
{
string strComparisonOp_FileRename = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileRename, objvMicroteachCase_Resource_Rel4Tea_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileUpDate, objvMicroteachCase_Resource_Rel4Tea_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileUpTime, objvMicroteachCase_Resource_Rel4Tea_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel4Tea_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_ResourceType, objvMicroteachCase_Resource_Rel4Tea_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceTypeID, objvMicroteachCase_Resource_Rel4Tea_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceTypeName, objvMicroteachCase_Resource_Rel4Tea_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ResourceOwner, objvMicroteachCase_Resource_Rel4Tea_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ftpFileType, objvMicroteachCase_Resource_Rel4Tea_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ftpFileSize, objvMicroteachCase_Resource_Rel4Tea_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner, objvMicroteachCase_Resource_Rel4Tea_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileOriginName, objvMicroteachCase_Resource_Rel4Tea_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileNewName, objvMicroteachCase_Resource_Rel4Tea_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.FileOldName, objvMicroteachCase_Resource_Rel4Tea_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.id_UsingMode, objvMicroteachCase_Resource_Rel4Tea_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IsVisible) == true)
{
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel4Tea.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel4Tea.IsVisible);
}
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.IndexNO, objvMicroteachCase_Resource_Rel4Tea_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel4Tea.BrowseCount, objvMicroteachCase_Resource_Rel4Tea_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.UpdDate, objvMicroteachCase_Resource_Rel4Tea_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.UpdUser, objvMicroteachCase_Resource_Rel4Tea_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.Memo, objvMicroteachCase_Resource_Rel4Tea_Cond.Memo, strComparisonOp_Memo);
}
if (objvMicroteachCase_Resource_Rel4Tea_Cond.IsUpdated(convMicroteachCase_Resource_Rel4Tea.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachCase_Resource_Rel4Tea_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel4Tea.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel4Tea.CollegeNameA, objvMicroteachCase_Resource_Rel4Tea_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v微格资源关系4Tea(vMicroteachCase_Resource_Rel4Tea)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_Rel4TeaWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase_Resource_Rel4TeaApi";

 public clsvMicroteachCase_Resource_Rel4TeaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = null;
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
objvMicroteachCase_Resource_Rel4TeaEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel4TeaEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel4TeaEN;
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
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = null;
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
objvMicroteachCase_Resource_Rel4TeaEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel4TeaEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel4TeaEN;
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
public static clsvMicroteachCase_Resource_Rel4TeaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = null;
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
objvMicroteachCase_Resource_Rel4TeaEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel4TeaEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel4TeaEN;
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
public static clsvMicroteachCase_Resource_Rel4TeaEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel =
from objvMicroteachCase_Resource_Rel4TeaEN in arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache
where objvMicroteachCase_Resource_Rel4TeaEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvMicroteachCase_Resource_Rel4TeaEN;
if (arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_Rel4TeaEN obj = clsvMicroteachCase_Resource_Rel4TeaWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel =
from objvMicroteachCase_Resource_Rel4TeaEN in arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvMicroteachCase_Resource_Rel4TeaEN.id_MicroteachCase_Resource_Rel)
select objvMicroteachCase_Resource_Rel4TeaEN;
return arrvMicroteachCase_Resource_Rel4TeaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENS, clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENT)
{
try
{
objvMicroteachCase_Resource_Rel4TeaENT.id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel4TeaENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaENT.id_MicroteachCase = objvMicroteachCase_Resource_Rel4TeaENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4TeaENT.id_StudyLevel = objvMicroteachCase_Resource_Rel4TeaENS.id_StudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaENT.StudyLevelName = objvMicroteachCase_Resource_Rel4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4TeaENT.id_TeachingPlan = objvMicroteachCase_Resource_Rel4TeaENS.id_TeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4TeaENT.id_Discipline = objvMicroteachCase_Resource_Rel4TeaENS.id_Discipline; //学科流水号
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineID = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineName = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaENT.id_TeachSkill = objvMicroteachCase_Resource_Rel4TeaENS.id_TeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillID = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeName = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillName = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaENT.id_SkillType = objvMicroteachCase_Resource_Rel4TeaENS.id_SkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeID = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4TeaENT.CaseLevelId = objvMicroteachCase_Resource_Rel4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4TeaENT.microteachCaseText = objvMicroteachCase_Resource_Rel4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4TeaENT.OwnerId = objvMicroteachCase_Resource_Rel4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4TeaENT.OwnerName = objvMicroteachCase_Resource_Rel4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaENT.TeacherID = objvMicroteachCase_Resource_Rel4TeaENS.TeacherID; //教师工号
objvMicroteachCase_Resource_Rel4TeaENT.TeacherName = objvMicroteachCase_Resource_Rel4TeaENS.TeacherName; //教师姓名
objvMicroteachCase_Resource_Rel4TeaENT.id_XzCollege = objvMicroteachCase_Resource_Rel4TeaENS.id_XzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4TeaENT.CollegeName = objvMicroteachCase_Resource_Rel4TeaENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4TeaENT.EntryDate = objvMicroteachCase_Resource_Rel4TeaENS.EntryDate; //进校日期
objvMicroteachCase_Resource_Rel4TeaENT.CollegeID = objvMicroteachCase_Resource_Rel4TeaENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4TeaENT.EntryYear = objvMicroteachCase_Resource_Rel4TeaENS.EntryYear; //EntryYear
objvMicroteachCase_Resource_Rel4TeaENT.IsDualVideo = objvMicroteachCase_Resource_Rel4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4TeaENT.UserTypeId = objvMicroteachCase_Resource_Rel4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.id_Resource = objvMicroteachCase_Resource_Rel4TeaENS.id_Resource; //资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4TeaENT.id_FtpResource = objvMicroteachCase_Resource_Rel4TeaENS.id_FtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.id_File = objvMicroteachCase_Resource_Rel4TeaENS.id_File; //文件流水号
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
objvMicroteachCase_Resource_Rel4TeaENT.id_ResourceType = objvMicroteachCase_Resource_Rel4TeaENS.id_ResourceType; //资源类型流水号
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
objvMicroteachCase_Resource_Rel4TeaENT.id_UsingMode = objvMicroteachCase_Resource_Rel4TeaENS.id_UsingMode; //资源使用模式流水号
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
public static DataTable ToDataTable(List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase_Resource_Rel4TeaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase_Resource_Rel4TeaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase_Resource_Rel4TeaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase_Resource_Rel4TeaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase_Resource_Rel4TeaEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache == null)
//{
//arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache = await clsvMicroteachCase_Resource_Rel4TeaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName_S);
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
public static List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_Rel4TeaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.EntryYear, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel4Tea.CollegeNameA, Type.GetType("System.String"));
foreach (clsvMicroteachCase_Resource_Rel4TeaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase_Resource_Rel];
objDR[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_MicroteachCase];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn];
objDR[convMicroteachCase_Resource_Rel4Tea.id_StudyLevel] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_StudyLevel];
objDR[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] = objInFor[convMicroteachCase_Resource_Rel4Tea.StudyLevelName];
objDR[convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_TeachingPlan];
objDR[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] = objInFor[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn];
objDR[convMicroteachCase_Resource_Rel4Tea.id_Discipline] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_Discipline];
objDR[convMicroteachCase_Resource_Rel4Tea.DisciplineID] = objInFor[convMicroteachCase_Resource_Rel4Tea.DisciplineID];
objDR[convMicroteachCase_Resource_Rel4Tea.DisciplineName] = objInFor[convMicroteachCase_Resource_Rel4Tea.DisciplineName];
objDR[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] = objInFor[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID];
objDR[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] = objInFor[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName];
objDR[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] = objInFor[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore];
objDR[convMicroteachCase_Resource_Rel4Tea.id_TeachSkill] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_TeachSkill];
objDR[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] = objInFor[convMicroteachCase_Resource_Rel4Tea.TeachSkillID];
objDR[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] = objInFor[convMicroteachCase_Resource_Rel4Tea.SkillTypeName];
objDR[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] = objInFor[convMicroteachCase_Resource_Rel4Tea.TeachSkillName];
objDR[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] = objInFor[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory];
objDR[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] = objInFor[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod];
objDR[convMicroteachCase_Resource_Rel4Tea.id_SkillType] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_SkillType];
objDR[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] = objInFor[convMicroteachCase_Resource_Rel4Tea.SkillTypeID];
objDR[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] = objInFor[convMicroteachCase_Resource_Rel4Tea.CaseLevelId];
objDR[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] = objInFor[convMicroteachCase_Resource_Rel4Tea.microteachCaseText];
objDR[convMicroteachCase_Resource_Rel4Tea.OwnerId] = objInFor[convMicroteachCase_Resource_Rel4Tea.OwnerId];
objDR[convMicroteachCase_Resource_Rel4Tea.OwnerName] = objInFor[convMicroteachCase_Resource_Rel4Tea.OwnerName];
objDR[convMicroteachCase_Resource_Rel4Tea.TeacherID] = objInFor[convMicroteachCase_Resource_Rel4Tea.TeacherID];
objDR[convMicroteachCase_Resource_Rel4Tea.TeacherName] = objInFor[convMicroteachCase_Resource_Rel4Tea.TeacherName];
objDR[convMicroteachCase_Resource_Rel4Tea.id_XzCollege] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_XzCollege];
objDR[convMicroteachCase_Resource_Rel4Tea.CollegeName] = objInFor[convMicroteachCase_Resource_Rel4Tea.CollegeName];
objDR[convMicroteachCase_Resource_Rel4Tea.EntryDate] = objInFor[convMicroteachCase_Resource_Rel4Tea.EntryDate];
objDR[convMicroteachCase_Resource_Rel4Tea.CollegeID] = objInFor[convMicroteachCase_Resource_Rel4Tea.CollegeID];
objDR[convMicroteachCase_Resource_Rel4Tea.EntryYear] = objInFor[convMicroteachCase_Resource_Rel4Tea.EntryYear];
objDR[convMicroteachCase_Resource_Rel4Tea.IsDualVideo] = objInFor[convMicroteachCase_Resource_Rel4Tea.IsDualVideo];
objDR[convMicroteachCase_Resource_Rel4Tea.UserTypeId] = objInFor[convMicroteachCase_Resource_Rel4Tea.UserTypeId];
objDR[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId] = objInFor[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId];
objDR[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] = objInFor[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName];
objDR[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] = objInFor[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case];
objDR[convMicroteachCase_Resource_Rel4Tea.id_Resource] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_Resource];
objDR[convMicroteachCase_Resource_Rel4Tea.ResourceID] = objInFor[convMicroteachCase_Resource_Rel4Tea.ResourceID];
objDR[convMicroteachCase_Resource_Rel4Tea.ResourceName] = objInFor[convMicroteachCase_Resource_Rel4Tea.ResourceName];
objDR[convMicroteachCase_Resource_Rel4Tea.id_FtpResource] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_FtpResource];
objDR[convMicroteachCase_Resource_Rel4Tea.id_File] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_File];
objDR[convMicroteachCase_Resource_Rel4Tea.FileName] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileName];
objDR[convMicroteachCase_Resource_Rel4Tea.FileType] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileType];
objDR[convMicroteachCase_Resource_Rel4Tea.SaveDate] = objInFor[convMicroteachCase_Resource_Rel4Tea.SaveDate];
objDR[convMicroteachCase_Resource_Rel4Tea.FileSize] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileSize];
objDR[convMicroteachCase_Resource_Rel4Tea.SaveTime] = objInFor[convMicroteachCase_Resource_Rel4Tea.SaveTime];
objDR[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] = objInFor[convMicroteachCase_Resource_Rel4Tea.FtpResourceID];
objDR[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileOriginalName];
objDR[convMicroteachCase_Resource_Rel4Tea.FileDirName] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileDirName];
objDR[convMicroteachCase_Resource_Rel4Tea.FileRename] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileRename];
objDR[convMicroteachCase_Resource_Rel4Tea.FileUpDate] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileUpDate];
objDR[convMicroteachCase_Resource_Rel4Tea.FileUpTime] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileUpTime];
objDR[convMicroteachCase_Resource_Rel4Tea.SaveMode] = objInFor[convMicroteachCase_Resource_Rel4Tea.SaveMode];
objDR[convMicroteachCase_Resource_Rel4Tea.id_ResourceType] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_ResourceType];
objDR[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] = objInFor[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID];
objDR[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] = objInFor[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName];
objDR[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] = objInFor[convMicroteachCase_Resource_Rel4Tea.ResourceOwner];
objDR[convMicroteachCase_Resource_Rel4Tea.ftpFileType] = objInFor[convMicroteachCase_Resource_Rel4Tea.ftpFileType];
objDR[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] = objInFor[convMicroteachCase_Resource_Rel4Tea.ftpFileSize];
objDR[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] = objInFor[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner];
objDR[convMicroteachCase_Resource_Rel4Tea.FileOriginName] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileOriginName];
objDR[convMicroteachCase_Resource_Rel4Tea.IsExistFile] = objInFor[convMicroteachCase_Resource_Rel4Tea.IsExistFile];
objDR[convMicroteachCase_Resource_Rel4Tea.FileNewName] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileNewName];
objDR[convMicroteachCase_Resource_Rel4Tea.FileOldName] = objInFor[convMicroteachCase_Resource_Rel4Tea.FileOldName];
objDR[convMicroteachCase_Resource_Rel4Tea.IsMain] = objInFor[convMicroteachCase_Resource_Rel4Tea.IsMain];
objDR[convMicroteachCase_Resource_Rel4Tea.id_UsingMode] = objInFor[convMicroteachCase_Resource_Rel4Tea.id_UsingMode];
objDR[convMicroteachCase_Resource_Rel4Tea.IsVisible] = objInFor[convMicroteachCase_Resource_Rel4Tea.IsVisible];
objDR[convMicroteachCase_Resource_Rel4Tea.IndexNO] = objInFor[convMicroteachCase_Resource_Rel4Tea.IndexNO];
objDR[convMicroteachCase_Resource_Rel4Tea.BrowseCount] = objInFor[convMicroteachCase_Resource_Rel4Tea.BrowseCount];
objDR[convMicroteachCase_Resource_Rel4Tea.UpdDate] = objInFor[convMicroteachCase_Resource_Rel4Tea.UpdDate];
objDR[convMicroteachCase_Resource_Rel4Tea.UpdUser] = objInFor[convMicroteachCase_Resource_Rel4Tea.UpdUser];
objDR[convMicroteachCase_Resource_Rel4Tea.Memo] = objInFor[convMicroteachCase_Resource_Rel4Tea.Memo];
objDR[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] = objInFor[convMicroteachCase_Resource_Rel4Tea.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}