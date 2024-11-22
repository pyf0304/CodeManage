
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4TeaWApi
 表名:vMicroteachCase4Tea(01120503)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:32
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
public static class clsvMicroteachCase4TeaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_MicroteachCase(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase4Tea.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase4Tea.id_MicroteachCase);
objvMicroteachCase4TeaEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_MicroteachCase) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseTypeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, convMicroteachCase4Tea.MicroteachCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachCase4Tea.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCase4Tea.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCase4Tea.MicroteachCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachCase4Tea.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCase4Tea.MicroteachCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseTheme(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, convMicroteachCase4Tea.MicroteachCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseDate(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCase4Tea.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCase4Tea.MicroteachCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseTime(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, convMicroteachCase4Tea.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, convMicroteachCase4Tea.MicroteachCaseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroteachCaseDateIn(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, convMicroteachCase4Tea.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, convMicroteachCase4Tea.MicroteachCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_StudyLevel(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMicroteachCase4Tea.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMicroteachCase4Tea.id_StudyLevel);
objvMicroteachCase4TeaEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_StudyLevel) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_StudyLevel, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_StudyLevel] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetStudyLevelName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMicroteachCase4Tea.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_TeachingPlan(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMicroteachCase4Tea.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMicroteachCase4Tea.id_TeachingPlan);
objvMicroteachCase4TeaEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_TeachingPlan) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_TeachingPlan, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_TeachingPlan] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMicroTeachCaseTimeIn(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, convMicroteachCase4Tea.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, convMicroteachCase4Tea.MicroTeachCaseTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_MicroteachCaseType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_MicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCaseType, convMicroteachCase4Tea.id_MicroteachCaseType);
clsCheckSql.CheckFieldLen(strid_MicroteachCaseType, 4, convMicroteachCase4Tea.id_MicroteachCaseType);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCaseType, 4, convMicroteachCase4Tea.id_MicroteachCaseType);
objvMicroteachCase4TeaEN.id_MicroteachCaseType = strid_MicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_MicroteachCaseType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_MicroteachCaseType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_MicroteachCaseType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetId_CaseType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convMicroteachCase4Tea.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convMicroteachCase4Tea.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convMicroteachCase4Tea.Id_CaseType);
objvMicroteachCase4TeaEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.Id_CaseType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.Id_CaseType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.Id_CaseType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_Discipline(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMicroteachCase4Tea.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMicroteachCase4Tea.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMicroteachCase4Tea.id_Discipline);
objvMicroteachCase4TeaEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_Discipline) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_Discipline, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_Discipline] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetDisciplineID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMicroteachCase4Tea.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMicroteachCase4Tea.DisciplineID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetDisciplineName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMicroteachCase4Tea.DisciplineName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_SenateGaugeVersion(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMicroteachCase4Tea.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMicroteachCase4Tea.id_SenateGaugeVersion);
objvMicroteachCase4TeaEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_SenateGaugeVersion) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetsenateGaugeVersionID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCase4Tea.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCase4Tea.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetsenateGaugeVersionName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCase4Tea.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetVersionNo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_TeachSkill(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convMicroteachCase4Tea.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convMicroteachCase4Tea.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convMicroteachCase4Tea.id_TeachSkill);
objvMicroteachCase4TeaEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_TeachSkill) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_TeachSkill, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_TeachSkill] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convMicroteachCase4Tea.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convMicroteachCase4Tea.TeachSkillID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetSkillTypeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convMicroteachCase4Tea.SkillTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convMicroteachCase4Tea.TeachSkillName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillTheory(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convMicroteachCase4Tea.TeachSkillTheory);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeachSkillOperMethod(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convMicroteachCase4Tea.TeachSkillOperMethod);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_SkillType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convMicroteachCase4Tea.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convMicroteachCase4Tea.id_SkillType);
objvMicroteachCase4TeaEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_SkillType) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_SkillType, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_SkillType] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetSkillTypeID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convMicroteachCase4Tea.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convMicroteachCase4Tea.SkillTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCaseLevelId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMicroteachCase4Tea.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMicroteachCase4Tea.CaseLevelId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetDocFile(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMicroteachCase4Tea.DocFile);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetWordCreateDate(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMicroteachCase4Tea.WordCreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetmicroteachCaseText(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, convMicroteachCase4Tea.microteachCaseText);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetOwnerId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMicroteachCase4Tea.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCase4Tea.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetOwnerName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCase4Tea.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeacherID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convMicroteachCase4Tea.TeacherID);
objvMicroteachCase4TeaEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.TeacherID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.TeacherID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.TeacherID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetTeacherName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convMicroteachCase4Tea.TeacherName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN Setid_XzCollege(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCase4Tea.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCase4Tea.id_XzCollege);
objvMicroteachCase4TeaEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.id_XzCollege) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCollegeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCase4Tea.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetEntryDate(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convMicroteachCase4Tea.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convMicroteachCase4Tea.EntryDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCollegeID(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCase4Tea.CollegeID);
objvMicroteachCase4TeaEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase4TeaEN.dicFldComparisonOp.ContainsKey(convMicroteachCase4Tea.CollegeID) == false)
{
objvMicroteachCase4TeaEN.dicFldComparisonOp.Add(convMicroteachCase4Tea.CollegeID, strComparisonOp);
}
else
{
objvMicroteachCase4TeaEN.dicFldComparisonOp[convMicroteachCase4Tea.CollegeID] = strComparisonOp;
}
}
return objvMicroteachCase4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetEntryYear(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strEntryYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convMicroteachCase4Tea.EntryYear);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetUserTypeId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCase4Tea.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCase4Tea.UserTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetRecommendedDegreeId(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMicroteachCase4Tea.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMicroteachCase4Tea.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMicroteachCase4Tea.RecommendedDegreeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetRecommendedDegreeName(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMicroteachCase4Tea.RecommendedDegreeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetMemo(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase4Tea.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetBrowseCount4Case(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, int intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetCollegeNameA(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCase4Tea.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase4TeaEN SetftpFileType(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase4Tea.ftpFileType);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase4TeaEN objvMicroteachCase4Tea_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_MicroteachCase, objvMicroteachCase4Tea_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseTypeName) == true)
{
string strComparisonOp_MicroteachCaseTypeName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseTypeName, objvMicroteachCase4Tea_Cond.MicroteachCaseTypeName, strComparisonOp_MicroteachCaseTypeName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseID, objvMicroteachCase4Tea_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseName, objvMicroteachCase4Tea_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseTheme, objvMicroteachCase4Tea_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseDate, objvMicroteachCase4Tea_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseTime, objvMicroteachCase4Tea_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroteachCaseDateIn, objvMicroteachCase4Tea_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_StudyLevel, objvMicroteachCase4Tea_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.StudyLevelName, objvMicroteachCase4Tea_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_TeachingPlan, objvMicroteachCase4Tea_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.MicroTeachCaseTimeIn, objvMicroteachCase4Tea_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_MicroteachCaseType) == true)
{
string strComparisonOp_id_MicroteachCaseType = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_MicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_MicroteachCaseType, objvMicroteachCase4Tea_Cond.id_MicroteachCaseType, strComparisonOp_id_MicroteachCaseType);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.Id_CaseType, objvMicroteachCase4Tea_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_Discipline, objvMicroteachCase4Tea_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.DisciplineID, objvMicroteachCase4Tea_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.DisciplineName, objvMicroteachCase4Tea_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_SenateGaugeVersion, objvMicroteachCase4Tea_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.senateGaugeVersionID, objvMicroteachCase4Tea_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.senateGaugeVersionName, objvMicroteachCase4Tea_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4Tea.senateGaugeVersionTtlScore, objvMicroteachCase4Tea_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4Tea.VersionNo, objvMicroteachCase4Tea_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_TeachSkill, objvMicroteachCase4Tea_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillID, objvMicroteachCase4Tea_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.SkillTypeName, objvMicroteachCase4Tea_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillName, objvMicroteachCase4Tea_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillTheory, objvMicroteachCase4Tea_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeachSkillOperMethod, objvMicroteachCase4Tea_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_SkillType, objvMicroteachCase4Tea_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.SkillTypeID, objvMicroteachCase4Tea_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CaseLevelId, objvMicroteachCase4Tea_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.DocFile) == true)
{
string strComparisonOp_DocFile = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.DocFile, objvMicroteachCase4Tea_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.IsNeedGeneWord) == true)
{
if (objvMicroteachCase4Tea_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4Tea.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4Tea.IsNeedGeneWord);
}
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.WordCreateDate, objvMicroteachCase4Tea_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.IsVisible) == true)
{
if (objvMicroteachCase4Tea_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4Tea.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4Tea.IsVisible);
}
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.microteachCaseText, objvMicroteachCase4Tea_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.OwnerId, objvMicroteachCase4Tea_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.OwnerName, objvMicroteachCase4Tea_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeacherID, objvMicroteachCase4Tea_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.TeacherName, objvMicroteachCase4Tea_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.id_XzCollege, objvMicroteachCase4Tea_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CollegeName, objvMicroteachCase4Tea_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.EntryDate) == true)
{
string strComparisonOp_EntryDate = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.EntryDate, objvMicroteachCase4Tea_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CollegeID, objvMicroteachCase4Tea_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.EntryYear) == true)
{
string strComparisonOp_EntryYear = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.EntryYear, objvMicroteachCase4Tea_Cond.EntryYear, strComparisonOp_EntryYear);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.IsDualVideo) == true)
{
if (objvMicroteachCase4Tea_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase4Tea.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase4Tea.IsDualVideo);
}
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.UserTypeId, objvMicroteachCase4Tea_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.RecommendedDegreeId, objvMicroteachCase4Tea_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.RecommendedDegreeName, objvMicroteachCase4Tea_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.Memo, objvMicroteachCase4Tea_Cond.Memo, strComparisonOp_Memo);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase4Tea.BrowseCount4Case, objvMicroteachCase4Tea_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.CollegeNameA, objvMicroteachCase4Tea_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvMicroteachCase4Tea_Cond.IsUpdated(convMicroteachCase4Tea.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCase4Tea_Cond.dicFldComparisonOp[convMicroteachCase4Tea.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase4Tea.ftpFileType, objvMicroteachCase4Tea_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vMicroteachCase4Tea(vMicroteachCase4Tea)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase4TeaWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase4TeaApi";

 public clsvMicroteachCase4TeaWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vMicroteachCase4Tea]...","0");
List<clsvMicroteachCase4TeaEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convMicroteachCase4Tea.id_MicroteachCase); 
List<clsvMicroteachCase4TeaEN> arrObjLst = clsvMicroteachCase4TeaWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN()
{
id_MicroteachCase = "0",
MicroteachCaseName = "选[vMicroteachCase4Tea]..."
};
arrObjLst.Insert(0, objvMicroteachCase4TeaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convMicroteachCase4Tea.id_MicroteachCase;
objComboBox.DisplayMember = convMicroteachCase4Tea.MicroteachCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase4TeaEN GetObjByid_MicroteachCase(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = null;
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
objvMicroteachCase4TeaEN = JsonConvert.DeserializeObject<clsvMicroteachCase4TeaEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase4TeaEN;
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
public static clsvMicroteachCase4TeaEN GetObjByid_MicroteachCase_WA_Cache(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = null;
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
objvMicroteachCase4TeaEN = JsonConvert.DeserializeObject<clsvMicroteachCase4TeaEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase4TeaEN;
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
public static clsvMicroteachCase4TeaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = null;
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
objvMicroteachCase4TeaEN = JsonConvert.DeserializeObject<clsvMicroteachCase4TeaEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase4TeaEN;
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
public static clsvMicroteachCase4TeaEN GetObjByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName_S);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel =
from objvMicroteachCase4TeaEN in arrvMicroteachCase4TeaObjLst_Cache
where objvMicroteachCase4TeaEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase4TeaEN;
if (arrvMicroteachCase4TeaObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase4TeaEN obj = clsvMicroteachCase4TeaWApi.GetObjByid_MicroteachCase(strid_MicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase4TeaObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName_S);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel1 =
from objvMicroteachCase4TeaEN in arrvMicroteachCase4TeaObjLst_Cache
where objvMicroteachCase4TeaEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase4TeaEN;
List <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel = new List<clsvMicroteachCase4TeaEN>();
foreach (clsvMicroteachCase4TeaEN obj in arrvMicroteachCase4TeaObjLst_Sel1)
{
arrvMicroteachCase4TeaObjLst_Sel.Add(obj);
}
if (arrvMicroteachCase4TeaObjLst_Sel.Count > 0)
{
return arrvMicroteachCase4TeaObjLst_Sel[0].MicroteachCaseName;
}
string strErrMsgForGetObjById = string.Format("在vMicroteachCase4Tea对象缓存列表中,找不到记录[id_MicroteachCase = {0}](函数:{1})", strid_MicroteachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvMicroteachCase4TeaBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName_S);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel1 =
from objvMicroteachCase4TeaEN in arrvMicroteachCase4TeaObjLst_Cache
where objvMicroteachCase4TeaEN.id_MicroteachCase == strid_MicroteachCase
select objvMicroteachCase4TeaEN;
List <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel = new List<clsvMicroteachCase4TeaEN>();
foreach (clsvMicroteachCase4TeaEN obj in arrvMicroteachCase4TeaObjLst_Sel1)
{
arrvMicroteachCase4TeaObjLst_Sel.Add(obj);
}
if (arrvMicroteachCase4TeaObjLst_Sel.Count > 0)
{
return arrvMicroteachCase4TeaObjLst_Sel[0].MicroteachCaseName;
}
string strErrMsgForGetObjById = string.Format("在vMicroteachCase4Tea对象缓存列表中,找不到记录的相关名称[id_MicroteachCase = {0}](函数:{1})", strid_MicroteachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvMicroteachCase4TeaBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstById_MicroteachCaseLst(List<string> arrId_MicroteachCase)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMicroteachCase4TeaEN> GetObjLstById_MicroteachCaseLst_Cache(List<string> arrId_MicroteachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName_S);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Sel =
from objvMicroteachCase4TeaEN in arrvMicroteachCase4TeaObjLst_Cache
where arrId_MicroteachCase.Contains(objvMicroteachCase4TeaEN.id_MicroteachCase)
select objvMicroteachCase4TeaEN;
return arrvMicroteachCase4TeaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase4TeaEN> GetObjLstById_MicroteachCaseLst_WA_Cache(List<string> arrId_MicroteachCase)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4TeaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase4TeaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase4TeaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase4TeaENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENS, clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENT)
{
try
{
objvMicroteachCase4TeaENT.id_MicroteachCase = objvMicroteachCase4TeaENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase4TeaENT.MicroteachCaseTypeName = objvMicroteachCase4TeaENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4TeaENT.MicroteachCaseID = objvMicroteachCase4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4TeaENT.MicroteachCaseName = objvMicroteachCase4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4TeaENT.MicroteachCaseTheme = objvMicroteachCase4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4TeaENT.MicroteachCaseDate = objvMicroteachCase4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4TeaENT.MicroteachCaseTime = objvMicroteachCase4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4TeaENT.MicroteachCaseDateIn = objvMicroteachCase4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4TeaENT.id_StudyLevel = objvMicroteachCase4TeaENS.id_StudyLevel; //id_StudyLevel
objvMicroteachCase4TeaENT.StudyLevelName = objvMicroteachCase4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase4TeaENT.id_TeachingPlan = objvMicroteachCase4TeaENS.id_TeachingPlan; //教案流水号
objvMicroteachCase4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4TeaENT.id_MicroteachCaseType = objvMicroteachCase4TeaENS.id_MicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4TeaENT.Id_CaseType = objvMicroteachCase4TeaENS.Id_CaseType; //案例类型流水号
objvMicroteachCase4TeaENT.id_Discipline = objvMicroteachCase4TeaENS.id_Discipline; //学科流水号
objvMicroteachCase4TeaENT.DisciplineID = objvMicroteachCase4TeaENS.DisciplineID; //学科ID
objvMicroteachCase4TeaENT.DisciplineName = objvMicroteachCase4TeaENS.DisciplineName; //学科名称
objvMicroteachCase4TeaENT.id_SenateGaugeVersion = objvMicroteachCase4TeaENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4TeaENT.senateGaugeVersionID = objvMicroteachCase4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4TeaENT.senateGaugeVersionName = objvMicroteachCase4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4TeaENT.VersionNo = objvMicroteachCase4TeaENS.VersionNo; //版本号
objvMicroteachCase4TeaENT.id_TeachSkill = objvMicroteachCase4TeaENS.id_TeachSkill; //教学技能流水号
objvMicroteachCase4TeaENT.TeachSkillID = objvMicroteachCase4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase4TeaENT.SkillTypeName = objvMicroteachCase4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase4TeaENT.TeachSkillName = objvMicroteachCase4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase4TeaENT.TeachSkillTheory = objvMicroteachCase4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4TeaENT.TeachSkillOperMethod = objvMicroteachCase4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4TeaENT.id_SkillType = objvMicroteachCase4TeaENS.id_SkillType; //技能类型流水号
objvMicroteachCase4TeaENT.SkillTypeID = objvMicroteachCase4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase4TeaENT.CaseLevelId = objvMicroteachCase4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase4TeaENT.DocFile = objvMicroteachCase4TeaENS.DocFile; //生成的Word文件名
objvMicroteachCase4TeaENT.IsNeedGeneWord = objvMicroteachCase4TeaENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4TeaENT.WordCreateDate = objvMicroteachCase4TeaENS.WordCreateDate; //Word生成日期
objvMicroteachCase4TeaENT.IsVisible = objvMicroteachCase4TeaENS.IsVisible; //是否显示
objvMicroteachCase4TeaENT.microteachCaseText = objvMicroteachCase4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase4TeaENT.OwnerId = objvMicroteachCase4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase4TeaENT.OwnerName = objvMicroteachCase4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase4TeaENT.TeacherID = objvMicroteachCase4TeaENS.TeacherID; //教师工号
objvMicroteachCase4TeaENT.TeacherName = objvMicroteachCase4TeaENS.TeacherName; //教师姓名
objvMicroteachCase4TeaENT.id_XzCollege = objvMicroteachCase4TeaENS.id_XzCollege; //学院流水号
objvMicroteachCase4TeaENT.CollegeName = objvMicroteachCase4TeaENS.CollegeName; //学院名称
objvMicroteachCase4TeaENT.EntryDate = objvMicroteachCase4TeaENS.EntryDate; //进校日期
objvMicroteachCase4TeaENT.CollegeID = objvMicroteachCase4TeaENS.CollegeID; //学院ID
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
public static DataTable ToDataTable(List<clsvMicroteachCase4TeaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase4TeaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase4TeaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase4TeaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase4TeaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase4TeaEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase");
//if (arrvMicroteachCase4TeaObjLst_Cache == null)
//{
//arrvMicroteachCase4TeaObjLst_Cache = await clsvMicroteachCase4TeaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName_S);
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
public static List<clsvMicroteachCase4TeaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase4TeaEN._CurrTabName_S);
List<clsvMicroteachCase4TeaEN> arrvMicroteachCase4TeaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase4TeaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase4TeaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase4Tea.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_MicroteachCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCase4Tea.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase4Tea.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase4Tea.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase4Tea.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.EntryYear, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase4Tea.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase4Tea.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase4Tea.ftpFileType, Type.GetType("System.String"));
foreach (clsvMicroteachCase4TeaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase4Tea.id_MicroteachCase] = objInFor[convMicroteachCase4Tea.id_MicroteachCase];
objDR[convMicroteachCase4Tea.MicroteachCaseTypeName] = objInFor[convMicroteachCase4Tea.MicroteachCaseTypeName];
objDR[convMicroteachCase4Tea.MicroteachCaseID] = objInFor[convMicroteachCase4Tea.MicroteachCaseID];
objDR[convMicroteachCase4Tea.MicroteachCaseName] = objInFor[convMicroteachCase4Tea.MicroteachCaseName];
objDR[convMicroteachCase4Tea.MicroteachCaseTheme] = objInFor[convMicroteachCase4Tea.MicroteachCaseTheme];
objDR[convMicroteachCase4Tea.MicroteachCaseDate] = objInFor[convMicroteachCase4Tea.MicroteachCaseDate];
objDR[convMicroteachCase4Tea.MicroteachCaseTime] = objInFor[convMicroteachCase4Tea.MicroteachCaseTime];
objDR[convMicroteachCase4Tea.MicroteachCaseDateIn] = objInFor[convMicroteachCase4Tea.MicroteachCaseDateIn];
objDR[convMicroteachCase4Tea.id_StudyLevel] = objInFor[convMicroteachCase4Tea.id_StudyLevel];
objDR[convMicroteachCase4Tea.StudyLevelName] = objInFor[convMicroteachCase4Tea.StudyLevelName];
objDR[convMicroteachCase4Tea.id_TeachingPlan] = objInFor[convMicroteachCase4Tea.id_TeachingPlan];
objDR[convMicroteachCase4Tea.MicroTeachCaseTimeIn] = objInFor[convMicroteachCase4Tea.MicroTeachCaseTimeIn];
objDR[convMicroteachCase4Tea.id_MicroteachCaseType] = objInFor[convMicroteachCase4Tea.id_MicroteachCaseType];
objDR[convMicroteachCase4Tea.Id_CaseType] = objInFor[convMicroteachCase4Tea.Id_CaseType];
objDR[convMicroteachCase4Tea.id_Discipline] = objInFor[convMicroteachCase4Tea.id_Discipline];
objDR[convMicroteachCase4Tea.DisciplineID] = objInFor[convMicroteachCase4Tea.DisciplineID];
objDR[convMicroteachCase4Tea.DisciplineName] = objInFor[convMicroteachCase4Tea.DisciplineName];
objDR[convMicroteachCase4Tea.id_SenateGaugeVersion] = objInFor[convMicroteachCase4Tea.id_SenateGaugeVersion];
objDR[convMicroteachCase4Tea.senateGaugeVersionID] = objInFor[convMicroteachCase4Tea.senateGaugeVersionID];
objDR[convMicroteachCase4Tea.senateGaugeVersionName] = objInFor[convMicroteachCase4Tea.senateGaugeVersionName];
objDR[convMicroteachCase4Tea.senateGaugeVersionTtlScore] = objInFor[convMicroteachCase4Tea.senateGaugeVersionTtlScore];
objDR[convMicroteachCase4Tea.VersionNo] = objInFor[convMicroteachCase4Tea.VersionNo];
objDR[convMicroteachCase4Tea.id_TeachSkill] = objInFor[convMicroteachCase4Tea.id_TeachSkill];
objDR[convMicroteachCase4Tea.TeachSkillID] = objInFor[convMicroteachCase4Tea.TeachSkillID];
objDR[convMicroteachCase4Tea.SkillTypeName] = objInFor[convMicroteachCase4Tea.SkillTypeName];
objDR[convMicroteachCase4Tea.TeachSkillName] = objInFor[convMicroteachCase4Tea.TeachSkillName];
objDR[convMicroteachCase4Tea.TeachSkillTheory] = objInFor[convMicroteachCase4Tea.TeachSkillTheory];
objDR[convMicroteachCase4Tea.TeachSkillOperMethod] = objInFor[convMicroteachCase4Tea.TeachSkillOperMethod];
objDR[convMicroteachCase4Tea.id_SkillType] = objInFor[convMicroteachCase4Tea.id_SkillType];
objDR[convMicroteachCase4Tea.SkillTypeID] = objInFor[convMicroteachCase4Tea.SkillTypeID];
objDR[convMicroteachCase4Tea.CaseLevelId] = objInFor[convMicroteachCase4Tea.CaseLevelId];
objDR[convMicroteachCase4Tea.DocFile] = objInFor[convMicroteachCase4Tea.DocFile];
objDR[convMicroteachCase4Tea.IsNeedGeneWord] = objInFor[convMicroteachCase4Tea.IsNeedGeneWord];
objDR[convMicroteachCase4Tea.WordCreateDate] = objInFor[convMicroteachCase4Tea.WordCreateDate];
objDR[convMicroteachCase4Tea.IsVisible] = objInFor[convMicroteachCase4Tea.IsVisible];
objDR[convMicroteachCase4Tea.microteachCaseText] = objInFor[convMicroteachCase4Tea.microteachCaseText];
objDR[convMicroteachCase4Tea.OwnerId] = objInFor[convMicroteachCase4Tea.OwnerId];
objDR[convMicroteachCase4Tea.OwnerName] = objInFor[convMicroteachCase4Tea.OwnerName];
objDR[convMicroteachCase4Tea.TeacherID] = objInFor[convMicroteachCase4Tea.TeacherID];
objDR[convMicroteachCase4Tea.TeacherName] = objInFor[convMicroteachCase4Tea.TeacherName];
objDR[convMicroteachCase4Tea.id_XzCollege] = objInFor[convMicroteachCase4Tea.id_XzCollege];
objDR[convMicroteachCase4Tea.CollegeName] = objInFor[convMicroteachCase4Tea.CollegeName];
objDR[convMicroteachCase4Tea.EntryDate] = objInFor[convMicroteachCase4Tea.EntryDate];
objDR[convMicroteachCase4Tea.CollegeID] = objInFor[convMicroteachCase4Tea.CollegeID];
objDR[convMicroteachCase4Tea.EntryYear] = objInFor[convMicroteachCase4Tea.EntryYear];
objDR[convMicroteachCase4Tea.IsDualVideo] = objInFor[convMicroteachCase4Tea.IsDualVideo];
objDR[convMicroteachCase4Tea.UserTypeId] = objInFor[convMicroteachCase4Tea.UserTypeId];
objDR[convMicroteachCase4Tea.RecommendedDegreeId] = objInFor[convMicroteachCase4Tea.RecommendedDegreeId];
objDR[convMicroteachCase4Tea.RecommendedDegreeName] = objInFor[convMicroteachCase4Tea.RecommendedDegreeName];
objDR[convMicroteachCase4Tea.Memo] = objInFor[convMicroteachCase4Tea.Memo];
objDR[convMicroteachCase4Tea.BrowseCount4Case] = objInFor[convMicroteachCase4Tea.BrowseCount4Case];
objDR[convMicroteachCase4Tea.CollegeNameA] = objInFor[convMicroteachCase4Tea.CollegeNameA];
objDR[convMicroteachCase4Tea.ftpFileType] = objInFor[convMicroteachCase4Tea.ftpFileType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}