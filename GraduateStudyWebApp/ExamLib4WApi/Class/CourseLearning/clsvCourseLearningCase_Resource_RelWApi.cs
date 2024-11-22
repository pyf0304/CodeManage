
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase_Resource_RelWApi
 表名:vCourseLearningCase_Resource_Rel(01120434)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:14
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFuncModuleId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCase_Resource_Rel.FuncModuleId);
objvCourseLearningCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FuncModuleId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFuncModuleName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCase_Resource_Rel.FuncModuleName);
objvCourseLearningCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FuncModuleName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_MicroteachCase(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCourseLearningCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCourseLearningCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCourseLearningCase_Resource_Rel.id_MicroteachCase);
objvCourseLearningCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_MicroteachCase) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseID);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase_Resource_Rel.CourseLearningCaseName);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseText(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCase_Resource_Rel.CourseLearningCaseText);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseText) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTheme(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDate);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTime(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTime);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseDateIn(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_CourseLearningCaseType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_CourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseLearningCaseType, 4, convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseLearningCaseType, 4, convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType);
objvCourseLearningCase_Resource_RelEN.id_CourseLearningCaseType = strid_CourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseLearningCaseTypeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName);
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetOwnerId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCase_Resource_Rel.OwnerId);
objvCourseLearningCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.OwnerId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetOwnerName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCase_Resource_Rel.OwnerName);
objvCourseLearningCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.OwnerName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetOwnerNameWithId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCase_Resource_Rel.OwnerNameWithId);
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.OwnerNameWithId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_XzMajor(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCourseLearningCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCourseLearningCase_Resource_Rel.id_XzMajor);
objvCourseLearningCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_XzMajor) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetMajorID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCase_Resource_Rel.MajorID);
objvCourseLearningCase_Resource_RelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.MajorID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetMajorName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCase_Resource_Rel.MajorName);
objvCourseLearningCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.MajorName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_XzCollege(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningCase_Resource_Rel.id_XzCollege);
objvCourseLearningCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_XzCollege) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollegeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCase_Resource_Rel.CollegeID);
objvCourseLearningCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollegeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollegeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCase_Resource_Rel.CollegeName);
objvCourseLearningCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollegeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_TeachSkill(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCourseLearningCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCourseLearningCase_Resource_Rel.id_TeachSkill);
objvCourseLearningCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_TeachSkill) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCase_Resource_Rel.TeachSkillID);
objvCourseLearningCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCase_Resource_Rel.TeachSkillName);
objvCourseLearningCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillTheory(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCase_Resource_Rel.TeachSkillTheory);
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillTheory) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetTeachSkillOperMethod(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCase_Resource_Rel.TeachSkillOperMethod);
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSkillTypeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCase_Resource_Rel.SkillTypeID);
objvCourseLearningCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SkillTypeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSkillTypeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCase_Resource_Rel.SkillTypeName);
objvCourseLearningCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SkillTypeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_Discipline(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCourseLearningCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCourseLearningCase_Resource_Rel.id_Discipline);
objvCourseLearningCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_Discipline) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetDisciplineID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCase_Resource_Rel.DisciplineID);
objvCourseLearningCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.DisciplineID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetDisciplineName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCase_Resource_Rel.DisciplineName);
objvCourseLearningCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.DisciplineName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_StudyLevel(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCourseLearningCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCourseLearningCase_Resource_Rel.id_StudyLevel);
objvCourseLearningCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_StudyLevel) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetStudyLevelName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCase_Resource_Rel.StudyLevelName);
objvCourseLearningCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.StudyLevelName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_File(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCourseLearningCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCourseLearningCase_Resource_Rel.id_File);
objvCourseLearningCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_File) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCourseLearningCase_Resource_Rel.FileName);
objvCourseLearningCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convCourseLearningCase_Resource_Rel.FileType);
objvCourseLearningCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSaveDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCourseLearningCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCourseLearningCase_Resource_Rel.SaveDate);
objvCourseLearningCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SaveDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileSize(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCourseLearningCase_Resource_Rel.FileSize);
objvCourseLearningCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileSize) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSaveTime(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCourseLearningCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCourseLearningCase_Resource_Rel.SaveTime);
objvCourseLearningCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SaveTime) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_SkillType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCourseLearningCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCourseLearningCase_Resource_Rel.id_SkillType);
objvCourseLearningCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_SkillType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_TeachingPlan(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCourseLearningCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCourseLearningCase_Resource_Rel.id_TeachingPlan);
objvCourseLearningCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_TeachingPlan) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_FtpResource(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCourseLearningCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCourseLearningCase_Resource_Rel.id_FtpResource);
objvCourseLearningCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_FtpResource) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFtpResourceID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCourseLearningCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCourseLearningCase_Resource_Rel.FtpResourceID);
objvCourseLearningCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FtpResourceID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileOriginalName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCourseLearningCase_Resource_Rel.FileOriginalName);
objvCourseLearningCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileOriginalName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileDirName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCourseLearningCase_Resource_Rel.FileDirName);
objvCourseLearningCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileDirName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileRename(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCourseLearningCase_Resource_Rel.FileRename);
objvCourseLearningCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileRename) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileUpDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCourseLearningCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCourseLearningCase_Resource_Rel.FileUpDate);
objvCourseLearningCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileUpDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileUpTime(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCourseLearningCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCourseLearningCase_Resource_Rel.FileUpTime);
objvCourseLearningCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileUpTime) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_Resource(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convCourseLearningCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCourseLearningCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCourseLearningCase_Resource_Rel.id_Resource);
objvCourseLearningCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_Resource) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCourseLearningCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCourseLearningCase_Resource_Rel.ResourceID);
objvCourseLearningCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetSaveMode(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.SaveMode) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsMain(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsMain) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_ResourceType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCourseLearningCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCourseLearningCase_Resource_Rel.id_ResourceType);
objvCourseLearningCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_ResourceType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceTypeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCourseLearningCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCourseLearningCase_Resource_Rel.ResourceTypeID);
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceTypeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceTypeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCourseLearningCase_Resource_Rel.ResourceTypeName);
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceTypeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN Setid_UsingMode(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convCourseLearningCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convCourseLearningCase_Resource_Rel.id_UsingMode);
objvCourseLearningCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.id_UsingMode) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIndexNO(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IndexNO) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase_Resource_Rel.CourseId);
objvCourseLearningCase_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseCode(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase_Resource_Rel.CourseCode);
objvCourseLearningCase_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseCode) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase_Resource_Rel.CourseName);
objvCourseLearningCase_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetBrowseCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.BrowseCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convCourseLearningCase_Resource_Rel.ResourceName);
objvCourseLearningCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetResourceOwner(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCourseLearningCase_Resource_Rel.ResourceOwner);
objvCourseLearningCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ResourceOwner) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetftpFileType(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCase_Resource_Rel.ftpFileType);
objvCourseLearningCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ftpFileType) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetftpFileSize(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCourseLearningCase_Resource_Rel.ftpFileSize);
objvCourseLearningCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ftpFileSize) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetftpResourceOwner(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCourseLearningCase_Resource_Rel.ftpResourceOwner);
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ftpResourceOwner) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetVersionNo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.VersionNo) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileOriginName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCourseLearningCase_Resource_Rel.FileOriginName);
objvCourseLearningCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileOriginName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetsenateGaugeVersionID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCase_Resource_Rel.senateGaugeVersionID);
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetsenateGaugeVersionName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCase_Resource_Rel.senateGaugeVersionName);
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCaseLevelId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCase_Resource_Rel.CaseLevelId);
objvCourseLearningCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CaseLevelId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsExistFile(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsExistFile) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetBrowseCount4Case(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.BrowseCount4Case) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileNewName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCourseLearningCase_Resource_Rel.FileNewName);
objvCourseLearningCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileNewName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileOldName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCourseLearningCase_Resource_Rel.FileOldName);
objvCourseLearningCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileOldName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsDualVideo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsDualVideo) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetViewCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intViewCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ViewCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsShow(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsShow) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetDownloadNumber(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.DownloadNumber) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetFileIntegration(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, int intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.FileIntegration) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetLikeCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, long lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.LikeCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollectionCount(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollectionCount) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetIsVisible(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.IsVisible) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetUpdDate(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCase_Resource_Rel.UpdDate);
objvCourseLearningCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.UpdDate) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetUpdUser(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCourseLearningCase_Resource_Rel.UpdUser);
objvCourseLearningCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.UpdUser) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetMemo(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase_Resource_Rel.Memo);
objvCourseLearningCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.Memo) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetRecommendedDegreeId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase_Resource_Rel.RecommendedDegreeId);
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetRecommendedDegreeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCase_Resource_Rel.RecommendedDegreeName);
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCollegeNameA(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCase_Resource_Rel.CollegeNameA);
objvCourseLearningCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CollegeNameA) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseChapterId(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase_Resource_Rel.CourseChapterId);
objvCourseLearningCase_Resource_RelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseChapterId) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseChapterName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCase_Resource_Rel.CourseChapterName);
objvCourseLearningCase_Resource_RelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseChapterName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetCourseChapterReferred(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCase_Resource_Rel.CourseChapterReferred);
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.CourseChapterReferred) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetParentNodeReferred(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCase_Resource_Rel.ParentNodeReferred);
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ParentNodeReferred) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetParentNodeID(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCourseLearningCase_Resource_Rel.ParentNodeID);
objvCourseLearningCase_Resource_RelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ParentNodeID) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ParentNodeID, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeID] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_Resource_RelEN SetParentNodeName(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCourseLearningCase_Resource_Rel.ParentNodeName);
objvCourseLearningCase_Resource_RelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Resource_Rel.ParentNodeName) == false)
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp.Add(convCourseLearningCase_Resource_Rel.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCase_Resource_RelEN.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvCourseLearningCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FuncModuleId, objvCourseLearningCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FuncModuleName, objvCourseLearningCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_MicroteachCase, objvCourseLearningCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseID, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseName, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseText) == true)
{
string strComparisonOp_CourseLearningCaseText = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseText, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseText, strComparisonOp_CourseLearningCaseText);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseDate, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTime, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType) == true)
{
string strComparisonOp_id_CourseLearningCaseType = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType, objvCourseLearningCase_Resource_Rel_Cond.id_CourseLearningCaseType, strComparisonOp_id_CourseLearningCaseType);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName) == true)
{
string strComparisonOp_CourseLearningCaseTypeName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName, objvCourseLearningCase_Resource_Rel_Cond.CourseLearningCaseTypeName, strComparisonOp_CourseLearningCaseTypeName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.OwnerId, objvCourseLearningCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.OwnerName, objvCourseLearningCase_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.OwnerNameWithId, objvCourseLearningCase_Resource_Rel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_XzMajor, objvCourseLearningCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.MajorID, objvCourseLearningCase_Resource_Rel_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.MajorName, objvCourseLearningCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_XzCollege, objvCourseLearningCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CollegeID, objvCourseLearningCase_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CollegeName, objvCourseLearningCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_TeachSkill, objvCourseLearningCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillID, objvCourseLearningCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillName, objvCourseLearningCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillTheory, objvCourseLearningCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.TeachSkillOperMethod, objvCourseLearningCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SkillTypeID, objvCourseLearningCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SkillTypeName, objvCourseLearningCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_Discipline, objvCourseLearningCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.DisciplineID, objvCourseLearningCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.DisciplineName, objvCourseLearningCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_StudyLevel, objvCourseLearningCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.StudyLevelName, objvCourseLearningCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_File, objvCourseLearningCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileName, objvCourseLearningCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileType, objvCourseLearningCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SaveDate, objvCourseLearningCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileSize, objvCourseLearningCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.SaveTime, objvCourseLearningCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_SkillType, objvCourseLearningCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_TeachingPlan, objvCourseLearningCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_FtpResource, objvCourseLearningCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FtpResourceID, objvCourseLearningCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileOriginalName, objvCourseLearningCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileDirName, objvCourseLearningCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileRename, objvCourseLearningCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileUpDate, objvCourseLearningCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileUpTime, objvCourseLearningCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_Resource, objvCourseLearningCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceID, objvCourseLearningCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.SaveMode) == true)
{
if (objvCourseLearningCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.SaveMode);
}
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.IsMain) == true)
{
if (objvCourseLearningCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsMain);
}
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_ResourceType, objvCourseLearningCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceTypeID, objvCourseLearningCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceTypeName, objvCourseLearningCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.id_UsingMode, objvCourseLearningCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.IndexNO, objvCourseLearningCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseId, objvCourseLearningCase_Resource_Rel_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseCode, objvCourseLearningCase_Resource_Rel_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseName, objvCourseLearningCase_Resource_Rel_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.BrowseCount, objvCourseLearningCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceName, objvCourseLearningCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ResourceOwner, objvCourseLearningCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ftpFileType, objvCourseLearningCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ftpFileSize, objvCourseLearningCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ftpResourceOwner, objvCourseLearningCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.VersionNo, objvCourseLearningCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileOriginName, objvCourseLearningCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.senateGaugeVersionID, objvCourseLearningCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.senateGaugeVersionName, objvCourseLearningCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore, objvCourseLearningCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CaseLevelId, objvCourseLearningCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.IsExistFile) == true)
{
if (objvCourseLearningCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsExistFile);
}
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.BrowseCount4Case, objvCourseLearningCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileNewName, objvCourseLearningCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.FileOldName, objvCourseLearningCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.IsDualVideo) == true)
{
if (objvCourseLearningCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsDualVideo);
}
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.ViewCount, objvCourseLearningCase_Resource_Rel_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.IsShow) == true)
{
if (objvCourseLearningCase_Resource_Rel_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsShow);
}
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.DownloadNumber, objvCourseLearningCase_Resource_Rel_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.FileIntegration, objvCourseLearningCase_Resource_Rel_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.LikeCount, objvCourseLearningCase_Resource_Rel_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Resource_Rel.CollectionCount, objvCourseLearningCase_Resource_Rel_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.IsVisible) == true)
{
if (objvCourseLearningCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Resource_Rel.IsVisible);
}
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.UpdDate, objvCourseLearningCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.UpdUser, objvCourseLearningCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.Memo, objvCourseLearningCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.RecommendedDegreeId, objvCourseLearningCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.RecommendedDegreeName, objvCourseLearningCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CollegeNameA, objvCourseLearningCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseChapterId, objvCourseLearningCase_Resource_Rel_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseChapterName, objvCourseLearningCase_Resource_Rel_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.CourseChapterReferred, objvCourseLearningCase_Resource_Rel_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ParentNodeReferred, objvCourseLearningCase_Resource_Rel_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ParentNodeID, objvCourseLearningCase_Resource_Rel_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCourseLearningCase_Resource_Rel_Cond.IsUpdated(convCourseLearningCase_Resource_Rel.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCourseLearningCase_Resource_Rel_Cond.dicFldComparisonOp[convCourseLearningCase_Resource_Rel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Resource_Rel.ParentNodeName, objvCourseLearningCase_Resource_Rel_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例资源关系(vCourseLearningCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCase_Resource_RelApi";

 public clsvCourseLearningCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = null;
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
objvCourseLearningCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCourseLearningCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase_Resource_RelEN;
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
public static clsvCourseLearningCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = null;
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
objvCourseLearningCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCourseLearningCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase_Resource_RelEN;
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
public static clsvCourseLearningCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = null;
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
objvCourseLearningCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCourseLearningCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase_Resource_RelEN;
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
public static clsvCourseLearningCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName_S);
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Sel =
from objvCourseLearningCase_Resource_RelEN in arrvCourseLearningCase_Resource_RelObjLst_Cache
where objvCourseLearningCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvCourseLearningCase_Resource_RelEN;
if (arrvCourseLearningCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase_Resource_RelEN obj = clsvCourseLearningCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCourseLearningCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName_S);
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Sel =
from objvCourseLearningCase_Resource_RelEN in arrvCourseLearningCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvCourseLearningCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvCourseLearningCase_Resource_RelEN;
return arrvCourseLearningCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCourseLearningCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCourseLearningCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENS, clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENT)
{
try
{
objvCourseLearningCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvCourseLearningCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelENT.FuncModuleId = objvCourseLearningCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCourseLearningCase_Resource_RelENT.FuncModuleName = objvCourseLearningCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCourseLearningCase_Resource_RelENT.id_MicroteachCase = objvCourseLearningCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseID = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseText = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTheme = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDate = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTime = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_Resource_RelENT.id_CourseLearningCaseType = objvCourseLearningCase_Resource_RelENS.id_CourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_Resource_RelENT.OwnerId = objvCourseLearningCase_Resource_RelENS.OwnerId; //拥有者Id
objvCourseLearningCase_Resource_RelENT.OwnerName = objvCourseLearningCase_Resource_RelENS.OwnerName; //拥有者姓名
objvCourseLearningCase_Resource_RelENT.OwnerNameWithId = objvCourseLearningCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_Resource_RelENT.id_XzMajor = objvCourseLearningCase_Resource_RelENS.id_XzMajor; //专业流水号
objvCourseLearningCase_Resource_RelENT.MajorID = objvCourseLearningCase_Resource_RelENS.MajorID; //专业ID
objvCourseLearningCase_Resource_RelENT.MajorName = objvCourseLearningCase_Resource_RelENS.MajorName; //专业名称
objvCourseLearningCase_Resource_RelENT.id_XzCollege = objvCourseLearningCase_Resource_RelENS.id_XzCollege; //学院流水号
objvCourseLearningCase_Resource_RelENT.CollegeID = objvCourseLearningCase_Resource_RelENS.CollegeID; //学院ID
objvCourseLearningCase_Resource_RelENT.CollegeName = objvCourseLearningCase_Resource_RelENS.CollegeName; //学院名称
objvCourseLearningCase_Resource_RelENT.id_TeachSkill = objvCourseLearningCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvCourseLearningCase_Resource_RelENT.TeachSkillID = objvCourseLearningCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_Resource_RelENT.TeachSkillName = objvCourseLearningCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_Resource_RelENT.TeachSkillTheory = objvCourseLearningCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_Resource_RelENT.TeachSkillOperMethod = objvCourseLearningCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_Resource_RelENT.SkillTypeID = objvCourseLearningCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_Resource_RelENT.SkillTypeName = objvCourseLearningCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_Resource_RelENT.id_Discipline = objvCourseLearningCase_Resource_RelENS.id_Discipline; //学科流水号
objvCourseLearningCase_Resource_RelENT.DisciplineID = objvCourseLearningCase_Resource_RelENS.DisciplineID; //学科ID
objvCourseLearningCase_Resource_RelENT.DisciplineName = objvCourseLearningCase_Resource_RelENS.DisciplineName; //学科名称
objvCourseLearningCase_Resource_RelENT.id_StudyLevel = objvCourseLearningCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvCourseLearningCase_Resource_RelENT.StudyLevelName = objvCourseLearningCase_Resource_RelENS.StudyLevelName; //学段名称
objvCourseLearningCase_Resource_RelENT.id_File = objvCourseLearningCase_Resource_RelENS.id_File; //文件流水号
objvCourseLearningCase_Resource_RelENT.FileName = objvCourseLearningCase_Resource_RelENS.FileName; //文件名称
objvCourseLearningCase_Resource_RelENT.FileType = objvCourseLearningCase_Resource_RelENS.FileType; //文件类型
objvCourseLearningCase_Resource_RelENT.SaveDate = objvCourseLearningCase_Resource_RelENS.SaveDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileSize = objvCourseLearningCase_Resource_RelENS.FileSize; //文件大小
objvCourseLearningCase_Resource_RelENT.SaveTime = objvCourseLearningCase_Resource_RelENS.SaveTime; //创建时间
objvCourseLearningCase_Resource_RelENT.id_SkillType = objvCourseLearningCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvCourseLearningCase_Resource_RelENT.id_TeachingPlan = objvCourseLearningCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvCourseLearningCase_Resource_RelENT.id_FtpResource = objvCourseLearningCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvCourseLearningCase_Resource_RelENT.FtpResourceID = objvCourseLearningCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCourseLearningCase_Resource_RelENT.FileOriginalName = objvCourseLearningCase_Resource_RelENS.FileOriginalName; //文件原名
objvCourseLearningCase_Resource_RelENT.FileDirName = objvCourseLearningCase_Resource_RelENS.FileDirName; //文件目录名
objvCourseLearningCase_Resource_RelENT.FileRename = objvCourseLearningCase_Resource_RelENS.FileRename; //文件新名
objvCourseLearningCase_Resource_RelENT.FileUpDate = objvCourseLearningCase_Resource_RelENS.FileUpDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileUpTime = objvCourseLearningCase_Resource_RelENS.FileUpTime; //创建时间
objvCourseLearningCase_Resource_RelENT.id_Resource = objvCourseLearningCase_Resource_RelENS.id_Resource; //资源流水号
objvCourseLearningCase_Resource_RelENT.ResourceID = objvCourseLearningCase_Resource_RelENS.ResourceID; //资源ID
objvCourseLearningCase_Resource_RelENT.SaveMode = objvCourseLearningCase_Resource_RelENS.SaveMode; //文件存放方式
objvCourseLearningCase_Resource_RelENT.IsMain = objvCourseLearningCase_Resource_RelENS.IsMain; //是否主资源
objvCourseLearningCase_Resource_RelENT.id_ResourceType = objvCourseLearningCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvCourseLearningCase_Resource_RelENT.ResourceTypeID = objvCourseLearningCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCase_Resource_RelENT.ResourceTypeName = objvCourseLearningCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCase_Resource_RelENT.id_UsingMode = objvCourseLearningCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvCourseLearningCase_Resource_RelENT.IndexNO = objvCourseLearningCase_Resource_RelENS.IndexNO; //序号
objvCourseLearningCase_Resource_RelENT.CourseId = objvCourseLearningCase_Resource_RelENS.CourseId; //课程Id
objvCourseLearningCase_Resource_RelENT.CourseCode = objvCourseLearningCase_Resource_RelENS.CourseCode; //课程代码
objvCourseLearningCase_Resource_RelENT.CourseName = objvCourseLearningCase_Resource_RelENS.CourseName; //课程名称
objvCourseLearningCase_Resource_RelENT.BrowseCount = objvCourseLearningCase_Resource_RelENS.BrowseCount; //浏览次数
objvCourseLearningCase_Resource_RelENT.ResourceName = objvCourseLearningCase_Resource_RelENS.ResourceName; //资源名称
objvCourseLearningCase_Resource_RelENT.ResourceOwner = objvCourseLearningCase_Resource_RelENS.ResourceOwner; //上传者
objvCourseLearningCase_Resource_RelENT.ftpFileType = objvCourseLearningCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_Resource_RelENT.ftpFileSize = objvCourseLearningCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCourseLearningCase_Resource_RelENT.ftpResourceOwner = objvCourseLearningCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCase_Resource_RelENT.VersionNo = objvCourseLearningCase_Resource_RelENS.VersionNo; //版本号
objvCourseLearningCase_Resource_RelENT.FileOriginName = objvCourseLearningCase_Resource_RelENS.FileOriginName; //原文件名
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionID = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionName = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_Resource_RelENT.CaseLevelId = objvCourseLearningCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_Resource_RelENT.IsExistFile = objvCourseLearningCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCourseLearningCase_Resource_RelENT.BrowseCount4Case = objvCourseLearningCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_Resource_RelENT.FileNewName = objvCourseLearningCase_Resource_RelENS.FileNewName; //新文件名
objvCourseLearningCase_Resource_RelENT.FileOldName = objvCourseLearningCase_Resource_RelENS.FileOldName; //旧文件名
objvCourseLearningCase_Resource_RelENT.IsDualVideo = objvCourseLearningCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCourseLearningCase_Resource_RelENT.ViewCount = objvCourseLearningCase_Resource_RelENS.ViewCount; //浏览量
objvCourseLearningCase_Resource_RelENT.IsShow = objvCourseLearningCase_Resource_RelENS.IsShow; //是否启用
objvCourseLearningCase_Resource_RelENT.DownloadNumber = objvCourseLearningCase_Resource_RelENS.DownloadNumber; //下载数目
objvCourseLearningCase_Resource_RelENT.FileIntegration = objvCourseLearningCase_Resource_RelENS.FileIntegration; //文件积分
objvCourseLearningCase_Resource_RelENT.LikeCount = objvCourseLearningCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_Resource_RelENT.CollectionCount = objvCourseLearningCase_Resource_RelENS.CollectionCount; //收藏数量
objvCourseLearningCase_Resource_RelENT.IsVisible = objvCourseLearningCase_Resource_RelENS.IsVisible; //是否显示
objvCourseLearningCase_Resource_RelENT.UpdDate = objvCourseLearningCase_Resource_RelENS.UpdDate; //修改日期
objvCourseLearningCase_Resource_RelENT.UpdUser = objvCourseLearningCase_Resource_RelENS.UpdUser; //修改人
objvCourseLearningCase_Resource_RelENT.Memo = objvCourseLearningCase_Resource_RelENS.Memo; //备注
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeId = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeName = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_Resource_RelENT.CollegeNameA = objvCourseLearningCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_Resource_RelENT.CourseChapterId = objvCourseLearningCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_Resource_RelENT.CourseChapterName = objvCourseLearningCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_Resource_RelENT.CourseChapterReferred = objvCourseLearningCase_Resource_RelENS.CourseChapterReferred; //节简称
objvCourseLearningCase_Resource_RelENT.ParentNodeReferred = objvCourseLearningCase_Resource_RelENS.ParentNodeReferred; //章简称
objvCourseLearningCase_Resource_RelENT.ParentNodeID = objvCourseLearningCase_Resource_RelENS.ParentNodeID; //父节点编号
objvCourseLearningCase_Resource_RelENT.ParentNodeName = objvCourseLearningCase_Resource_RelENS.ParentNodeName; //父节点名称
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
public static DataTable ToDataTable(List<clsvCourseLearningCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCase_Resource_RelEN.AttributeName)
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeWApi没有刷新缓存机制(clsCourseLearningCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeWApi没有刷新缓存机制(clsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvCourseLearningCase_Resource_RelObjLst_Cache == null)
//{
//arrvCourseLearningCase_Resource_RelObjLst_Cache = await clsvCourseLearningCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvCourseLearningCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase_Resource_RelEN._CurrTabName_S);
List<clsvCourseLearningCase_Resource_RelEN> arrvCourseLearningCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Resource_Rel.ParentNodeName, Type.GetType("System.String"));
foreach (clsvCourseLearningCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convCourseLearningCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convCourseLearningCase_Resource_Rel.FuncModuleId] = objInFor[convCourseLearningCase_Resource_Rel.FuncModuleId];
objDR[convCourseLearningCase_Resource_Rel.FuncModuleName] = objInFor[convCourseLearningCase_Resource_Rel.FuncModuleName];
objDR[convCourseLearningCase_Resource_Rel.id_MicroteachCase] = objInFor[convCourseLearningCase_Resource_Rel.id_MicroteachCase];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseID];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseName];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseText];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn];
objDR[convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType] = objInFor[convCourseLearningCase_Resource_Rel.id_CourseLearningCaseType];
objDR[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] = objInFor[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName];
objDR[convCourseLearningCase_Resource_Rel.OwnerId] = objInFor[convCourseLearningCase_Resource_Rel.OwnerId];
objDR[convCourseLearningCase_Resource_Rel.OwnerName] = objInFor[convCourseLearningCase_Resource_Rel.OwnerName];
objDR[convCourseLearningCase_Resource_Rel.OwnerNameWithId] = objInFor[convCourseLearningCase_Resource_Rel.OwnerNameWithId];
objDR[convCourseLearningCase_Resource_Rel.id_XzMajor] = objInFor[convCourseLearningCase_Resource_Rel.id_XzMajor];
objDR[convCourseLearningCase_Resource_Rel.MajorID] = objInFor[convCourseLearningCase_Resource_Rel.MajorID];
objDR[convCourseLearningCase_Resource_Rel.MajorName] = objInFor[convCourseLearningCase_Resource_Rel.MajorName];
objDR[convCourseLearningCase_Resource_Rel.id_XzCollege] = objInFor[convCourseLearningCase_Resource_Rel.id_XzCollege];
objDR[convCourseLearningCase_Resource_Rel.CollegeID] = objInFor[convCourseLearningCase_Resource_Rel.CollegeID];
objDR[convCourseLearningCase_Resource_Rel.CollegeName] = objInFor[convCourseLearningCase_Resource_Rel.CollegeName];
objDR[convCourseLearningCase_Resource_Rel.id_TeachSkill] = objInFor[convCourseLearningCase_Resource_Rel.id_TeachSkill];
objDR[convCourseLearningCase_Resource_Rel.TeachSkillID] = objInFor[convCourseLearningCase_Resource_Rel.TeachSkillID];
objDR[convCourseLearningCase_Resource_Rel.TeachSkillName] = objInFor[convCourseLearningCase_Resource_Rel.TeachSkillName];
objDR[convCourseLearningCase_Resource_Rel.TeachSkillTheory] = objInFor[convCourseLearningCase_Resource_Rel.TeachSkillTheory];
objDR[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod];
objDR[convCourseLearningCase_Resource_Rel.SkillTypeID] = objInFor[convCourseLearningCase_Resource_Rel.SkillTypeID];
objDR[convCourseLearningCase_Resource_Rel.SkillTypeName] = objInFor[convCourseLearningCase_Resource_Rel.SkillTypeName];
objDR[convCourseLearningCase_Resource_Rel.id_Discipline] = objInFor[convCourseLearningCase_Resource_Rel.id_Discipline];
objDR[convCourseLearningCase_Resource_Rel.DisciplineID] = objInFor[convCourseLearningCase_Resource_Rel.DisciplineID];
objDR[convCourseLearningCase_Resource_Rel.DisciplineName] = objInFor[convCourseLearningCase_Resource_Rel.DisciplineName];
objDR[convCourseLearningCase_Resource_Rel.id_StudyLevel] = objInFor[convCourseLearningCase_Resource_Rel.id_StudyLevel];
objDR[convCourseLearningCase_Resource_Rel.StudyLevelName] = objInFor[convCourseLearningCase_Resource_Rel.StudyLevelName];
objDR[convCourseLearningCase_Resource_Rel.id_File] = objInFor[convCourseLearningCase_Resource_Rel.id_File];
objDR[convCourseLearningCase_Resource_Rel.FileName] = objInFor[convCourseLearningCase_Resource_Rel.FileName];
objDR[convCourseLearningCase_Resource_Rel.FileType] = objInFor[convCourseLearningCase_Resource_Rel.FileType];
objDR[convCourseLearningCase_Resource_Rel.SaveDate] = objInFor[convCourseLearningCase_Resource_Rel.SaveDate];
objDR[convCourseLearningCase_Resource_Rel.FileSize] = objInFor[convCourseLearningCase_Resource_Rel.FileSize];
objDR[convCourseLearningCase_Resource_Rel.SaveTime] = objInFor[convCourseLearningCase_Resource_Rel.SaveTime];
objDR[convCourseLearningCase_Resource_Rel.id_SkillType] = objInFor[convCourseLearningCase_Resource_Rel.id_SkillType];
objDR[convCourseLearningCase_Resource_Rel.id_TeachingPlan] = objInFor[convCourseLearningCase_Resource_Rel.id_TeachingPlan];
objDR[convCourseLearningCase_Resource_Rel.id_FtpResource] = objInFor[convCourseLearningCase_Resource_Rel.id_FtpResource];
objDR[convCourseLearningCase_Resource_Rel.FtpResourceID] = objInFor[convCourseLearningCase_Resource_Rel.FtpResourceID];
objDR[convCourseLearningCase_Resource_Rel.FileOriginalName] = objInFor[convCourseLearningCase_Resource_Rel.FileOriginalName];
objDR[convCourseLearningCase_Resource_Rel.FileDirName] = objInFor[convCourseLearningCase_Resource_Rel.FileDirName];
objDR[convCourseLearningCase_Resource_Rel.FileRename] = objInFor[convCourseLearningCase_Resource_Rel.FileRename];
objDR[convCourseLearningCase_Resource_Rel.FileUpDate] = objInFor[convCourseLearningCase_Resource_Rel.FileUpDate];
objDR[convCourseLearningCase_Resource_Rel.FileUpTime] = objInFor[convCourseLearningCase_Resource_Rel.FileUpTime];
objDR[convCourseLearningCase_Resource_Rel.id_Resource] = objInFor[convCourseLearningCase_Resource_Rel.id_Resource];
objDR[convCourseLearningCase_Resource_Rel.ResourceID] = objInFor[convCourseLearningCase_Resource_Rel.ResourceID];
objDR[convCourseLearningCase_Resource_Rel.SaveMode] = objInFor[convCourseLearningCase_Resource_Rel.SaveMode];
objDR[convCourseLearningCase_Resource_Rel.IsMain] = objInFor[convCourseLearningCase_Resource_Rel.IsMain];
objDR[convCourseLearningCase_Resource_Rel.id_ResourceType] = objInFor[convCourseLearningCase_Resource_Rel.id_ResourceType];
objDR[convCourseLearningCase_Resource_Rel.ResourceTypeID] = objInFor[convCourseLearningCase_Resource_Rel.ResourceTypeID];
objDR[convCourseLearningCase_Resource_Rel.ResourceTypeName] = objInFor[convCourseLearningCase_Resource_Rel.ResourceTypeName];
objDR[convCourseLearningCase_Resource_Rel.id_UsingMode] = objInFor[convCourseLearningCase_Resource_Rel.id_UsingMode];
objDR[convCourseLearningCase_Resource_Rel.IndexNO] = objInFor[convCourseLearningCase_Resource_Rel.IndexNO];
objDR[convCourseLearningCase_Resource_Rel.CourseId] = objInFor[convCourseLearningCase_Resource_Rel.CourseId];
objDR[convCourseLearningCase_Resource_Rel.CourseCode] = objInFor[convCourseLearningCase_Resource_Rel.CourseCode];
objDR[convCourseLearningCase_Resource_Rel.CourseName] = objInFor[convCourseLearningCase_Resource_Rel.CourseName];
objDR[convCourseLearningCase_Resource_Rel.BrowseCount] = objInFor[convCourseLearningCase_Resource_Rel.BrowseCount];
objDR[convCourseLearningCase_Resource_Rel.ResourceName] = objInFor[convCourseLearningCase_Resource_Rel.ResourceName];
objDR[convCourseLearningCase_Resource_Rel.ResourceOwner] = objInFor[convCourseLearningCase_Resource_Rel.ResourceOwner];
objDR[convCourseLearningCase_Resource_Rel.ftpFileType] = objInFor[convCourseLearningCase_Resource_Rel.ftpFileType];
objDR[convCourseLearningCase_Resource_Rel.ftpFileSize] = objInFor[convCourseLearningCase_Resource_Rel.ftpFileSize];
objDR[convCourseLearningCase_Resource_Rel.ftpResourceOwner] = objInFor[convCourseLearningCase_Resource_Rel.ftpResourceOwner];
objDR[convCourseLearningCase_Resource_Rel.VersionNo] = objInFor[convCourseLearningCase_Resource_Rel.VersionNo];
objDR[convCourseLearningCase_Resource_Rel.FileOriginName] = objInFor[convCourseLearningCase_Resource_Rel.FileOriginName];
objDR[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] = objInFor[convCourseLearningCase_Resource_Rel.senateGaugeVersionID];
objDR[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] = objInFor[convCourseLearningCase_Resource_Rel.senateGaugeVersionName];
objDR[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convCourseLearningCase_Resource_Rel.CaseLevelId] = objInFor[convCourseLearningCase_Resource_Rel.CaseLevelId];
objDR[convCourseLearningCase_Resource_Rel.IsExistFile] = objInFor[convCourseLearningCase_Resource_Rel.IsExistFile];
objDR[convCourseLearningCase_Resource_Rel.BrowseCount4Case] = objInFor[convCourseLearningCase_Resource_Rel.BrowseCount4Case];
objDR[convCourseLearningCase_Resource_Rel.FileNewName] = objInFor[convCourseLearningCase_Resource_Rel.FileNewName];
objDR[convCourseLearningCase_Resource_Rel.FileOldName] = objInFor[convCourseLearningCase_Resource_Rel.FileOldName];
objDR[convCourseLearningCase_Resource_Rel.IsDualVideo] = objInFor[convCourseLearningCase_Resource_Rel.IsDualVideo];
objDR[convCourseLearningCase_Resource_Rel.ViewCount] = objInFor[convCourseLearningCase_Resource_Rel.ViewCount];
objDR[convCourseLearningCase_Resource_Rel.IsShow] = objInFor[convCourseLearningCase_Resource_Rel.IsShow];
objDR[convCourseLearningCase_Resource_Rel.DownloadNumber] = objInFor[convCourseLearningCase_Resource_Rel.DownloadNumber];
objDR[convCourseLearningCase_Resource_Rel.FileIntegration] = objInFor[convCourseLearningCase_Resource_Rel.FileIntegration];
objDR[convCourseLearningCase_Resource_Rel.LikeCount] = objInFor[convCourseLearningCase_Resource_Rel.LikeCount];
objDR[convCourseLearningCase_Resource_Rel.CollectionCount] = objInFor[convCourseLearningCase_Resource_Rel.CollectionCount];
objDR[convCourseLearningCase_Resource_Rel.IsVisible] = objInFor[convCourseLearningCase_Resource_Rel.IsVisible];
objDR[convCourseLearningCase_Resource_Rel.UpdDate] = objInFor[convCourseLearningCase_Resource_Rel.UpdDate];
objDR[convCourseLearningCase_Resource_Rel.UpdUser] = objInFor[convCourseLearningCase_Resource_Rel.UpdUser];
objDR[convCourseLearningCase_Resource_Rel.Memo] = objInFor[convCourseLearningCase_Resource_Rel.Memo];
objDR[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] = objInFor[convCourseLearningCase_Resource_Rel.RecommendedDegreeId];
objDR[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] = objInFor[convCourseLearningCase_Resource_Rel.RecommendedDegreeName];
objDR[convCourseLearningCase_Resource_Rel.CollegeNameA] = objInFor[convCourseLearningCase_Resource_Rel.CollegeNameA];
objDR[convCourseLearningCase_Resource_Rel.CourseChapterId] = objInFor[convCourseLearningCase_Resource_Rel.CourseChapterId];
objDR[convCourseLearningCase_Resource_Rel.CourseChapterName] = objInFor[convCourseLearningCase_Resource_Rel.CourseChapterName];
objDR[convCourseLearningCase_Resource_Rel.CourseChapterReferred] = objInFor[convCourseLearningCase_Resource_Rel.CourseChapterReferred];
objDR[convCourseLearningCase_Resource_Rel.ParentNodeReferred] = objInFor[convCourseLearningCase_Resource_Rel.ParentNodeReferred];
objDR[convCourseLearningCase_Resource_Rel.ParentNodeID] = objInFor[convCourseLearningCase_Resource_Rel.ParentNodeID];
objDR[convCourseLearningCase_Resource_Rel.ParentNodeName] = objInFor[convCourseLearningCase_Resource_Rel.ParentNodeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}